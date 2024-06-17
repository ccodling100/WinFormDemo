namespace DGSDataUtils.Entities.DGSEntities;

public partial class TicketDetail
{
    public int TicketNumber { get; set; }

    public int IdWager { get; set; }

    public virtual TicketMain TicketNumberNavigation { get; set; } = null!;
}
