namespace DGSDataUtils.Entities.DGSEntities;

public partial class AggLimitWork
{
    public int Key { get; set; }

    public int AccountId { get; set; }

    public int RaceId { get; set; }

    public byte TicketType { get; set; }

    public string Selections { get; set; } = null!;

    public decimal Amount { get; set; }

    public int TicketId { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual RaceTicketMain Ticket { get; set; } = null!;
}
