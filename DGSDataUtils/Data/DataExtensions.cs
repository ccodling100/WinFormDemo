using DGSDataUtils.Contexts;
using DGSDataUtils.Data.Models;
using DGSDataUtils.Entities.DGSEntities;
using DGSDataUtils.Entities.ProMgrEntities;
using DGSDataUtils.Extensions;

namespace DGSDataUtils.Data
{
    public static class DataExtensions
    {
        private static Dictionary<string, string> TrackMap = GetTrackCodeMap();

        #region Public Methods

        /// <summary>
        /// Retrieves the profile limits for a given player profile.
        /// </summary>
        /// <param name="profile">The player profile for which to retrieve the limits.</param>
        /// <param name="connectionString">The connection string to the database.</param>
        /// <returns>A list of DGSTrackLimit objects representing the profile limits.</returns>
        public static List<DGSTrackLimit> GetProfileLimits(this Playerprofile profile, string connectionString)
        {
            List<DGSTrackLimit> trackLimits = null;

            using (DGSDbContext ctx = new DGSDbContext(connectionString))
            {
                trackLimits = ctx.Playerprofiles.Join(
                        ctx.ProfileTrackEnables, pt => pt.IdProfile, pte => pte.ProfileId,
                        (pt, pte) => new
                        {
                            ProfileId = pte.ProfileId,
                            TrackId = pte.TrackId,
                            uitype = pte.Uitype
                        }).Where(x => x.uitype == 1 && x.ProfileId == profile.IdProfile).Join(ctx.Tracks, pte => pte.TrackId, t => t.TrackId,
                        (pte, t) => new
                        {
                            ProfileId = pte.ProfileId,
                            TrackId = t.TrackId,
                            TrackEnabled = t.Enabled
                        }).Join(ctx.LimitSetTracks, t => new { t.TrackId, t.ProfileId },
                        lst => new { lst.TrackId, lst.ProfileId },
                        (t, lst) => new
                        {
                            ProfileId = t.ProfileId,
                            TrackId = t.TrackId,
                            TrackEnabled = t.TrackEnabled,
                            LimitSetId = lst.LimitSetId
                        }).Join(ctx.LimitSets, lst => lst.LimitSetId, ls => ls.LimitSetId,
                        (lst, ls) => new
                        {
                            ProfileId = lst.ProfileId,
                            TrackId = lst.TrackId,
                            TrackEnabled = lst.TrackEnabled,
                            LimitSetId = ls.LimitSetId,
                            ParlayMaxSize = ls.ParlayMaxSize,
                            MaxRaceWin = ls.MaxRaceWin,
                            MaxRaceWinType = ls.MaxRaceWinType
                        }).Join(ctx.LimitSetBetTypes, ls => ls.LimitSetId,
                        lsbt => lsbt.LimitSetId, (ls, lsbt) => new
                        {
                            ProfileId = ls.ProfileId,
                            TrackId = ls.TrackId,
                            TrackEnabled = ls.TrackEnabled,
                            ParlayMaxSize = ls.ParlayMaxSize,
                            MaxRaceWin = ls.MaxRaceWin,
                            MaxRaceWinType = ls.MaxRaceWinType,
                            MaxStake = lsbt.MaxStake,
                            MaxPayoutOdds = lsbt.MaxPayoutOdds,
                            MaxPayoutCap = lsbt.MaxPayoutCap,
                            BetType = lsbt.BetType,
                            MinStake = lsbt.MinStake
                        })
                    .Select(c => new DGSTrackLimit
                    {
                        ProfileId = c.ProfileId,
                        TrackId = c.TrackId,
                        TrackEnabled = c.TrackEnabled,
                        ParlayMaxSize = c.ParlayMaxSize,
                        MaxRaceWin = c.MaxRaceWin,
                        MaxRaceWinType = c.MaxRaceWinType,
                        MaxStake = c.MaxStake,
                        MaxPayoutOdds = c.MaxPayoutOdds,
                        MaxPayoutCap = c.MaxPayoutCap,
                        BetType = c.BetType,
                        MinStake = c.MinStake
                    }).AsEnumerable().DistinctBy(x => new {x.ProfileId, x.TrackId, x.BetType}).ToList();
            }

            return trackLimits;
        }

