namespace DGSReportManager
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
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition3 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition4 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            colModifiedTrackName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            colModifiedIsEnabled = new DevExpress.XtraGrid.Columns.TileViewColumn();
            modifiedTrackRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            lblDateRange = new DevExpress.XtraEditors.LabelControl();
            lblFromDate = new DevExpress.XtraEditors.LabelControl();
            lblToDate = new DevExpress.XtraEditors.LabelControl();
            dtStartDate = new DevExpress.XtraEditors.DateEdit();
            dtEndDate = new DevExpress.XtraEditors.DateEdit();
            agentLookupCtl = new DevExpress.XtraEditors.LookUpEdit();
            lblAgent = new DevExpress.XtraEditors.LabelControl();
            lstSelectedAgentList = new DevExpress.XtraEditors.ListBoxControl();
            betsGrid = new DevExpress.XtraGrid.GridControl();
            profileView = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            colProfileName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            layoutViewField_colProfileName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            colIdRaceProfile = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            layoutViewField_colIdRaceProfile = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            profileCardView = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
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
            modifiedTracksGrid = new DevExpress.XtraGrid.GridControl();
            modifiedTracksView = new DevExpress.XtraGrid.Views.Tile.TileView();
            colModifiedTrackSelected = new DevExpress.XtraGrid.Columns.TileViewColumn();
            colModifiedIdTrack = new DevExpress.XtraGrid.Columns.TileViewColumn();
            btnClearAgents = new DevExpress.XtraEditors.SimpleButton();
            btnAllPlayers = new DevExpress.XtraEditors.SimpleButton();
            chkGrandTotalOnly = new System.Windows.Forms.CheckBox();
            lblPlayers = new DevExpress.XtraEditors.LabelControl();
            btnClearPlayers = new DevExpress.XtraEditors.SimpleButton();
            playerLookupCtl = new DevExpress.XtraEditors.LookUpEdit();
            trackLookupCtrl = new DevExpress.XtraEditors.LookUpEdit();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            lblTracks = new DevExpress.XtraEditors.LabelControl();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)modifiedTrackRepositoryTextEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtStartDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtStartDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtEndDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtEndDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agentLookupCtl.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lstSelectedAgentList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)betsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profileView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_colProfileName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_colIdRaceProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profileCardView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_colPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewCard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modifiedTracksGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modifiedTracksView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerLookupCtl.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackLookupCtrl.Properties).BeginInit();
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
            // lblDateRange
            // 
            lblDateRange.Location = new System.Drawing.Point(12, 11);
            lblDateRange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            lblDateRange.Name = "lblDateRange";
            lblDateRange.Size = new System.Drawing.Size(186, 13);
            lblDateRange.TabIndex = 1;
            lblDateRange.Text = "Choose the date range of your report:";
            // 
            // lblFromDate
            // 
            lblFromDate.Location = new System.Drawing.Point(12, 28);
            lblFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new System.Drawing.Size(23, 13);
            lblFromDate.TabIndex = 2;
            lblFromDate.Text = "Date";
            // 
            // lblToDate
            // 
            lblToDate.Location = new System.Drawing.Point(147, 28);
            lblToDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new System.Drawing.Size(10, 13);
            lblToDate.TabIndex = 3;
            lblToDate.Text = "to";
            // 
            // dtStartDate
            // 
            dtStartDate.EditValue = null;
            dtStartDate.Location = new System.Drawing.Point(41, 29);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtStartDate.Size = new System.Drawing.Size(100, 20);
            dtStartDate.TabIndex = 4;
            // 
            // dtEndDate
            // 
            dtEndDate.EditValue = null;
            dtEndDate.Location = new System.Drawing.Point(163, 29);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtEndDate.Size = new System.Drawing.Size(100, 20);
            dtEndDate.TabIndex = 5;
            // 
            // agentLookupCtl
            // 
            agentLookupCtl.EditValue = "";
            agentLookupCtl.EnterMoveNextControl = true;
            agentLookupCtl.Location = new System.Drawing.Point(12, 84);
            agentLookupCtl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            agentLookupCtl.Name = "agentLookupCtl";
            agentLookupCtl.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.True;
            agentLookupCtl.Properties.BeepOnError = true;
            agentLookupCtl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            agentLookupCtl.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Agent1", "Agent", 38, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default) });
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
            agentLookupCtl.Size = new System.Drawing.Size(261, 20);
            agentLookupCtl.TabIndex = 6;
            // 
            // lblAgent
            // 
            lblAgent.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblAgent.Appearance.Options.UseFont = true;
            lblAgent.Location = new System.Drawing.Point(12, 65);
            lblAgent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            lblAgent.Name = "lblAgent";
            lblAgent.Size = new System.Drawing.Size(40, 13);
            lblAgent.TabIndex = 7;
            lblAgent.Text = "Agents";
            // 
            // lstSelectedAgentList
            // 
            lstSelectedAgentList.Location = new System.Drawing.Point(14, 112);
            lstSelectedAgentList.Name = "lstSelectedAgentList";
            lstSelectedAgentList.Size = new System.Drawing.Size(259, 522);
            lstSelectedAgentList.TabIndex = 8;
            // 
            // betsGrid
            // 
            betsGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            betsGrid.Location = new System.Drawing.Point(12, 640);
            betsGrid.MainView = profileView;
            betsGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            betsGrid.Name = "betsGrid";
            betsGrid.Size = new System.Drawing.Size(259, 152);
            betsGrid.TabIndex = 14;
            betsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { profileView });
            // 
            // profileView
            // 
            profileView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            profileView.CardHorzInterval = 1;
            profileView.CardMinSize = new System.Drawing.Size(150, 20);
            profileView.CardVertInterval = 1;
            profileView.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] { colProfileName, colIdRaceProfile });
            profileView.DetailHeight = 284;
            profileView.GridControl = betsGrid;
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
            layoutViewField_colProfileName.Location = new System.Drawing.Point(0, 0);
            layoutViewField_colProfileName.Name = "layoutViewField_colProfileName";
            layoutViewField_colProfileName.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            layoutViewField_colProfileName.Size = new System.Drawing.Size(89, 22);
            layoutViewField_colProfileName.TextSize = new System.Drawing.Size(0, 0);
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
            layoutViewField_colIdRaceProfile.Location = new System.Drawing.Point(0, 22);
            layoutViewField_colIdRaceProfile.Name = "layoutViewField_colIdRaceProfile";
            layoutViewField_colIdRaceProfile.Size = new System.Drawing.Size(97, 24);
            layoutViewField_colIdRaceProfile.TextSize = new System.Drawing.Size(75, 16);
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
            // playerGrid
            // 
            playerGrid.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.False;
            playerGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            playerGrid.Location = new System.Drawing.Point(290, 112);
            playerGrid.MainView = playerView;
            playerGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            playerGrid.Name = "playerGrid";
            playerGrid.Size = new System.Drawing.Size(300, 680);
            playerGrid.TabIndex = 15;
            playerGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { playerView });
            // 
            // playerView
            // 
            playerView.Appearance.SelectionFrame.BackColor = System.Drawing.Color.FromArgb(255, 255, 128);
            playerView.Appearance.SelectionFrame.Options.UseBackColor = true;
            playerView.Appearance.ViewBackground.BorderColor = System.Drawing.Color.Transparent;
            playerView.Appearance.ViewBackground.Options.UseBorderColor = true;
            playerView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            playerView.CardHorzInterval = 1;
            playerView.CardMinSize = new System.Drawing.Size(94, 41);
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
            layoutViewField_colPlayer.Location = new System.Drawing.Point(0, 0);
            layoutViewField_colPlayer.Name = "layoutViewField_colPlayer";
            layoutViewField_colPlayer.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            layoutViewField_colPlayer.Size = new System.Drawing.Size(110, 22);
            layoutViewField_colPlayer.TextSize = new System.Drawing.Size(0, 0);
            layoutViewField_colPlayer.TextVisible = false;
            // 
            // colProfile
            // 
            colProfile.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            layoutViewField_layoutViewColumn1.Location = new System.Drawing.Point(0, 22);
            layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1";
            layoutViewField_layoutViewColumn1.Size = new System.Drawing.Size(110, 26);
            layoutViewField_layoutViewColumn1.TextSize = new System.Drawing.Size(0, 0);
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
            layoutViewField_layoutViewColumn1_1.Location = new System.Drawing.Point(0, 0);
            layoutViewField_layoutViewColumn1_1.Name = "layoutViewField_layoutViewColumn1_1";
            layoutViewField_layoutViewColumn1_1.Size = new System.Drawing.Size(134, 48);
            layoutViewField_layoutViewColumn1_1.TextSize = new System.Drawing.Size(100, 16);
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
            layoutViewField_layoutViewColumn1_2.Location = new System.Drawing.Point(0, 0);
            layoutViewField_layoutViewColumn1_2.Name = "layoutViewField_layoutViewColumn1_2";
            layoutViewField_layoutViewColumn1_2.Size = new System.Drawing.Size(134, 48);
            layoutViewField_layoutViewColumn1_2.TextSize = new System.Drawing.Size(100, 16);
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
            // modifiedTracksGrid
            // 
            modifiedTracksGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            modifiedTracksGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            modifiedTracksGrid.EmbeddedNavigator.ShowToolTips = false;
            modifiedTracksGrid.Location = new System.Drawing.Point(610, 112);
            modifiedTracksGrid.MainView = modifiedTracksView;
            modifiedTracksGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            modifiedTracksGrid.Name = "modifiedTracksGrid";
            modifiedTracksGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { modifiedTrackRepositoryTextEdit });
            modifiedTracksGrid.Size = new System.Drawing.Size(300, 680);
            modifiedTracksGrid.TabIndex = 16;
            modifiedTracksGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { modifiedTracksView });
            // 
            // modifiedTracksView
            // 
            modifiedTracksView.Appearance.EmptySpace.BackColor = System.Drawing.Color.White;
            modifiedTracksView.Appearance.EmptySpace.BorderColor = System.Drawing.Color.Transparent;
            modifiedTracksView.Appearance.EmptySpace.Options.UseBackColor = true;
            modifiedTracksView.Appearance.ItemNormal.BorderColor = System.Drawing.Color.Transparent;
            modifiedTracksView.Appearance.ItemNormal.ForeColor = System.Drawing.Color.White;
            modifiedTracksView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            modifiedTracksView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colModifiedTrackName, colModifiedIsEnabled, colModifiedTrackSelected, colModifiedIdTrack });
            modifiedTracksView.DetailHeight = 122;
            modifiedTracksView.GridControl = modifiedTracksGrid;
            modifiedTracksView.Name = "modifiedTracksView";
            modifiedTracksView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Tile.TileViewEditingMode.Disabled;
            modifiedTracksView.OptionsBehavior.ReadOnly = true;
            modifiedTracksView.OptionsTiles.AllowPressAnimation = false;
            modifiedTracksView.OptionsTiles.ColumnCount = 2;
            modifiedTracksView.OptionsTiles.HighlightFocusedTileStyle = DevExpress.XtraGrid.Views.Tile.HighlightFocusedTileStyle.None;
            modifiedTracksView.OptionsTiles.IndentBetweenGroups = 1;
            modifiedTracksView.OptionsTiles.IndentBetweenItems = 0;
            modifiedTracksView.OptionsTiles.ItemBorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            modifiedTracksView.OptionsTiles.ItemPadding = new System.Windows.Forms.Padding(0);
            modifiedTracksView.OptionsTiles.ItemSize = new System.Drawing.Size(175, 25);
            modifiedTracksView.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            modifiedTracksView.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            modifiedTracksView.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            modifiedTracksView.OptionsTiles.RowCount = 0;
            modifiedTracksView.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            modifiedTracksView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] { new DevExpress.XtraGrid.Columns.GridColumnSortInfo(colModifiedTrackName, DevExpress.Data.ColumnSortOrder.Ascending) });
            modifiedTracksView.TileColumns.Add(tableColumnDefinition3);
            modifiedTracksView.TileColumns.Add(tableColumnDefinition4);
            modifiedTracksView.TileRows.Add(tableRowDefinition2);
            tileViewItemElement3.Column = colModifiedTrackName;
            tileViewItemElement3.Name = "lblTrackName";
            tileViewItemElement3.StretchVertical = true;
            tileViewItemElement3.Text = "colTrackName";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement3.TextLocation = new System.Drawing.Point(5, 0);
            tileViewItemElement4.Column = colModifiedIsEnabled;
            tileViewItemElement4.ColumnIndex = 1;
            tileViewItemElement4.Name = "lblTrackEnabled";
            tileViewItemElement4.Text = "colIsEnabled";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            modifiedTracksView.TileTemplate.Add(tileViewItemElement3);
            modifiedTracksView.TileTemplate.Add(tileViewItemElement4);
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
            // btnClearAgents
            // 
            btnClearAgents.Location = new System.Drawing.Point(58, 65);
            btnClearAgents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnClearAgents.Name = "btnClearAgents";
            btnClearAgents.Size = new System.Drawing.Size(40, 15);
            btnClearAgents.TabIndex = 18;
            btnClearAgents.Text = "CLEAR";
            // 
            // btnAllPlayers
            // 
            btnAllPlayers.Location = new System.Drawing.Point(338, 65);
            btnAllPlayers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnAllPlayers.Name = "btnAllPlayers";
            btnAllPlayers.Size = new System.Drawing.Size(40, 15);
            btnAllPlayers.TabIndex = 19;
            btnAllPlayers.Text = "ALL";
            // 
            // chkGrandTotalOnly
            // 
            chkGrandTotalOnly.AutoSize = true;
            chkGrandTotalOnly.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            chkGrandTotalOnly.Location = new System.Drawing.Point(111, 65);
            chkGrandTotalOnly.Name = "chkGrandTotalOnly";
            chkGrandTotalOnly.Size = new System.Drawing.Size(107, 17);
            chkGrandTotalOnly.TabIndex = 20;
            chkGrandTotalOnly.Text = "Grand Total Only";
            chkGrandTotalOnly.UseVisualStyleBackColor = true;
            // 
            // lblPlayers
            // 
            lblPlayers.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPlayers.Appearance.Options.UseFont = true;
            lblPlayers.Location = new System.Drawing.Point(290, 65);
            lblPlayers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            lblPlayers.Name = "lblPlayers";
            lblPlayers.Size = new System.Drawing.Size(42, 13);
            lblPlayers.TabIndex = 21;
            lblPlayers.Text = "Players";
            // 
            // btnClearPlayers
            // 
            btnClearPlayers.Location = new System.Drawing.Point(394, 65);
            btnClearPlayers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnClearPlayers.Name = "btnClearPlayers";
            btnClearPlayers.Size = new System.Drawing.Size(40, 15);
            btnClearPlayers.TabIndex = 22;
            btnClearPlayers.Text = "CLEAR";
            // 
            // playerLookupCtl
            // 
            playerLookupCtl.EditValue = "";
            playerLookupCtl.EnterMoveNextControl = true;
            playerLookupCtl.Location = new System.Drawing.Point(290, 84);
            playerLookupCtl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            playerLookupCtl.Name = "playerLookupCtl";
            playerLookupCtl.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.True;
            playerLookupCtl.Properties.BeepOnError = true;
            playerLookupCtl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            playerLookupCtl.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Agent1", "Agent", 38, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default) });
            playerLookupCtl.Properties.DisplayMember = "Agent1";
            playerLookupCtl.Properties.DropDownRows = 8;
            playerLookupCtl.Properties.HideSelection = false;
            playerLookupCtl.Properties.ImmediatePopup = true;
            playerLookupCtl.Properties.NullText = "";
            playerLookupCtl.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
            playerLookupCtl.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            playerLookupCtl.Properties.SelectFirstRowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
            playerLookupCtl.Properties.ShowFooter = false;
            playerLookupCtl.Properties.ShowHeader = false;
            playerLookupCtl.Properties.ValidateOnEnterKey = true;
            playerLookupCtl.Properties.ValueMember = "Agent1";
            playerLookupCtl.Size = new System.Drawing.Size(300, 20);
            playerLookupCtl.TabIndex = 23;
            // 
            // trackLookupCtrl
            // 
            trackLookupCtrl.EditValue = "";
            trackLookupCtrl.EnterMoveNextControl = true;
            trackLookupCtrl.Location = new System.Drawing.Point(610, 84);
            trackLookupCtrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            trackLookupCtrl.Name = "trackLookupCtrl";
            trackLookupCtrl.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.True;
            trackLookupCtrl.Properties.BeepOnError = true;
            trackLookupCtrl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            trackLookupCtrl.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Agent1", "Agent", 38, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default) });
            trackLookupCtrl.Properties.DisplayMember = "Agent1";
            trackLookupCtrl.Properties.DropDownRows = 8;
            trackLookupCtrl.Properties.HideSelection = false;
            trackLookupCtrl.Properties.ImmediatePopup = true;
            trackLookupCtrl.Properties.NullText = "";
            trackLookupCtrl.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
            trackLookupCtrl.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            trackLookupCtrl.Properties.SelectFirstRowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
            trackLookupCtrl.Properties.ShowFooter = false;
            trackLookupCtrl.Properties.ShowHeader = false;
            trackLookupCtrl.Properties.ValidateOnEnterKey = true;
            trackLookupCtrl.Properties.ValueMember = "Agent1";
            trackLookupCtrl.Size = new System.Drawing.Size(300, 20);
            trackLookupCtrl.TabIndex = 27;
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new System.Drawing.Point(714, 65);
            simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(40, 15);
            simpleButton1.TabIndex = 26;
            simpleButton1.Text = "CLEAR";
            // 
            // lblTracks
            // 
            lblTracks.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTracks.Appearance.Options.UseFont = true;
            lblTracks.Location = new System.Drawing.Point(610, 65);
            lblTracks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            lblTracks.Name = "lblTracks";
            lblTracks.Size = new System.Drawing.Size(38, 13);
            lblTracks.TabIndex = 25;
            lblTracks.Text = "Tracks";
            // 
            // simpleButton2
            // 
            simpleButton2.Location = new System.Drawing.Point(658, 65);
            simpleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new System.Drawing.Size(40, 15);
            simpleButton2.TabIndex = 24;
            simpleButton2.Text = "ALL";
            // 
            // btnPrint
            // 
            btnPrint.Appearance.BackColor = System.Drawing.Color.RoyalBlue;
            btnPrint.Appearance.ForeColor = System.Drawing.Color.White;
            btnPrint.Appearance.Options.UseBackColor = true;
            btnPrint.Appearance.Options.UseForeColor = true;
            btnPrint.Appearance.Options.UseTextOptions = true;
            btnPrint.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            btnPrint.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnPrint.AppearanceDisabled.ForeColor = System.Drawing.Color.Gray;
            btnPrint.AppearanceDisabled.Options.UseBackColor = true;
            btnPrint.AppearanceDisabled.Options.UseForeColor = true;
            btnPrint.AppearanceDisabled.Options.UseTextOptions = true;
            btnPrint.Location = new System.Drawing.Point(837, 18);
            btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new System.Drawing.Size(73, 23);
            btnPrint.TabIndex = 28;
            btnPrint.Text = "Print";
            btnPrint.Click += btnPrint_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(925, 802);
            Controls.Add(btnPrint);
            Controls.Add(trackLookupCtrl);
            Controls.Add(simpleButton1);
            Controls.Add(lblTracks);
            Controls.Add(simpleButton2);
            Controls.Add(playerLookupCtl);
            Controls.Add(btnClearPlayers);
            Controls.Add(lblPlayers);
            Controls.Add(chkGrandTotalOnly);
            Controls.Add(btnAllPlayers);
            Controls.Add(btnClearAgents);
            Controls.Add(modifiedTracksGrid);
            Controls.Add(playerGrid);
            Controls.Add(betsGrid);
            Controls.Add(lstSelectedAgentList);
            Controls.Add(agentLookupCtl);
            Controls.Add(lblAgent);
            Controls.Add(dtEndDate);
            Controls.Add(dtStartDate);
            Controls.Add(lblToDate);
            Controls.Add(lblFromDate);
            Controls.Add(lblDateRange);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Horse Report Manager";
            ((System.ComponentModel.ISupportInitialize)modifiedTrackRepositoryTextEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtStartDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtStartDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtEndDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtEndDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)agentLookupCtl.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lstSelectedAgentList).EndInit();
            ((System.ComponentModel.ISupportInitialize)betsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)profileView).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_colProfileName).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_colIdRaceProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)profileCardView).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerView).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_colPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewCard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)modifiedTracksGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)modifiedTracksView).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerLookupCtl.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackLookupCtrl.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblDateRange;
        private DevExpress.XtraEditors.LabelControl lblFromDate;
        private DevExpress.XtraEditors.LabelControl lblToDate;
        private DevExpress.XtraEditors.DateEdit dtStartDate;
        private DevExpress.XtraEditors.DateEdit dtEndDate;
        private DevExpress.XtraEditors.LookUpEdit agentLookupCtl;
        private DevExpress.XtraEditors.LabelControl lblAgent;
        private DevExpress.XtraEditors.ListBoxControl lstSelectedAgentList;
        private DevExpress.XtraGrid.GridControl betsGrid;
        private DevExpress.XtraGrid.Views.Layout.LayoutView profileView;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colProfileName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colProfileName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colIdRaceProfile;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colIdRaceProfile;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard profileCardView;
        private DevExpress.XtraGrid.GridControl playerGrid;
        private DevExpress.XtraGrid.Views.Layout.LayoutView playerView;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colPlayer;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colPlayer;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colProfile;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn profileId;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn playerId;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraGrid.GridControl modifiedTracksGrid;
        private DevExpress.XtraGrid.Views.Tile.TileView modifiedTracksView;
        private DevExpress.XtraGrid.Columns.TileViewColumn colModifiedTrackName;
        private DevExpress.XtraGrid.Columns.TileViewColumn colModifiedIsEnabled;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit modifiedTrackRepositoryTextEdit;
        private DevExpress.XtraGrid.Columns.TileViewColumn colModifiedTrackSelected;
        private DevExpress.XtraGrid.Columns.TileViewColumn colModifiedIdTrack;
        private DevExpress.XtraEditors.SimpleButton btnClearAgents;
        private DevExpress.XtraEditors.SimpleButton btnAllPlayers;
        private System.Windows.Forms.CheckBox chkGrandTotalOnly;
        private DevExpress.XtraEditors.LabelControl lblPlayers;
        private DevExpress.XtraEditors.SimpleButton btnClearPlayers;
        private DevExpress.XtraEditors.LookUpEdit playerLookupCtl;
        private DevExpress.XtraEditors.LookUpEdit trackLookupCtrl;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl lblTracks;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
    }
}

