namespace DGSDataUtils.Entities.DGSEntities;

public partial class Gamevalue
{
    public short IdLineType { get; set; }

    public int IdGame { get; set; }

    public int? VisitorOdds { get; set; }

    public int? HomeOdds { get; set; }

    public float? TotalOver { get; set; }

    public int? OverOdds { get; set; }

    public float? TotalUnder { get; set; }

    public int? UnderOdds { get; set; }

    public float? VisitorSpread { get; set; }

    public int? VisitorSpreadOdds { get; set; }

    public float? HomeSpread { get; set; }

    public int? HomeSpreadOdds { get; set; }

    public float? VisitorSpecial { get; set; }

    public int? VisitorSpecialOdds { get; set; }

    public float? HomeSpecial { get; set; }

    public int? HomeSpecialOdds { get; set; }

    public bool? SendToLs { get; set; }

    public bool HideGame { get; set; }

    public bool? SyncSpread { get; set; }

    public bool? SyncTotal { get; set; }

    public bool? SyncMl { get; set; }

    public bool BoldSpread { get; set; }

    public bool BoldTotal { get; set; }

    public bool BoldMl { get; set; }

    public virtual Game IdGameNavigation { get; set; } = null!;

    public virtual Linetype IdLineTypeNavigation { get; set; } = null!;
}
