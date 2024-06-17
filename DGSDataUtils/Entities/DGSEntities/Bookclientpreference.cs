namespace DGSDataUtils.Entities.DGSEntities;

public partial class Bookclientpreference
{
    public short IdBook { get; set; }

    public bool AllCanadianLine { get; set; }

    public bool BuyPointsInPeriods { get; set; }

    public bool? DisplayBothTeamsOnTotals { get; set; }

    public bool MlbhalvesUseLp { get; set; }

    public bool UseTrueOdds { get; set; }

    public bool RoundType { get; set; }

    /// <summary>
    /// R=Risk, W=Win, A=WagerAmount
    /// </summary>
    public string MaxWagerCheck { get; set; } = null!;

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Book IdBookNavigation { get; set; } = null!;
}
