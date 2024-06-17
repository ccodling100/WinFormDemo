using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DGSDataUtils.Data.Models;
using DevExpress.XtraEditors.Mask;

namespace DGSProfileManager;

partial class MainForm
{
    /// <summary>
    /// Loads the track limits for a given profile and list of track IDs.
    /// </summary>
    /// <param name="profileId">The ID of the profile.</param>
    /// <param name="trackIdList">The list of track IDs.</param>
    private void LoadTrackLimits(int profileId, List<int> trackIdList)
    {
        var trackLimits = DGSDataUtils.Data.DataExtensions.GetTrackLimits(profileId, trackIdList, Session.ProMgrConnectionString);
        limitsGrid.DataSource = trackLimits;
        limitsView.RefreshData();

        var profile = _proMgrCtx.RaceProfiles.FirstOrDefault(c => c.IdRaceProfile == profileId);
        if (profile != null)
        {
            Session.HorseGlobalMaxOn = profile.HorseGlobalMax != 0;
            Session.HorseGlobalMaxDayOn = profile.GlobalMaxTime == 1;
            Session.HorseGlobalMaxWeekOn = profile.GlobalMaxTime == 2;
            txtGlobalMaxAmount.Text =$"{profile.GlobalMaxAmount}";
        }

        var perRaceMaxWin = trackLimits.Max(c => c.PerRaceMaxWin);
        txtPerRaceMax.Text = $"{perRaceMaxWin}";
        txtPerRaceMax.Properties.Mask.EditMask = "c0";
        txtPerRaceMax.Properties.Mask.MaskType = MaskType.Numeric;
        txtPerRaceMax.Properties.UseMaskAsDisplayFormat = true;
        txtPerRaceMax.Properties.DisplayFormat.FormatString = "c0";

        txtGlobalMaxAmount.Properties.Mask.EditMask = "c0";
        txtGlobalMaxAmount.Properties.Mask.MaskType = MaskType.Numeric;
        txtGlobalMaxAmount.Properties.UseMaskAsDisplayFormat = true;
        txtGlobalMaxAmount.Properties.DisplayFormat.FormatString = "c0";
        
        SetLimitsUiState();
    }

    /// <summary>
    /// Sets the UI state for the limits in the MainForm.
    /// </summary>
    private void SetLimitsUiState()
    {
        // lblDayLimit.Enabled = Session.HorseGlobalMaxOn;
        // lblWeekLimit.Enabled = Session.HorseGlobalMaxOn;
        
        Styles.SetGlobalMaxStyle(lblHorseGlobalMaxToggle, Session.HorseGlobalMaxOn);
        Styles.SetDayWeekStyle(lblDayLimit, Session.HorseGlobalMaxDayOn);
        Styles.SetDayWeekStyle(lblWeekLimit, Session.HorseGlobalMaxWeekOn);
        
        // Enable/disable associated buttons
        if (Session.HorseGlobalMaxOn)
        {
            lblHorseGlobalMaxToggle.Text = "On";
            if (Session.HorseGlobalMaxDayOn || Session.HorseGlobalMaxWeekOn)
                txtGlobalMaxAmount.Enabled = true;
        }
        else
        {
            lblHorseGlobalMaxToggle.Text = "Off";
            txtGlobalMaxAmount.Enabled = false; 
        }
    }

