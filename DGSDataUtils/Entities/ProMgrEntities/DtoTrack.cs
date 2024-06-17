using System.ComponentModel.DataAnnotations.Schema;

namespace DGSDataUtils.Entities.ProMgrEntities
{
    [Table("IBET_Track")]
    public class DtoTrack
    {
        public int IdTrack { get; set; }
        public string TrackName { get; set; }
        public string TrackCode { get; set; }
        public virtual DtoTrackLimit? IbetTrackLimit { get; set; }
    }
}