namespace DGSDataUtils.Entities.DGSEntities;

public partial class TicketHold
{
    public int TicketNumber { get; set; }

    public int ManagerId { get; set; }

    public DateTime HoldDateTime { get; set; }

    public string HoldReason { get; set; } = null!;

    public virtual TerminalManager Manager { get; set; } = null!;

    public virtual TicketMain TicketNumberNavigation { get; set; } = null!;
}