    /// <summary>
    /// Custom draw cell event handler for the limitsView GridView.
    /// </summary>
    /// <param name="sender">The object that triggered the event.</param>
    /// <param name="e">An object containing event data.</param>
    private void limitsView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
    {
        GridView view = sender as GridView;
        TrackLimitsView trackLimit = limitsView.GetRow(e.RowHandle) as TrackLimitsView;
        bool bOn = false;

        if (trackLimit == null) return;
        bOn = trackLimit.Status;
        
        if (e.Column.FieldName == "Status")
        {
            e.Appearance.ForeColor = bOn ? Styles.PrimaryWhite : Styles.PrimaryGray;
            var fillColor = bOn ? Styles.PrimaryGold : Styles.PrimaryWhite;
            var rect = e.Bounds;
            rect.Inflate(-2, -2);

            if (bOn)
            {
                e.DisplayText = "On";
                e.Graphics.FillRectangle(e.Cache.GetSolidBrush(fillColor), rect);
            }
            else
            {
                e.DisplayText = "Off";
                e.Graphics.FillRectangle(e.Cache.GetSolidBrush(fillColor), rect);
                e.Graphics.DrawRectangle(e.Cache.GetPen(Color.Gray, 1), rect);
            }

            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
           e.Appearance.DrawString(e.Cache, e.DisplayText, rect, sf);

            e.Handled = true;
        }

        if (trackLimit.Category != "Default")
        {
            if (e.Column.FieldName != "Status" && e.Column.FieldName != "Category")
            {
                Color textColor = Color.Black;
        
                if (!bOn)
                    textColor = Color.LightGray;
        
                e.Appearance.ForeColor = textColor;
            }
        }
        else
        {
            if (e.Column.FieldName != "Category" && e.Column.FieldName != "Status")
            {
                e.Appearance.ForeColor = Styles.PrimaryBlack;
                var rect = e.Bounds;
                rect.Inflate(-2, -2);
                e.Graphics.DrawRectangle(e.Cache.GetPen(Styles.PrimaryGold, 1), rect);

                var s = e.DisplayText;
                var v = (decimal) e.CellValue;
                if (v < 0)
                    s = "";
                StringFormat sf = new StringFormat();
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Center;
                e.Appearance.DrawString(e.Cache, s, rect, sf);
                
                e.Handled = true;
            }
        }
    }

    /// <summary>
    /// Handles the CustomRowCellEdit event of the limitsView control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The CustomRowCellEditEventArgs instance containing the event data.</param>
    private void limitsView_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
    {
        //limitsDefaultTextEdit
        GridView view = sender as GridView;
        if (e.Column == view.FocusedColumn && e.RowHandle == view.FocusedRowHandle && view.IsEditing)
            e.RepositoryItem = limitsDefaultTextEdit;
    }

    /// <summary>
    /// Custom event handler for the "limitsView_CustomRowCellEditForEditing" event.
    /// Sets the repository item for editing a specific cell in the limitsView grid.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">A CustomRowCellEditEventArgs object that contains event data.</param>
    private void limitsView_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
    {
        e.RepositoryItem = limitsDefaultTextEdit;
        GridView view = sender as GridView;
        BeginInvoke(new MethodInvoker(() =>
        {
            view.RefreshRowCell(view.FocusedRowHandle, view.FocusedColumn);
        }));
    }

    /// <summary>
    /// Custom draw event handler for the column headers in the limitsView.
    /// </summary>
    /// <param name="sender">The object that triggers the event.</param>
    /// <param name="e">The event arguments containing information about the custom drawing.</param>
    private void limitsView_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
    {
        e.Appearance.BackColor = Color.White;
        e.Appearance.ForeColor = Color.Black;

        StringFormat sf = new StringFormat();
        sf.LineAlignment = StringAlignment.Center;

        if (e.Info.Column != null)
        {
            if (e.Info.Column.Name == "colCategory")
            {
                sf.Alignment = StringAlignment.Near;
            }
            else
            {
                sf.Alignment = StringAlignment.Center;
            }
        }

        e.Appearance.DrawString(e.Cache, e.Info.Caption, e.Info.CaptionRect, sf);
        e.Handled = true;
    }

    /// <summary>
    /// Event handler for the ShowingEditor event of the limitsView element.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">A CancelEventArgs object that contains the event data.</param>
    private void limitsView_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
    {
        TrackLimitsView trackLimitRow = limitsView.GetRow((sender as GridView).FocusedRowHandle) as TrackLimitsView;
        
        if (trackLimitRow != null)
        {
            if (!trackLimitRow.Status && trackLimitRow.Category != "Default")
                e.Cancel = true;
            if (trackLimitRow.Max < trackLimitRow.Min && trackLimitRow.Status == true)
            {
                //XtraMessageBox.Show("Max value can not be less than min value!", "Error", MessageBoxButtons.OK);
                // Creates and initializes an object with message box settings.
                XtraMessageBoxArgs args = new XtraMessageBoxArgs() {
                    Caption = "Warning",
                    Text = "Max value can not be less than min value!",
                    Buttons = new DialogResult[] { DialogResult.OK },
                    AutoCloseOptions = new AutoCloseOptions() {
                        Delay = 3000,
                        ShowTimerOnDefaultButton = true
                    }
                };
                XtraMessageBox.Show(args);
                    e.Cancel = true;
                trackLimitRow.Max = trackLimitRow.Min;
                e.Cancel = false;
            }
        }        
    }

