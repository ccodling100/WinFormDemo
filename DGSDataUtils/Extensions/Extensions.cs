using DGSDataUtils.Data;
using DGSDataUtils.Data.Models;
using DGSDataUtils.Entities.DGSEntities;
using DGSDataUtils.Entities.ProMgrEntities;

namespace DGSDataUtils.Extensions
{
    public static class Extensions
    {
        public static DtoAgentDefault ToAgentDefault(this Agent agent)
        {
            return new()
            {
                IdAgent = agent.IdAgent
            };
        }

        public static DtoTrack ToTrack(this Track track)
        {
            return new()
            {
                IdTrack = track.TrackId,
                TrackName = track.TrackName,
                TrackCode = track.TrackCode.ToIbetTrackCode()
            };
        }

        public static DtoRaceProfile ToRaceProfile(this Playerprofile profile)
        {
            return new()
            {
                IdRaceProfile = profile.IdProfile,
                ProfileName = profile.ProfileName
            };
        }

        public static DtoProfileMap ToProfileMap(this Player player)
        {
            DtoProfileMap profileMap = new DtoProfileMap
            {
                IdSportProfile = player.IdProfile,
                IdPlayer = player.IdPlayer,
                IdRaceProfile = player.IdProfile        // on import only these are the same?
            };
            return profileMap;
        }

        public static DtoTrackLimit ToTrackLimit(this DGSTrackLimit dgsLimit)
        {
            DtoTrackLimit tl = new()
            {
                IdTrack = dgsLimit.TrackId,
                IdRaceProfile = dgsLimit.ProfileId,
                IdBetType = dgsLimit.BetType,
                IsEnabled = dgsLimit.TrackEnabled.Value,
                MaxPayoutOdds = dgsLimit.MaxPayoutOdds,
                MinBet = dgsLimit.MinStake,
                MaxBet = dgsLimit.MaxStake,
                PerBetMaxWin = dgsLimit.MaxPayoutCap,
                PerRaceMaxWin = dgsLimit.MaxRaceWin
            };

            return tl;
        }
        
        public static DtoRaceProfile CloneProfile(this DtoRaceProfile profile)
        {
            DtoRaceProfile np = new DtoRaceProfile();
            
            np.ProfileName = $"{profile.ProfileName}(1)";
            np.HorseGlobalMax = profile.HorseGlobalMax;
            np.GlobalMaxAmount = profile.GlobalMaxAmount;
            np.GlobalMaxTime = profile.GlobalMaxTime;
            np.IbetAgentDefault = profile.IbetAgentDefault;

            return np;
        }

        public static DtoTrackLimit CloneTrackLimit(this DtoTrackLimit limit)
        {
            var newLimit = new DtoTrackLimit
            {
                IsEnabled = limit.IsEnabled,
                IdBetType = limit.IdBetType,
                IdTrack = limit.IdTrack,
                MaxPayoutOdds = limit.MaxPayoutOdds,
                MinBet = limit.MinBet,
                MaxBet = limit.MaxBet,
                PerBetMaxWin = limit.PerBetMaxWin,
                PerRaceMaxWin = limit.PerRaceMaxWin
            };

            return newLimit;
        }
    }
}