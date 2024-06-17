using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid.Views.Layout.Events;
using DevExpress.XtraSplashScreen;
using DGSDataUtils.Data;
using DGSProfileManager.ViewModels;

namespace DGSProfileManager;

partial class MainForm
{
    /// <summary>
    /// Loads the players associated with the given agent ID.
    /// </summary>
    /// <param name="agentId">The ID of the agent.</param>
    private void LoadPlayers(int agentId)
    {
        var agentPlayers = _dgsCtx.Players.Where(a => a.IdAgent == agentId).Select(p => new { p.Player1, p.IdPlayer }).ToList();
        List<int> playerIdList = agentPlayers.Select(c => c.IdPlayer).ToList();
        var profileMaps = DataExtensions.GetPlayerMaps(playerIdList, Session.ProMgrConnectionString).ToList();

        try
        {
            var playerCards = agentPlayers
                .Join(profileMaps, p => p.IdPlayer, pm => pm.IdPlayer,
                    (p, pm) => new
                    {
                        PlayerId = p.IdPlayer,
                        PlayerName = p.Player1,
                        ProfileId = pm.IdRaceProfile
                    })
                .GroupJoin(_proMgrCtx.RaceProfiles, p => p.ProfileId, rp => rp.IdRaceProfile,
                    (p, rp) => new
                    {
                        ProfileId = p.ProfileId,
                        PlayerName = p.PlayerName,
                        PlayerId = p.PlayerId,
                        ProfileNames = rp.Select(r => r.ProfileName)
                    })
                .SelectMany(x => x.ProfileNames.DefaultIfEmpty(),
                    (x,y) => new
                {
                    PlayerId = x.PlayerId,
                    Player1 = x.PlayerName,
                    ProfileId = x.ProfileId,
                    ProfileName = y
                })
                .OrderBy(o => o.Player1).ToList();
            playerGrid.DataSource = playerCards;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        
        playerView.Appearance.SelectionFrame.Assign(playerView.PaintAppearance.Card);
    }

    /// <summary>
    /// Handles the CustomFieldValueStyle event for the playerView control.
    /// </summary>
    /// <param name="sender">The object that raises the event.</param>
    /// <param name="e">The event data.</param>
    private void playerView_CustomFieldValueStyle(object sender, LayoutViewFieldValueStyleEventArgs e)
    {
        var playerName = (string) playerView.GetRowCellValue(e.RowHandle, "Player1");
        var profileName = (string)playerView.GetRowCellValue(e.RowHandle, "ProfileName");
        
        if (Session.SelectedPlayers.Count(x => x.PlayerName == playerName.ToUpper()) > 0)
        {
            Styles.SetSimpleLabelStyle(e.Appearance, true);
        }
        else
        {
            Styles.SetSimpleLabelStyle(e.Appearance, false);
        }
    }

    /// <summary>
    /// Handles the event when a card in the player view is clicked.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">The event arguments containing information about the click event.</param>
    private void playerView_CardClick(object sender, CardClickEventArgs e)
    {
        if (e.Card.Items[0] is LayoutViewField player)
        {
            var playerName = (string) playerView.GetRowCellValue(e.RowHandle, player.Column);
            SelectPlayer(playerName);
        }
    }

    /// <summary>
    /// Event handler that is triggered when the value of the txtSearchPlayers textbox is changed.
    /// It applies a filter to the playerView based on the entered search text.
    /// </summary>
    /// <param name="sender">The object that triggered the event.</param>
    /// <param name="e">The EventArgs object that contains the event data.</param>
    private void txtSearchPlayers_EditValueChanged(object sender, EventArgs e)
    {
        if (playerView.ActiveFilterEnabled == false)
            playerView.ActiveFilterEnabled = true;

        var sFilter = $"Contains([Player1],'{txtSearchPlayers.Text}')";
        playerView.ActiveFilterString = sFilter;
    }

    /// <summary>
    /// Event handler for the button pressed event of txtSearchPlayers control.
    /// Clears the text of txtSearchPlayers control.
    /// </summary>
    /// <param name="sender">The object that triggered the event.</param>
    /// <param name="e">The event arguments for the button pressed event.</param>
    private void txtSearchPlayers_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
    {
        txtSearchPlayers.Text = String.Empty;
    }

    /// <summary>
    /// Handles the Enter event of the txtSearchPlayers control. Selects all the text in the txtSearchPlayers control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">An EventArgs that contains the event data.</param>
    private void txtSearchPlayers_Enter(object sender, EventArgs e)
    {
        txtSearchPlayers.SelectAll();
    }

    /// <summary>
    /// Handles the click event of the searchImage button.
    /// </summary>
    /// <param name="sender">The object that triggers the event.</param>
    /// <param name="e">The event data.</param>
    private void searchImage_Click(object sender, EventArgs e)
    {
        txtSearchPlayers.Focus();
        txtSearchPlayers.SelectAll();
    }

    /// <summary>
    /// Event handler for btnClearPlayers_Click event.
    /// Clears the list of selected players, highlighted profiles, and sets selected profile to a new instance of ProfileItem. Then updates the player text, profile text, and refreshes the player view and profile view.
    /// </summary>
    /// <param name="sender">The object that triggered the event.</param>
    /// <param name="e">The event arguments.</param>
    private void btnClearPlayers_Click(object sender, EventArgs e)
    {
        Session.SelectedPlayers.Clear();
        Session.HighlightedProfiles.Clear();
        Session.SelectedProfile = new ProfileItem();
        UpdatePlayerText();
        UpdateProfileText();
        playerView.Refresh();
        profileView.Refresh();
    }

    /// <summary>
    /// Event handler for the btnSelectAllPlayers click event.
    /// Clears the list of selected players and highlighted profiles,
    /// then populates them with the data from the playerView.
    /// Finally, updates the player and profile texts and refreshes
    /// the player and profile views.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">The EventArgs object that contains the event data.</param>
    private void btnSelectAllPlayers_Click(object sender, EventArgs e)
    {
        Session.SelectedPlayers.Clear();
        Session.HighlightedProfiles.Clear();
        var rowCount = playerView.DataRowCount;
        try
        {
            for (int i = 0; i < rowCount; i++)
            {
                var pi = new PlayerItem();
                var rowHandle = playerView.GetRowHandle(i);
                pi.PlayerName = playerView.GetRowCellValue(rowHandle, "Player1").ToString();
                pi.IdPlayer = (int) playerView.GetRowCellValue(rowHandle, "PlayerId");
                pi.IdProfile = (int)playerView.GetRowCellValue(rowHandle, "ProfileId");
                pi.IdAgent = Session.SelectedAgent.IdAgent;
                Session.SelectedPlayers.Add(pi);
                var profileName = playerView.GetRowCellValue(rowHandle, "ProfileName").ToString();
                Session.HighlightedProfiles.Add(new ProfileItem(pi.IdProfile, profileName, pi.IdPlayer));
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
        }
        
        Session.SelectedProfile = new ProfileItem();
        UpdatePlayerText();
        UpdateProfileText();
        playerView.Refresh();
        profileView.Refresh();
    }
    
    
    private void playerView_KeyPress(object sender, KeyPressEventArgs e)
    {
        if(e.KeyChar == 13)
        {
            var playerName = playerView.GetRowCellValue(playerView.FocusedRowHandle, "Player1").ToString();
            SelectPlayer(playerName);
        }
    }

    private void SelectPlayer(string playerName)
    {
        if (IsPlayerSelected(playerName))
        {
            RemovePlayerFromSession(playerName);
        }
        else
        {
            AddPlayerToSession(playerName);
        }
        // If no players are selected, then remove all of the highlighted profiles and leave just the default profile to the agent if it exists.
        if (Session.SelectedPlayers.Count == 0)
        {
            Session.HighlightedProfiles.Clear();
            Session.SelectedProfile = new ProfileItem();
        }

        SplashScreenManager.ShowForm(this, typeof(LoadingForm), true, true, false);
        try
        {
            UpdatePlayerText();
            UpdateProfileText();
            
            playerView.Refresh();
            profileView.Refresh();
            
            RefreshTrackLimitsUI();
        }
        finally
        {
            SplashScreenManager.CloseForm(false);
        }
    }
}