namespace DGSDataUtils.Entities.DGSEntities;

public partial class RaceChart
{
    public int RaceId { get; set; }

    public byte BetType { get; set; }

    public string Selections { get; set; } = null!;

    public decimal Amount { get; set; }

    public int BetCount { get; set; }
}
