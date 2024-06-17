namespace DGSDataUtils.Entities.DGSEntities;

public partial class Itmeet
{
    public string MeetingCode { get; set; } = null!;

    public bool Valid { get; set; }

    public int? TrackId { get; set; }

    public DateTime? RaceDate { get; set; }

    public short CurrentEasternBias { get; set; }
}
