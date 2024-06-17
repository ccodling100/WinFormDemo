using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DGSDataUtils.Contexts;

namespace DGSReportManager
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private DGSDbContext _dgsCtx;
        private ProMgrDbContext _proMgrCtx;
        
        public MainForm()
        {
            InitializeComponent();
            InitializeApplication();
        }

        private void InitializeApplication()
        {
            Session.InitAppSettings();
            Session.InitSession();
            
            _dgsCtx = new DGSDbContext(Session.DgsConnectionstring);
            _proMgrCtx = new ProMgrDbContext(Session.ProMgrConnectionString);
            _proMgrCtx.ChangeTracker.LazyLoadingEnabled = false;
            
            dtStartDate.DateTime = DateTime.Now.AddMonths(-1);
            dtEndDate.DateTime = DateTime.Now;
            
            LoadAgents();
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
        }
    }
}
