namespace DGSDataUtils.Entities.DGSEntities;

public partial class ManualScoreQ
{
    public int TicketId { get; set; }

    public virtual RaceTicketMain Ticket { get; set; } = null!;
}
