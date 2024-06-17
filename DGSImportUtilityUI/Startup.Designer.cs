namespace DGSImportUtilityUI
{
    partial class Startup
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSourceConnection = new Label();
            lblDestConnection = new Label();
            txtSourceConnection = new TextBox();
            txtDestConnection = new TextBox();
            progressBar = new ProgressBar();
            lblImportProgress = new Label();
            lblTable = new Label();
            btnImport = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblSourceConnection
            // 
            lblSourceConnection.AutoSize = true;
            lblSourceConnection.Location = new Point(64, 29);
            lblSourceConnection.Name = "lblSourceConnection";
            lblSourceConnection.Size = new Size(80, 15);
            lblSourceConnection.TabIndex = 0;
            lblSourceConnection.Text = "DGS Database";
            // 
            // lblDestConnection
            // 
            lblDestConnection.AutoSize = true;
            lblDestConnection.Location = new Point(27, 67);
            lblDestConnection.Name = "lblDestConnection";
            lblDestConnection.Size = new Size(117, 15);
            lblDestConnection.TabIndex = 1;
            lblDestConnection.Text = "Profile Mgr Database";
            // 
            // txtSourceConnection
            // 
            txtSourceConnection.Location = new Point(178, 29);
            txtSourceConnection.Name = "txtSourceConnection";
            txtSourceConnection.Size = new Size(396, 23);
            txtSourceConnection.TabIndex = 2;
            // 
            // txtDestConnection
            // 
            txtDestConnection.Location = new Point(178, 67);
            txtDestConnection.Name = "txtDestConnection";
            txtDestConnection.Size = new Size(396, 23);
            txtDestConnection.TabIndex = 3;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(178, 141);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(396, 23);
            progressBar.TabIndex = 4;
            // 
            // lblImportProgress
            // 
            lblImportProgress.AutoSize = true;
            lblImportProgress.Location = new Point(53, 141);
            lblImportProgress.Name = "lblImportProgress";
            lblImportProgress.Size = new Size(91, 15);
            lblImportProgress.TabIndex = 5;
            lblImportProgress.Text = "Import Progress";
            // 
            // lblTable
            // 
            lblTable.AutoSize = true;
            lblTable.Location = new Point(178, 110);
            lblTable.Name = "lblTable";
            lblTable.Size = new Size(122, 15);
            lblTable.TabIndex = 6;
            lblTable.Text = "Processing Table: N/A";
            // 
            // btnImport
            // 
            btnImport.Location = new Point(499, 210);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(75, 23);
            btnImport.TabIndex = 7;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(418, 210);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Startup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(600, 263);
            Controls.Add(btnCancel);
            Controls.Add(btnImport);
            Controls.Add(lblTable);
            Controls.Add(lblImportProgress);
            Controls.Add(progressBar);
            Controls.Add(txtDestConnection);
            Controls.Add(txtSourceConnection);
            Controls.Add(lblDestConnection);
            Controls.Add(lblSourceConnection);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Startup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DGS Data Importer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSourceConnection;
        private Label lblDestConnection;
        private TextBox txtSourceConnection;
        private TextBox txtDestConnection;
        private ProgressBar progressBar;
        private Label lblImportProgress;
        private Label lblTable;
        private Button btnImport;
        private Button btnCancel;
    }
}
