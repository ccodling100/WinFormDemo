using System.ComponentModel.DataAnnotations.Schema;

namespace DGSDataUtils.Entities.ProMgrEntities
{
    [Table("IBET_TrackLimits")]
    public class DtoTrackLimit
    {
        public int IdRaceProfile { get; set; }
        public int IdTrack { get; set; }
        public bool IsEnabled { get; set; }
        [Column(TypeName="money")]
        public decimal PerRaceMaxWin { get; set; }
        public int IdBetType { get; set; }
        [Column(TypeName="money")]
        public decimal MinBet { get; set; }
        [Column(TypeName="money")]
        public decimal MaxBet { get; set; }
        [Column(TypeName="money")]
        public decimal PerBetMaxWin { get; set; }
        [Column(TypeName="money")]
        public decimal MaxPayoutOdds { get; set; }
        public virtual DtoBetType IdBetTypeNavigation { get; set; } = null!;
        public virtual DtoTrack IdTrackNavigation { get; set; } = null!;
        public virtual DtoRaceProfile IdRaceProfileNavigation { get; set; } = null!;
    }
}