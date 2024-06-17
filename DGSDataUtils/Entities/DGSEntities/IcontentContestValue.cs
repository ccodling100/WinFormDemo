namespace DGSDataUtils.Entities.DGSEntities;

public partial class IcontentContestValue
{
    public long IdContent { get; set; }

    public long? IdScheduleDetails { get; set; }

    public string? IdUser { get; set; }

    public string? SelectionDescription { get; set; }

    public DateTime? Regdate { get; set; }

    public string? ValueType { get; set; }

    public string? ValueSelected { get; set; }

    public string? SideChoose { get; set; }

    public string? Status { get; set; }

    public long? IdSchedule { get; set; }

    public decimal? TieBreaker { get; set; }

    public short? Result { get; set; }
}
