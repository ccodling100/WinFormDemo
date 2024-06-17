namespace DGSDataUtils.Entities.DGSEntities;

public partial class EntryPastPerf
{
    public int RaceId { get; set; }

    public int EntryId { get; set; }

    public string PastPerfXml { get; set; } = null!;
}
