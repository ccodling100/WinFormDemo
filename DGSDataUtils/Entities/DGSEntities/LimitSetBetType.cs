namespace DGSDataUtils.Entities.DGSEntities;

public partial class LimitSetBetType
{
    public int LimitSetId { get; set; }

    public byte BetType { get; set; }

    public decimal MaxStake { get; set; }

    public decimal MaxStakeOnline { get; set; }

    public decimal MaxPayoutOdds { get; set; }

    public decimal MaxPayoutCap { get; set; }

    public decimal AddPayoutOdds { get; set; }

    public bool ToteBet { get; set; }

    public decimal ToteThreshold { get; set; }

    public bool BetTypeEnabled { get; set; }

    public decimal Rebate { get; set; }

    public decimal RebateOnline { get; set; }

    public decimal MinStake { get; set; }

    public decimal MinStakeOnline { get; set; }

    public virtual LimitSet LimitSet { get; set; } = null!;
}
