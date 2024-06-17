using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraGrid.Views.Tile.ViewInfo;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DGSDataUtils.Data.Models;

namespace DGSProfileManager;

/// <summary>
/// Represents the main form of the DGSProfileManager application.
/// </summary>
partial class MainForm
{
    /// <summary>
    /// Loads tracks for the specified profile ID.
    /// </summary>
    /// <param name="profileId">The ID of the profile.</param>
    private void LoadTracks(int profileId)
    {
        Session.GeneralSelectedTracks.Clear();
        Session.ModifiedSelectedTracks.Clear();
        // Load default tracks (unmodified by the user)
        var tracks = DGSDataUtils.Data.DataExtensions.GetTracks(profileId, Session.ProMgrConnectionString).Where(c => c.IsModified == false);
        tracksGrid.DataSource = tracks;
        tracksView.RefreshData();

        // Load modified tracks
        var modifiedTracks = DGSDataUtils.Data.DataExtensions.GetTracks(profileId, Session.ProMgrConnectionString).Where(c => c.IsModified);
        if (modifiedTracks.Any())
        {
            modifiedTracksGrid.DataSource = modifiedTracks;
            modifiedTracksView.RefreshData();
            ShowModifiedTracks();
        }
        else
        {
            ShowModifiedTracks(false);
        }
        chkGeneralSelectAll.CheckState = CheckState.Checked;
        SelectAllTracks(true);
        RefreshTrackLimitsUI();
    }

    /// <summary>
    /// Customizes the display text for a specific column in the Tracks view.
    /// </summary>
    /// <param name="sender">The object that triggered the event.</param>
    /// <param name="e">The event arguments containing information about the column and cell.</param>
    private void TracksViewCustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
    {
        if (e.Column.FieldName == "IsEnabled")
        {
            e.DisplayText = (bool)e.Value == true ? "Enabled" : "Disabled";
        }
    }

    /// <summary>
    /// Customizes the appearance of a TileViewItem in the Tracks View.
    /// </summary>
    /// <param name="sender">The event sender object.</param>
    /// <param name="e">The event arguments.</param>
    private void TracksViewItemCustomize(object sender, TileViewItemCustomizeEventArgs e)
    {
        if (e.Item == null || e.Item.Elements.Count == 0)
            return;

        bool isEnabled = (bool) tracksView.GetRowCellValue(e.RowHandle, tracksView.Columns["IsEnabled"]);
        var trackEnabledLabel = e.Item.GetElementByName("lblTrackEnabled");
        Styles.SetOnOffGridViewLabelAppearance(trackEnabledLabel, isEnabled);

        bool trackSelected = (bool) tracksView.GetRowCellValue(e.RowHandle, tracksView.Columns["IsTrackSelected"]);
        var trackNameLabel = e.Item.GetElementByName("lblTrackName");
        Styles.SetSimpleLabelStyle(trackNameLabel.Appearance.Normal, trackSelected);
    }

