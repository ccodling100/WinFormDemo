using System.ComponentModel.DataAnnotations.Schema;

namespace DGSDataUtils.Entities.ProMgrEntities
{
    [Table("IBET_ProfileMaps")]
    public class DtoProfileMap
    {
        public int IdProfileMap { get; set; }
        public int IdSportProfile { get; set; }
        public int? IdPlayer { get; set; }
        public int? IdRaceProfile { get; set; }
        //public virtual DtoRaceProfile IdRaceProfileNavigation { get; set; } = null!;
    }
}