    /// <summary>
    /// Event handler for the ShownEditor event of the limitsView control.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">An EventArgs object that contains the event data.</param>
    private void limitsView_ShownEditor(object sender, EventArgs e)
    {
        ColumnView view = (ColumnView)sender;
        var fieldName = view.FocusedColumn.FieldName;

        if (limitsView.ActiveEditor != null)
        {
            limitsView.ActiveEditor.SelectAll();
            limitsView.ActiveEditor.Text = "";
        }
    }

    /// <summary>
    /// Event handler for the CellValueChanged event of the limitsView grid view.
    /// </summary>
    /// <param name="sender">The object that triggered the event.</param>
    /// <param name="e">The CellValueChangedEventArgs containing the event data.</param>
    private void limitsView_CellValueChanged(object sender, CellValueChangedEventArgs e)
    {
        TrackLimitsView trackLimit = limitsView.GetRow(e.RowHandle) as TrackLimitsView;
        if (trackLimit == null)
            return;

        Session.IsModified = true;
        if (e.Column.FieldName == "Category" || e.Column.FieldName == "Status")
        {
            return;
        }

        var oldValue = (decimal) e.OldValue;
        var newValue = (decimal)e.Value;
        
        // are we on a row, other than the 'default' row?
        if (trackLimit.Category != "Default")
        {
            if (e.Column.FieldName != "Category" && e.Column.FieldName != "Status")
            {
                if ((int) newValue < 0 )
                {
                    switch (e.Column.FieldName)
                    {
                        case "Min":
                            trackLimit.Min = oldValue;
                            break;
                        case "Max":
                            trackLimit.Max = oldValue;
                            break;
                        case "Payout":
                            trackLimit.Payout = oldValue;
                            break;
                        case "Odds":
                            trackLimit.Odds = oldValue;
                            break;
                    }
                    trackLimit.Min = oldValue;
                }
            }
        }
        else
        {
            // update all values in this column
            if (e.Column.FieldName != "Category" && e.Column.FieldName != "Status")
            {
                // Did we change a default value?
                if ((int)newValue <= 0)
                    return;
                
                SetTrackColumnDefault(e.Column, newValue);
            }
        }
    }

    /// <summary>
    /// Handles the click event of a cell in the limitsView grid.
    /// </summary>
    /// <param name="sender">The object that triggered the event.</param>
    /// <param name="e">An object that contains data related to the click event.</param>
    private void limitsView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
    {
        Session.IsModified = true;
        if (e.Column.Name == "colStatus")
        {
            TrackLimitsView trackLimit = limitsView.GetRow(e.RowHandle) as TrackLimitsView;
            if (trackLimit.Category == "Default")
                DefaultStatusCellClicked(sender, e);
            else
                StatusCellClicked(sender, e);
        }
    }

    /// <summary>
    /// Method called when the lblHorseGlobalMaxToggle is clicked.
    /// It toggles the value of Session.HorseGlobalMaxOn and updates the UI state accordingly.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">The event arguments.</param>
    private void lblHorseGlobalMaxToggle_Click(object sender, EventArgs e)
    {
        Session.IsModified = true;
        Session.HorseGlobalMaxOn = !Session.HorseGlobalMaxOn;
        SetLimitsUiState();
    }

    /// <summary>
    /// Event handler for the btnTrackOdds Click event.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">The event arguments.</param>
    private void btnTrackOdds_Click(object sender, EventArgs e)
    {
        Session.IsModified = true;
        var response = XtraMessageBox.Show("Are you sure you want to set all the bet types to unlimited?", "Confirmation", MessageBoxButtons.YesNo);
        if (response == DialogResult.Yes)
        {
            SetTrackOddsToOn();
        }
    }