    /// <summary>
    /// Method for handling the click event of a tile item in the Tracks view.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">An instance of the TileViewItemClickEventArgs class that contains event data.</param>
    private void TracksViewItemClick(object sender, TileViewItemClickEventArgs e)
    {
        TileView view = sender as TileView;
        Point pt = view.GridControl.PointToClient(Control.MousePosition);
        TileViewHitInfo hitInfo = view.CalcHitInfo(pt);
        if (hitInfo.ItemInfo != null)
        {
            TileItemElementViewInfo elementInfo = hitInfo.ItemInfo.Elements.FirstOrDefault(t => t.EntireElementBounds.Contains(pt));
            if (elementInfo != null)
            {
                Session.IsModified = true;
                string itemValue = elementInfo.Element.Text;
                if (itemValue.ToLower() != "disabled" && itemValue.ToLower() != "enabled")
                {
                    // Track 'name' selected
                    bool isCurrentlySelected = (bool)tracksView.GetRowCellValue(e.Item.RowHandle, tracksView.Columns["IsTrackSelected"]);
                    int selectedTrackId = (int)tracksView.GetRowCellValue(e.Item.RowHandle, tracksView.Columns["IdTrack"]);
                    tracksView.SetRowCellValue(e.Item.RowHandle, tracksView.Columns["IsTrackSelected"], !isCurrentlySelected);
                    
                    if (!isCurrentlySelected)
                    {
                        Session.GeneralSelectedTracks.Add(selectedTrackId);
                    }
                    else
                    {
                        Session.GeneralSelectedTracks.Remove(selectedTrackId);
                    }
                    RefreshTrackLimitsUI();
                }
                else
                {
                    // Track enable/disable was selected
                    bool isEnabled = (bool)tracksView.GetRowCellValue(e.Item.RowHandle, tracksView.Columns["IsEnabled"]);
                    tracksView.SetRowCellValue(e.Item.RowHandle, tracksView.Columns["IsEnabled"], !isEnabled);
                }

                if (Session.GeneralSelectedTracks.Count < tracksView.RowCount)
                    chkGeneralSelectAll.CheckState = CheckState.Unchecked;
                else if (Session.GeneralSelectedTracks.Count == tracksView.RowCount)
                    chkGeneralSelectAll.CheckState = CheckState.Checked;
                
                btnClearGeneralTracks.Enabled = Session.GeneralSelectedTracks.Count > 0;
            }
        }
    }

    /// <summary>
    /// Event handler for when the search track button is pressed.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">The button pressed event arguments.</param>
    private void txtSearchTrack_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
    {
        tracksView.ActiveFilterEnabled = false;
        txtSearchTrack.Text = String.Empty;
    }

    /// <summary>
    /// Event handler called when the value of the txtSearchTrack control is changed.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">The event arguments.</param>
    private void txtSearchTrack_EditValueChanged(object sender, EventArgs e)
    {
        if (tracksView.ActiveFilterEnabled == false)
            tracksView.ActiveFilterEnabled = true;

        var sFilter = $"StartsWith([TrackName],'{txtSearchTrack.Text}')";
        tracksView.ActiveFilterString = sFilter;
    }

    /// <summary>
    /// Handler for the MouseClick event of the chkGeneralSelectAll CheckBox.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">An instance of the MouseEventArgs class containing event data.</param>
    /// <remarks>
    /// This method is called when the user clicks the chkGeneralSelectAll CheckBox.
    /// If the state of chkGeneralSelectAll is Checked, it unchecks chkModifiedSelectAll,
    /// calls the SelectAllModifiedTracks method with the parameter false, and calls the
    /// SelectAllTracks method with the parameter true. Otherwise, it calls the SelectAllTracks
    /// method with the parameter false. After performing the necessary operations, it calls
    /// the RefreshTrackLimitsUI method.
    /// </remarks>
    private void chkGeneralSelectAll_MouseClick(object sender, MouseEventArgs e)
    {
        if (chkGeneralSelectAll.CheckState == CheckState.Checked)
        {
            chkModifiedSelectAll.CheckState = CheckState.Unchecked;
            SelectAllModifiedTracks(false);
            SelectAllTracks(true);
        }
        else
        {
            SelectAllTracks(false);
        }
        RefreshTrackLimitsUI();
    }
    
    // Modifed Tracks
    /// <summary>
    /// Event handler for the MouseClick event on the "chkModifiedSelectAll" check box.
    /// Updates the state of the tracks based on the state of the "chkModifiedSelectAll" check box.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">A MouseEventArgs object that contains event data.</param>
    private void chkModifiedSelectAll_MouseClick(object sender, MouseEventArgs e)
    {
        if (chkModifiedSelectAll.CheckState == CheckState.Checked)
        {
            chkGeneralSelectAll.CheckState = CheckState.Unchecked;
            SelectAllTracks(false);
            SelectAllModifiedTracks(true);
        }
        else
        {
            SelectAllModifiedTracks(false);
        }
        RefreshTrackLimitsUI();
    }

