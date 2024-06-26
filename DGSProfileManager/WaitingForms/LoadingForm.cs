using System;
using DevExpress.XtraWaitForm;

namespace DGSProfileManager
{
    public partial class LoadingForm : WaitForm 
    {
        public LoadingForm() {
            InitializeComponent();
            this.progressPanel1.AutoSize = true;
        }

        #region Overrides

        public override void SetCaption(string caption) {
            base.SetCaption(caption);
            this.progressPanel1.Caption = caption;
        }
        public override void SetDescription(string description) {
            base.SetDescription(description);
            this.progressPanel1.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg) {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum WaitFormCommand {}
    }
}