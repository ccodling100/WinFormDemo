using DevExpress.XtraGrid.Views.Tile;
using System.Drawing;

namespace DGSProfileManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            TileViewItemElement tileViewItemElement1 = new TileViewItemElement();
            TileViewItemElement tileViewItemElement2 = new TileViewItemElement();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition3 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition4 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            TileViewItemElement tileViewItemElement3 = new TileViewItemElement();
            TileViewItemElement tileViewItemElement4 = new TileViewItemElement();
            colModifiedTrackName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            colModifiedIsEnabled = new DevExpress.XtraGrid.Columns.TileViewColumn();
            modifiedTrackRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            colTrackName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            colIsEnabled = new DevExpress.XtraGrid.Columns.TileViewColumn();
            trackRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            menuPanel = new DevExpress.XtraEditors.PanelControl();
            btnRefresh = new DevExpress.XtraEditors.SvgImageBox();
            btnSelectAllPlayers = new DevExpress.XtraEditors.SimpleButton();
            btnClearPlayers = new DevExpress.XtraEditors.SimpleButton();
            txtSearchProfiles = new DevExpress.XtraEditors.ButtonEdit();
            txtSearchPlayers = new DevExpress.XtraEditors.ButtonEdit();
            profileSearchImage = new DevExpress.XtraEditors.SvgImageBox();
            playerSearchImage = new DevExpress.XtraEditors.SvgImageBox();
            txtPlayer = new DevExpress.XtraEditors.TextEdit();
            txtProfile = new DevExpress.XtraEditors.TextEdit();
            agentLookupCtl = new DevExpress.XtraEditors.LookUpEdit();
            agentBindingSource = new System.Windows.Forms.BindingSource(components);
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            btnProfileNew = new DevExpress.XtraEditors.SimpleButton();
            btnDefaultProfileNew = new DevExpress.XtraEditors.SimpleButton();
            btnProfileAssign = new DevExpress.XtraEditors.SimpleButton();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            txtDefaultProfile = new DevExpress.XtraEditors.TextEdit();
            lblPlayer = new DevExpress.XtraEditors.LabelControl();
            btnDefaultProfileAssign = new DevExpress.XtraEditors.SimpleButton();
            lblAgent = new DevExpress.XtraEditors.LabelControl();
            searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            profilesPanel = new DevExpress.XtraEditors.PanelControl();
            profileGrid = new DevExpress.XtraGrid.GridControl();
            profileView = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            colProfileName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            layoutViewField_colProfileName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            colIdRaceProfile = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            layoutViewField_colIdRaceProfile = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            profileCardView = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            raceProfilesBindingSource = new System.Windows.Forms.BindingSource(components);
            playersPanel = new DevExpress.XtraEditors.PanelControl();
            playerGrid = new DevExpress.XtraGrid.GridControl();
            playerView = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            colPlayer = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            layoutViewField_colPlayer = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            colProfile = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            layoutViewField_layoutViewColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            profileId = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            layoutViewField_layoutViewColumn1_1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            playerId = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            layoutViewField_layoutViewColumn1_2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            tracksPanel = new DevExpress.XtraEditors.PanelControl();
            modifiedTracksGrid = new DevExpress.XtraGrid.GridControl();
            modifiedTracksView = new TileView();
            colModifiedTrackSelected = new DevExpress.XtraGrid.Columns.TileViewColumn();
            colModifiedIdTrack = new DevExpress.XtraGrid.Columns.TileViewColumn();
            tracksGrid = new DevExpress.XtraGrid.GridControl();
            tracksView = new TileView();
            colTrackSelected = new DevExpress.XtraGrid.Columns.TileViewColumn();
            colIdTrack = new DevExpress.XtraGrid.Columns.TileViewColumn();
            trackTopPanel = new DevExpress.XtraEditors.PanelControl();
            btnClearGeneralTracks = new DevExpress.XtraEditors.SimpleButton();
            btnClearModifiedTracks = new DevExpress.XtraEditors.SimpleButton();
            txtSearchTrack = new DevExpress.XtraEditors.ButtonEdit();
            txtModifiedSearchTrack = new DevExpress.XtraEditors.ButtonEdit();
            btnResetTracks = new DevExpress.XtraEditors.SimpleButton();
            chkGeneralSelectAll = new System.Windows.Forms.CheckBox();
            chkModifiedSelectAll = new System.Windows.Forms.CheckBox();
            lblGeneralLimits = new DevExpress.XtraEditors.LabelControl();
            lblModifiedLimits = new DevExpress.XtraEditors.LabelControl();
            lblModifiedTrack = new DevExpress.XtraEditors.LabelControl();
            limitsPanel = new DevExpress.XtraEditors.PanelControl();
            limitsGrid = new DevExpress.XtraGrid.GridControl();
            limitsView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            limitsRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            colMin = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemNumberEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            colMax = new DevExpress.XtraGrid.Columns.GridColumn();
            colPayout = new DevExpress.XtraGrid.Columns.GridColumn();
            colOdds = new DevExpress.XtraGrid.Columns.GridColumn();
            limitsDefaultTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            trackLimitsTopPanel = new DevExpress.XtraEditors.PanelControl();
            btnTrackOdds = new DevExpress.XtraEditors.SimpleButton();
            txtGlobalMaxAmount = new DevExpress.XtraEditors.TextEdit();
            txtPerRaceMax = new DevExpress.XtraEditors.TextEdit();
            lblWeekLimit = new DevExpress.XtraEditors.LabelControl();
            lblDayLimit = new DevExpress.XtraEditors.LabelControl();
            lblHorseGlobalMaxToggle = new DevExpress.XtraEditors.LabelControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            lblLimits = new DevExpress.XtraEditors.LabelControl();
            profilePopupMenu = new System.Windows.Forms.ContextMenuStrip(components);
            mnuProfileClone = new System.Windows.Forms.ToolStripMenuItem();
            mnuProfileDelete = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            mnuProfileEdit = new System.Windows.Forms.ToolStripMenuItem();
            uiTimer = new System.Windows.Forms.Timer(components);
            statusBar = new System.Windows.Forms.StatusStrip();
            lblStatusPlayerCount = new System.Windows.Forms.ToolStripStatusLabel();
            lblStatusProfileCount = new System.Windows.Forms.ToolStripStatusLabel();
            lblStatusHasChanges = new System.Windows.Forms.ToolStripStatusLabel();
            lblStatusSpace = new System.Windows.Forms.ToolStripStatusLabel();
            lblStatusActiveProfile = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)modifiedTrackRepositoryTextEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackRepositoryTextEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuPanel).BeginInit();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSearchProfiles.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSearchPlayers.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profileSearchImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerSearchImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPlayer.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtProfile.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agentLookupCtl.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDefaultProfile.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profilesPanel).BeginInit();
            profilesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profileGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profileView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_colProfileName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_colIdRaceProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profileCardView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)raceProfilesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playersPanel).BeginInit();
            playersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)playerGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_colPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewCard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tracksPanel).BeginInit();
            tracksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)modifiedTracksGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modifiedTracksView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tracksGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tracksView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackTopPanel).BeginInit();
            trackTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSearchTrack.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtModifiedSearchTrack.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)limitsPanel).BeginInit();
            limitsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)limitsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)limitsView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)limitsRepositoryTextEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemNumberEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)limitsDefaultTextEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackLimitsTopPanel).BeginInit();
            trackLimitsTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtGlobalMaxAmount.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPerRaceMax.Properties).BeginInit();
            profilePopupMenu.SuspendLayout();
            statusBar.SuspendLayout();
            SuspendLayout();
            // 
            // colModifiedTrackName
            // 
            colModifiedTrackName.Caption = "Track Name";
            colModifiedTrackName.FieldName = "TrackName";
            colModifiedTrackName.MinWidth = 21;
            colModifiedTrackName.Name = "colModifiedTrackName";
            colModifiedTrackName.OptionsColumn.AllowEdit = false;
            colModifiedTrackName.OptionsColumn.AllowFocus = false;
            colModifiedTrackName.OptionsColumn.AllowMove = false;
            colModifiedTrackName.OptionsColumn.AllowShowHide = false;
            colModifiedTrackName.OptionsColumn.AllowSize = false;
            colModifiedTrackName.OptionsColumn.ReadOnly = true;
            colModifiedTrackName.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None;
            colModifiedTrackName.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            colModifiedTrackName.Visible = true;
            colModifiedTrackName.VisibleIndex = 0;
            // 
            // colModifiedIsEnabled
            // 
            colModifiedIsEnabled.Caption = "Enabled";
            colModifiedIsEnabled.ColumnEdit = modifiedTrackRepositoryTextEdit;
            colModifiedIsEnabled.FieldName = "IsEnabled";
            colModifiedIsEnabled.MinWidth = 21;
            colModifiedIsEnabled.Name = "colModifiedIsEnabled";
            colModifiedIsEnabled.OptionsColumn.AllowEdit = false;
            colModifiedIsEnabled.OptionsColumn.AllowMove = false;
            colModifiedIsEnabled.OptionsColumn.AllowShowHide = false;
            colModifiedIsEnabled.OptionsColumn.AllowSize = false;
            colModifiedIsEnabled.OptionsColumn.ReadOnly = true;
            colModifiedIsEnabled.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None;
            colModifiedIsEnabled.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            colModifiedIsEnabled.Visible = true;
            colModifiedIsEnabled.VisibleIndex = 1;
            // 
            // modifiedTrackRepositoryTextEdit
            // 
            modifiedTrackRepositoryTextEdit.AutoHeight = false;
            modifiedTrackRepositoryTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            modifiedTrackRepositoryTextEdit.Name = "modifiedTrackRepositoryTextEdit";
            // 
            // colTrackName
            // 
            colTrackName.Caption = "Track Name";
            colTrackName.FieldName = "TrackName";
            colTrackName.MinWidth = 21;
            colTrackName.Name = "colTrackName";
            colTrackName.OptionsColumn.AllowEdit = false;
            colTrackName.OptionsColumn.AllowFocus = false;
            colTrackName.OptionsColumn.AllowMove = false;
            colTrackName.OptionsColumn.AllowShowHide = false;
            colTrackName.OptionsColumn.AllowSize = false;
            colTrackName.OptionsColumn.ReadOnly = true;
            colTrackName.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None;
            colTrackName.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            colTrackName.Visible = true;
            colTrackName.VisibleIndex = 0;
            // 
            // colIsEnabled
            // 
            colIsEnabled.Caption = "Enabled";
            colIsEnabled.ColumnEdit = trackRepositoryTextEdit;
            colIsEnabled.FieldName = "IsEnabled";
            colIsEnabled.MinWidth = 21;
            colIsEnabled.Name = "colIsEnabled";
            colIsEnabled.OptionsColumn.AllowEdit = false;
            colIsEnabled.OptionsColumn.AllowMove = false;
            colIsEnabled.OptionsColumn.AllowShowHide = false;
            colIsEnabled.OptionsColumn.AllowSize = false;
            colIsEnabled.OptionsColumn.ReadOnly = true;
            colIsEnabled.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None;
            colIsEnabled.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            colIsEnabled.Visible = true;
            colIsEnabled.VisibleIndex = 1;
            // 
            // trackRepositoryTextEdit
            // 
            trackRepositoryTextEdit.AutoHeight = false;
            trackRepositoryTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            trackRepositoryTextEdit.Name = "trackRepositoryTextEdit";
            // 
            // menuPanel
            // 
            menuPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            menuPanel.Appearance.BackColor = Color.White;
            menuPanel.Appearance.BorderColor = Color.White;
            menuPanel.Appearance.Options.UseBackColor = true;
            menuPanel.Appearance.Options.UseBorderColor = true;
            menuPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            menuPanel.Controls.Add(btnRefresh);
            menuPanel.Controls.Add(btnSelectAllPlayers);
            menuPanel.Controls.Add(btnClearPlayers);
            menuPanel.Controls.Add(txtSearchProfiles);
            menuPanel.Controls.Add(txtSearchPlayers);
            menuPanel.Controls.Add(profileSearchImage);
            menuPanel.Controls.Add(playerSearchImage);
            menuPanel.Controls.Add(txtPlayer);
            menuPanel.Controls.Add(txtProfile);
            menuPanel.Controls.Add(agentLookupCtl);
            menuPanel.Controls.Add(btnSave);
            menuPanel.Controls.Add(labelControl4);
            menuPanel.Controls.Add(labelControl3);
            menuPanel.Controls.Add(btnProfileNew);
            menuPanel.Controls.Add(btnDefaultProfileNew);
            menuPanel.Controls.Add(btnProfileAssign);
            menuPanel.Controls.Add(labelControl2);
            menuPanel.Controls.Add(labelControl1);
            menuPanel.Controls.Add(txtDefaultProfile);
            menuPanel.Controls.Add(lblPlayer);
            menuPanel.Controls.Add(btnDefaultProfileAssign);
            menuPanel.Controls.Add(lblAgent);
            menuPanel.Location = new Point(10, 10);
            menuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(1138, 102);
            menuPanel.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(926, 19);
            btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(32, 32);
            btnRefresh.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnRefresh.SvgImage");
            btnRefresh.TabIndex = 21;
            btnRefresh.ToolTip = "Refresh Data";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSelectAllPlayers
            // 
            btnSelectAllPlayers.Appearance.BackColor = Color.FromArgb(0, 192, 0);
            btnSelectAllPlayers.Appearance.Options.UseBackColor = true;
            btnSelectAllPlayers.Location = new Point(470, 80);
            btnSelectAllPlayers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSelectAllPlayers.Name = "btnSelectAllPlayers";
            btnSelectAllPlayers.Size = new Size(100, 15);
            btnSelectAllPlayers.TabIndex = 20;
            btnSelectAllPlayers.Text = "Select All Players";
            btnSelectAllPlayers.Click += btnSelectAllPlayers_Click;
            // 
            // btnClearPlayers
            // 
            btnClearPlayers.Appearance.BackColor = Color.FromArgb(0, 192, 0);
            btnClearPlayers.Appearance.Options.UseBackColor = true;
            btnClearPlayers.Location = new Point(364, 80);
            btnClearPlayers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnClearPlayers.Name = "btnClearPlayers";
            btnClearPlayers.Size = new Size(100, 15);
            btnClearPlayers.TabIndex = 19;
            btnClearPlayers.Text = "Unselect All Players";
            btnClearPlayers.Click += btnClearPlayers_Click;
            // 
            // txtSearchProfiles
            // 
            txtSearchProfiles.Location = new Point(642, 80);
            txtSearchProfiles.Name = "txtSearchProfiles";
            txtSearchProfiles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear) });
            txtSearchProfiles.Size = new Size(173, 20);
            txtSearchProfiles.TabIndex = 2;
            txtSearchProfiles.ButtonPressed += txtSearchProfiles_ButtonPressed;
            txtSearchProfiles.EditValueChanged += txtSearchProfiles_EditValueChanged;
            txtSearchProfiles.Enter += txtSearchProfiles_Enter;
            // 
            // txtSearchPlayers
            // 
            txtSearchPlayers.Location = new Point(72, 80);
            txtSearchPlayers.Name = "txtSearchPlayers";
            txtSearchPlayers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear) });
            txtSearchPlayers.Size = new Size(204, 20);
            txtSearchPlayers.TabIndex = 1;
            txtSearchPlayers.ButtonPressed += txtSearchPlayers_ButtonPressed;
            txtSearchPlayers.EditValueChanged += txtSearchPlayers_EditValueChanged;
            txtSearchPlayers.Enter += txtSearchPlayers_Enter;
            // 
            // profileSearchImage
            // 
            profileSearchImage.Location = new Point(820, 80);
            profileSearchImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            profileSearchImage.Name = "profileSearchImage";
            profileSearchImage.Size = new Size(21, 20);
            profileSearchImage.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("profileSearchImage.SvgImage");
            profileSearchImage.TabIndex = 18;
            profileSearchImage.ToolTip = "Search Profiles";
            profileSearchImage.Click += profileSearchImage_Click;
            // 
            // playerSearchImage
            // 
            playerSearchImage.Location = new Point(281, 80);
            playerSearchImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            playerSearchImage.Name = "playerSearchImage";
            playerSearchImage.Size = new Size(21, 20);
            playerSearchImage.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("playerSearchImage.SvgImage");
            playerSearchImage.TabIndex = 17;
            playerSearchImage.ToolTip = "Search Players";
            playerSearchImage.Click += searchImage_Click;
            // 
            // txtPlayer
            // 
            txtPlayer.Location = new Point(54, 40);
            txtPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtPlayer.Name = "txtPlayer";
            txtPlayer.Properties.ReadOnly = true;
            txtPlayer.Properties.UseReadOnlyAppearance = false;
            txtPlayer.Size = new Size(232, 20);
            txtPlayer.TabIndex = 16;
            // 
            // txtProfile
            // 
            txtProfile.Location = new Point(372, 41);
            txtProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtProfile.Name = "txtProfile";
            txtProfile.Properties.ReadOnly = true;
            txtProfile.Properties.UseReadOnlyAppearance = false;
            txtProfile.Size = new Size(198, 20);
            txtProfile.TabIndex = 15;
            // 
            // agentLookupCtl
            // 
            agentLookupCtl.EditValue = "";
            agentLookupCtl.EnterMoveNextControl = true;
            agentLookupCtl.Location = new Point(54, 12);
            agentLookupCtl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            agentLookupCtl.Name = "agentLookupCtl";
            agentLookupCtl.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.True;
            agentLookupCtl.Properties.BeepOnError = true;
            agentLookupCtl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            agentLookupCtl.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Agent1", "Agent", 38, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default) });
            agentLookupCtl.Properties.DataSource = agentBindingSource;
            agentLookupCtl.Properties.DisplayMember = "Agent1";
            agentLookupCtl.Properties.DropDownRows = 8;
            agentLookupCtl.Properties.HideSelection = false;
            agentLookupCtl.Properties.ImmediatePopup = true;
            agentLookupCtl.Properties.NullText = "";
            agentLookupCtl.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
            agentLookupCtl.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            agentLookupCtl.Properties.SelectFirstRowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
            agentLookupCtl.Properties.ShowFooter = false;
            agentLookupCtl.Properties.ShowHeader = false;
            agentLookupCtl.Properties.ValidateOnEnterKey = true;
            agentLookupCtl.Properties.ValueMember = "Agent1";
            agentLookupCtl.Size = new Size(232, 20);
            agentLookupCtl.TabIndex = 0;
            agentLookupCtl.Closed += agentLookupCtl_Closed;
            agentLookupCtl.Click += agentLookupCtl_Click;
            agentLookupCtl.Enter += agentLookupCtl_Enter;
            agentLookupCtl.Leave += OnAgentLookupFocusLeave;
            // 
            // agentBindingSource
            // 
            agentBindingSource.DataSource = typeof(DGSDataUtils.Entities.DGSEntities.Agent);
            // 
            // btnSave
            // 
            btnSave.Appearance.BackColor = Color.RoyalBlue;
            btnSave.Appearance.ForeColor = Color.White;
            btnSave.Appearance.Options.UseBackColor = true;
            btnSave.Appearance.Options.UseForeColor = true;
            btnSave.Appearance.Options.UseTextOptions = true;
            btnSave.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            btnSave.AppearanceDisabled.BackColor = Color.FromArgb(224, 224, 224);
            btnSave.AppearanceDisabled.ForeColor = Color.Gray;
            btnSave.AppearanceDisabled.Options.UseBackColor = true;
            btnSave.AppearanceDisabled.Options.UseForeColor = true;
            btnSave.AppearanceDisabled.Options.UseTextOptions = true;
            btnSave.Location = new Point(838, 19);
            btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(73, 32);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save Changes";
            btnSave.Click += btnSave_Click;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(595, 80);
            labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(42, 13);
            labelControl4.TabIndex = 14;
            labelControl4.Text = "Profiles";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(8, 80);
            labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(42, 13);
            labelControl3.TabIndex = 12;
            labelControl3.Text = "Players";
            // 
            // btnProfileNew
            // 
            btnProfileNew.Appearance.BackColor = Color.FromArgb(0, 192, 0);
            btnProfileNew.Appearance.Options.UseBackColor = true;
            btnProfileNew.Location = new Point(715, 39);
            btnProfileNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnProfileNew.Name = "btnProfileNew";
            btnProfileNew.Size = new Size(101, 21);
            btnProfileNew.TabIndex = 7;
            btnProfileNew.Text = "New";
            btnProfileNew.Click += btnProfileNew_Click;
            // 
            // btnDefaultProfileNew
            // 
            btnDefaultProfileNew.Appearance.BackColor = Color.FromArgb(0, 192, 0);
            btnDefaultProfileNew.Appearance.Options.UseBackColor = true;
            btnDefaultProfileNew.Location = new Point(715, 10);
            btnDefaultProfileNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnDefaultProfileNew.Name = "btnDefaultProfileNew";
            btnDefaultProfileNew.Size = new Size(101, 21);
            btnDefaultProfileNew.TabIndex = 5;
            btnDefaultProfileNew.Text = "New";
            btnDefaultProfileNew.Click += btnDefaultProfileNew_Click;
            // 
            // btnProfileAssign
            // 
            btnProfileAssign.Appearance.BackColor = Color.FromArgb(0, 192, 0);
            btnProfileAssign.Appearance.Options.UseBackColor = true;
            btnProfileAssign.Location = new Point(595, 39);
            btnProfileAssign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnProfileAssign.Name = "btnProfileAssign";
            btnProfileAssign.Size = new Size(101, 21);
            btnProfileAssign.TabIndex = 6;
            btnProfileAssign.Text = "Assign";
            btnProfileAssign.Click += btnProfileAssign_Click;
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(298, 43);
            labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(30, 13);
            labelControl2.TabIndex = 8;
            labelControl2.Text = "Profile";
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(298, 14);
            labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(68, 13);
            labelControl1.TabIndex = 6;
            labelControl1.Text = "Default Profile";
            // 
            // txtDefaultProfile
            // 
            txtDefaultProfile.Location = new Point(372, 11);
            txtDefaultProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtDefaultProfile.Name = "txtDefaultProfile";
            txtDefaultProfile.Size = new Size(198, 20);
            txtDefaultProfile.TabIndex = 3;
            // 
            // lblPlayer
            // 
            lblPlayer.Location = new Point(15, 43);
            lblPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(30, 13);
            lblPlayer.TabIndex = 4;
            lblPlayer.Text = "Player";
            // 
            // btnDefaultProfileAssign
            // 
            btnDefaultProfileAssign.Location = new Point(595, 10);
            btnDefaultProfileAssign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnDefaultProfileAssign.Name = "btnDefaultProfileAssign";
            btnDefaultProfileAssign.Size = new Size(101, 21);
            btnDefaultProfileAssign.TabIndex = 4;
            btnDefaultProfileAssign.Text = "Assign";
            btnDefaultProfileAssign.Click += btnDefaultProfileAssign_Click;
            // 
            // lblAgent
            // 
            lblAgent.Location = new Point(15, 12);
            lblAgent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            lblAgent.Name = "lblAgent";
            lblAgent.Size = new Size(29, 13);
            lblAgent.TabIndex = 0;
            lblAgent.Text = "Agent";
            // 
            // searchLookUpEdit1View
            // 
            searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1 });
            searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            searchLookUpEdit1View.Tag = "Name";
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "Agent Name";
            gridColumn1.FieldName = "Name";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            // 
            // profilesPanel
            // 
            profilesPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            profilesPanel.Controls.Add(profileGrid);
            profilesPanel.Location = new Point(587, 116);
            profilesPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            profilesPanel.Name = "profilesPanel";
            profilesPanel.Size = new Size(557, 264);
            profilesPanel.TabIndex = 1;
            // 
            // profileGrid
            // 
            profileGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            profileGrid.DataSource = typeof(DGSDataUtils.Entities.ProMgrEntities.DtoRaceProfile);
            profileGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            profileGrid.Location = new Point(0, 0);
            profileGrid.MainView = profileView;
            profileGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            profileGrid.Name = "profileGrid";
            profileGrid.Size = new Size(557, 264);
            profileGrid.TabIndex = 13;
            profileGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { profileView });
            // 
            // profileView
            // 
            profileView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            profileView.CardHorzInterval = 1;
            profileView.CardMinSize = new Size(150, 20);
            profileView.CardVertInterval = 1;
            profileView.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] { colProfileName, colIdRaceProfile });
            profileView.DetailHeight = 284;
            profileView.GridControl = profileGrid;
            profileView.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutViewField_colIdRaceProfile });
            profileView.Name = "profileView";
            profileView.OptionsBehavior.Editable = false;
            profileView.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            profileView.OptionsBehavior.ReadOnly = true;
            profileView.OptionsBehavior.ScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            profileView.OptionsCustomization.AllowFilter = false;
            profileView.OptionsCustomization.AllowSort = false;
            profileView.OptionsItemText.TextToControlDistance = 0;
            profileView.OptionsMultiRecordMode.MaxCardColumns = 3;
            profileView.OptionsMultiRecordMode.MultiRowScrollBarOrientation = DevExpress.XtraGrid.Views.Layout.ScrollBarOrientation.Vertical;
            profileView.OptionsSelection.MultiSelect = true;
            profileView.OptionsView.AllowHotTrackFields = false;
            profileView.OptionsView.FocusRectStyle = DevExpress.XtraGrid.Views.Layout.FocusRectStyle.None;
            profileView.OptionsView.ShowCardBorderIfCaptionHidden = false;
            profileView.OptionsView.ShowCardCaption = false;
            profileView.OptionsView.ShowCardExpandButton = false;
            profileView.OptionsView.ShowCardLines = false;
            profileView.OptionsView.ShowFieldHints = false;
            profileView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            profileView.OptionsView.ShowHeaderPanel = false;
            profileView.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow;
            profileView.TemplateCard = profileCardView;
            profileView.CustomFieldValueStyle += profileView_CustomFieldValueStyle;
            profileView.FieldValueClick += profileView_FieldValueClick;
            // 
            // colProfileName
            // 
            colProfileName.FieldName = "ProfileName";
            colProfileName.LayoutViewField = layoutViewField_colProfileName;
            colProfileName.MinWidth = 21;
            colProfileName.Name = "colProfileName";
            colProfileName.Width = 81;
            // 
            // layoutViewField_colProfileName
            // 
            layoutViewField_colProfileName.EditorPreferredWidth = 76;
            layoutViewField_colProfileName.Location = new Point(0, 0);
            layoutViewField_colProfileName.Name = "layoutViewField_colProfileName";
            layoutViewField_colProfileName.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            layoutViewField_colProfileName.Size = new Size(89, 22);
            layoutViewField_colProfileName.TextSize = new Size(0, 0);
            layoutViewField_colProfileName.TextVisible = false;
            // 
            // colIdRaceProfile
            // 
            colIdRaceProfile.FieldName = "IdRaceProfile";
            colIdRaceProfile.LayoutViewField = layoutViewField_colIdRaceProfile;
            colIdRaceProfile.MinWidth = 21;
            colIdRaceProfile.Name = "colIdRaceProfile";
            colIdRaceProfile.Width = 81;
            // 
            // layoutViewField_colIdRaceProfile
            // 
            layoutViewField_colIdRaceProfile.EditorPreferredWidth = 4;
            layoutViewField_colIdRaceProfile.Location = new Point(0, 22);
            layoutViewField_colIdRaceProfile.Name = "layoutViewField_colIdRaceProfile";
            layoutViewField_colIdRaceProfile.Size = new Size(97, 24);
            layoutViewField_colIdRaceProfile.TextSize = new Size(75, 16);
            // 
            // profileCardView
            // 
            profileCardView.CustomizationFormText = "TemplateCard";
            profileCardView.GroupBordersVisible = false;
            profileCardView.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            profileCardView.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutViewField_colProfileName });
            profileCardView.Name = "layoutViewTemplateCard";
            profileCardView.OptionsItemText.TextToControlDistance = 0;
            profileCardView.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            profileCardView.Text = "Profile Card View";
            // 
            // raceProfilesBindingSource
            // 
            raceProfilesBindingSource.DataSource = typeof(DGSDataUtils.Entities.ProMgrEntities.DtoRaceProfile);
            // 
            // playersPanel
            // 
            playersPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            playersPanel.Controls.Add(playerGrid);
            playersPanel.Location = new Point(10, 116);
            playersPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            playersPanel.Name = "playersPanel";
            playersPanel.Size = new Size(557, 264);
            playersPanel.TabIndex = 2;
            // 
            // playerGrid
            // 
            playerGrid.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.False;
            playerGrid.DataSource = raceProfilesBindingSource;
            playerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            playerGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            playerGrid.Location = new Point(0, 0);
            playerGrid.MainView = playerView;
            playerGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            playerGrid.Name = "playerGrid";
            playerGrid.Size = new Size(557, 264);
            playerGrid.TabIndex = 9;
            playerGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { playerView });
            // 
            // playerView
            // 
            playerView.Appearance.SelectionFrame.BackColor = Color.FromArgb(255, 255, 128);
            playerView.Appearance.SelectionFrame.Options.UseBackColor = true;
            playerView.Appearance.ViewBackground.BorderColor = Color.Transparent;
            playerView.Appearance.ViewBackground.Options.UseBorderColor = true;
            playerView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            playerView.CardHorzInterval = 1;
            playerView.CardMinSize = new Size(94, 41);
            playerView.CardVertInterval = 1;
            playerView.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] { colPlayer, colProfile, profileId, playerId });
            playerView.DetailHeight = 284;
            playerView.GridControl = playerGrid;
            playerView.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutViewField_layoutViewColumn1_2, layoutViewField_layoutViewColumn1_1 });
            playerView.Name = "playerView";
            playerView.OptionsBehavior.AutoSelectAllInEditor = false;
            playerView.OptionsBehavior.Editable = false;
            playerView.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            playerView.OptionsBehavior.ReadOnly = true;
            playerView.OptionsBehavior.ScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            playerView.OptionsCustomization.AllowFilter = false;
            playerView.OptionsCustomization.AllowSort = false;
            playerView.OptionsItemText.TextToControlDistance = 0;
            playerView.OptionsMultiRecordMode.MultiRowScrollBarOrientation = DevExpress.XtraGrid.Views.Layout.ScrollBarOrientation.Vertical;
            playerView.OptionsView.AllowHotTrackFields = false;
            playerView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            playerView.OptionsView.DefaultColumnCount = 6;
            playerView.OptionsView.ShowCardBorderIfCaptionHidden = false;
            playerView.OptionsView.ShowCardCaption = false;
            playerView.OptionsView.ShowCardExpandButton = false;
            playerView.OptionsView.ShowCardLines = false;
            playerView.OptionsView.ShowFieldHints = false;
            playerView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            playerView.OptionsView.ShowHeaderPanel = false;
            playerView.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow;
            playerView.TemplateCard = layoutViewCard1;
            playerView.CustomFieldValueStyle += playerView_CustomFieldValueStyle;
            playerView.CardClick += playerView_CardClick;
            playerView.KeyPress += playerView_KeyPress;
            // 
            // colPlayer
            // 
            colPlayer.AppearanceCell.Options.UseTextOptions = true;
            colPlayer.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colPlayer.FieldName = "Player1";
            colPlayer.LayoutViewField = layoutViewField_colPlayer;
            colPlayer.MinWidth = 21;
            colPlayer.Name = "colPlayer";
            colPlayer.OptionsColumn.AllowFocus = false;
            colPlayer.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            colPlayer.Width = 81;
            // 
            // layoutViewField_colPlayer
            // 
            layoutViewField_colPlayer.EditorPreferredWidth = 94;
            layoutViewField_colPlayer.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.False;
            layoutViewField_colPlayer.Location = new Point(0, 0);
            layoutViewField_colPlayer.Name = "layoutViewField_colPlayer";
            layoutViewField_colPlayer.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            layoutViewField_colPlayer.Size = new Size(110, 22);
            layoutViewField_colPlayer.TextSize = new Size(0, 0);
            layoutViewField_colPlayer.TextVisible = false;
            // 
            // colProfile
            // 
            colProfile.AppearanceCell.Font = new Font("Tahoma", 7F, FontStyle.Regular, GraphicsUnit.Point);
            colProfile.AppearanceCell.Options.UseFont = true;
            colProfile.AppearanceCell.Options.UseTextOptions = true;
            colProfile.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colProfile.FieldName = "ProfileName";
            colProfile.LayoutViewField = layoutViewField_layoutViewColumn1;
            colProfile.MinWidth = 21;
            colProfile.Name = "colProfile";
            colProfile.OptionsColumn.AllowFocus = false;
            colProfile.Width = 81;
            // 
            // layoutViewField_layoutViewColumn1
            // 
            layoutViewField_layoutViewColumn1.EditorPreferredWidth = 91;
            layoutViewField_layoutViewColumn1.Location = new Point(0, 22);
            layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1";
            layoutViewField_layoutViewColumn1.Size = new Size(110, 26);
            layoutViewField_layoutViewColumn1.TextSize = new Size(0, 0);
            layoutViewField_layoutViewColumn1.TextVisible = false;
            // 
            // profileId
            // 
            profileId.CustomizationCaption = "profileid";
            profileId.LayoutViewField = layoutViewField_layoutViewColumn1_1;
            profileId.MinWidth = 21;
            profileId.Name = "profileId";
            profileId.Width = 81;
            // 
            // layoutViewField_layoutViewColumn1_1
            // 
            layoutViewField_layoutViewColumn1_1.EditorPreferredWidth = 9;
            layoutViewField_layoutViewColumn1_1.Location = new Point(0, 0);
            layoutViewField_layoutViewColumn1_1.Name = "layoutViewField_layoutViewColumn1_1";
            layoutViewField_layoutViewColumn1_1.Size = new Size(134, 48);
            layoutViewField_layoutViewColumn1_1.TextSize = new Size(100, 16);
            // 
            // playerId
            // 
            playerId.CustomizationCaption = "playerid";
            playerId.LayoutViewField = layoutViewField_layoutViewColumn1_2;
            playerId.MinWidth = 21;
            playerId.Name = "playerId";
            playerId.Width = 81;
            // 
            // layoutViewField_layoutViewColumn1_2
            // 
            layoutViewField_layoutViewColumn1_2.EditorPreferredWidth = 9;
            layoutViewField_layoutViewColumn1_2.Location = new Point(0, 0);
            layoutViewField_layoutViewColumn1_2.Name = "layoutViewField_layoutViewColumn1_2";
            layoutViewField_layoutViewColumn1_2.Size = new Size(134, 48);
            layoutViewField_layoutViewColumn1_2.TextSize = new Size(100, 16);
            // 
            // layoutViewCard1
            // 
            layoutViewCard1.CustomizationFormText = "TemplateCard";
            layoutViewCard1.GroupBordersVisible = false;
            layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutViewField_colPlayer, layoutViewField_layoutViewColumn1 });
            layoutViewCard1.Name = "layoutViewTemplateCard";
            layoutViewCard1.OptionsItemText.TextToControlDistance = 0;
            layoutViewCard1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            layoutViewCard1.Text = "TemplateCard";
            // 
            // tracksPanel
            // 
            tracksPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            tracksPanel.Controls.Add(modifiedTracksGrid);
            tracksPanel.Controls.Add(tracksGrid);
            tracksPanel.Controls.Add(trackTopPanel);
            tracksPanel.Location = new Point(10, 386);
            tracksPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tracksPanel.Name = "tracksPanel";
            tracksPanel.Size = new Size(609, 420);
            tracksPanel.TabIndex = 3;
            tracksPanel.Paint += tracksPanel_Paint;
            // 
            // modifiedTracksGrid
            // 
            modifiedTracksGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            modifiedTracksGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            modifiedTracksGrid.EmbeddedNavigator.ShowToolTips = false;
            modifiedTracksGrid.Location = new Point(0, 46);
            modifiedTracksGrid.MainView = modifiedTracksView;
            modifiedTracksGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            modifiedTracksGrid.Name = "modifiedTracksGrid";
            modifiedTracksGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { modifiedTrackRepositoryTextEdit });
            modifiedTracksGrid.Size = new Size(295, 365);
            modifiedTracksGrid.TabIndex = 13;
            modifiedTracksGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { modifiedTracksView });
            // 
            // modifiedTracksView
            // 
            modifiedTracksView.Appearance.EmptySpace.BackColor = Color.White;
            modifiedTracksView.Appearance.EmptySpace.BorderColor = Color.Transparent;
            modifiedTracksView.Appearance.EmptySpace.Options.UseBackColor = true;
            modifiedTracksView.Appearance.ItemNormal.BorderColor = Color.Transparent;
            modifiedTracksView.Appearance.ItemNormal.ForeColor = Color.White;
            modifiedTracksView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            modifiedTracksView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colModifiedTrackName, colModifiedIsEnabled, colModifiedTrackSelected, colModifiedIdTrack });
            modifiedTracksView.DetailHeight = 122;
            modifiedTracksView.GridControl = modifiedTracksGrid;
            modifiedTracksView.Name = "modifiedTracksView";
            modifiedTracksView.OptionsBehavior.EditingMode = TileViewEditingMode.Disabled;
            modifiedTracksView.OptionsBehavior.ReadOnly = true;
            modifiedTracksView.OptionsTiles.AllowPressAnimation = false;
            modifiedTracksView.OptionsTiles.ColumnCount = 2;
            modifiedTracksView.OptionsTiles.HighlightFocusedTileStyle = HighlightFocusedTileStyle.None;
            modifiedTracksView.OptionsTiles.IndentBetweenGroups = 1;
            modifiedTracksView.OptionsTiles.IndentBetweenItems = 0;
            modifiedTracksView.OptionsTiles.ItemBorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            modifiedTracksView.OptionsTiles.ItemPadding = new System.Windows.Forms.Padding(0);
            modifiedTracksView.OptionsTiles.ItemSize = new Size(175, 25);
            modifiedTracksView.OptionsTiles.LayoutMode = TileViewLayoutMode.List;
            modifiedTracksView.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            modifiedTracksView.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            modifiedTracksView.OptionsTiles.RowCount = 0;
            modifiedTracksView.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            modifiedTracksView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] { new DevExpress.XtraGrid.Columns.GridColumnSortInfo(colModifiedTrackName, DevExpress.Data.ColumnSortOrder.Ascending) });
            modifiedTracksView.TileColumns.Add(tableColumnDefinition1);
            modifiedTracksView.TileColumns.Add(tableColumnDefinition2);
            modifiedTracksView.TileRows.Add(tableRowDefinition1);
            tileViewItemElement1.Column = colModifiedTrackName;
            tileViewItemElement1.Name = "lblTrackName";
            tileViewItemElement1.StretchVertical = true;
            tileViewItemElement1.Text = "colTrackName";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement1.TextLocation = new Point(5, 0);
            tileViewItemElement2.Column = colModifiedIsEnabled;
            tileViewItemElement2.ColumnIndex = 1;
            tileViewItemElement2.Name = "lblTrackEnabled";
            tileViewItemElement2.Text = "colIsEnabled";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            modifiedTracksView.TileTemplate.Add(tileViewItemElement1);
            modifiedTracksView.TileTemplate.Add(tileViewItemElement2);
            modifiedTracksView.ItemClick += modifiedTracksView_ItemClick;
            modifiedTracksView.ItemCustomize += modifiedTracksView_ItemCustomize;
            modifiedTracksView.CustomColumnDisplayText += modifiedTracksView_CustomColumnDisplayText;
            // 
            // colModifiedTrackSelected
            // 
            colModifiedTrackSelected.Caption = "TrackSelected";
            colModifiedTrackSelected.FieldName = "IsTrackSelected";
            colModifiedTrackSelected.MinWidth = 21;
            colModifiedTrackSelected.Name = "colModifiedTrackSelected";
            colModifiedTrackSelected.Width = 21;
            // 
            // colModifiedIdTrack
            // 
            colModifiedIdTrack.Caption = "Track Id";
            colModifiedIdTrack.FieldName = "IdTrack";
            colModifiedIdTrack.Name = "colModifiedIdTrack";
            colModifiedIdTrack.Width = 20;
            // 
            // tracksGrid
            // 
            tracksGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            tracksGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tracksGrid.EmbeddedNavigator.ShowToolTips = false;
            tracksGrid.Location = new Point(305, 46);
            tracksGrid.MainView = tracksView;
            tracksGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tracksGrid.Name = "tracksGrid";
            tracksGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { trackRepositoryTextEdit });
            tracksGrid.Size = new Size(295, 365);
            tracksGrid.TabIndex = 12;
            tracksGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { tracksView });
            // 
            // tracksView
            // 
            tracksView.Appearance.EmptySpace.BackColor = Color.White;
            tracksView.Appearance.EmptySpace.BorderColor = Color.Transparent;
            tracksView.Appearance.EmptySpace.Options.UseBackColor = true;
            tracksView.Appearance.ItemNormal.BorderColor = Color.Transparent;
            tracksView.Appearance.ItemNormal.ForeColor = Color.White;
            tracksView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            tracksView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colTrackName, colIsEnabled, colTrackSelected, colIdTrack });
            tracksView.DetailHeight = 122;
            tracksView.GridControl = tracksGrid;
            tracksView.Name = "tracksView";
            tracksView.OptionsBehavior.EditingMode = TileViewEditingMode.Disabled;
            tracksView.OptionsBehavior.ReadOnly = true;
            tracksView.OptionsTiles.AllowPressAnimation = false;
            tracksView.OptionsTiles.ColumnCount = 2;
            tracksView.OptionsTiles.HighlightFocusedTileStyle = HighlightFocusedTileStyle.None;
            tracksView.OptionsTiles.IndentBetweenGroups = 1;
            tracksView.OptionsTiles.IndentBetweenItems = 0;
            tracksView.OptionsTiles.ItemBorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tracksView.OptionsTiles.ItemPadding = new System.Windows.Forms.Padding(0);
            tracksView.OptionsTiles.ItemSize = new Size(175, 25);
            tracksView.OptionsTiles.LayoutMode = TileViewLayoutMode.List;
            tracksView.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            tracksView.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            tracksView.OptionsTiles.RowCount = 0;
            tracksView.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            tracksView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] { new DevExpress.XtraGrid.Columns.GridColumnSortInfo(colTrackName, DevExpress.Data.ColumnSortOrder.Ascending) });
            tracksView.TileColumns.Add(tableColumnDefinition3);
            tracksView.TileColumns.Add(tableColumnDefinition4);
            tracksView.TileRows.Add(tableRowDefinition2);
            tileViewItemElement3.Column = colTrackName;
            tileViewItemElement3.Name = "lblTrackName";
            tileViewItemElement3.StretchVertical = true;
            tileViewItemElement3.Text = "colTrackName";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement4.Column = colIsEnabled;
            tileViewItemElement4.ColumnIndex = 1;
            tileViewItemElement4.Name = "lblTrackEnabled";
            tileViewItemElement4.Text = "colIsEnabled";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tracksView.TileTemplate.Add(tileViewItemElement3);
            tracksView.TileTemplate.Add(tileViewItemElement4);
            tracksView.ItemClick += TracksViewItemClick;
            tracksView.ItemCustomize += TracksViewItemCustomize;
            tracksView.CustomColumnDisplayText += TracksViewCustomColumnDisplayText;
            // 
            // colTrackSelected
            // 
            colTrackSelected.Caption = "TrackSelected";
            colTrackSelected.FieldName = "IsTrackSelected";
            colTrackSelected.MinWidth = 21;
            colTrackSelected.Name = "colTrackSelected";
            colTrackSelected.Width = 21;
            // 
            // colIdTrack
            // 
            colIdTrack.Caption = "Track Id";
            colIdTrack.FieldName = "IdTrack";
            colIdTrack.Name = "colIdTrack";
            colIdTrack.Width = 20;
            // 
            // trackTopPanel
            // 
            trackTopPanel.Appearance.BackColor = Color.White;
            trackTopPanel.Appearance.Options.UseBackColor = true;
            trackTopPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            trackTopPanel.Controls.Add(btnClearGeneralTracks);
            trackTopPanel.Controls.Add(btnClearModifiedTracks);
            trackTopPanel.Controls.Add(txtSearchTrack);
            trackTopPanel.Controls.Add(txtModifiedSearchTrack);
            trackTopPanel.Controls.Add(btnResetTracks);
            trackTopPanel.Controls.Add(chkGeneralSelectAll);
            trackTopPanel.Controls.Add(chkModifiedSelectAll);
            trackTopPanel.Controls.Add(lblGeneralLimits);
            trackTopPanel.Controls.Add(lblModifiedLimits);
            trackTopPanel.Controls.Add(lblModifiedTrack);
            trackTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            trackTopPanel.Location = new Point(0, 0);
            trackTopPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            trackTopPanel.Name = "trackTopPanel";
            trackTopPanel.Size = new Size(609, 46);
            trackTopPanel.TabIndex = 0;
            // 
            // btnClearGeneralTracks
            // 
            btnClearGeneralTracks.Appearance.BackColor = Color.FromArgb(0, 192, 0);
            btnClearGeneralTracks.Appearance.Options.UseBackColor = true;
            btnClearGeneralTracks.Location = new Point(400, 28);
            btnClearGeneralTracks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnClearGeneralTracks.Name = "btnClearGeneralTracks";
            btnClearGeneralTracks.Size = new Size(40, 15);
            btnClearGeneralTracks.TabIndex = 21;
            btnClearGeneralTracks.Text = "Clear";
            btnClearGeneralTracks.Click += btnClearGeneralTracks_Click;
            // 
            // btnClearModifiedTracks
            // 
            btnClearModifiedTracks.Appearance.BackColor = Color.FromArgb(0, 192, 0);
            btnClearModifiedTracks.Appearance.Options.UseBackColor = true;
            btnClearModifiedTracks.Location = new Point(131, 28);
            btnClearModifiedTracks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnClearModifiedTracks.Name = "btnClearModifiedTracks";
            btnClearModifiedTracks.Size = new Size(40, 15);
            btnClearModifiedTracks.TabIndex = 20;
            btnClearModifiedTracks.Text = "Clear";
            btnClearModifiedTracks.Click += btnClearModifiedTracks_Click;
            // 
            // txtSearchTrack
            // 
            txtSearchTrack.Location = new Point(300, 6);
            txtSearchTrack.Name = "txtSearchTrack";
            txtSearchTrack.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear) });
            txtSearchTrack.Size = new Size(187, 20);
            txtSearchTrack.TabIndex = 18;
            txtSearchTrack.ButtonPressed += txtSearchTrack_ButtonPressed;
            txtSearchTrack.EditValueChanged += txtSearchTrack_EditValueChanged;
            // 
            // txtModifiedSearchTrack
            // 
            txtModifiedSearchTrack.Location = new Point(54, 6);
            txtModifiedSearchTrack.Name = "txtModifiedSearchTrack";
            txtModifiedSearchTrack.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear) });
            txtModifiedSearchTrack.Size = new Size(185, 20);
            txtModifiedSearchTrack.TabIndex = 10;
            txtModifiedSearchTrack.ButtonPressed += TxtModifiedSearchTrackButtonPressed;
            txtModifiedSearchTrack.EditValueChanged += TxtModifiedSearchTrackEditValueChanged;
            // 
            // btnResetTracks
            // 
            btnResetTracks.Appearance.BackColor = Color.FromArgb(0, 192, 0);
            btnResetTracks.Appearance.Options.UseBackColor = true;
            btnResetTracks.Location = new Point(85, 28);
            btnResetTracks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnResetTracks.Name = "btnResetTracks";
            btnResetTracks.Size = new Size(40, 15);
            btnResetTracks.TabIndex = 17;
            btnResetTracks.Text = "Revert";
            btnResetTracks.Click += btnResetTracks_Click;
            // 
            // chkGeneralSelectAll
            // 
            chkGeneralSelectAll.CheckAlign = ContentAlignment.MiddleRight;
            chkGeneralSelectAll.Checked = true;
            chkGeneralSelectAll.CheckState = System.Windows.Forms.CheckState.Checked;
            chkGeneralSelectAll.Location = new Point(480, 28);
            chkGeneralSelectAll.Name = "chkGeneralSelectAll";
            chkGeneralSelectAll.Size = new Size(69, 15);
            chkGeneralSelectAll.TabIndex = 16;
            chkGeneralSelectAll.Text = "Select All";
            chkGeneralSelectAll.UseVisualStyleBackColor = true;
            chkGeneralSelectAll.MouseClick += chkGeneralSelectAll_MouseClick;
            // 
            // chkModifiedSelectAll
            // 
            chkModifiedSelectAll.CheckAlign = ContentAlignment.MiddleRight;
            chkModifiedSelectAll.Location = new Point(170, 28);
            chkModifiedSelectAll.Name = "chkModifiedSelectAll";
            chkModifiedSelectAll.Size = new Size(69, 15);
            chkModifiedSelectAll.TabIndex = 15;
            chkModifiedSelectAll.Text = "Select All";
            chkModifiedSelectAll.UseVisualStyleBackColor = true;
            chkModifiedSelectAll.MouseClick += chkModifiedSelectAll_MouseClick;
            // 
            // lblGeneralLimits
            // 
            lblGeneralLimits.Appearance.BackColor = Color.Transparent;
            lblGeneralLimits.Appearance.BorderColor = Color.Silver;
            lblGeneralLimits.Appearance.ForeColor = Color.Black;
            lblGeneralLimits.Appearance.Options.UseBackColor = true;
            lblGeneralLimits.Appearance.Options.UseBorderColor = true;
            lblGeneralLimits.Appearance.Options.UseForeColor = true;
            lblGeneralLimits.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            lblGeneralLimits.Location = new Point(275, 28);
            lblGeneralLimits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            lblGeneralLimits.MinimumSize = new Size(80, 0);
            lblGeneralLimits.Name = "lblGeneralLimits";
            lblGeneralLimits.Size = new Size(80, 13);
            lblGeneralLimits.TabIndex = 14;
            lblGeneralLimits.Text = "General Limits";
            // 
            // lblModifiedLimits
            // 
            lblModifiedLimits.Appearance.BackColor = Color.Transparent;
            lblModifiedLimits.Appearance.BorderColor = Color.Silver;
            lblModifiedLimits.Appearance.ForeColor = Color.Black;
            lblModifiedLimits.Appearance.Options.UseBackColor = true;
            lblModifiedLimits.Appearance.Options.UseBorderColor = true;
            lblModifiedLimits.Appearance.Options.UseForeColor = true;
            lblModifiedLimits.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            lblModifiedLimits.Location = new Point(2, 28);
            lblModifiedLimits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            lblModifiedLimits.MinimumSize = new Size(80, 0);
            lblModifiedLimits.Name = "lblModifiedLimits";
            lblModifiedLimits.Size = new Size(80, 13);
            lblModifiedLimits.TabIndex = 13;
            lblModifiedLimits.Text = "Modified Limits";
            // 
            // lblModifiedTrack
            // 
            lblModifiedTrack.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblModifiedTrack.Appearance.Options.UseFont = true;
            lblModifiedTrack.Location = new Point(2, 6);
            lblModifiedTrack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            lblModifiedTrack.Name = "lblModifiedTrack";
            lblModifiedTrack.Size = new Size(38, 13);
            lblModifiedTrack.TabIndex = 2;
            lblModifiedTrack.Text = "Tracks";
            // 
            // limitsPanel
            // 
            limitsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            limitsPanel.AutoSize = true;
            limitsPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            limitsPanel.Controls.Add(limitsGrid);
            limitsPanel.Controls.Add(trackLimitsTopPanel);
            limitsPanel.Location = new Point(625, 386);
            limitsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            limitsPanel.Name = "limitsPanel";
            limitsPanel.Size = new Size(523, 403);
            limitsPanel.TabIndex = 4;
            // 
            // limitsGrid
            // 
            limitsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            limitsGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            limitsGrid.EmbeddedNavigator.ShowToolTips = false;
            limitsGrid.Location = new Point(0, 58);
            limitsGrid.MainView = limitsView;
            limitsGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            limitsGrid.Name = "limitsGrid";
            limitsGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { limitsRepositoryTextEdit, repositoryItemNumberEdit, limitsDefaultTextEdit });
            limitsGrid.Size = new Size(523, 345);
            limitsGrid.TabIndex = 16;
            limitsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { limitsView });
            // 
            // limitsView
            // 
            limitsView.Appearance.HeaderPanel.BackColor = Color.White;
            limitsView.Appearance.HeaderPanel.BorderColor = Color.White;
            limitsView.Appearance.HeaderPanel.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            limitsView.Appearance.HeaderPanel.ForeColor = Color.Black;
            limitsView.Appearance.HeaderPanel.Options.UseBackColor = true;
            limitsView.Appearance.HeaderPanel.Options.UseBorderColor = true;
            limitsView.Appearance.HeaderPanel.Options.UseForeColor = true;
            limitsView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            limitsView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            limitsView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            limitsView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colCategory, colStatus, colMin, colMax, colPayout, colOdds });
            limitsView.DetailHeight = 122;
            limitsView.GridControl = limitsGrid;
            limitsView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            limitsView.Name = "limitsView";
            limitsView.OptionsCustomization.AllowColumnMoving = false;
            limitsView.OptionsCustomization.AllowColumnResizing = false;
            limitsView.OptionsCustomization.AllowFilter = false;
            limitsView.OptionsCustomization.AllowGroup = false;
            limitsView.OptionsCustomization.AllowSort = false;
            limitsView.OptionsEditForm.PopupEditFormWidth = 686;
            limitsView.OptionsMenu.EnableColumnMenu = false;
            limitsView.OptionsMenu.EnableFooterMenu = false;
            limitsView.OptionsMenu.EnableGroupPanelMenu = false;
            limitsView.OptionsNavigation.AutoMoveRowFocus = false;
            limitsView.OptionsNavigation.EnterMoveNextColumn = true;
            limitsView.OptionsNavigation.UseOfficePageNavigation = false;
            limitsView.OptionsSelection.EnableAppearanceFocusedCell = false;
            limitsView.OptionsSelection.EnableAppearanceFocusedRow = false;
            limitsView.OptionsSelection.UseIndicatorForSelection = false;
            limitsView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.NeverAnimate;
            limitsView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            limitsView.OptionsView.ShowGroupPanel = false;
            limitsView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            limitsView.OptionsView.ShowIndicator = false;
            limitsView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            limitsView.RowCellClick += limitsView_RowCellClick;
            limitsView.CustomDrawColumnHeader += limitsView_CustomDrawColumnHeader;
            limitsView.CustomDrawCell += limitsView_CustomDrawCell;
            limitsView.CustomRowCellEdit += limitsView_CustomRowCellEdit;
            limitsView.CustomRowCellEditForEditing += limitsView_CustomRowCellEditForEditing;
            limitsView.ShowingEditor += limitsView_ShowingEditor;
            limitsView.ShownEditor += limitsView_ShownEditor;
            limitsView.CellValueChanged += limitsView_CellValueChanged;
            // 
            // colCategory
            // 
            colCategory.Caption = "Category";
            colCategory.FieldName = "Category";
            colCategory.MinWidth = 30;
            colCategory.Name = "colCategory";
            colCategory.OptionsColumn.AllowEdit = false;
            colCategory.OptionsColumn.AllowFocus = false;
            colCategory.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            colCategory.OptionsColumn.AllowSize = false;
            colCategory.OptionsColumn.FixedWidth = true;
            colCategory.Visible = true;
            colCategory.VisibleIndex = 0;
            colCategory.Width = 81;
            // 
            // colStatus
            // 
            colStatus.Caption = "Enabled";
            colStatus.ColumnEdit = limitsRepositoryTextEdit;
            colStatus.FieldName = "Status";
            colStatus.MinWidth = 17;
            colStatus.Name = "colStatus";
            colStatus.OptionsColumn.AllowEdit = false;
            colStatus.OptionsColumn.AllowMove = false;
            colStatus.OptionsColumn.AllowShowHide = false;
            colStatus.OptionsColumn.AllowSize = false;
            colStatus.OptionsColumn.FixedWidth = true;
            colStatus.OptionsColumn.ReadOnly = true;
            colStatus.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            colStatus.Visible = true;
            colStatus.VisibleIndex = 1;
            colStatus.Width = 81;
            // 
            // limitsRepositoryTextEdit
            // 
            limitsRepositoryTextEdit.AllowFocused = false;
            limitsRepositoryTextEdit.AutoHeight = false;
            limitsRepositoryTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            limitsRepositoryTextEdit.DisplayFormat.FormatString = "c";
            limitsRepositoryTextEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            limitsRepositoryTextEdit.EditFormat.FormatString = "c";
            limitsRepositoryTextEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            limitsRepositoryTextEdit.Name = "limitsRepositoryTextEdit";
            // 
            // colMin
            // 
            colMin.AppearanceCell.Options.UseTextOptions = true;
            colMin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colMin.Caption = "Min";
            colMin.ColumnEdit = repositoryItemNumberEdit;
            colMin.DisplayFormat.FormatString = "c";
            colMin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colMin.FieldName = "Min";
            colMin.MinWidth = 21;
            colMin.Name = "colMin";
            colMin.Visible = true;
            colMin.VisibleIndex = 2;
            colMin.Width = 81;
            // 
            // repositoryItemNumberEdit
            // 
            repositoryItemNumberEdit.AutoHeight = false;
            repositoryItemNumberEdit.EditFormat.FormatString = "c";
            repositoryItemNumberEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            repositoryItemNumberEdit.Name = "repositoryItemNumberEdit";
            repositoryItemNumberEdit.UseMaskAsDisplayFormat = true;
            // 
            // colMax
            // 
            colMax.AppearanceCell.Options.UseTextOptions = true;
            colMax.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colMax.Caption = "Max";
            colMax.ColumnEdit = repositoryItemNumberEdit;
            colMax.DisplayFormat.FormatString = "c";
            colMax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colMax.FieldName = "Max";
            colMax.MinWidth = 21;
            colMax.Name = "colMax";
            colMax.Visible = true;
            colMax.VisibleIndex = 3;
            colMax.Width = 81;
            // 
            // colPayout
            // 
            colPayout.AppearanceCell.Options.UseTextOptions = true;
            colPayout.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colPayout.Caption = "Payout";
            colPayout.ColumnEdit = repositoryItemNumberEdit;
            colPayout.DisplayFormat.FormatString = "c";
            colPayout.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colPayout.FieldName = "Payout";
            colPayout.MinWidth = 21;
            colPayout.Name = "colPayout";
            colPayout.Visible = true;
            colPayout.VisibleIndex = 4;
            colPayout.Width = 81;
            // 
            // colOdds
            // 
            colOdds.AppearanceCell.Options.UseTextOptions = true;
            colOdds.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            colOdds.Caption = "Odds";
            colOdds.ColumnEdit = repositoryItemNumberEdit;
            colOdds.DisplayFormat.FormatString = "0.00";
            colOdds.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colOdds.FieldName = "Odds";
            colOdds.MinWidth = 21;
            colOdds.Name = "colOdds";
            colOdds.Visible = true;
            colOdds.VisibleIndex = 5;
            colOdds.Width = 81;
            // 
            // limitsDefaultTextEdit
            // 
            limitsDefaultTextEdit.AutoHeight = false;
            limitsDefaultTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            limitsDefaultTextEdit.Name = "limitsDefaultTextEdit";
            // 
            // trackLimitsTopPanel
            // 
            trackLimitsTopPanel.Appearance.BackColor = Color.White;
            trackLimitsTopPanel.Appearance.Options.UseBackColor = true;
            trackLimitsTopPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            trackLimitsTopPanel.Controls.Add(btnTrackOdds);
            trackLimitsTopPanel.Controls.Add(txtGlobalMaxAmount);
            trackLimitsTopPanel.Controls.Add(txtPerRaceMax);
            trackLimitsTopPanel.Controls.Add(lblWeekLimit);
            trackLimitsTopPanel.Controls.Add(lblDayLimit);
            trackLimitsTopPanel.Controls.Add(lblHorseGlobalMaxToggle);
            trackLimitsTopPanel.Controls.Add(labelControl7);
            trackLimitsTopPanel.Controls.Add(labelControl6);
            trackLimitsTopPanel.Controls.Add(lblLimits);
            trackLimitsTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            trackLimitsTopPanel.Location = new Point(0, 0);
            trackLimitsTopPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            trackLimitsTopPanel.Name = "trackLimitsTopPanel";
            trackLimitsTopPanel.Size = new Size(523, 58);
            trackLimitsTopPanel.TabIndex = 1;
            // 
            // btnTrackOdds
            // 
            btnTrackOdds.Appearance.BackColor = Color.FromArgb(0, 192, 0);
            btnTrackOdds.Appearance.Options.UseBackColor = true;
            btnTrackOdds.Location = new Point(184, 37);
            btnTrackOdds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnTrackOdds.Name = "btnTrackOdds";
            btnTrackOdds.Size = new Size(103, 16);
            btnTrackOdds.TabIndex = 19;
            btnTrackOdds.Text = "Set Track Odds";
            btnTrackOdds.Click += btnTrackOdds_Click;
            // 
            // txtGlobalMaxAmount
            // 
            txtGlobalMaxAmount.Location = new Point(240, 18);
            txtGlobalMaxAmount.Name = "txtGlobalMaxAmount";
            txtGlobalMaxAmount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            txtGlobalMaxAmount.Properties.EditFormat.FormatString = "c";
            txtGlobalMaxAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            txtGlobalMaxAmount.Size = new Size(75, 18);
            txtGlobalMaxAmount.TabIndex = 17;
            txtGlobalMaxAmount.Click += txtGlobalMaxAmount_Click;
            // 
            // txtPerRaceMax
            // 
            txtPerRaceMax.Location = new Point(105, 36);
            txtPerRaceMax.Name = "txtPerRaceMax";
            txtPerRaceMax.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            txtPerRaceMax.Properties.EditFormat.FormatString = "c";
            txtPerRaceMax.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            txtPerRaceMax.Size = new Size(75, 18);
            txtPerRaceMax.TabIndex = 16;
            txtPerRaceMax.Click += txtPerRaceMax_Click;
            // 
            // lblWeekLimit
            // 
            lblWeekLimit.Appearance.Options.UseTextOptions = true;
            lblWeekLimit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            lblWeekLimit.Location = new Point(184, 20);
            lblWeekLimit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            lblWeekLimit.MinimumSize = new Size(43, 0);
            lblWeekLimit.Name = "lblWeekLimit";
            lblWeekLimit.Size = new Size(43, 13);
            lblWeekLimit.TabIndex = 7;
            lblWeekLimit.Text = "Week";
            lblWeekLimit.Click += lblWeekLimit_Click;
            // 
            // lblDayLimit
            // 
            lblDayLimit.Appearance.Options.UseTextOptions = true;
            lblDayLimit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            lblDayLimit.Location = new Point(141, 20);
            lblDayLimit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            lblDayLimit.MinimumSize = new Size(39, 0);
            lblDayLimit.Name = "lblDayLimit";
            lblDayLimit.Size = new Size(39, 13);
            lblDayLimit.TabIndex = 6;
            lblDayLimit.Text = "Day";
            lblDayLimit.Click += lblDayLimit_Click;
            // 
            // lblHorseGlobalMaxToggle
            // 
            lblHorseGlobalMaxToggle.Appearance.BackColor = Color.White;
            lblHorseGlobalMaxToggle.Appearance.BorderColor = Color.Silver;
            lblHorseGlobalMaxToggle.Appearance.ForeColor = Color.Silver;
            lblHorseGlobalMaxToggle.Appearance.Options.UseBackColor = true;
            lblHorseGlobalMaxToggle.Appearance.Options.UseBorderColor = true;
            lblHorseGlobalMaxToggle.Appearance.Options.UseForeColor = true;
            lblHorseGlobalMaxToggle.Appearance.Options.UseTextOptions = true;
            lblHorseGlobalMaxToggle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            lblHorseGlobalMaxToggle.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            lblHorseGlobalMaxToggle.Location = new Point(105, 20);
            lblHorseGlobalMaxToggle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            lblHorseGlobalMaxToggle.MinimumSize = new Size(30, 0);
            lblHorseGlobalMaxToggle.Name = "lblHorseGlobalMaxToggle";
            lblHorseGlobalMaxToggle.Size = new Size(30, 15);
            lblHorseGlobalMaxToggle.TabIndex = 14;
            lblHorseGlobalMaxToggle.Text = "Off";
            lblHorseGlobalMaxToggle.Click += lblHorseGlobalMaxToggle_Click;
            // 
            // labelControl7
            // 
            labelControl7.Location = new Point(3, 37);
            labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(66, 13);
            labelControl7.TabIndex = 2;
            labelControl7.Text = "Per Race Max";
            // 
            // labelControl6
            // 
            labelControl6.Location = new Point(3, 20);
            labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(83, 13);
            labelControl6.TabIndex = 1;
            labelControl6.Text = "Horse Global Max";
            // 
            // lblLimits
            // 
            lblLimits.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblLimits.Appearance.Options.UseFont = true;
            lblLimits.Location = new Point(3, 3);
            lblLimits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            lblLimits.Name = "lblLimits";
            lblLimits.Size = new Size(30, 12);
            lblLimits.TabIndex = 0;
            lblLimits.Text = "Limits";
            // 
            // profilePopupMenu
            // 
            profilePopupMenu.ImageScalingSize = new Size(20, 20);
            profilePopupMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuProfileClone, mnuProfileDelete, toolStripSeparator1, mnuProfileEdit });
            profilePopupMenu.Name = "profilePopupMenu";
            profilePopupMenu.Size = new Size(108, 76);
            profilePopupMenu.Closed += profilePopupMenu_Closed;
            profilePopupMenu.ItemClicked += profilePopupMenu_ItemClicked;
            // 
            // mnuProfileClone
            // 
            mnuProfileClone.Name = "mnuProfileClone";
            mnuProfileClone.Size = new Size(107, 22);
            mnuProfileClone.Text = "Clone";
            // 
            // mnuProfileDelete
            // 
            mnuProfileDelete.Name = "mnuProfileDelete";
            mnuProfileDelete.Size = new Size(107, 22);
            mnuProfileDelete.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(104, 6);
            // 
            // mnuProfileEdit
            // 
            mnuProfileEdit.Name = "mnuProfileEdit";
            mnuProfileEdit.Size = new Size(107, 22);
            mnuProfileEdit.Text = "Edit";
            // 
            // uiTimer
            // 
            uiTimer.Interval = 1000;
            uiTimer.Tick += uiTimer_Tick;
            // 
            // statusBar
            // 
            statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lblStatusPlayerCount, lblStatusProfileCount, lblStatusHasChanges, lblStatusSpace, lblStatusActiveProfile });
            statusBar.Location = new Point(0, 794);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(1158, 24);
            statusBar.TabIndex = 5;
            statusBar.Text = "Horse Profile Manager";
            // 
            // lblStatusPlayerCount
            // 
            lblStatusPlayerCount.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            lblStatusPlayerCount.Name = "lblStatusPlayerCount";
            lblStatusPlayerCount.Size = new Size(107, 19);
            lblStatusPlayerCount.Text = "Selected Players: 0";
            // 
            // lblStatusProfileCount
            // 
            lblStatusProfileCount.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            lblStatusProfileCount.Name = "lblStatusProfileCount";
            lblStatusProfileCount.Size = new Size(109, 19);
            lblStatusProfileCount.Text = "Selected Profiles: 0";
            // 
            // lblStatusHasChanges
            // 
            lblStatusHasChanges.BackColor = Color.White;
            lblStatusHasChanges.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            lblStatusHasChanges.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            lblStatusHasChanges.ForeColor = Color.FromArgb(8, 96, 69);
            lblStatusHasChanges.Name = "lblStatusHasChanges";
            lblStatusHasChanges.Size = new Size(76, 19);
            lblStatusHasChanges.Text = "No Changes";
            // 
            // lblStatusSpace
            // 
            lblStatusSpace.Name = "lblStatusSpace";
            lblStatusSpace.Size = new Size(742, 19);
            lblStatusSpace.Spring = true;
            // 
            // lblStatusActiveProfile
            // 
            lblStatusActiveProfile.BackColor = Color.Gainsboro;
            lblStatusActiveProfile.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            lblStatusActiveProfile.ForeColor = Color.IndianRed;
            lblStatusActiveProfile.Name = "lblStatusActiveProfile";
            lblStatusActiveProfile.Size = new Size(109, 19);
            lblStatusActiveProfile.Text = "Active Profile: N/A";
            // 
            // MainForm
            // 
            Appearance.BackColor = Color.White;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new Size(1158, 818);
            Controls.Add(statusBar);
            Controls.Add(limitsPanel);
            Controls.Add(playersPanel);
            Controls.Add(tracksPanel);
            Controls.Add(profilesPanel);
            Controls.Add(menuPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            IconOptions.Icon = (Icon)resources.GetObject("MainForm.IconOptions.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Horse Profile Manager";
            FormClosing += MainForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)modifiedTrackRepositoryTextEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackRepositoryTextEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuPanel).EndInit();
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSearchProfiles.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSearchPlayers.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)profileSearchImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerSearchImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPlayer.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtProfile.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)agentLookupCtl.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)agentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDefaultProfile.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)profilesPanel).EndInit();
            profilesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)profileGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)profileView).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_colProfileName).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_colIdRaceProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)profileCardView).EndInit();
            ((System.ComponentModel.ISupportInitialize)raceProfilesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)playersPanel).EndInit();
            playersPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)playerGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerView).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_colPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewCard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tracksPanel).EndInit();
            tracksPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)modifiedTracksGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)modifiedTracksView).EndInit();
            ((System.ComponentModel.ISupportInitialize)tracksGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)tracksView).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackTopPanel).EndInit();
            trackTopPanel.ResumeLayout(false);
            trackTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtSearchTrack.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtModifiedSearchTrack.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)limitsPanel).EndInit();
            limitsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)limitsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)limitsView).EndInit();
            ((System.ComponentModel.ISupportInitialize)limitsRepositoryTextEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemNumberEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)limitsDefaultTextEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackLimitsTopPanel).EndInit();
            trackLimitsTopPanel.ResumeLayout(false);
            trackLimitsTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtGlobalMaxAmount.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPerRaceMax.Properties).EndInit();
            profilePopupMenu.ResumeLayout(false);
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl menuPanel;
        private DevExpress.XtraEditors.LabelControl lblAgent;
        private DevExpress.XtraEditors.LabelControl lblPlayer;
        private DevExpress.XtraEditors.SimpleButton btnDefaultProfileAssign;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDefaultProfile;
        private DevExpress.XtraEditors.SimpleButton btnProfileNew;
        private DevExpress.XtraEditors.SimpleButton btnDefaultProfileNew;
        private DevExpress.XtraEditors.SimpleButton btnProfileAssign;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.PanelControl profilesPanel;
        private DevExpress.XtraEditors.PanelControl playersPanel;
        private DevExpress.XtraEditors.PanelControl tracksPanel;
        private DevExpress.XtraEditors.PanelControl limitsPanel;
        private System.Windows.Forms.BindingSource raceProfilesBindingSource;
        private DevExpress.XtraGrid.GridControl playerGrid;
        private DevExpress.XtraEditors.LookUpEdit agentLookupCtl;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.BindingSource agentBindingSource;
        private DevExpress.XtraGrid.Views.Layout.LayoutView playerView;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colPlayer;
        private DevExpress.XtraGrid.GridControl profileGrid;
        private DevExpress.XtraGrid.Views.Layout.LayoutView profileView;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colProfileName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colProfileName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard profileCardView;
        private System.Windows.Forms.ContextMenuStrip profilePopupMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuProfileClone;
        private System.Windows.Forms.ToolStripMenuItem mnuProfileDelete;
        private DevExpress.XtraGrid.GridControl tracksGrid;
        private DevExpress.XtraEditors.PanelControl trackTopPanel;
        private DevExpress.XtraEditors.LabelControl lblModifiedTrack;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colIdRaceProfile;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colIdRaceProfile;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit trackRepositoryTextEdit;
        private DevExpress.XtraGrid.Views.Tile.TileView tracksView;
        private DevExpress.XtraGrid.Columns.TileViewColumn colTrackName;
        private DevExpress.XtraGrid.Columns.TileViewColumn colIsEnabled;
        private DevExpress.XtraGrid.GridControl limitsGrid;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit limitsRepositoryTextEdit;
        private DevExpress.XtraEditors.PanelControl trackLimitsTopPanel;
        private DevExpress.XtraGrid.Views.Grid.GridView limitsView;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colMin;
        private DevExpress.XtraGrid.Columns.GridColumn colMax;
        private DevExpress.XtraGrid.Columns.GridColumn colPayout;
        private DevExpress.XtraGrid.Columns.GridColumn colOdds;
        private DevExpress.XtraEditors.LabelControl lblLimits;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lblHorseGlobalMaxToggle;
        private DevExpress.XtraEditors.LabelControl lblDayLimit;
        private DevExpress.XtraEditors.LabelControl lblWeekLimit;
        private DevExpress.XtraEditors.TextEdit txtProfile;
        private DevExpress.XtraEditors.TextEdit txtPlayer;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemNumberEdit;
        private DevExpress.XtraGrid.Columns.TileViewColumn colTrackSelected;
        private DevExpress.XtraEditors.SvgImageBox playerSearchImage;
        private DevExpress.XtraEditors.SvgImageBox profileSearchImage;
        private DevExpress.XtraGrid.Columns.TileViewColumn colIdTrack;
        private DevExpress.XtraGrid.GridControl modifiedTracksGrid;
        private TileView modifiedTracksView;
        private DevExpress.XtraGrid.Columns.TileViewColumn colModifiedTrackName;
        private DevExpress.XtraGrid.Columns.TileViewColumn colModifiedIsEnabled;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit modifiedTrackRepositoryTextEdit;
        private DevExpress.XtraEditors.LabelControl lblModifiedLimits;
        private DevExpress.XtraEditors.TextEdit txtPerRaceMax;
        private DevExpress.XtraEditors.TextEdit txtGlobalMaxAmount;
        private DevExpress.XtraGrid.Columns.TileViewColumn colModifiedTrackSelected;
        private DevExpress.XtraGrid.Columns.TileViewColumn colModifiedIdTrack;
        private DevExpress.XtraEditors.SimpleButton btnTrackOdds;
        private System.Windows.Forms.Timer uiTimer;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colProfile;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn profileId;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn playerId;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colPlayer;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraEditors.LabelControl lblGeneralLimits;
        private System.Windows.Forms.CheckBox chkGeneralSelectAll;
        private System.Windows.Forms.CheckBox chkModifiedSelectAll;
        private DevExpress.XtraEditors.SimpleButton btnResetTracks;
        private DevExpress.XtraEditors.ButtonEdit txtSearchPlayers;
        private DevExpress.XtraEditors.ButtonEdit txtSearchProfiles;
        private DevExpress.XtraEditors.ButtonEdit txtModifiedSearchTrack;
        private DevExpress.XtraEditors.ButtonEdit txtSearchTrack;
        private DevExpress.XtraEditors.SimpleButton btnClearPlayers;
        private DevExpress.XtraEditors.SimpleButton btnSelectAllPlayers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuProfileEdit;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusActiveProfile;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusPlayerCount;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusProfileCount;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusHasChanges;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusSpace;
        private DevExpress.XtraEditors.SimpleButton btnClearModifiedTracks;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit limitsDefaultTextEdit;
        private DevExpress.XtraEditors.SimpleButton btnClearGeneralTracks;
        private DevExpress.XtraEditors.SvgImageBox btnRefresh;
    }
}

