using System.ComponentModel.DataAnnotations.Schema;

namespace DGSDataUtils.Entities.ProMgrEntities
{
    [Table("IBET_RaceProfiles")]
    public class DtoRaceProfile
    {
        public int IdRaceProfile { get; set; }
        public string ProfileName { get; set; }
        public int HorseGlobalMax { get; set; }
        public int GlobalMaxTime { get; set; }
        [Column(TypeName="money")]
        public decimal GlobalMaxAmount { get; set; }
        [Column(TypeName="money")]
        public decimal DefaultPerRaceMaxWin { get; set; }
        public virtual DtoAgentDefault? IbetAgentDefault { get; set; }

        // public virtual DtoProfileMap? IbetProfileMap { get; set; }
    }
}