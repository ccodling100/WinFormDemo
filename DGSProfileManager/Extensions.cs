using DGSDataUtils.Entities.ProMgrEntities;
using DGSProfileManager.ViewModels;

namespace DGSProfileManager
{
    public static class Extensions
    {
        public static int StrToInt(this string strValue)
        {
            int x = -1;
            var rc = int.TryParse(strValue, out x);
            if (!rc)
                x = -1;

            return x;
        }

        public static ProfileItem ToProfileItem(this DtoRaceProfile profile)
        {
            ProfileItem pi = new();
            pi.ProfileName = profile.ProfileName;
            pi.IdProfile = profile.IdRaceProfile;
            if (Session.SelectedPlayers.Count > 0)
            {
                pi.IdPlayer = Session.SelectedPlayers[0].IdPlayer;
            }
            else
            {
                if (Session.SelectedAgent != null)
                    pi.IdPlayer = Session.SelectedAgent.IdPlayer;
            }

            return pi;
        }
    }
}
