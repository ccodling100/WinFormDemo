using DGSDataUtils.Configure;
using DGSDataUtils.Contexts;
using DGSDataUtils.Data.Models;
using DGSDataUtils.Entities.ProMgrEntities;
using DGSDataUtils.Extensions;

namespace DGSDataUtils.Data
{
    public class ImportUtility : IImportUtility
    {
        public event EventHandler<ProgressEventArgs> ImportProgressChanged;
        private readonly SimpleLogger _logger;

        public int DefaultBatchSize
        {
            get => _defaultBatchSize;
            set => _defaultBatchSize = value;
        }

        private string _defaultSourceConnectionString;
        private string _defaultDestinationConnectionString;
        private int _defaultBatchSize;

        /// <summary>
        /// The ImportUtility class provides functionality for importing data from DGSData database to another destination database.
        /// </summary>
        public ImportUtility(string defaultSourceConnectionString, string defaultDestinationConnectionString, int defaultBatchSize)
        {
            _defaultSourceConnectionString = defaultSourceConnectionString;
            _defaultDestinationConnectionString = defaultDestinationConnectionString;
            _defaultBatchSize = defaultBatchSize;

            // Ensure that the database exists.  If it does not, then it is created.
            using var proMgrCtx = new ProMgrDbContext(_defaultDestinationConnectionString);
            proMgrCtx.Database.EnsureCreated();

            // Initialize the logger
            _logger = new SimpleLogger();
        }

