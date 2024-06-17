namespace DGSDataUtils.Entities.DGSEntities;

public partial class Gradedgametntpropbyagent
{
    public int IdAgent { get; set; }

    public int IdGame { get; set; }

    public int TeamNumber { get; set; }

    public int? Odds { get; set; }

    public bool HideGame { get; set; }

    public bool Follow { get; set; }

    public decimal? ActionRisk { get; set; }

    public decimal? ActionWin { get; set; }

    public int? ActionCount { get; set; }

    public decimal? MasterActionRisk { get; set; }

    public decimal? MasterActionWin { get; set; }

    public int? MasterActionCount { get; set; }

    public decimal? SumActionRisk { get; set; }

    public decimal? SumActionWin { get; set; }

    public int? SumActionCount { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Agent IdAgentNavigation { get; set; } = null!;

    public virtual Gradedgame IdGameNavigation { get; set; } = null!;
}
