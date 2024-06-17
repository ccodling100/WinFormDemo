namespace DGSDataUtils.Entities.DGSEntities;

public partial class RaceTicketDetail
{
    public int TicketDetailId { get; set; }

    public int TicketId { get; set; }

    public byte TicketPlay { get; set; }

    public int RaceId { get; set; }

    public byte EntryNum { get; set; }

    public virtual Race Race { get; set; } = null!;

    public virtual RaceTicketMain Ticket { get; set; } = null!;
}