    /// <summary>
    /// Custom event handler for the ModifiedTracksView's CustomColumnDisplayText event.
    /// Modifies the display text of the IsEnabled column based on the value of the cell.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">The event arguments containing the event data.</param>
    private void modifiedTracksView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
    {
        if (e.Column.FieldName == "IsEnabled")
        {
            e.DisplayText = (bool)e.Value == true ? "Enabled" : "Disabled";
        }
    }

    /// <summary>
    /// Customizes the appearance of an item in the modifiedTracksView.
    /// </summary>
    /// <param name="sender">The object that triggered the event.</param>
    /// <param name="e">The event arguments containing information about the item.</param>
    private void modifiedTracksView_ItemCustomize(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs e)
    {
        if (e.Item == null || e.Item.Elements.Count == 0)
            return;

        bool isEnabled = (bool) modifiedTracksView.GetRowCellValue(e.RowHandle, modifiedTracksView.Columns["IsEnabled"]);
        var trackEnabledLabel = e.Item.GetElementByName("lblTrackEnabled");
        Styles.SetOnOffGridViewLabelAppearance(trackEnabledLabel, isEnabled);

        bool trackSelected = (bool) modifiedTracksView.GetRowCellValue(e.RowHandle, modifiedTracksView.Columns["IsTrackSelected"]);
        var trackNameLabel = e.Item.GetElementByName("lblTrackName");
        Styles.SetSimpleLabelStyle(trackNameLabel.Appearance.Normal, trackSelected);
    }

    /// <summary>
    /// Handles the item click event for the modifiedTracksView.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">An object that contains event data.</param>
    private void modifiedTracksView_ItemClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
    {
        TileView view = sender as TileView;
        Point pt = view.GridControl.PointToClient(Control.MousePosition);
        TileViewHitInfo hitInfo = view.CalcHitInfo(pt);
        if (hitInfo.ItemInfo != null)
        {
            TileItemElementViewInfo elementInfo = hitInfo.ItemInfo.Elements.FirstOrDefault(t => t.EntireElementBounds.Contains(pt));
            if (elementInfo != null)
            {
                Session.IsModified = true;
                string itemValue = elementInfo.Element.Text;
                if (itemValue.ToLower() != "disabled" && itemValue.ToLower() != "enabled")
                {
                    // Track 'name' selected
                    bool isCurrentlySelected = (bool)modifiedTracksView.GetRowCellValue(e.Item.RowHandle, modifiedTracksView.Columns["IsTrackSelected"]);
                    int selectedTrackId = (int)modifiedTracksView.GetRowCellValue(e.Item.RowHandle, modifiedTracksView.Columns["IdTrack"]);
                    modifiedTracksView.SetRowCellValue(e.Item.RowHandle, modifiedTracksView.Columns["IsTrackSelected"], !isCurrentlySelected);
                    
                    if (!isCurrentlySelected)
                    {
                        Session.ModifiedSelectedTracks.Add(selectedTrackId);
                    }
                    else
                    {
                        Session.ModifiedSelectedTracks.Remove(selectedTrackId);
                    }
                    RefreshTrackLimitsUI();
                }
                else
                {
                    // Track enable/disable was selected
                    bool isEnabled = (bool)modifiedTracksView.GetRowCellValue(e.Item.RowHandle, modifiedTracksView.Columns["IsEnabled"]);
                    modifiedTracksView.SetRowCellValue(e.Item.RowHandle, modifiedTracksView.Columns["IsEnabled"], !isEnabled);
                }
                
                if (Session.ModifiedSelectedTracks.Count < modifiedTracksView.RowCount)
                    chkModifiedSelectAll.CheckState = CheckState.Unchecked;
                else if (Session.ModifiedSelectedTracks.Count == modifiedTracksView.RowCount)
                    chkModifiedSelectAll.CheckState = CheckState.Checked;
                
                btnResetTracks.Enabled = Session.ModifiedSelectedTracks.Count > 0;
                btnClearModifiedTracks.Enabled = btnResetTracks.Enabled;
            }
        }
    }

