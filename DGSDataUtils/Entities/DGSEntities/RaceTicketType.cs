namespace DGSDataUtils.Entities.DGSEntities;

public partial class RaceTicketType
{
    public byte TicketType { get; set; }

    public string ShortDesc { get; set; } = null!;

    public string LongDesc { get; set; } = null!;

    public byte NumLegs { get; set; }

    public byte BaseTicketType { get; set; }

    public string? BaseShortDesc { get; set; }
}
