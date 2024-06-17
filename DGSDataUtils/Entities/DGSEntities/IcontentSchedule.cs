namespace DGSDataUtils.Entities.DGSEntities;

public partial class IcontentSchedule
{
    public long IdSchedule { get; set; }

    public string? Title { get; set; }

    public int? Week { get; set; }

    public string? Dgssports { get; set; }

    public bool? Enable { get; set; }

    public DateTime? RegDate { get; set; }

    public DateTime? OpenTime { get; set; }

    public DateTime? CloseTime { get; set; }

    public short? Status { get; set; }
}
