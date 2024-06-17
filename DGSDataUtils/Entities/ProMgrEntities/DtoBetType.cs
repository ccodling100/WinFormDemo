using System.ComponentModel.DataAnnotations.Schema;

namespace DGSDataUtils.Entities.ProMgrEntities
{
    [Table("IBET_BetTypes")]
    public class DtoBetType
    {
        public int IdBetType { get; set; }
        public string BetName { get; set; }
        //public virtual ICollection<DtoTrackLimit> IbetTrackLimits { get; set; } = new List<DtoTrackLimit>();
    }
}