        /// <summary>
        /// Retrieves the tracks for a given profile id.
        /// </summary>
        /// <param name="profileId">The profile id.</param>
        /// <param name="connectionString">The connection string.</param>
        /// <returns>The list of TracksViewModel objects representing the tracks.</returns>
        public static List<TracksViewModel> GetTracks(int profileId, string connectionString)
        {
            List<TracksViewModel> trackList = null;

            using (var ctx = new ProMgrDbContext(connectionString))
            {
                try
                {
                    var modifiedTrackLimits = ctx.GetAllTrackLimitPercentages(profileId).Where(c => c.ValuePercentage < 50).ToList();
                    
                    trackList = ctx.Tracks.Join(ctx.TrackLimits, t => t.IdTrack, tl => tl.IdTrack,
                            (t, tl) => new
                            {
                                IdTrack = t.IdTrack,
                                TrackName = t.TrackName,
                                IsEnabled = tl.IsEnabled,
                                IdProfile = tl.IdRaceProfile
                            }).Join(ctx.RaceProfiles, tl => tl.IdProfile, rp => rp.IdRaceProfile,
                            (tl, rp) => new
                            {
                                TrackInfo = tl
                            }).Where(x => x.TrackInfo.IdProfile == profileId)
                        .Select(c => new TracksViewModel
                        {
                            IdTrack = c.TrackInfo.IdTrack,
                            TrackName = c.TrackInfo.TrackName,
                            IsEnabled = c.TrackInfo.IsEnabled,
                            IdProfile = c.TrackInfo.IdProfile,
                            IsModified = false
                        }).AsEnumerable().DistinctBy(x => new {x.TrackName, x.IsEnabled}).ToList();

                    List<int> modifiedTracks = new();
                    var relevantBetTypes = modifiedTrackLimits.Select(c => c.IdBetType).Distinct().ToList();
                    var ptl = ctx.TrackLimits.Where(c => c.IdRaceProfile == profileId && relevantBetTypes.Contains(c.IdBetType)).ToList();
                    
                    foreach (var tl in ptl)
                    {
                        var relevantModifiedTrackLimits = modifiedTrackLimits.Where(mtl => tl.IdBetType == mtl.IdBetType).ToList();
                        foreach (var mtl in relevantModifiedTrackLimits.Where(mtl => tl.IdBetType == mtl.IdBetType))
                        {
                            if (tl.MinBet == mtl.Value && mtl.ValueType == (int) LimitValueType.MinBet)
                                modifiedTracks.Add(tl.IdTrack);
                            if (tl.MaxBet == mtl.Value && mtl.ValueType == (int) LimitValueType.MaxBet)
                                modifiedTracks.Add(tl.IdTrack);
                            if (tl.PerBetMaxWin == mtl.Value && mtl.ValueType == (int) LimitValueType.PerBetMaxWin)
                                modifiedTracks.Add(tl.IdTrack);
                            if (tl.PerRaceMaxWin == mtl.Value && mtl.ValueType == (int) LimitValueType.PerRaceMaxWin)
                                modifiedTracks.Add(tl.IdTrack);
                            if (tl.MaxPayoutOdds == mtl.Value && mtl.ValueType == (int) LimitValueType.PayoutOdds)
                                modifiedTracks.Add(tl.IdTrack);
                        }
                    }

                    foreach (var track in trackList.Where(track => modifiedTracks.Contains(track.IdTrack)))
                    {
                        track.IsModified = true;
                    }
                }
                catch (Exception e)
                {
                    //Console.WriteLine(e);
                    trackList = new();
                }
            }

            return trackList;
        }

        /// <summary>
        /// Retrieves the default track limits for a given profile ID and connection string.
        /// </summary>
        /// <param name="profileId">The ID of the profile for which to retrieve the default track limits.</param>
        /// <param name="connectionString">The database connection string.</param>
        /// <returns>A list of TrackLimitsView objects representing the default track limits.</returns>
        private static List<TrackLimitsView> GetDefaultTrackLimits(int profileId, string connectionString)
        {
            var trackLimits = new List<TrackLimitsView>();
            var currentTrackLimits = new List<TrackLimitsView>();
            
            TrackLimitsView tl = new TrackLimitsView
            {
                Category = "Default",
                Status = false,
                //PerRaceMaxWin = -1,
                Min = -1,
                Max = -1,
                Payout = -1,
                Odds = -1
            };
            trackLimits.Add(tl);

            using (var ctx = new ProMgrDbContext(connectionString))
            {
                var defaultLimits = ctx.GetAllTrackLimitPercentages(profileId).ToList();
                var betTypes = ctx.BetTypes.ToList();
                TrackLimitPercentages p;

                foreach (var betType in betTypes)
                {
                    TrackLimitsView trackLimit = new();
                    trackLimit.Category = betType.BetName;

                    // Set to true by default, and then calculate down below if it should be changed to false.
                    trackLimit.Status = true;

                    // We don't use -1, as this means that it's disabled (Status == off)
                    // MinBet
                    p = defaultLimits.FirstOrDefault(c =>
                        c.IdBetType == betType.IdBetType && c.ValueType == (int)LimitValueType.MinBet &&
                        c.ValuePercentage > 50);
                    trackLimit.Min = p?.Value ?? -2; // if it's -2, then the UI will make it blank upon display
                    // MaxBet
                    p = defaultLimits.FirstOrDefault(c =>
                        c.IdBetType == betType.IdBetType && c.ValueType == (int)LimitValueType.MaxBet &&
                        c.ValuePercentage > 50);
                    trackLimit.Max = p?.Value ?? -2;
                    // PerRaceMaxWin
                    p = defaultLimits.FirstOrDefault(c =>
                        c.IdBetType == betType.IdBetType && c.ValueType == (int)LimitValueType.PerBetMaxWin &&
                        c.ValuePercentage > 50);
                    trackLimit.Payout = p?.Value ?? -2;
                    // PayoutOdds
                    p = defaultLimits.FirstOrDefault(c =>
                        c.IdBetType == betType.IdBetType && c.ValueType == (int)LimitValueType.PayoutOdds &&
                        c.ValuePercentage > 50);
                    trackLimit.Odds = p?.Value ?? -2;
                    // PerRaceMaxWin
                    p = defaultLimits.FirstOrDefault(c =>
                        c.IdBetType == betType.IdBetType && c.ValueType == (int)LimitValueType.PerRaceMaxWin &&
                        c.ValuePercentage > 50);
                    trackLimit.PerRaceMaxWin = p?.Value ?? -2;

                    if (trackLimit.Min == -1 && trackLimit.Max == -1 && trackLimit.Payout == -1 &&
                        trackLimit.Odds == -1)
                        trackLimit.Status = false;

                    currentTrackLimits.Add(trackLimit);
                }

                trackLimits.AddRange(currentTrackLimits);
                return trackLimits;
            }
        }