    /// <summary>
    /// Event handler for the button click event to reset selected tracks back to the GENERAL limits.
    /// </summary>
    /// <param name="sender">The object that triggered the event.</param>
    /// <param name="e">The event arguments.</param>
    private void btnResetTracks_Click(object sender, EventArgs e)
    {
        int profileId = 0;
        if (Session.ModifiedSelectedTracks.Count == 0)
        {
            XtraMessageBox.Show("You do not have any modified tracks selected.  Please select at least 1 track and try again.", "No Selected Tracks", MessageBoxButtons.OK);
            return;
        }

        var result = XtraMessageBox.Show("Are you sure you want to reset the selected tracks back to the GENERAL limits?",
            "Confirmation", MessageBoxButtons.YesNo);
        if (result == DialogResult.No)
            return;
        
        foreach (var dstTrackId in Session.ModifiedSelectedTracks)
        {
            var srcTrackId = (int)tracksView.GetRowCellValue(0, "IdTrack");
            profileId = Session.SelectedProfile.IdProfile;
            var rv = DGSDataUtils.Data.DataExtensions.CopyTrackLimits(profileId, srcTrackId, dstTrackId, Session.ProMgrConnectionString);
        }
        Session.ModifiedSelectedTracks.Clear();
        LoadTracks(profileId);
    }

    /// <summary>
    /// Shows or hides the modified tracks section in the main form.
    /// </summary>
    /// <param name="show">True to show the modified tracks section, False to hide it.</param>
    private void ShowModifiedTracks(bool show = true)
    {
        if (show)
        {
            // Location
            modifiedTracksGrid.Location = new Point(0, 46);
            tracksGrid.Location = new Point(Styles.GeneralLimitsSplitHorizonalStart, 46);
            txtModifiedSearchTrack.Location = new Point(50, 6);
            // Size
            modifiedTracksGrid.Size = new Size(Styles.ModifiedGridWidth, Styles.TrackGridHeight);
            tracksGrid.Size = new Size(Styles.TrackGridSharedWidth, Styles.TrackGridHeight);
            tracksView.OptionsTiles.ColumnCount = 2;
            // Panel Buttons
            lblModifiedLimits.Location = new Point(Styles.LabelXLocation, Styles.LabelYLocation);
            lblModifiedTrack.Location = new  Point(Styles.LabelXLocation, 6);
            lblModifiedLimits.Visible = true;
            btnClearModifiedTracks.Visible = true;
            btnResetTracks.Visible = true;
            chkModifiedSelectAll.Visible = true;
            chkModifiedSelectAll.Location = new Point(170, Styles.LabelYLocation);
            chkGeneralSelectAll.Location = new Point(480, Styles.LabelYLocation);
            btnClearGeneralTracks.Location = new Point(400, Styles.LabelYLocation);
            txtModifiedSearchTrack.Visible = true;
            
            txtSearchTrack.Location = new Point(Styles.GeneralLimitsSplitHorizonalStart, 6);
            lblGeneralLimits.Location = new Point(Styles.GeneralLimitsSplitHorizonalStart, Styles.LabelYLocation);
        }
        else
        {
            // Location
            modifiedTracksGrid.Location = new Point(0, 0);
            tracksGrid.Location = new Point(0, 46);
            // Size
            modifiedTracksGrid.Size = new Size(0, 0);
            tracksGrid.Size = new Size(Styles.TrackGridFullWidth, Styles.TrackGridHeight);
            tracksView.OptionsTiles.ColumnCount = 3;
            // Panel Buttons
            lblModifiedLimits.Visible = false;
            btnClearModifiedTracks.Visible = false;
            btnResetTracks.Visible = false;
            chkModifiedSelectAll.Visible = false;
            lblGeneralLimits.Location = new Point(Styles.LabelXLocation, Styles.LabelYLocation);
            chkGeneralSelectAll.Location = new Point(170, Styles.LabelYLocation);
            btnClearGeneralTracks.Location = new Point(85, Styles.LabelYLocation);
            txtModifiedSearchTrack.Visible = false;
            txtSearchTrack.Location = new Point(45, 6);
        }
    }

