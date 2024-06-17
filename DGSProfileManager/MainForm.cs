using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DGSDataUtils.Contexts;
using DGSProfileManager.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace DGSProfileManager
{
    public partial class MainForm : XtraForm
    {
        private string _selectedProfileItem = string.Empty;

        private DGSDbContext _dgsCtx;
        private ProMgrDbContext _proMgrCtx;

        public MainForm()
        {
            InitializeComponent();
            RefreshApplication();
        }

        /// <summary>
        /// Sets the core UI state of the MainForm.
        /// </summary>
        private void SetCoreUiState()
        {
            btnSave.Enabled = Session.IsModified;

            // Override if multiple profiles are highlighted (selected)
            if (Session.HighlightedProfiles.Count > 1)
            {
                EnableTrackAndLimitsUI(false);
            }

            if (Session.GeneralSelectedTracks.Count == 0 && Session.ModifiedSelectedTracks.Count == 0 && limitsGrid.Enabled)
                limitsGrid.Enabled = false;

            btnClearPlayers.Enabled = Session.SelectedPlayers.Count != 0;
        }

        /// <summary>
        /// Loads the agents from the database and binds the data to a control.
        /// </summary>
        private void LoadAgents()
        {
            _dgsCtx.Agents.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                var agents = _dgsCtx.Agents.Local.Where(x => x.Enable == true).Select(c => new { c.IdAgent, c.Agent1 })
                    .OrderBy(o => o.Agent1).ToList();
                agentLookupCtl.Properties.DataSource = agents;
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        /// <summary>
        /// Event handler for the OnAgentLookupFocusLeave event.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">An EventArgs object containing event data.</param>
        private void OnAgentLookupFocusLeave(object sender, EventArgs e)
        {
            if (Session.IsModified)
            {
                var result = XtraMessageBox.Show(
                    "You have unsaved changes that will be lost if you continue to a new selected agent.  Do you want to continue?",
                    "Unsaved Changes", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    agentLookupCtl.Focus();
                    agentLookupCtl.ShowPopup();
                    return;
                }
            }
            ShowAgentPlayers();
        }

        /// <summary>
        /// Event handler for the click event of the profileSearchImage button.
        /// Sets the focus to the txtSearchProfiles TextBox and selects all its text.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void profileSearchImage_Click(object sender, EventArgs e)
        {
            txtSearchProfiles.Focus();
            txtSearchProfiles.SelectAll();
        }

        // Main UI Timer to refresh elements based on user interaction
        /// <summary>
        /// Event handler for the main UI timer.
        /// Refreshes elements based on user interaction.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">An EventArgs object that contains the event data.</param>
        private void uiTimer_Tick(object sender, EventArgs e)
        {
            SetCoreUiState();
            UpdateStatusBar();
        }

        /// <summary>
        /// Shows the players associated with the selected agent.
        /// </summary>
        private void ShowAgentPlayers()
        {
            txtPlayer.Text = txtProfile.Text = string.Empty;
            try
            {
                SplashScreenManager.ShowForm(this, typeof(LoadingForm), false, false, false);
                try
                {
                    // Clear session players and profiles
                    Session.InitSession();
                    var agentId = (int)agentLookupCtl.GetColumnValue("IdAgent");
                    LoadPlayers(agentId);
                    AddAgentToSession(agentId);
                    UpdateDefaultProfileView();
                    profileView.Refresh();
                }
                finally
                {
                    //Close Loading Form
                    SplashScreenManager.CloseForm(false);
                }
            }
            catch (Exception)
            {
                // Do nothing
            }
        }

        /// <summary>
        /// Handles the Enter event of the agentLookupCtl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.</param>
        private void agentLookupCtl_Enter(object sender, EventArgs e)
        {
            agentLookupCtl.SelectAll();
        }

        /// <summary>
        /// Event handler for the agentLookupCtl click event.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void agentLookupCtl_Click(object sender, EventArgs e)
        {
            agentLookupCtl.SelectAll();
        }

        /// <summary>
        /// Event handler for the MainForm's FormClosing event.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">A FormClosingEventArgs object that contains the event data.</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Session.IsModified)
            {
                var result = XtraMessageBox.Show("You have unsaved changes that will be lost if you continue.  Do you want to close the application?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                var result = XtraMessageBox.Show("Are you sure you want to close the application?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Event handler for the Save button click event.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
            ShowAgentPlayers();
        }

        private void agentLookupCtl_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            txtSearchPlayers.Focus();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshApplication();
        }

        private void RefreshApplication()
        {
            Size = new Size(1160, 850);

            Session.InitAppSettings();
            Session.InitSession();

            _dgsCtx = new DGSDbContext(Session.DgsConnectionstring);
            _proMgrCtx = new ProMgrDbContext(Session.ProMgrConnectionString);
            _proMgrCtx.ChangeTracker.LazyLoadingEnabled = false;

            //Open Loading Form
            SplashScreenManager.ShowForm(this, typeof(InitAppForm), false, true, false);
            try
            {
                Session.SelectedPlayers = new Collection<PlayerItem>();
                Session.HighlightedProfiles = new Collection<ProfileItem>();
                Session.DefaultProfile = new ProfileItem();

                LoadAgents();
                LoadProfiles();
            }
            finally
            {
                //Close Loading Form
                SplashScreenManager.CloseForm(false);
            }

            Session.IsModified = false;
            btnSave.Enabled = false;
            ShowModifiedTracks(false);

            // Set Visual UI Initial State
            SetLimitsUiState();
            EnableTrackAndLimitsUI(false);
            RefreshTrackLimitsUI();
            uiTimer.Enabled = true;
            DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;
            lblStatusSpace.Text = String.Empty;
            Styles.SetDayWeekStyle(lblDayLimit, false);
            Styles.SetDayWeekStyle(lblWeekLimit, false);

            SetUIColors();
        }
    }
}