        /// <summary>
        /// Copies track limits from one track to another for a given player profile.
        /// </summary>
        /// <param name="profileId">The ID of the player profile.</param>
        /// <param name="srcTrackId">The ID of the source track.</param>
        /// <param name="dstTrackId">The ID of the destination track.</param>
        /// <param name="connectionString">The connection string to the database.</param>
        /// <returns>Returns true if the track limits were copied successfully, false otherwise.</returns>
        public static bool CopyTrackLimits(int profileId, int srcTrackId, int dstTrackId, string connectionString)
        {
            var rv = true;
            
            using (var ctx = new ProMgrDbContext(connectionString))
            {
                List<DtoTrackLimit> limitsSrc = ctx.TrackLimits
                    .Where(c => c.IdRaceProfile == profileId && c.IdTrack == srcTrackId).ToList();

                List<DtoTrackLimit> limitsDst = ctx.TrackLimits
                    .Where(c => c.IdRaceProfile == profileId && c.IdTrack == dstTrackId).ToList();

                foreach (var srcLimit in limitsSrc)
                {
                    var dstLimit = limitsDst.FirstOrDefault(c => c.IdBetType == srcLimit.IdBetType);
                    if (dstLimit != null)
                    {
                        dstLimit.IsEnabled = srcLimit.IsEnabled;
                        dstLimit.PerRaceMaxWin = srcLimit.PerRaceMaxWin;
                        dstLimit.MinBet = srcLimit.MinBet;
                        dstLimit.MaxBet = srcLimit.MaxBet;
                        dstLimit.PerBetMaxWin = srcLimit.PerBetMaxWin;
                        dstLimit.MaxPayoutOdds = srcLimit.MaxPayoutOdds;
                        
                        ctx.Update(dstLimit);
                    }
                }

                ctx.SaveChanges();
            }

            return rv;
        }

        /// <summary>
        /// Retrieves the track limits for a player profile.
        /// </summary>
        /// <param name="profileId">The ID of the player profile.</param>
        /// <param name="trackIdList">A list of track IDs.</param>
        /// <param name="connectionString">The database connection string.</param>
        /// <returns>A list of TrackLimitsView objects containing the track limits.</returns>
        public static List<TrackLimitsView> GetTrackLimits(int profileId, List<int> trackIdList, string connectionString)
        {
            if (trackIdList.Count == 0)
            {
                return GetDefaultTrackLimits(profileId, connectionString);
            }

            List<TrackLimitsView> currentTrackLimits = null;
            List<TrackLimitsView> trackLimits = new List<TrackLimitsView>();
            TrackLimitsView tl = new TrackLimitsView
            {
                Category = "Default",
                Status = false,
                Min = -1,
                Max = -1,
                Payout = -1,
                Odds = -1
            };
            trackLimits.Add(tl);
            
            using (var ctx = new ProMgrDbContext(connectionString))
            {
                try
                {
                    currentTrackLimits = ctx.BetTypes.Join(ctx.TrackLimits, t => t.IdBetType, tl => tl.IdBetType,
                            (t, tl) => new
                            {
                                IdRaceProfile = tl.IdRaceProfile,
                                IdTrack = tl.IdTrack,
                                Category = t.BetName,
                                Status = true,  // default value and then updated down below
                                Min = tl.MinBet,
                                Max = tl.MaxBet,
                                Payout = tl.PerBetMaxWin,
                                Odds = tl.MaxPayoutOdds,
                                RaceMaxWin = tl.PerRaceMaxWin
                                //}).Where(x => x.IdRaceProfile == profileId && x.IdTrack == trackIdList)
                            }).Where(x => x.IdRaceProfile == profileId && trackIdList.Contains(x.IdTrack))
                        .Select(c => new TrackLimitsView
                        {
                            Category = c.Category,
                            Status = c.Status,
                            Min = c.Min,
                            Max = c.Max,
                            Payout = c.Payout,
                            Odds = c.Odds,
                            PerRaceMaxWin = c.RaceMaxWin
                        }).ToList().UpdateStatusColumn();
                }
                catch (Exception e)
                {
                    //Console.WriteLine(e);
                    currentTrackLimits = new();
                }
            }

            trackLimits.AddRange(currentTrackLimits);
            return trackLimits.UnifyTrackLimitsView();
        }