    /// <summary>
    /// Handles the paint event for the tracksPanel.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">The PaintEventArgs containing the event data.</param>
    private void tracksPanel_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
    {
        // Line Separator
        // Draw a vertical line between the modifiedTracksGrid and the tracksGrid
        Pen pen = new Pen(Color.DarkSlateGray);
        e.Graphics.DrawLine(pen, 240, 16, 240, 385);
    }

    /// <summary>
    /// Event handler for the TextChanged event of the TxtModifiedSearchTrack Edit control.
    /// Filters the modifiedTracksView based on the value entered in the TxtModifiedSearchTrack Edit control.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">The event data.</param>
    private void TxtModifiedSearchTrackEditValueChanged(object sender, EventArgs e)
    {
        if (modifiedTracksView.ActiveFilterEnabled == false)
            modifiedTracksView.ActiveFilterEnabled = true;

        var sFilter = $"StartsWith([TrackName],'{txtModifiedSearchTrack.Text}')";
        modifiedTracksView.ActiveFilterString = sFilter;
    }

    /// <summary>
    /// Handles the button press event when the modified search track button is pressed.
    /// </summary>
    /// <param name="sender">The object that raises the event.</param>
    /// <param name="e">The event arguments.</param>
    private void TxtModifiedSearchTrackButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
    {
        modifiedTracksView.ActiveFilterEnabled = false;
        txtModifiedSearchTrack.Text = String.Empty;
    }

    /// <summary>
    /// Selects or deselects all tracks.
    /// </summary>
    /// <param name="isOn">True if all tracks should be selected, false if all tracks should be deselected.</param>
    private void SelectAllTracks(bool isOn)
    {
        Session.GeneralSelectedTracks.Clear();
        for (int i = 0; i < tracksView.RowCount; i++)
        {
            var vm = tracksView.GetRow(i) as TracksViewModel;
            tracksView.SetRowCellValue(i, tracksView.Columns["IsTrackSelected"], isOn);
            if (isOn)
                Session.GeneralSelectedTracks.Add(vm.IdTrack);
        }
        modifiedTracksGrid.Enabled = Session.GeneralSelectedTracks.Count <= 0;
        btnResetTracks.Enabled = Session.ModifiedSelectedTracks.Count > 0;
        btnClearModifiedTracks.Enabled = btnResetTracks.Enabled;
    }

    /// <summary>
    /// Selects all modified tracks.
    /// </summary>
    /// <param name="isOn">Indicates whether the tracks should be selected or deselected.</param>
    private void SelectAllModifiedTracks(bool isOn)
    {
        Session.ModifiedSelectedTracks.Clear();
        for (int i = 0; i < modifiedTracksView.RowCount; i++)
        {
            var vm = modifiedTracksView.GetRow(i) as TracksViewModel;
            modifiedTracksView.SetRowCellValue(i, modifiedTracksView.Columns["IsTrackSelected"], isOn);
            if (isOn)
                Session.ModifiedSelectedTracks.Add(vm.IdTrack);
        }
        tracksGrid.Enabled = Session.ModifiedSelectedTracks.Count <= 0;
        btnResetTracks.Enabled = Session.ModifiedSelectedTracks.Count > 0;
        btnClearModifiedTracks.Enabled = btnResetTracks.Enabled;
    }

    /// <summary>
    /// Clears the selection of modified tracks and unchecks the "Select All" checkbox.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> object that contains the event data.</param>
    private void btnClearModifiedTracks_Click(object sender, EventArgs e)
    {
        SelectAllModifiedTracks(false);
        chkModifiedSelectAll.CheckState = CheckState.Unchecked;
    }

    /// <summary>
    /// Event handler for the click event of the 'btnClearGeneralTracks' button.
    /// Clears the selection of all general tracks and unchecks the 'chkGeneralSelectAll' checkbox.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">The event arguments.</param>
    private void btnClearGeneralTracks_Click(object sender, EventArgs e)
    {
        SelectAllTracks(false);
        chkGeneralSelectAll.CheckState = CheckState.Unchecked;
    }
}