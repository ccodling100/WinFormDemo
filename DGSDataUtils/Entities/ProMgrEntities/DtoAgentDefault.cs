using System.ComponentModel.DataAnnotations.Schema;

namespace DGSDataUtils.Entities.ProMgrEntities
{
    [Table("IBET_AgentDefaults")]
    public class DtoAgentDefault
    {
        public int IdAgent { get; set; }
        public int? IdRaceProfile { get; set; }
        //public virtual DtoRaceProfile IdRaceProfileNavigation { get; set; } = null!;
    }
}