        /// <summary>
        /// Converts the given betTypeId to the corresponding bet name.
        /// </summary>
        /// <param name="betTypeId">The bet type ID to be converted.</param>
        /// <returns>The corresponding bet name as a string.</returns>
        public static string ToBetName(this byte betTypeId)
        {
            string b = String.Empty;

            switch (betTypeId)
            {
                case 0:
                    b = "Win";
                    break;
                case 1:
                    b = "Place";
                    break;
                case 2:
                    b = "Show";
                    break;
                case 7:
                    b = "Double";
                    break;
                case 8:
                    b = "Exacta";
                    break;
                case 9:
                    b = "Trifecta";
                    break;
                case 12:
                    b = "Quinella";
                    break;
                case 13:
                    b = "Superfecta";
                    break;
                case 23:
                    b = "Pick3";
                    break;
                case 24:
                    b = "Pick4";
                    break;
                case 25:
                    b = "Pick6";
                    break;
                case 27:
                    b = "Win Parlay";
                    break;
                case 28:
                    b = "Place Parlay";
                    break;
                case 29:
                    b = "Show Parlay";
                    break;
                case 33:
                    b = "House Quin";
                    break;
            }

            return b;
        }

        /// <summary>
        /// Converts the given bet name to the corresponding bet type ID.
        /// </summary>
        /// <param name="betName">The bet name to convert.</param>
        /// <returns>The corresponding bet type ID; -1 if not found.</returns>
        public static int ToBetTypeId(this string betName)
        {
            int idBetType = -1;

            switch (betName)
            {
                case "Win":
                    idBetType = 0;
                    break;
                case "Place":
                    idBetType = 1;
                    break;
                case "Show":
                    idBetType = 2;
                    break;
                case "Double":
                    idBetType = 7;
                    break;
                case "Exacta":
                    idBetType = 8;
                    break;
                case "Trifecta":
                    idBetType = 9;
                    break;
                case "Quinella":
                    idBetType = 12;
                    break;
                case "Superfecta":
                    idBetType = 13;
                    break;
                case "Pick3":
                    idBetType = 23;
                    break;
                case "Pick4":
                    idBetType = 24;
                    break;
                case "Pick6":
                    idBetType = 25;
                    break;
                case "Win Parlay":
                    idBetType = 27;
                    break;
                case "Place Parlay":
                    idBetType = 28;
                    break;
                case "Show Parlay":
                    idBetType = 29;
                    break;
                case "House Quin":
                    idBetType = 33;
                    break;
            }

            return idBetType;
        }

        /// <summary>
        /// Maps a track code to an IBET track code.
        /// </summary>
        /// <param name="trackCode">The track code to map to an IBET track code.</param>
        /// <returns>The mapped IBET track code. If no mapping is found, the original track code is returned.</returns>
        public static string ToIbetTrackCode(this string trackCode)
        {
            var mapping = TrackMap.AsQueryable().Where(x => x.Value == trackCode);
            var newMapCode =  (mapping == null ? trackCode : mapping.FirstOrDefault().Key) ?? trackCode;
            return newMapCode;
        }