        /// <summary>
        /// Imports data from the DGSDataDB into the application.
        /// </summary>
        /// <param name="tableEnumOptions">The table or tables to import.
        /// Possible values: AgentDefaults, Tracks, BetTypes, TrackLimits, ProfileMaps, RaceProfiles, All</param>
        /// <returns>True if the import is successful; otherwise, false.</returns>
        public bool ImportDataFromDGSDataDB(ImportTableEnums tableEnumOptions)
        {
            bool rc = false;
            int TotalRecordCount = 0;
            int RecordsProcessed = 0;
            int percentProcessed = 0;
            int idx = 0;
            ProgressEventArgs progressEventArgs = new ProgressEventArgs();

            using (var dgsCtx = new DGSDbContext(_defaultSourceConnectionString))
            {
                using (var proMgrCtx = new ProMgrDbContext(_defaultDestinationConnectionString))
                {
                    try
                    {
                        // IBET_BetTypes
                        if (tableEnumOptions == ImportTableEnums.BetTypes || tableEnumOptions == ImportTableEnums.All)
                        {
                            TotalRecordCount = dgsCtx.LimitSetBetTypes.Select(x => x.BetType).Distinct().Count();
                            RecordsProcessed = 0;
                            idx = 0;
                            progressEventArgs.TableName = "IBET_BetTypes";

                            foreach (var betId in dgsCtx.LimitSetBetTypes.Select(x => x.BetType).Distinct())
                            {
                                try
                                {
                                    var dtoBetType = new DtoBetType { IdBetType = betId, BetName = betId.ToBetName() };
                                    proMgrCtx.BetTypes.Add(dtoBetType);
                                    proMgrCtx.SaveChanges();
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e);
                                }
                                RecordsProcessed++;
                                idx++;
                                percentProcessed = (int)(((float)RecordsProcessed / (float)TotalRecordCount) * 100.0);
                                progressEventArgs.Progress = percentProcessed;
                                ImportProgressChanged?.Invoke(this, progressEventArgs);
                            }

                            proMgrCtx.ChangeTracker.Clear();
                            rc = true;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        _logger.Log("IBET_BetTypes",e.Message);
                    }

                    try
                    {
                        // IBET_Tracks
                        if (tableEnumOptions == ImportTableEnums.Tracks || tableEnumOptions == ImportTableEnums.All)
                        {
                            TotalRecordCount = dgsCtx.Tracks.Count();
                            RecordsProcessed = 0;
                            idx = 0;
                            progressEventArgs.TableName = "IBET_Tracks";

                            foreach (var track in dgsCtx.Tracks)
                            {
                                var dtoTrack = track.ToTrack();
                                proMgrCtx.Tracks.Add(dtoTrack);
                                if (_defaultBatchSize > 1)
                                {
                                    if (idx >= _defaultBatchSize)
                                    {
                                        proMgrCtx.SaveChanges();
                                        idx = 0;
                                    }
                                }
                                else
                                {
                                    proMgrCtx.SaveChanges();
                                }

                                RecordsProcessed++;
                                idx++;
                                percentProcessed = (int)(((float)RecordsProcessed / (float)TotalRecordCount) * 100.0);
                                progressEventArgs.Progress = percentProcessed;
                                ImportProgressChanged?.Invoke(this, progressEventArgs);
                            }

                            proMgrCtx.SaveChanges();
                            proMgrCtx.ChangeTracker.Clear();

                            rc = true;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        _logger.Log("IBET_Tracks",e.Message);
                    }

                    try
                    {
                        // IBET_RaceProfiles
                        if (tableEnumOptions == ImportTableEnums.RaceProfiles || tableEnumOptions == ImportTableEnums.All)
                        {
                            TotalRecordCount = dgsCtx.Playerprofiles.Count();
                            RecordsProcessed = 0;
                            idx = 0;
                            progressEventArgs.TableName = "IBET_RaceProfiles";

                            foreach (var profile in dgsCtx.Playerprofiles)
                            {
                                var dtoProfile = profile.ToRaceProfile();
                                proMgrCtx.RaceProfiles.Add(dtoProfile);
                                if (_defaultBatchSize > 1)
                                {
                                    if (idx >= _defaultBatchSize)
                                    {
                                        proMgrCtx.SaveChanges();
                                        idx = 0;
                                    }
                                }
                                else
                                {
                                    proMgrCtx.SaveChanges();
                                }

                                RecordsProcessed++;
                                idx++;
                                percentProcessed = (int)(((float)RecordsProcessed / (float)TotalRecordCount) * 100.0);
                                progressEventArgs.Progress = percentProcessed;
                                ImportProgressChanged?.Invoke(this, progressEventArgs);
                            }

                            proMgrCtx.SaveChanges();
                            proMgrCtx.ChangeTracker.Clear();

                            rc = true;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        _logger.Log("IBET_RaceProfiles",e.Message);
                    }

                    try
                    {
                        // IBET_AgentDefaults
                        if (tableEnumOptions == ImportTableEnums.AgentDefaults || tableEnumOptions == ImportTableEnums.All)
                        {
                            TotalRecordCount = dgsCtx.Agents.Count();
                            RecordsProcessed = 0;
                            progressEventArgs.TableName = "IBET_Agents";

                            foreach (var agent in dgsCtx.Agents)
                            {
                                int agentId = agent.IdAgent;
                                int defaultProfileId = 0;
                                var rankings = GetAgentProfileRankings(agentId);
                                if (rankings.Count > 0)
                                {
                                    var defaultProfile = rankings[0];
                                    defaultProfileId = defaultProfile.IdProfile;
                                }

                                var dtoAgent = agent.ToAgentDefault();
                                if (defaultProfileId > 0)
                                    dtoAgent.IdRaceProfile = defaultProfileId;
                                proMgrCtx.AgentDefaults.Add(dtoAgent);
                                if (_defaultBatchSize > 1)
                                {
                                    if (idx >= _defaultBatchSize)
                                    {
                                        proMgrCtx.SaveChanges();
                                        idx = 0;
                                    }
                                }
                                else
                                {
                                    proMgrCtx.SaveChanges();
                                }

                                RecordsProcessed++;
                                idx++;
                                percentProcessed = (int)(((float)RecordsProcessed / (float)TotalRecordCount) * 100.0);
                                progressEventArgs.Progress = percentProcessed;
                                ImportProgressChanged?.Invoke(this, progressEventArgs);
                            }

                            proMgrCtx.SaveChanges();
                            proMgrCtx.ChangeTracker.Clear();
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        _logger.Log("IBET_AGENTS",e.Message);
                    }


                    try
                    {
                        // IBET_ProfileMap
                        if (tableEnumOptions == ImportTableEnums.ProfileMaps || tableEnumOptions == ImportTableEnums.All)
                        {
                            TotalRecordCount = dgsCtx.Players.Count();
                            RecordsProcessed = 0;
                            idx = 0;
                            progressEventArgs.TableName = "IBET_ProfileMaps";

                            foreach (var player in dgsCtx.Players)
                            {
                                var dtoProfileMap = player.ToProfileMap();
                                proMgrCtx.ProfileMaps.Add(dtoProfileMap);
                                if (_defaultBatchSize > 1)
                                {
                                    if (idx >= _defaultBatchSize)
                                    {
                                        proMgrCtx.SaveChanges();
                                        idx = 0;
                                    }
                                }
                                else
                                {
                                    proMgrCtx.SaveChanges();
                                }

                                RecordsProcessed++;
                                idx++;
                                percentProcessed = (int)(((float)RecordsProcessed / (float)TotalRecordCount) * 100.0);
                                progressEventArgs.Progress = percentProcessed;
                                ImportProgressChanged?.Invoke(this, progressEventArgs);
                            }
                            proMgrCtx.SaveChanges();
                            proMgrCtx.ChangeTracker.Clear();

                            rc = true;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        _logger.Log("IBET_ProfileMaps",e.Message);
                    }

                    try
                    {
                        // IBET_TrackLimits
                        if (tableEnumOptions == ImportTableEnums.TrackLimits || tableEnumOptions == ImportTableEnums.All)
                        {
                            TotalRecordCount = dgsCtx.Playerprofiles.Count();
                            RecordsProcessed = 0;
                            idx = 0;
                            progressEventArgs.TableName = "IBET_TrackLimits";
                            var noPlayerTrackLimitCount = 0;

                            foreach (var playerProfile in dgsCtx.Playerprofiles)
                            {
                                try
                                {
                                    var trackLimits = playerProfile.GetProfileLimits(_defaultSourceConnectionString);
                                    if (trackLimits.Count == 0)
                                    {
                                        // TODO: No track limits exist in old system, should we use the default profile track limits?
                                        noPlayerTrackLimitCount++;
                                    }

                                    foreach (var trackLimit in trackLimits)
                                    {
                                        var dtoTrackLimit = trackLimit.ToTrackLimit();
                                        proMgrCtx.TrackLimits.Add(dtoTrackLimit);

                                        if (_defaultBatchSize > 1)
                                        {
                                            if (idx >= _defaultBatchSize)
                                            {
                                                proMgrCtx.SaveChanges();
                                                idx = 0;
                                            }
                                        }
                                        else
                                        {
                                            proMgrCtx.SaveChanges();
                                        }
                                        idx++;
                                    }
                                    proMgrCtx.SaveChanges();
                                    proMgrCtx.ChangeTracker.Clear();
                                    idx = 0;

                                    RecordsProcessed++;
                                    percentProcessed = (int)(((float)RecordsProcessed / (float)TotalRecordCount) * 100.0);
                                    progressEventArgs.Progress = percentProcessed;
                                    ImportProgressChanged?.Invoke(this, progressEventArgs);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e);
                                    _logger.Log("IBET_TrackLimits",e.Message);
                                }
                            }

                            rc = true;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }

            return rc;
        }

        /// <summary>
        /// Retrieves the agent profile rankings.
        /// </summary>
        /// <param name="agentId">The ID of the agent.</param>
        /// <returns>The list of agent profile rankings.</returns>
        private List<AgentPlayerProfileStats> GetAgentProfileRankings(int agentId)
        {
            List<AgentPlayerProfileStats> profileStatResults = null;
            try
            {
                using (var ctx = new DGSDbContext(_defaultSourceConnectionString))
                {
                    var totalPlayersForAgent = ctx.Players.Count(p => p.IdAgent == agentId);

                    profileStatResults = ctx.Players
                        .Where(p => p.IdAgent == agentId)
                        .GroupBy(p => new { p.IdProfile, p.IdAgent })
                        .Select(g => new AgentPlayerProfileStats
                        {
                            IdProfile = g.Key.IdProfile,
                            IdAgent = g.Key.IdAgent,
                            Percentage = g.Count() * 100.0 / totalPlayersForAgent
                        }).OrderByDescending(m => m.Percentage)
                        .ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return profileStatResults;
        }
    }
}