    /// <summary>
    /// Event handler for the click event of the lblDayLimit label control.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">An EventArgs object that contains event data.</param>
    private void lblDayLimit_Click(object sender, EventArgs e)
    {
        if (!Session.HorseGlobalMaxOn)
            return;
        Session.IsModified = true;
        Session.HorseGlobalMaxDayOn = true;
        Session.HorseGlobalMaxWeekOn = false;
        SetLimitsUiState();
    }

    /// <summary>
    /// Event handler for the click event of lblWeekLimit.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">The event arguments.</param>
    private void lblWeekLimit_Click(object sender, EventArgs e)
    {
        if (!Session.HorseGlobalMaxOn)
            return;
        Session.IsModified = true;
        Session.HorseGlobalMaxWeekOn = true;
        Session.HorseGlobalMaxDayOn = false;
        SetLimitsUiState();
    }

    /// <summary>
    /// Event handler for when the status cell is clicked in the limitsView grid.
    /// </summary>
    /// <param name="sender">The object that triggered the event.</param>
    /// <param name="e">The event arguments containing information about the clicked cell.</param>
    private void StatusCellClicked(object sender, RowCellClickEventArgs e)
    {
        bool bStatus = (bool) e.CellValue;
        bStatus = !bStatus;
        limitsView.SetRowCellValue(e.RowHandle, e.Column, bStatus);
    }

    /// <summary>
    /// Handles the click event of the status cell in the limitsView grid.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">The event data.</param>
    private void DefaultStatusCellClicked(object sender, RowCellClickEventArgs e)
    {
        Session.IsModified = true;
        bool bStatus = (bool) e.CellValue;
        bStatus = !bStatus;
        
        var rowCount = limitsView.DataRowCount;
        for (int i = 0; i < rowCount; i++)
        {
            var row = limitsView.GetRowHandle(i);
            limitsView.SetRowCellValue(row, e.Column, bStatus);
        }
    }

    /// <summary>
    /// Sets the track odds to ON for all bet types.
    /// </summary>
    /// <remarks>
    /// This method is triggered when the user clicks the "Track Odds" button in the MainForm.
    /// It sets the track odds to ON for all bet types and sets the minimum, maximum, payouts, and odds to unlimited or 0.
    /// </remarks>
    private void SetTrackOddsToOn()
    {
        var limits = (List<TrackLimitsView>)limitsGrid.DataSource;
        Session.IsModified = true;
        foreach (TrackLimitsView limit in limits)
        {
            // All status are ON.
            limit.Status = true;
            // Min, Max, Payouts & Odds go to "unlimited" or 0.
            limit.Min = limit.Max = limit.Payout = limit.Odds = 0;
        }

        limitsView.RefreshData();
    }

    /// <summary>
    /// Sets the default value of a specific column in the track limits view.
    /// </summary>
    /// <param name="column">The grid column to set the default value for.</param>
    /// <param name="value">The default value to set for the column.</param>
    private void SetTrackColumnDefault(GridColumn column, decimal value)
    {
        var limits = (List<TrackLimitsView>)limitsGrid.DataSource;
        foreach (TrackLimitsView limit in limits)
        {
            // Min, Max, Payouts & Odds go to "unlimited" or 0.
            switch (column.FieldName)
            {
                case "Min":
                    limit.Min = value;
                    break;
                case "Max":
                    limit.Max = value;
                    break;
                case "Payout":
                    limit.Payout = value;
                    break;
                case "Odds":
                    limit.Odds = value;
                    break;
            }
        }

        limitsView.RefreshData();
    }

    /// <summary>
    /// Event handler for the Click event of the txtPerRaceMax TextBox control.
    /// Selects all text in the txtPerRaceMax TextBox.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">An EventArgs that contains the event data.</param>
    private void txtPerRaceMax_Click(object sender, EventArgs e)
    {
        txtPerRaceMax.SelectAll();
    }

    /// <summary>
    /// Event handler for clicking on the txtGlobalMaxAmount control.
    /// Selects all the text within the control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">An EventArgs object that contains the event data.</param>
    private void txtGlobalMaxAmount_Click(object sender, EventArgs e)
    {
        txtGlobalMaxAmount.SelectAll();
    }
}