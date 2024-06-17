using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DGSDataUtils.Contexts;
using DGSDataUtils.Data.Models;
using DGSProfileManager.ViewModels;

namespace DGSProfileManager;

partial class MainForm
{
    /// <summary>
    /// Adds an agent to the session.
    /// </summary>
    /// <param name="agentId">The ID of the agent to be added.</param>
    private void AddAgentToSession(int agentId)
    {
        PlayerItem pi = new();
        try
        {
            var agent = _dgsCtx.Agents.FirstOrDefault(p => p.IdAgent == agentId);
        
            pi.PlayerName = agent!.Agent1;
            pi.IdPlayer = agentId;
            pi.IdAgent = agentId;
            Session.SelectedAgent = pi;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    /// <summary>
    /// Adds a player to the current session.
    /// </summary>
    /// <param name="playerName">The name of the player to add.</param>
    /// <returns>Returns true if the player was successfully added, false otherwise.</returns>
    private bool AddPlayerToSession(string playerName)
    {
        // Remove player if it already exists
        RemovePlayerFromSession(playerName);
        PlayerItem pi = new();
        var player = _dgsCtx.Players.FirstOrDefault(p => p.Player1.ToUpper() == playerName.ToUpper());
        if (player == null)
            return false;
        
        pi.PlayerName = playerName.ToUpper();
        pi.IdPlayer = player!.IdPlayer;
        pi.IdAgent = Session.SelectedAgent.IdAgent;
        if (pi.IdPlayer == 0)
            return false;
        
        // If this player has a profile, then it needs to be selected and added to the current session
        var map = _proMgrCtx.ProfileMaps.FirstOrDefault(c => c.IdPlayer == pi.IdPlayer);
        if (map != null)
        {
            var profile = _proMgrCtx.RaceProfiles.FirstOrDefault(c => c.IdRaceProfile == map.IdRaceProfile);
            AddProfileToSession(profile!.ProfileName, pi.IdPlayer);
            pi.IdProfile = profile.IdRaceProfile;
        }
        Session.SelectedPlayers.Add(pi);
        
        return true;
    }

    /// <summary>
    /// Adds the default profile to the session.
    /// </summary>
    /// <param name="profileName">The name of the default profile.</param>
    /// <param name="agentId">The ID of the agent.</param>
    /// <returns>Returns true if the default profile was added to the session successfully; otherwise, false.</returns>
    private bool AddDefaultProfileToSession(string profileName, int agentId)
    {
        try
        {
            var pi = new ProfileItem();
            var profile = _proMgrCtx.RaceProfiles.FirstOrDefault(rp => rp.ProfileName == profileName);
            if (profile == null) return false;

            pi.ProfileName = profileName;
            pi.IdProfile = profile.IdRaceProfile;
            pi.IdPlayer = agentId;
                
            Session.DefaultProfile = pi;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }

        return true;
    }

    /// <summary>
    /// Adds a profile to the session.
    /// </summary>
    /// <param name="profileName">The name of the profile to add.</param>
    /// <param name="playerId">The ID of the player to associate with the profile. If set to -1, the ID of the profile currently selected in the session will be used.</param>
    /// <returns>Returns true if the profile was successfully added to the session, otherwise false.</returns>
    private bool AddProfileToSession(string profileName, int playerId)
    {
        try
        {
            // Remove profile if it already exists
            var curProfile = Session.HighlightedProfiles.Where(c => c.ProfileName.ToUpper() == profileName.ToUpper()).FirstOrDefault();
            if (playerId < 0)
                playerId = curProfile.IdPlayer;
            RemoveProfileFromSession(profileName);
            ProfileItem pi = new();
            var profile = _proMgrCtx.RaceProfiles.FirstOrDefault(rp => rp.ProfileName == profileName);
            if (profile == null)
                return false;

            pi.ProfileName = profileName;
            pi.IdProfile = profile.IdRaceProfile;
            pi.IdPlayer = playerId;
            
            Session.HighlightedProfiles.Add(pi);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
        
        return true;
    }

    /// <summary>
    /// Removes a player from the current session, including any associated profile.
    /// </summary>
    /// <param name="playerName">The name of the player to be removed.</param>
    private void RemovePlayerFromSession(string playerName)
    {
        var pi = Session.SelectedPlayers.FirstOrDefault(c => c.PlayerName == playerName.ToUpper());
        if (pi == null)
            return;
        Session.SelectedPlayers.Remove(pi);
        
        // If this player has a profile selected, and they are the only player with that profile, the profile needs to be unselected as well
        if (Session.SelectedPlayers.All(p => p.IdPlayer != pi.IdPlayer))
        {
            var profileCount = Session.SelectedPlayers.Count(p => p.IdProfile == pi.IdProfile);
            if (profileCount == 0)
            {
                var profileToRemove = Session.HighlightedProfiles.FirstOrDefault(p => p.IdProfile == pi.IdProfile);
                Session.HighlightedProfiles.Remove(profileToRemove);
            }
        }
    }

    /// <summary>
    /// Removes a profile from the session.
    /// </summary>
    /// <param name="profileName">The name of the profile to remove.</param>
    private void RemoveProfileFromSession(string profileName)
    {
        var pi = Session.HighlightedProfiles.FirstOrDefault(c => c.ProfileName == profileName.ToUpper());
        Session.HighlightedProfiles.Remove(pi);
    }

    /// <summary>
    /// Updates the text of the player input field based on the selected players.
    /// </summary>
    private void UpdatePlayerText()
    {
        if (Session.SelectedPlayers.Count == 1)
            txtPlayer.Text =Session.SelectedPlayers[0].PlayerName;
        else if (Session.SelectedPlayers.Count > 1)
            txtPlayer.Text = "Multiple";
        else
            txtPlayer.Text = "";   
    }

    /// Determines if a player is selected in the session.
    /// @param playerName The name of the player to check.
    /// @returns True if the player is selected, false otherwise.
    /// /
    private bool IsPlayerSelected(string playerName)
    {
        return Session.SelectedPlayers.Count(c => c.PlayerName == playerName.ToUpper()) > 0;
    }

    /// <summary>
    /// Determines if a profile is selected.
    /// </summary>
    /// <param name="profileName">The name of the profile.</param>
    /// <returns>True if the profile is selected; otherwise, false.</returns>
    private bool IsProfileSelected(string profileName)
    {
        return ((Session.HighlightedProfiles.Count(c => c.ProfileName == profileName.ToUpper()) > 0) 
                || (Session.DefaultProfile.ProfileName == profileName.ToUpper()));
    }

    /// <summary>
    /// Updates the text displayed in the profile field based on the selected or highlighted profile(s).
    /// </summary>
    /// <param name="bProfileSelected">Indicates whether a profile is actively selected. Default is false.</param>
    private void UpdateProfileText(bool bProfileSelected = false)
    {
        if (bProfileSelected)
        {
            if (Session.SelectedProfile != null)
            {
                var pi = Session.SelectedProfile;
                // As per Frank, we do not want to display this
                // txtProfile.Text = pi.ProfileName;
                ViewGridProfile(pi.ProfileName, true);
                Session.SelectedProfile = pi;
                LoadTracks(pi.IdProfile);
                return;
            }
        }
        
        if (Session.HighlightedProfiles.Count == 1)
        {
            var pi = Session.HighlightedProfiles[0];
            txtProfile.Text = pi.ProfileName;
            ViewGridProfile(pi.ProfileName, true);
            Session.SelectedProfile = pi;
            LoadTracks(pi.IdProfile);
        }
        else if (Session.HighlightedProfiles.Count > 1)
            txtProfile.Text = "Mixed";
        else
        {
            if (Session.SelectedProfile!.IdProfile > 0)
            {
                txtProfile.Text = Session.SelectedProfile.ProfileName;
                ViewGridProfile(Session.SelectedProfile.ProfileName, true);
                LoadTracks(Session.SelectedProfile.IdProfile);
            }
            else if (Session.DefaultProfile.IdProfile > 0)
            {
                txtProfile.Text = Session.DefaultProfile.ProfileName;
                ViewGridProfile(Session.DefaultProfile.ProfileName, true);
                LoadTracks(Session.DefaultProfile.IdProfile);                    
            }
            else
                txtProfile.Text = Session.SelectedProfile != null ? Session.SelectedProfile.ProfileName : "";
        }

        // if 1 or more player profiles are highlighted, then un-highlight the default profile so the system doesn't think we have 2 profiles highlighted and we grey-out track and limits
        if (Session.HighlightedProfiles.Count > 0)
            Session.DefaultProfile = new ProfileItem();
    }

    /// <summary>
    /// Updates the profile text in the MainForm.
    /// </summary>
    /// <param name="profileName">The name of the profile to update.</param>
    private void UpdateProfileText(string profileName)
    {
        AddProfileToSession(profileName, -1);
        
        if (Session.HighlightedProfiles.Count == 1)
        {
            txtProfile.Text = Session.HighlightedProfiles[0].ProfileName;
            ViewGridProfile(Session.HighlightedProfiles[0].ProfileName, true);
        }
        else if (Session.HighlightedProfiles.Count > 1)
            txtProfile.Text = "Mixed";
        else
            txtProfile.Text = profileName;  
    }

    /// <summary>
    /// Updates the default profile view of the MainForm based on the selected agent and profile.
    /// </summary>
    private void UpdateDefaultProfileView()
    {
        // Does this agent have a default profile?
        var profileDefault = _proMgrCtx.AgentDefaults.FirstOrDefault(c => c.IdAgent == Session.SelectedAgent.IdAgent);
        _proMgrCtx.Entry(profileDefault).Reload();

        if (profileDefault != null && profileDefault.IdRaceProfile != null)
        {
            var profile = _proMgrCtx.RaceProfiles.FirstOrDefault(c => c.IdRaceProfile == profileDefault.IdRaceProfile);
            if (profile == null)
                return;
            try
            {
                if (profile.ProfileName.Length > 0)
                {
                    txtDefaultProfile.Text = profile.ProfileName;
                    AddDefaultProfileToSession(profile.ProfileName, profileDefault.IdAgent);
                    profileView.Refresh();
                    // If there is only one profile selected, and it's the agent's default profile, let's show that profile down below
                    if (Session.HighlightedProfiles.Count == 0 && Session.DefaultProfile.IdProfile != 0)
                    {
                        LoadTracks(profile.IdRaceProfile);
                        LoadTrackLimits(profile.IdRaceProfile, Session.GeneralSelectedTracks);
                        ViewGridProfile(profile.ProfileName, true);
                        Session.DefaultProfile = profile.ToProfileItem();
                        EnableTrackAndLimitsUI(true);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        else
        {
            Session.DefaultProfile = new ProfileItem();
            txtDefaultProfile.Text = String.Empty;
        }
    }

    /// <summary>
    /// Enables or disables the track and limits UI controls.
    /// </summary>
    /// <param name="enable">True to enable the controls, false to disable.</param>
    private void EnableTrackAndLimitsUI(bool enable)
    {
        trackTopPanel.Enabled = enable;
        trackLimitsTopPanel.Enabled = enable;
        if (Session.GeneralSelectedTracks.Count == 0 && Session.ModifiedSelectedTracks.Count == 0 && enable)
            limitsGrid.Enabled = false;     // override if no tracks are selected
        else
            limitsGrid.Enabled = enable;
        modifiedTracksGrid.Enabled = enable;
        tracksGrid.Enabled = enable;

        if (tracksGrid.Enabled)
            tracksGrid.Enabled = Session.ModifiedSelectedTracks.Count <= 0;
        if (modifiedTracksGrid.Enabled)
            modifiedTracksGrid.Enabled = Session.GeneralSelectedTracks.Count <= 0;
    }

    /// <summary>
    /// Refreshes the UI for the track limits based on the selected profile and tracks.
    /// </summary>
    private void RefreshTrackLimitsUI()
    {
        int profileId = 0;
        
        if (Session.HighlightedProfiles.Count == 1 || Session.SelectedProfile.IdProfile > 0 || Session.DefaultProfile.IdProfile > 0)
        {
            ProfileItem profileItem;
            profileItem = Session.SelectedProfile.IdProfile > 0 ? Session.SelectedProfile : Session.HighlightedProfiles.FirstOrDefault();
            if (profileItem != null)
                profileId = profileItem.IdProfile;
            else
            {
                // No profiles exist and none selected, but if there is a default profile for the agent highlighted, let's use that profile
                if (Session.DefaultProfile.IdProfile > 0)
                    profileId = Session.DefaultProfile.IdProfile;
            }
        }

        if (profileId == 0)
        {
            EnableTrackAndLimitsUI(false);
            return;
        }
        
        EnableTrackAndLimitsUI(true);
        List<int> selectedTracks = new List<int>();

        if (Session.GeneralSelectedTracks.Count > 0)
            selectedTracks = Session.GeneralSelectedTracks;
        else if (Session.ModifiedSelectedTracks.Count > 0)
            selectedTracks = Session.ModifiedSelectedTracks;
        
        LoadTrackLimits(profileId, selectedTracks);
    }

    /// <summary>
    /// Validates whether a new default profile can be created.
    /// </summary>
    /// <returns>True if the validation passes, otherwise false.</returns>
    private bool ValidateNewDefaultProfile()
    {
        if (Session.SelectedAgent.IdAgent <= 0)
        {
            XtraMessageBox.Show("You do not have an agent selected.  Please select an agent and a profile to assign a default profile.", "Warning", MessageBoxButtons.OK);
            return false;
        }

        return true;
    }

    /// <summary>
    /// Validates a new profile creation.
    /// </summary>
    /// <returns>Returns true if the profile creation is valid; otherwise, false.</returns>
    private bool ValidateNewProfile()
    {
        if (!ValidateNewDefaultProfile())
            return false;
        
        if (Session.SelectedPlayers.Count == 0)
        {
            XtraMessageBox.Show("You do not have any players selected.  Please choose a player to assign this profile to.", "Warning", MessageBoxButtons.OK);
            return false;
        }        
        
        return true;
    }

    /// <summary>
    /// Validates and assigns a profile to an agent.
    /// </summary>
    /// <returns>
    /// Returns true if the validation passes and the profile is successfully assigned to the agent,
    /// otherwise returns false.
    /// </returns>
    private bool ValidateAssignProfileToAgent()
    {
        if (Session.SelectedAgent.IdAgent <= 0)
        {
            XtraMessageBox.Show("You do not have an agent selected.  Please select an agent and a profile to assign a default profile.", "Warning", MessageBoxButtons.OK);
            return false;
        }

        if (profileView.FocusedColumn == null && Session.SelectedProfile.ProfileName.Length == 0)
        {
            XtraMessageBox.Show("You do not have any profiles selected.  Please choose a profile to assign as the default profile for this agent.", "Warning", MessageBoxButtons.OK);
            return false;
        }
        
        return true;
    }

    /// <summary>
    /// Validates the assignment of a profile to a player.
    /// </summary>
    /// <returns>
    /// Returns true if the assignment is valid; otherwise, false.
    /// </returns>
    private bool ValidateAssignProfileToPlayer()
    {
        // Ensure that we have at least 1 player selected and a profile must also be selected.
        
        if (Session.SelectedPlayers.Count == 0)
        {
            XtraMessageBox.Show("You do not have any players selected.  Please choose a player to assign this profile to.", "Warning", MessageBoxButtons.OK);
            return false;
        }

        if (Session.SelectedProfile == null)
        {
            XtraMessageBox.Show("You do not have a profile selected.  Please choose a profile to assign to this player.", "Warning", MessageBoxButtons.OK);
            return false;
        }
        
        return true;
    }

    /// <summary>
    /// Locates and selects a profile in the grid view based on the profile name.
    /// </summary>
    /// <param name="profileName">The name of the profile to view.</param>
    /// <param name="bSelect">True if the profile should be selected, otherwise false.</param>
    private void ViewGridProfile(string profileName, bool bSelect)
    {
        int rowHandle = profileView.LocateByValue("ProfileName", profileName);  
        if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)  
        {  
            if (bSelect)
                profileView.SelectRow(rowHandle);
            profileView.VisibleRecordIndex = rowHandle;
        }  
    }

    /// <summary>
    /// Updates the status bar with relevant information.
    /// </summary>
    private void UpdateStatusBar()
    {
        string profileName = string.Empty;
        if (btnProfileAssign.Tag != null)
        {
            profileName = btnProfileAssign.Tag.ToString();
        }

        if (profileName.Length == 0)
        {
            if (Session.SelectedProfile.ProfileName.Length > 0)
                profileName = Session.SelectedProfile.ProfileName;
        }

        lblStatusPlayerCount.Text = $@"Selected Players: {Session.SelectedPlayers.Count}";
        lblStatusProfileCount.Text = $@"Selected Profiles: {Session.HighlightedProfiles.Count}";
        if (profileName.Length > 0)
            lblStatusActiveProfile.Text = $@"Active Profile: {profileName}";
        if (Session.IsModified)
            lblStatusHasChanges.Text = @"Has Changes";
        else
            lblStatusHasChanges.Text = @"No Changes";
    }

    /// <summary>
    /// Displays a message box with save and cancel buttons.
    /// </summary>
    /// <param name="caption">The text to display in the message box title bar.</param>
    /// <param name="message">The text to display in the message box.</param>
    /// <returns>The dialog result indicating the button clicked by the user.</returns>
    private DialogResult ShowSaveCancelMessageBox(string caption, string message)
    {
        // Initializes an XtraMessageBoxArgs object to hold message box arguments.
        XtraMessageBoxArgs args = new XtraMessageBoxArgs();
        args.Caption = caption;
        args.Text = message;
        args.Buttons = new DialogResult[] { DialogResult.OK, DialogResult.Cancel};
        args.Showing += Args_Showing;
        var response = XtraMessageBox.Show(args);
        return response;
    }

    /// <summary>
    /// Event handler method for customizing the appearance of a DevExpress XtraMessageBox.
    /// </summary>
    /// <param name="sender">The object that triggered the event.</param>
    /// <param name="e">The event arguments containing the message box form.</param>
    private void Args_Showing(object sender, XtraMessageShowingArgs e) {
        // Loops through all controls in the message box.
        foreach (var control in e.MessageBoxForm.Controls) {
            // Checks if a control is a SimpleButton.
            SimpleButton button = control as SimpleButton;
            if (button != null) {
                switch (button.DialogResult.ToString()) {
                    case ("OK"):
                        button.Text = "Save";
                        break;
                    case ("Cancel"):
                        button.Text = "Cancel";
                        break;
                }
            }
        }
    }

    /// <summary>
    /// Returns a comma-separated list of selected player names.
    /// </summary>
    /// <returns>A string representing the selected player names.</returns>
    private string GetSelectedPlayersList()
    {
        return Session.SelectedPlayers.Aggregate(string.Empty, (current, player) => current + (player.PlayerName + ", ")).TrimEnd(' ').TrimEnd(',');
    }

    /// <summary>
    /// Saves all current changes to the selected profile.
    /// </summary>
    private void SaveChanges()
    {
        bool rc = false;
        var response = XtraMessageBox.Show("Are you sure you want to save all current changes?", "Confirmation",
            MessageBoxButtons.YesNo);
        if (response == DialogResult.No)
            return;
        
        int profileId = 0;
        if (Session.SelectedProfile != null || Session.DefaultProfile != null)
        {
            if (Session.SelectedProfile != null) profileId = Session.SelectedProfile.IdProfile;

            if (profileId < 0)
                profileId = Session.DefaultProfile.IdProfile;
        }
        else
        {
            XtraMessageBox.Show("You must select a profile.", "No Profile Selected", MessageBoxButtons.OK);
            return;
        }
        
        SplashScreenManager.ShowForm(this, typeof(SavingForm), true, true, false);
        try
        {
            // Save profile global settings
            var profile = _proMgrCtx.RaceProfiles.FirstOrDefault(c => c.IdRaceProfile == profileId);
            if (profile != null)
            {
                var s = txtGlobalMaxAmount.EditValue.ToString();
                decimal d,dd;
                decimal.TryParse(s, out d);
                profile.GlobalMaxAmount = d;
                s = txtPerRaceMax.EditValue.ToString();
                decimal.TryParse(s, out dd);
                profile.DefaultPerRaceMaxWin = dd;
                profile.HorseGlobalMax = Session.HorseGlobalMaxOn ? 1 : 0;
                profile.GlobalMaxTime = Session.HorseGlobalMaxDayOn ? 1 : 2;
                //profile.GlobalMaxTime = Session.HorseGlobalMaxWeekOn ? 2 : 1;
                
                DGSDataUtils.Data.DataExtensions.UpdateExistingProfile(profile, Session.ProMgrConnectionString);
            }
            else
            {
                XtraMessageBox.Show("You must select a profile.", "No Profile Selected", MessageBoxButtons.OK);
                return;
            }

            List<TracksViewModel> allTracks = new List<TracksViewModel>();
            List<TracksViewModel> selectedTracks = new List<TracksViewModel>();
            
            for (int i = 0; i < tracksView.RowCount; i++)
            {
                var vm = tracksView.GetRow(i) as TracksViewModel;
                allTracks.Add(vm);
            }

            if (allTracks.Count(c => c.IsTrackSelected) == 0)
            {
                selectedTracks.AddRange(allTracks);
            }
            else
            {
                selectedTracks.AddRange(allTracks.Where(c => c.IsTrackSelected));
            }

            var limitValues = (List<TrackLimitsView>)limitsGrid.DataSource;
            
            var rwc = DGSDataUtils.Data.DataExtensions.SaveTrackAndLimits(profile, selectedTracks, limitValues, Session.ProMgrConnectionString);
            if (rwc > -1)
                rc = true;
        }
        finally {
            //Close Wait Form
            SplashScreenManager.CloseForm(false);
            if (!rc)
            {
                XtraMessageBox.Show("Error saving profile track limits.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                XtraMessageBox.Show("Profile track limits saved successfully.", "Complete", MessageBoxButtons.OK);
                Session.IsModified = false;
            }
        }
    }

    /// <summary>
    /// Sets the UI colors for the different sections of the application.
    /// </summary>
    private void SetUIColors()
    {
        // Profile Section
        btnProfileAssign.Appearance.BackColor = Styles.PrimaryGreen;
        btnProfileAssign.Appearance.ForeColor = Styles.PrimaryWhite;
        btnDefaultProfileAssign.Appearance.BackColor = Styles.PrimaryGreen;
        btnDefaultProfileAssign.Appearance.ForeColor = Styles.PrimaryWhite;
        btnProfileNew.Appearance.BackColor = Styles.PrimaryGreen;
        btnProfileNew.Appearance.ForeColor = Styles.PrimaryWhite;
        btnDefaultProfileNew.Appearance.BackColor = Styles.PrimaryGreen;
        btnDefaultProfileNew.Appearance.ForeColor = Styles.PrimaryWhite;
        btnSave.Appearance.BackColor = Styles.PrimaryBlue;
        btnSave.Appearance.ForeColor = Styles.PrimaryWhite;
        
        // Player Section
        btnClearPlayers.Appearance.BackColor = Styles.PrimaryRed;
        btnClearPlayers.Appearance.ForeColor = Styles.PrimaryWhite;
        btnSelectAllPlayers.Appearance.BackColor = Styles.PrimaryBlue;
        btnSelectAllPlayers.Appearance.ForeColor = Styles.PrimaryWhite;
        
        // Track Section
        btnClearGeneralTracks.Appearance.BackColor = Styles.PrimaryRed;
        btnClearGeneralTracks.Appearance.ForeColor = Styles.PrimaryWhite;
        btnClearModifiedTracks.Appearance.BackColor = Styles.PrimaryRed;
        btnClearModifiedTracks.Appearance.ForeColor = Styles.PrimaryWhite;
        btnResetTracks.Appearance.BackColor = Styles.PrimaryGreen;
        btnResetTracks.Appearance.ForeColor = Styles.PrimaryWhite;
        
        // Limits Section
        lblHorseGlobalMaxToggle.Appearance.BackColor = Styles.PrimaryGold;
        lblHorseGlobalMaxToggle.Appearance.ForeColor = Styles.PrimaryWhite;
        lblHorseGlobalMaxToggle.AppearanceDisabled.BackColor = Styles.PrimaryWhite;
        lblHorseGlobalMaxToggle.AppearanceDisabled.ForeColor = Styles.PrimaryGray;
        
        lblDayLimit.Appearance.BackColor = Styles.PrimaryGreen;
        lblDayLimit.Appearance.ForeColor = Styles.PrimaryWhite;
        lblDayLimit.BackColor = Styles.PrimaryGreen;
        lblDayLimit.ForeColor = Styles.PrimaryWhite;
        lblDayLimit.AppearanceDisabled.BackColor = Styles.PrimaryGreen;
        lblDayLimit.AppearanceDisabled.ForeColor = Styles.PrimaryGray;
        
        lblWeekLimit.Appearance.BackColor = Styles.PrimaryGreen;
        lblWeekLimit.Appearance.ForeColor = Styles.PrimaryWhite;
        lblWeekLimit.BackColor = Styles.PrimaryGreen;
        lblWeekLimit.ForeColor = Styles.PrimaryWhite;
        lblWeekLimit.AppearanceDisabled.BackColor = Styles.PrimaryGreen;
        lblWeekLimit.AppearanceDisabled.ForeColor = Styles.PrimaryGray;
        
        btnTrackOdds.Appearance.BackColor = Styles.PrimaryBlue;
        btnTrackOdds.Appearance.ForeColor = Styles.PrimaryWhite;
        
        // Status Bar Section
        lblStatusHasChanges.BackColor = Styles.PrimaryWhite;
        lblStatusPlayerCount.BackColor = Styles.PrimaryWhite;
        lblStatusProfileCount.BackColor = Styles.PrimaryWhite;
        lblStatusActiveProfile.BackColor = Styles.PrimaryWhite;
        lblStatusHasChanges.ForeColor = Styles.PrimaryGreen;
        lblStatusActiveProfile.ForeColor = Styles.PrimaryGreen;
    }
}