namespace DGSDataUtils.Entities.DGSEntities;

public partial class Gamevaluesbyagent
{
    public int IdAgent { get; set; }

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

    public bool HideGame { get; set; }

    public bool HideSpread { get; set; }

    public bool HideTotal { get; set; }

    public bool HideMoneyLine { get; set; }

    public bool FollowSpread { get; set; }

    public bool FollowTotal { get; set; }

    public bool FollowMoney { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Agent IdAgentNavigation { get; set; } = null!;

    public virtual Game IdGameNavigation { get; set; } = null!;
}
