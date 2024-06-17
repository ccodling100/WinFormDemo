namespace DGSDataUtils.Entities.DGSEntities;

public partial class TicketHoldRelease
{
    public int TicketNumber { get; set; }

    public int ReleaseId { get; set; }

    public int ManagerId { get; set; }

    public DateTime HoldDateTime { get; set; }

    public string HoldReason { get; set; } = null!;

    public int ReleaseManagerId { get; set; }

    public DateTime ReleaseDateTime { get; set; }

    public string ReleaseReason { get; set; } = null!;

    public virtual TerminalManager Manager { get; set; } = null!;

    public virtual TerminalManager ReleaseManager { get; set; } = null!;
}
