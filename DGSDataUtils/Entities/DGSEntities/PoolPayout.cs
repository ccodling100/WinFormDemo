namespace DGSDataUtils.Entities.DGSEntities;

public partial class PoolPayout
{
    public int RaceId { get; set; }

    public byte PoolType { get; set; }

    public string Entries { get; set; } = null!;

    public byte NumCorrect { get; set; }

    public decimal Payoff { get; set; }

    public virtual Race Race { get; set; } = null!;
}