        /// <summary>
        /// Update an existing race profile in the database.
        /// </summary>
        /// <param name="profile">The DTO race profile object containing the updated profile information.</param>
        /// <param name="connectionString">The connection string to the database.</param>
        public static void UpdateExistingProfile(DtoRaceProfile profile, string connectionString)
        {
            using (var ctx = new ProMgrDbContext(connectionString))
            {
                var oldProfile = ctx.RaceProfiles.FirstOrDefault(c => c.IdRaceProfile == profile.IdRaceProfile);
                if (oldProfile != null)
                {
                    oldProfile.ProfileName = profile.ProfileName;
                    oldProfile.HorseGlobalMax = profile.HorseGlobalMax;
                    oldProfile.GlobalMaxTime = profile.GlobalMaxTime;
                    oldProfile.GlobalMaxAmount = profile.GlobalMaxAmount;
                    oldProfile.DefaultPerRaceMaxWin = profile.DefaultPerRaceMaxWin;
                    ctx.RaceProfiles.Update(oldProfile);
                    ctx.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Creates a new default profile for an agent.
        /// </summary>
        /// <param name="profileName">The name of the new default profile.</param>
        /// <param name="agentId">The ID of the agent.</param>
        /// <param name="connectionString">The connection string.</param>
        /// <returns>The ID of the new default profile if successful, otherwise a negative value.</returns>
        public static int CreateNewDefaultProfile(string profileName, int agentId, string connectionString)
        {
            int newProfileId = CreateEmptyProfile(profileName.ToUpper(), connectionString);
            if (newProfileId < 0)
                return newProfileId;

            using (var ctx = new ProMgrDbContext(connectionString))
            {
                var agentDefault = ctx.AgentDefaults.FirstOrDefault(c => c.IdAgent == agentId);
                if (agentDefault == null)
                {
                    agentDefault = new DtoAgentDefault();
                    agentDefault.IdAgent = agentId;
                    agentDefault.IdRaceProfile = newProfileId;
                    ctx.AgentDefaults.Add(agentDefault);
                    ctx.SaveChanges();
                    ctx.ChangeTracker.Clear();
                    return newProfileId;
                }
    
                agentDefault.IdRaceProfile = newProfileId;
                ctx.AgentDefaults.Update(agentDefault);
                ctx.SaveChanges();
            }
            
            return newProfileId;
        }

        /// <summary>
        /// Creates a new player profile.
        /// </summary>
        /// <param name="profileName">The name of the new profile.</param>
        /// <param name="playerIdList">The list of player IDs to assign to the new profile.</param>
        /// <param name="connectionString">The connection string used to connect to the database.</param>
        /// <returns>The ID of the newly created profile.</returns>
        public static int CreateNewPlayerProfile(string profileName, List<int> playerIdList, string connectionString)
        {
            int newProfileId = CreateEmptyProfile(profileName.ToUpper(), connectionString);
            if (newProfileId < 0)
                return newProfileId;
            
            using (var ctx = new ProMgrDbContext(connectionString))
            {
                foreach (int playerId in playerIdList)
                {
                    DtoProfileMap pm = ctx.ProfileMaps.FirstOrDefault(c => c.IdPlayer == playerId);
                    if (pm == null)
                    {
                        pm = new DtoProfileMap();
                        pm.IdPlayer = playerId;
                        pm.IdSportProfile = -1;     // unknown since it's in the old system
                        pm.IdRaceProfile = newProfileId;
                        ctx.ProfileMaps.Add(pm);
                    }
                    else
                    {
                        pm.IdRaceProfile = newProfileId;
                        pm.IdPlayer = playerId;
                        ctx.ProfileMaps.Update(pm);
                    }

                    ctx.SaveChanges();
                }
            }

            return newProfileId;
        }

        /// <summary>
        /// Saves the selected tracks and their limits for a race profile.
        /// </summary>
        /// <param name="profile">The race profile to save.</param>
        /// <param name="selectedTracks">The list of selected tracks.</param>
        /// <param name="limitValues">The list of track limits.</param>
        /// <param name="connectionString">The database connection string.</param>
        /// <returns>The number of tracks and limits saved.</returns>
        public static int SaveTrackAndLimits(DtoRaceProfile profile, List<TracksViewModel> selectedTracks, List<TrackLimitsView> limitValues, string connectionString)
        {
            int rc = 0;
            int profileId = profile.IdRaceProfile;
            List<int> trackIdList = selectedTracks.Select(c => c.IdTrack).ToList();

            using (var ctx = new ProMgrDbContext(connectionString))
            {
                var betList = ctx.BetTypes.ToList();
                var dtoTrackLimitsToUpdate = ctx.TrackLimits.Where(c => c.IdRaceProfile == profileId && trackIdList.Contains(c.IdTrack)).ToList();

                var bNew = false;
                foreach (var trackId in trackIdList)
                {
                    var tvm = selectedTracks.FirstOrDefault(c => c.IdTrack == trackId);
                    foreach (var trackLimit in limitValues.Where(c => c.Category.ToUpper() != "DEFAULT"))
                    {
                        var idBetType = betList.FirstOrDefault(c => c.BetName == trackLimit.Category).IdBetType;
                        var dtoTrackLimit = dtoTrackLimitsToUpdate.FirstOrDefault(c => c.IdTrack == trackId && c.IdBetType == idBetType && c.IdRaceProfile == profileId);
                        
                        if (dtoTrackLimit.PerRaceMaxWin == null)
                        {
                            dtoTrackLimit.PerRaceMaxWin = profile.DefaultPerRaceMaxWin;
                        }

                        if (dtoTrackLimit.PerRaceMaxWin <= (decimal)0.0000001)
                        {
                            dtoTrackLimit.PerRaceMaxWin = profile.DefaultPerRaceMaxWin;
                        }
                        
                        // if the TrackLimit Status = 'Off' then set all values to -1
                        if (!trackLimit.Status)
                        {
                            //trackLimit.PerRaceMaxWin = -1;
                            trackLimit.Min = -1;
                            trackLimit.Max = -1;
                            trackLimit.Odds = -1;
                            trackLimit.Payout = -1;
                        }
                        bNew = false;
                        if (dtoTrackLimit != null)
                        {
                            if (dtoTrackLimit.IsEnabled != tvm.IsEnabled)
                            {
                                dtoTrackLimit.IsEnabled = tvm.IsEnabled;
                                bNew = true;
                            }

                            if (dtoTrackLimit.MinBet != trackLimit.Min)
                            {
                                dtoTrackLimit.MinBet = trackLimit.Min;
                                bNew = true;
                            }

                            if (dtoTrackLimit.MaxBet != trackLimit.Max)
                            {
                                dtoTrackLimit.MaxBet = trackLimit.Max;
                                bNew = true;
                            }

                            if (dtoTrackLimit.PerBetMaxWin != trackLimit.Payout)
                            {
                                dtoTrackLimit.PerBetMaxWin = trackLimit.Payout;
                                bNew = true;
                            }

                            if (dtoTrackLimit.MaxPayoutOdds != trackLimit.Odds)
                            {
                                dtoTrackLimit.MaxPayoutOdds = trackLimit.Odds;
                                bNew = true;
                            }
                        }

                        if (bNew)
                            ctx.Update(dtoTrackLimit);
                    }
                    
                    rc = ctx.SaveChanges();
                }

                ctx.SaveChanges();
            }

            return rc;
        }

        /// <summary>
        /// Clones the given DtoRaceProfile and saves it as a new profile with the provided name.
        /// </summary>
        /// <param name="profile">The profile to be cloned.</param>
        /// <param name="newProfileName">The name of the new profile.</param>
        /// <param name="connectionString">The connection string for the database.</param>
        /// <returns>The newly created DtoRaceProfile object.</returns>
        public static DtoRaceProfile CloneDtoProfile(DtoRaceProfile profile, string newProfileName, /*int playerId,*/ string connectionString)
        {
            DtoRaceProfile newProfile = null;
            int oldRaceProfileId = profile.IdRaceProfile;
            
            using (var ctx = new ProMgrDbContext(connectionString))
            {
                // Save the cloned profile
                DtoRaceProfile np = profile.CloneProfile();
                np.ProfileName = newProfileName;
                np.IdRaceProfile = ctx.RaceProfiles.Max(c => c.IdRaceProfile) + 1;
                ctx.RaceProfiles.Add(np);
                ctx.SaveChanges();
                newProfile = ctx.RaceProfiles.FirstOrDefault(p => p.IdRaceProfile == np.IdRaceProfile);
                
                // TODO: This assigns the new profile to the selected player, but this functionality may not be intended as the new profile can be 'assigned' to a new player by the user
                // Update the mapping table
                // var profileMap = ctx.ProfileMaps.FirstOrDefault(c => c.IdPlayer == playerId);
                // profileMap.IdRaceProfile = newProfile.IdRaceProfile;
                // ctx.Update(profileMap);
                // ctx.SaveChanges();

                // Clone the track limits for this profile
                var existingTrackLimits = ctx.TrackLimits.Where(c => c.IdRaceProfile == oldRaceProfileId);
                foreach (var limit in existingTrackLimits)
                {
                    var newTrackLimit = limit.CloneTrackLimit();
                    newTrackLimit.IdRaceProfile = newProfile.IdRaceProfile;
                    ctx.TrackLimits.Add(newTrackLimit);
                }

                ctx.SaveChanges();

            }

            return newProfile;
        }

        /// <summary>
        /// Deletes the specified DtoRaceProfile from the database.
        /// </summary>
        /// <param name="profile">The DtoRaceProfile to delete.</param>
        /// <param name="connectionString">The connection string for the database.</param>
        /// <returns>True if the DtoRaceProfile was deleted successfully; otherwise, false.</returns>
        public static bool DeleteDtoProfile(DtoRaceProfile profile, string connectionString)
        {
            // TODO: Improve performance for Delete profile.
            var rc = false;

            using (var ctx = new ProMgrDbContext(connectionString))
            {
                ctx.ChangeTracker.AutoDetectChangesEnabled = false;
                var x = ctx.RaceProfiles.Remove(profile);
                var profileMap = ctx.ProfileMaps.Where(c => c.IdRaceProfile == profile.IdRaceProfile);
                ctx.ProfileMaps.RemoveRange(profileMap);
                var existingTrackLimits = ctx.TrackLimits.Where(c => c.IdRaceProfile == profile.IdRaceProfile).ToList();
                ctx.TrackLimits.RemoveRange(existingTrackLimits);
                var removedRows = ctx.SaveChanges();
                ctx.ChangeTracker.Clear();
                if (removedRows > 0)
                    rc = true;
            }
        
            return rc;
        }

        /// <summary>
        /// Get the player maps for the given list of player IDs.
        /// </summary>
        /// <param name="playerIdList">The list of player IDs.</param>
        /// <param name="connectionString">The connection string.</param>
        /// <returns>The list of player maps.</returns
        public static List<DtoProfileMap> GetPlayerMaps(List<int> playerIdList, string connectionString)
        {
            using var ctx = new ProMgrDbContext(connectionString);
            return ctx.ProfileMaps.Where(pm => playerIdList.Contains(pm.IdPlayer.Value)).ToList();
        }

        /// <summary>
        /// Assigns a profile to a list of players.
        /// </summary>
        /// <param name="profileId">The ID of the profile to be assigned.</param>
        /// <param name="playerIdList">The list of player IDs.</param>
        /// <param name="connectionString">The database connection string.</param>
        /// <returns>True if the assignment was successful, false otherwise.</returns>
        public static bool AssignProfileToPlayers(int profileId, List<int> playerIdList, string connectionString)
        {
            var rc = false;

            try
            {
                using (ProMgrDbContext ctx = new ProMgrDbContext(connectionString))
                {
                    List<int> mapIdList = new List<int>();
                    foreach (var playerId in playerIdList)
                    {
                        var map = ctx.ProfileMaps.FirstOrDefault(c => c.IdPlayer == playerId);
                        if (map != null)
                        {
                            map.IdRaceProfile = profileId;
                            ctx.ProfileMaps.Update(map);
                            mapIdList.Add(map.IdProfileMap);
                        }
                        else
                        {
                            map = new DtoProfileMap();
                            map.IdRaceProfile = profileId;
                            map.IdPlayer = playerId;
                            ctx.ProfileMaps.Add(map);
                        }
                    }

                    if (ctx.SaveChanges() > 0)
                    {
                        rc = true;
                        
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                rc = false;
            }
            
            return rc;
        }

        /// <summary>
        /// Assigns the specified profile to a list of players.
        /// </summary>
        /// <param name="profileId">The ID of the profile to be assigned.</param>
        /// <param name="playerIdList">The list of player IDs to which the profile should be assigned.</param>
        /// <param name="ctx">The database context for accessing the player profiles.</param>
        /// <returns>True if the profile was successfully assigned to the players; otherwise, false.</returns>
        public static bool AssignProfileToPlayersV2(int profileId, List<int> playerIdList, ProMgrDbContext ctx)
        {
            var rc = false;

            try
            {
                List<int> mapIdList = new List<int>();
                foreach (var playerId in playerIdList)
                {
                    var map = ctx.ProfileMaps.FirstOrDefault(c => c.IdPlayer == playerId);
                    if (map != null)
                    {
                        map.IdRaceProfile = profileId;
                        ctx.ProfileMaps.Update(map);
                        mapIdList.Add(map.IdProfileMap);
                    }
                    else
                    {
                        map = new DtoProfileMap();
                        map.IdRaceProfile = profileId;
                        map.IdPlayer = playerId;
                        ctx.ProfileMaps.Add(map);
                    }
                }

                if (ctx.SaveChanges() > 0)
                {
                    rc = true;
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                rc = false;
            }
            
            return rc;
        }

        /// <summary>
        /// Retrieves the players assigned to a given profile.
        /// </summary>
        /// <param name="profileId">The ID of the profile to retrieve players for.</param>
        /// <param name="mgrConnectionString">The connection string to the ProMgr database.</param>
        /// <param name="dgsConnectionString">The connection string to the DGS database.</param>
        /// <returns>A string containing the names of the players assigned to the profile.</returns>
        public static string GetPlayersAssignedToProfile(int profileId, string mgrConnectionString, string dgsConnectionString)
        {
            string playerNameList = string.Empty;
            using (var ctx = new ProMgrDbContext(mgrConnectionString))
            {
                var playerIdList = ctx.ProfileMaps.Where(c => c.IdRaceProfile == profileId).Select(d => d.IdPlayer).ToList();
                using (var dtx = new DGSDbContext(dgsConnectionString))
                {
                    var playerNames = dtx.Players.Where(p => playerIdList.Contains(p.IdPlayer)).Select(n => n.Player1).ToList();
                    var players = playerNames.Aggregate(playerNameList, (current, playerName) => current + $"{playerName},");
                    playerNameList = players.TrimEnd(',');
                }
            }

            return playerNameList;
        }

        /// <summary>
        /// Retrieves a race profile based on the profile name.
        /// </summary>
        /// <param name="profileName">The name of the profile to retrieve.</param>
        /// <param name="connectionString">The connection string for the database.</param>
        /// <returns>The race profile with the given profile name. Returns null if no profile is found.</returns>
        public static DtoRaceProfile GetProfileByName(string profileName, string connectionString)
        {
            using var ctx = new ProMgrDbContext(connectionString);
            var profile = ctx.RaceProfiles.FirstOrDefault(c => c.ProfileName.ToUpper() == profileName.ToUpper());
            return profile;
        }

        #endregion

        #region Private Methods
        
        private static int CreateEmptyProfile(string profileName, string connectionString)
        {
            var newProfileId = -1;
            List<DtoTrack> tracks = null;
            List<DtoBetType> betTypes = null;
            int idRaceProfile = -1;
            var rc = -1;

            using (var ctx = new ProMgrDbContext(connectionString))
            {
                var profileCount = ctx.RaceProfiles.Count(c => c.ProfileName.ToUpper() == profileName);
                if (profileCount > 0)
                    return -1;
            }
            
            using (var ctx = new ProMgrDbContext(connectionString))
            {
                ctx.ChangeTracker.AutoDetectChangesEnabled = false;
                
                tracks = ctx.Tracks.ToList();
                betTypes = ctx.BetTypes.ToList();
                idRaceProfile = ctx.RaceProfiles.Max(c => c.IdRaceProfile) + 1;
                
                var newProfile = new DtoRaceProfile
                {
                    ProfileName = profileName,
                    IdRaceProfile = idRaceProfile,
                    HorseGlobalMax = 0,
                    GlobalMaxTime = 0,
                    GlobalMaxAmount = 0,
                    DefaultPerRaceMaxWin = 0
                };

                try
                {
                    ctx.RaceProfiles.Add(newProfile);
                    rc = ctx.SaveChanges();
                    if (rc > 0)
                        newProfileId = newProfile.IdRaceProfile;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return newProfileId;
                }
                
                try
                {
                    ctx.ChangeTracker.Clear();
                    
                    foreach (var track in tracks)
                    {
                        foreach (var bet in betTypes)
                        {
                            var trackLimit = new DtoTrackLimit
                            {
                                IdRaceProfile = newProfileId,
                                IdTrack = track.IdTrack,
                                IdBetType = bet.IdBetType,
                                IsEnabled = true,
                                PerRaceMaxWin = -1,
                                MinBet = -1,
                                MaxBet = -1,
                                PerBetMaxWin = -1,
                                MaxPayoutOdds = -1
                            };

                            ctx.TrackLimits.Add(trackLimit);
                        }

                        rc = ctx.SaveChanges();
                        ctx.ChangeTracker.Clear();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                ctx.ChangeTracker.AutoDetectChangesEnabled = true;
            }
            
            return newProfileId;
        }

        private static List<TrackLimitsView> UnifyTrackLimitsView(this List<TrackLimitsView> allLimits)
        {
            var trackLimits = new List<TrackLimitsView>();

            var limits = allLimits.FirstOrDefault(c => c.Category.ToUpper() == "DEFAULT");
            if (limits != null)
                trackLimits.Add(limits);
            
            var betTypesList = allLimits.Select(x => x.Category).Distinct();
            foreach (var betTypeName in betTypesList)
            {
                if (betTypeName.ToUpper() == "DEFAULT")
                    continue;

                // Get all of the limits for this 'category'
                //var tempLimits = allLimits.Where(c => c.Category == betTypeName).ToList();
                trackLimits.Add(allLimits.Where(c => c.Category == betTypeName).ToList().CombineLimits());
            }

            return trackLimits;
        }

        private static List<TrackLimitsView> UpdateStatusColumn(this List<TrackLimitsView> limitsView)
        {
            List<TrackLimitsView> v = new List<TrackLimitsView>();

            foreach (TrackLimitsView vw in limitsView)
            {
                vw.Status = true;
                if (vw is { Min: -1, Max: -1, Payout: -1, Odds: -1 })
                    vw.Status = false;
                v.Add(vw);
            }

            return v;
        }

        private static Dictionary<string, string> GetTrackCodeMap()
        {
            // manual track short-name mapping from IBET -> DGS
            return new Dictionary<string, string>
            {
                { "ABQ", "ALB" },
                { "ARP", "ARD" },
                { "ASN", "ASD" },
                { "BE2", "BEL" },
                { "CAL", "CEX" },
                { "CHT", "CTN" },
                { "CD", "CHU" },
                { "CT", "CTN" },
                { "CNM", "CTM" },
                { "RPK", "DTN" },
                { "FG", "FGX" },
                { "FAN", "FMT" },
                { "FP", "FMT" },
                { "FL", "FLK" },
                { "FE", "FER" },
                { "FRT", "FER" },
                { "FRE", "FHD" },
                { "GG", "GOL" },
                { "GP", "GUL" },
                { "CHS", "HPH" },
                { "HOO", "HOS" },
                { "IJN", "IND" },
                { "KEE", "KEN" },
                { "CHA", "KDA" },
                { "KD", "KED" },
                { "LRL", "LAU" },
                { "LS", "LON" },
                { "LRC", "LOT" },
                { "LAD", "LDN" },
                { "MMA", "MEA" },
                { "MVD", "MVR" },
                { "LEB", "MIV" },
                { "MR", "MNC" },
                { "NFL", "NFD" },
                { "OP", "OAK" },
                { "PHI", "PHA" },
                { "PRX", "PHA" },
                { "PRC", "PRD" },
                { "PPK", "POM" },
                { "PIA", "PKA" },
                { "PID", "PQI" },
                { "RDM", "RED" },
                { "RP", "REM" },
                { "RD", "BTP" },
                { "SAC", "SCR" },
                { "HOU", "SAM" },
                { "SA", "SAX" },
                { "SR", "STR" },
                { "SCD", "SCI" },
                { "TDN", "THI" },
                { "WBS", "WMP" },
                { "WO", "WOX" }
            };
        }

        private static TrackLimitsView CombineLimits(this List<TrackLimitsView> inLimits)
        {
            TrackLimitsView outLimit = new TrackLimitsView();
            if (inLimits.Count == 0)
                return outLimit;
            outLimit = inLimits.FirstOrDefault();
            
            foreach (var limit in inLimits)
            {
                if (outLimit.Status != limit.Status)
                    outLimit.Status = false;        // mixed?
                if (outLimit.Min != limit.Min)
                    outLimit.Min = -1;      // UI will display as mixed
                if (outLimit.Max != limit.Max)
                    outLimit.Max = -1;
                if (outLimit.Payout != limit.Payout)
                    outLimit.Payout = -1;
                if (outLimit.Odds != limit.Odds)
                    outLimit.Odds = -1;
            }

            return outLimit;
        }

        #endregion
    }
}