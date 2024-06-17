namespace DGSDataUtils.Entities.DGSEntities;

public partial class Smtolog
{
    public int IdLog { get; set; }

    public short IdLineType { get; set; }

    public int IdGame { get; set; }

    public int? ParentIdLog { get; set; }

    public int? VisitorOdds { get; set; }

    public int? VisitorOddsAdjustment { get; set; }

    public int? HomeOdds { get; set; }

    public int? HomeOddsAdjustment { get; set; }

    public float? TotalOver { get; set; }

    public float? TotalOverAdjustment { get; set; }

    public int? OverOdds { get; set; }

    public int? OverOddsAdjustment { get; set; }

    public float? TotalUnder { get; set; }

    public float? TotalUnderAdjustment { get; set; }

    public int? UnderOdds { get; set; }

    public int? UnderOddsAdjustment { get; set; }

    public float? VisitorSpread { get; set; }

    public float? VisitorSpreadAdjustment { get; set; }

    public int? VisitorSpreadOdds { get; set; }

    public int? VisitorSpreadOddsAdjustment { get; set; }

    public float? HomeSpread { get; set; }

    public float? HomeSpreadAdjustment { get; set; }

    public int? HomeSpreadOdds { get; set; }

    public int? HomeSpreadOddsAdjustment { get; set; }

    public float? VisitorSpecial { get; set; }

    public float? VisitorSpecialAdjustment { get; set; }

    public int? VisitorSpecialOdds { get; set; }

    public int? VisitorSpecialOddsAdjustment { get; set; }

    public float? HomeSpecial { get; set; }

    public float? HomeSpecialAdjustment { get; set; }

    public int? HomeSpecialOdds { get; set; }

    public int? HomeSpecialOddsAdjustment { get; set; }

    public short? IdBook { get; set; }

    public int? IdLink { get; set; }

    public int? IdAdjustment { get; set; }

    public bool? IsVisitorOddsChanged { get; set; }

    public bool? IsHomeOddsChanged { get; set; }

    public bool? IsOverChanged { get; set; }

    public bool? IsOverOddsChanged { get; set; }

    public bool? IsUnderChanged { get; set; }

    public bool? IsUnderOddsChanged { get; set; }

    public bool? IsVisitorSpreadChanged { get; set; }

    public bool? IsVisitorSpreadOddsChanged { get; set; }

    public bool? IsHomeSpreadChanged { get; set; }

    public bool? IsHomeSpreadOddsChanged { get; set; }

    public bool? IsVisitorSpecialChanged { get; set; }

    public bool? IsVisitorSpecialOddsChanged { get; set; }

    public bool? IsHomeSpecialChanged { get; set; }

    public bool? IsHomeSpecialOddsChanged { get; set; }

    public short? IdReason { get; set; }

    public DateTime? TimeStamp { get; set; }

    public virtual SmtogameValueAdjustment? IdAdjustmentNavigation { get; set; }

    public virtual Smtobook? IdBookNavigation { get; set; }

    public virtual Game IdGameNavigation { get; set; } = null!;

    public virtual Linetype IdLineTypeNavigation { get; set; } = null!;

    public virtual SmtolineTypeBookLink? IdLinkNavigation { get; set; }
}
