using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DGSProfileManager;

public static class Helper
{
    public static bool ValidateNewProfileName(string profileName, string connectionString)
    {
        bool rc = true;
        
        if (profileName.Length < 4)
        {
            XtraMessageBox.Show("Profile name is invalid.  Profile name must contain at least 3 characters.", "Invalid", MessageBoxButtons.OK);
            rc = false;
        }

        var profile = DGSDataUtils.Data.DataExtensions.GetProfileByName(profileName, connectionString);
        if (profile != null)
        {
            XtraMessageBox.Show("This profile name already exists.  Please choose a profile name that is unique.", "Duplicate Profile Name", MessageBoxButtons.OK);
            rc = false;
        }

        return rc;
    }
}