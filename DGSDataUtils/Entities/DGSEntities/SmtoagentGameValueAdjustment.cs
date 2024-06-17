namespace DGSDataUtils.Entities.DGSEntities;

public partial class SmtoagentGameValueAdjustment
{
    public int IdAdjustment { get; set; }

    public int IdAgent { get; set; }

    public int IdGame { get; set; }

    public int VisitorOdds { get; set; }

    public int HomeOdds { get; set; }

    public float TotalOver { get; set; }

    public int OverOdds { get; set; }

    public float TotalUnder { get; set; }

    public int UnderOdds { get; set; }

    public float VisitorSpread { get; set; }

    public int VisitorSpreadOdds { get; set; }

    public float HomeSpread { get; set; }

    public int HomeSpreadOdds { get; set; }

    public float VisitorSpecial { get; set; }

    public int VisitorSpecialOdds { get; set; }

    public float HomeSpecial { get; set; }

    public int HomeSpecialOdds { get; set; }

    public short IdStatus { get; set; }

    public bool? IsActive { get; set; }

    public DateTime LastUpdate { get; set; }

    public virtual Agent IdAgentNavigation { get; set; } = null!;

    public virtual Game IdGameNavigation { get; set; } = null!;

    public virtual Smtostatus IdStatusNavigation { get; set; } = null!;
}
