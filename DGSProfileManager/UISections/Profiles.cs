using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Layout.Events;
using DevExpress.XtraSplashScreen;
using DGSDataUtils.Data;
using DGSDataUtils.Data.Models;
using DGSDataUtils.Entities.ProMgrEntities;
using DGSProfileManager.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace DGSProfileManager;

partial class MainForm
{
    /// <summary>
    /// Asynchronously loads the race profiles data from the database and binds it to the profile grid.
    /// </summary>
    private void LoadProfiles()
    {
        // Asynchronous loading of the data
        _proMgrCtx.RaceProfiles.OrderBy(c => c.ProfileName).LoadAsync().ContinueWith(loadTask =>
        {
            profileGrid.DataSource = _proMgrCtx.RaceProfiles.Local.ToBindingList();
        }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        
        // Synchronous loading of the data
        //profileGrid.DataSource = _proMgrCtx.RaceProfiles.ToList();
        profileView.FocusedRowHandle = -1;
    }

    /// <summary>
    /// Handles the CustomFieldValueStyle event of the profileView control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The LayoutViewFieldValueStyleEventArgs instance containing the event data.</param>
    private void profileView_CustomFieldValueStyle(object sender, LayoutViewFieldValueStyleEventArgs e)
    {
        var profileName = (string)profileView.GetRowCellValue(e.RowHandle, "ProfileName");
        if (IsProfileSelected(profileName))
        {
            Styles.SetSimpleLabelStyle(e.Appearance, true);
        }
    }

    /// <summary>
    /// Handles the FieldValueClick event of the profileView control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="FieldValueClickEventArgs"/> instance containing the event data.</param>
    private void profileView_FieldValueClick(object sender, FieldValueClickEventArgs e)
    {
        if (e.Button == MouseButtons.Right)
        {
            DoShowMenu(e);
            return;
        }

        // DO we still want left mouse click to select since we have a menu 'edit'
        if (e.Button == MouseButtons.Left)
        {
            //EditProfile(e.FieldValue.ToString());
            btnProfileAssign.Tag = e.FieldValue.ToString();
            btnDefaultProfileAssign.Tag = e.FieldValue.ToString();
        }
    }

    /// <summary>
    /// Shows the menu for the field value click event.
    /// </summary>
    /// <param name="e">The FieldValueClickEventArgs object that contains information about the click event.</param>
    void DoShowMenu(FieldValueClickEventArgs e)
    {
        _selectedProfileItem = (string)e.FieldValue;
        profilePopupMenu.Show(profileGrid, e.X, e.Y);
    }

    /// <summary>
    /// Event handler that is called when the profile popup menu is closed.
    /// </summary>
    /// <param name="sender">The object that raised the event</param>
    /// <param name="e">The event arguments</param>
    private void profilePopupMenu_Closed(object sender, ToolStripDropDownClosedEventArgs e)
    {
        _selectedProfileItem = string.Empty;
    }

    /// <summary>
    /// Handles the click event of the items in the profilePopupMenu control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A ToolStripItemClickedEventArgs that contains the event data.</param>
    private void profilePopupMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        if (e.ClickedItem.Text == "Delete")
        {
            var profile = _proMgrCtx.RaceProfiles.FirstOrDefault(c => c.ProfileName.ToUpper() == _selectedProfileItem.ToUpper());
            var profileId = profile.IdRaceProfile;
            
            var sMsg = "Are you sure you want to delete this profile?\r\n";
                sMsg += "Doing so, will cause the following player(s) to be without a profile and a new profile will need to be assigned to them.\r\n";
                sMsg += "Player(s): ";
                sMsg += DataExtensions.GetPlayersAssignedToProfile(profileId, Session.ProMgrConnectionString, Session.DgsConnectionstring);
            var result = XtraMessageBox.Show(sMsg, "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;
            DoDeleteProfileItem(_selectedProfileItem);
        }
        else if (e.ClickedItem.Text == "Clone")
        {
            DoCloneProfileItem(_selectedProfileItem);
        }
        else
        {
            DoEditProfileItem(_selectedProfileItem);
        }
    }

    /// <summary>
    /// Clones a profile item with the specified name.
    /// </summary>
    /// <param name="profileName">The name of the profile item to clone.</param>
    private void DoCloneProfileItem(string profileName)
    {
        var x = profileName;
        var profile = _proMgrCtx.RaceProfiles.FirstOrDefault(x => x.ProfileName.ToUpper() == profileName.ToUpper());
        
        if (profile == null)
            return; // TODO: Display error in message box (shouldn't happen)

        // TODO: we're not assigning to the player at this time
        // int playerId = -1;
        // var highlightedProfile = Session.HighlightedProfiles.FirstOrDefault(c => c.IdProfile == profile.IdRaceProfile);
        // if (highlightedProfile != null)
        //     playerId = highlightedProfile.IdPlayer;
        // else
        //     playerId = (int) playerView.GetRowCellValue(playerView.FocusedRowHandle, "IdPlayer");
        
        CloneProfile(profile/*, playerId*/);
        _selectedProfileItem = string.Empty;
    }

    /// <summary>
    /// Deletes a profile item from the RaceProfiles table in the ProMgr database.
    /// </summary>
    /// <param name="profileName">The name of the profile item to delete.</param>
    private void DoDeleteProfileItem(string profileName)
    {
        var x = profileName;
        var profile = _proMgrCtx.RaceProfiles.FirstOrDefault(x => x.ProfileName.ToUpper() == profileName.ToUpper());
        
        if (profile == null)
            return; // TODO: Display error in message box (shouldn't happen)
        
        DeleteProfile(profile);
        _selectedProfileItem = string.Empty;
    }

    /// <summary>
    /// Edits the profile item with the specified profile name.
    /// </summary>
    /// <param name="profileName">The name of the profile to edit.</param>
    private void DoEditProfileItem(string profileName)
    {
        EditProfile(profileName);
        btnProfileAssign.Tag = profileName;
        btnDefaultProfileAssign.Tag = profileName;
    }

    /// Creates a clone of a DtoRaceProfile object with a new profile name.
    /// @param profile The DtoRaceProfile object to clone.
    /// @returns Returns true if the cloning was successful, false otherwise.
    /// /
    private bool CloneProfile(DtoRaceProfile profile/*, int idPlayer*/)
    {
        bool rc = false;
        var clonedProfileName = XtraInputBox.Show("Enter a new name for this cloned profile.", "Clone Profile", $"{profile.ProfileName}(1)", MessageBoxButtons.OKCancel);
        
        if (clonedProfileName == null)
            return false;

        if (clonedProfileName.Length < 4)
        {
            XtraMessageBox.Show("Profile name is invalid.  Profile name must contain at least 3 characters.", "Invalid", MessageBoxButtons.OK);
            return false;
        }

        DtoRaceProfile clonedProfile = null;
        SplashScreenManager.ShowForm(this, typeof(SavingForm), false, false, false);
        try
        {
            clonedProfile = DGSDataUtils.Data.DataExtensions.CloneDtoProfile(profile, clonedProfileName, Session.ProMgrConnectionString);
            LoadProfiles();
        }
        finally
        {
            //Close Loading Form
            SplashScreenManager.CloseForm(false);
            if (clonedProfile != null)
            {
                profileView.RefreshData();
                rc = true;
            }
        }
        
        return rc;
    }

    /// <summary>
    /// Deletes a profile from the database.
    /// </summary>
    /// <param name="profile">The profile to be deleted.</param>
    private void DeleteProfile(DtoRaceProfile profile)
    {
        var profileName = profile.ProfileName;
        var response = XtraMessageBox.Show($"Are you sure you want to delete the profile '{profile.ProfileName}'.", "Confirmation", MessageBoxButtons.YesNo);
        if (response == DialogResult.No)
            return;

        bool rc = false;
        SplashScreenManager.ShowForm(this, typeof(SavingForm), false, false, false);
        try
        {
            rc = DataExtensions.DeleteDtoProfile(profile, Session.ProMgrConnectionString);
        }
        finally
        {
            if (rc)
            {
                if (IsProfileSelected(profileName))
                {
                    RemoveProfileFromSession(profileName);            
                    UpdateProfileText();
                }
                profileView.RefreshData();
            }
            SplashScreenManager.CloseForm(false);
        }
    }
    
    private void btnDefaultProfileNew_Click(object sender, EventArgs e)
    {
        if (!ValidateNewDefaultProfile())
            return;

        var newProfileName = XtraInputBox.Show("Enter a new default profile name", "New Default Profile", "");
        if (newProfileName == null)
            return;
        
        if (newProfileName.Length < 4)
        {
            XtraMessageBox.Show("Profile name is invalid.  Profile name must contain at least 3 characters.", "Invalid", MessageBoxButtons.OK);
            return;
        }

        var newProfileId = DataExtensions.CreateNewDefaultProfile(newProfileName, Session.SelectedAgent.IdAgent, Session.ProMgrConnectionString);

        if (newProfileId < 0)
        {
            XtraMessageBox.Show("Error creating default profile.  Please ensure that your profile name is unique.", "Error", MessageBoxButtons.OK);
        }
        else
        {
            //XtraMessageBox.Show("New default profile created successfully.", "Complete", MessageBoxButtons.OK);
            AssignProfileToAgent(newProfileId, newProfileName);
            XtraMessageBox.Show("New default profile created and assigned to this agent successfully.", "Complete", MessageBoxButtons.OK);
            
            Session.DefaultProfile = new() { ProfileName = newProfileName, IdProfile = newProfileId, IdPlayer = Session.SelectedAgent.IdAgent };
            UpdateDefaultProfileView();
            profileView.Refresh();
        }
    }

    /// <summary>
    /// Event handler for the "New Profile" button click event.
    /// Validates the new profile information, prompts the user for a new profile name,
    /// creates the new profile in the database, and updates the UI accordingly.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">An EventArgs object containing event data.</param>
    private void btnProfileNew_Click(object sender, EventArgs e)
    {
        if (!ValidateNewProfile())
            return;
        
        var newProfileName = XtraInputBox.Show("Enter a new profile name", "New Profile", "", MessageBoxButtons.OKCancel);
        if (newProfileName == null)
            return;

        if (newProfileName.Length < 4)
        {
            XtraMessageBox.Show("Profile name is invalid.  Profile name must contain at least 3 characters.", "Invalid", MessageBoxButtons.OK);
            return;
        }

        var playerName = txtPlayer.Text;
        if (playerName.Length == 0)
        {
            XtraMessageBox.Show("No player is selected.  Please select a player to create a new profile for.", "Invalid Player", MessageBoxButtons.OK);
            return;
        }
        
        var newProfileId = DataExtensions.CreateNewPlayerProfile(newProfileName, Session.SelectedPlayers.Select(c => c.IdPlayer).ToList(), Session.ProMgrConnectionString);
        
        if (newProfileId < 0)
        {
            XtraMessageBox.Show("Error creating new profile.  Please ensure that your profile name is unique.", "Error", MessageBoxButtons.OK);
        }
        else
        {
            XtraMessageBox.Show("New profile created successfully.", "Complete", MessageBoxButtons.OK);
            
            ProfileItem pi = new() { ProfileName = newProfileName, IdProfile = newProfileId, IdPlayer = Session.SelectedAgent.IdAgent };
            Session.HighlightedProfiles.Add(pi);
            Session.SelectedProfile = pi;
            AssignProfileToPlayers(pi.IdProfile);
            UpdateProfileText(newProfileName);
            profileView.RefreshData();
            //profileView.Refresh();
        }
    }

    /// <summary>
    /// Method that handles the click event of the btnDefaultProfileAssign button.
    /// It assigns the default profile to the selected agent.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">An EventArgs that contains the event data.</param>
    private void btnDefaultProfileAssign_Click(object sender, EventArgs e)
    {
        if (!ValidateAssignProfileToAgent())
        {
            return;
        }

        string profileName;
        int profileId;
        if (btnDefaultProfileAssign.Tag == null)
        {
            profileName = Session.SelectedProfile.ProfileName;
            profileId = Session.SelectedProfile.IdProfile;
        }
        else
        {
            profileName = btnDefaultProfileAssign.Tag.ToString();
            var focusProfile = DataExtensions.GetProfileByName(profileName, Session.ProMgrConnectionString);
            profileId = focusProfile.IdRaceProfile;
        }
        
        var agentName = agentLookupCtl.Text;
        var msg = $"Are you sure you want to save the assignment of this profile ({profileName}) to this agent ({agentName})?";
        
        var rv = ShowSaveCancelMessageBox("Confirmation", msg);
        if (rv == DialogResult.Cancel)
            return;

        AssignProfileToAgent(profileId, profileName);

        var sMsg = $"Default profile '{profileName} has been assigned to this agent.";
        XtraMessageBox.Show(sMsg, "Information", MessageBoxButtons.OK);
    }

    /// <summary>
    /// Assigns a profile to an agent and updates the default profile view.
    /// </summary>
    /// <param name="profileId">The ID of the profile to be assigned.</param>
    /// <param name="profileName">The name of the profile to be assigned.</param>
    private void AssignProfileToAgent(int profileId, string profileName)
    {
        SplashScreenManager.ShowForm(this, typeof(SavingForm), false, true, false);
        try
        {
            var agentDefault = _proMgrCtx.AgentDefaults.FirstOrDefault(x => x.IdAgent == Session.SelectedAgent.IdAgent);
            if (agentDefault == null)
            {
                // Create a default entry for this agent
                agentDefault = new DtoAgentDefault();
                agentDefault.IdAgent = Session.SelectedAgent.IdAgent;
                agentDefault.IdRaceProfile = profileId;
                _proMgrCtx.AgentDefaults.Add(agentDefault);
            }
            else
            {
                agentDefault.IdRaceProfile = profileId;
                _proMgrCtx.AgentDefaults.Update(agentDefault);
            }

            // Assign this profile to all players of this agent, that do not already have a profile assigned to them.
            List<int> agentPlayers = _dgsCtx.Players
                .Where(p => p.IdAgent == Session.SelectedAgent.IdAgent)
                .Select(c => c.IdPlayer)
                .ToList();
            foreach (var profileMap in agentPlayers
                         .Select(player => _proMgrCtx.ProfileMaps.FirstOrDefault(p => p.IdPlayer == player))
                         .Where(profileMap => profileMap.IdRaceProfile.HasValue == false))
            {
                profileMap.IdRaceProfile = profileId;
                _proMgrCtx.ProfileMaps.Update(profileMap);
            }

            _proMgrCtx.SaveChanges();
            
            AddDefaultProfileToSession(profileName, Session.SelectedAgent.IdAgent);
            UpdateDefaultProfileView();
            profileView.Refresh();
        }
        finally
        {
            SplashScreenManager.CloseForm(false);
        }
    }

    /// <summary>
    /// Event handler for assigning a profile to players.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void btnProfileAssign_Click(object sender, EventArgs e)
    {
        if (!ValidateAssignProfileToPlayer())
        {
            return;
        }
        
        string profileName;
        int profileId;
        if (btnDefaultProfileAssign.Tag == null)
        {
            profileName = Session.SelectedProfile.ProfileName;
            profileId = Session.SelectedProfile.IdProfile;
        }
        else
        {
            profileName = btnDefaultProfileAssign.Tag.ToString();
            var focusProfile = DataExtensions.GetProfileByName(profileName, Session.ProMgrConnectionString);
            profileId = focusProfile.IdRaceProfile;
        }
        
        var players = GetSelectedPlayersList();
        var msg = $"Are you sure you want to save the assignment of this profile ({profileName}) to the following players: \n{players}";
        
        var rv = ShowSaveCancelMessageBox("Confirmation", msg);
        if (rv == DialogResult.Cancel)
            return;

        var rc = AssignProfileToPlayers(profileId);
        
        if (rc)
        {
            var sMsg = $"Profile {Session.SelectedProfile.ProfileName} has been assigned to the selected player(s).";
            XtraMessageBox.Show(sMsg, "Information", MessageBoxButtons.OK);
        }
        else
        {
            var sMsg = $"Failed to assign profile {Session.SelectedProfile.ProfileName} to the selected player(s).";
            XtraMessageBox.Show(sMsg, "Warning", MessageBoxButtons.OK);
        }
    }

    /// <summary>
    /// Assigns a profile to players.
    /// </summary>
    /// <param name="profileId">The ID of the profile to assign.</param>
    /// <returns>True if the assignment is successful; otherwise, false.</returns>
    private bool AssignProfileToPlayers(int profileId)
    {
        bool rc = false;
        SplashScreenManager.ShowForm(this, typeof(SavingForm), false, true, false);
        try
        {
            List<int> playerIdList = Session.SelectedPlayers.Select(c => c.IdPlayer).ToList();
            rc = DataExtensions.AssignProfileToPlayersV2(profileId, playerIdList, /*Session.ProMgrConnectionString*/ _proMgrCtx);
            
            // Reload the players
            LoadPlayers(Session.SelectedAgent.IdAgent);
        }
        finally
        {
            SplashScreenManager.CloseForm(false);
        }

        return rc;
    }

    /// <summary>
    /// Event handler for the EditValueChanged event of the txtSearchProfiles control.
    /// Applies a filter to the profileView based on the text entered in txtSearchProfiles.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">An EventArgs object containing event data.</param>
    private void txtSearchProfiles_EditValueChanged(object sender, EventArgs e)
    {
        if (profileView.ActiveFilterEnabled == false)
            profileView.ActiveFilterEnabled = true;

        var sFilter = $"Contains([ProfileName],'{txtSearchProfiles.Text}')";
        profileView.ActiveFilterString = sFilter;
    }

    /// <summary>
    /// Event handler for the ButtonPressed event of the txtSearchProfiles control.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">An instance of the ButtonPressedEventArgs class that contains the event data.</param>
    private void txtSearchProfiles_ButtonPressed(object sender, ButtonPressedEventArgs e)
    {
        txtSearchProfiles.Text = String.Empty;
    }

    /// <summary>
    /// This method is an event handler for the Enter event of the txtSearchProfiles textbox.
    /// It selects all the text in the textbox when it receives focus.
    /// </summary>
    /// <param name="sender">The object that triggered the event.</param>
    /// <param name="e">The EventArgs associated with the event.</param>
    private void txtSearchProfiles_Enter(object sender, EventArgs e)
    {
        txtSearchProfiles.SelectAll();
    }

    /// <summary>
    /// Edits the profile with the given profile name.
    /// </summary>
    /// <param name="profileName">The name of the profile to edit.</param>
    private void EditProfile(string profileName)
    {
        var profile = _proMgrCtx.RaceProfiles.FirstOrDefault(x => x.ProfileName == profileName);
        if (profile != null)
        {
            int playerId = -1;
            if (Session.SelectedPlayers.Count == 1)
                playerId = Session.SelectedPlayers[0].IdPlayer;
            Session.SelectedProfile = new ProfileItem(profile.IdRaceProfile, profile.ProfileName, playerId);
                
            //Open Loading Form
            SplashScreenManager.ShowForm(this, typeof(LoadingForm), false, false, false);
            try
            {
                UpdateProfileText(true);
                EnableTrackAndLimitsUI(true);
            }
            finally
            {
                //Close Loading Form
                SplashScreenManager.CloseForm(false);
            }
        }
    }
}