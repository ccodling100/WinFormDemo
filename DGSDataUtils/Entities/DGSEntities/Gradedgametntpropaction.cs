namespace DGSDataUtils.Entities.DGSEntities;

public partial class Gradedgametntpropaction
{
    public int IdGame { get; set; }

    public short IdLineType { get; set; }

    public int TeamNumber { get; set; }

    public float? Odds { get; set; }

    public decimal? ActionRisk { get; set; }

    public decimal? ActionWin { get; set; }

    public float? ActionCount { get; set; }

    public decimal? MasterActionRisk { get; set; }

    public decimal? MasterActionWin { get; set; }

    public float? MasterActionCount { get; set; }

    public decimal? SumActionRisk { get; set; }

    public decimal? SumActionWin { get; set; }

    public float? SumActionCount { get; set; }

    public bool? SendToLs { get; set; }

    public bool HideGame { get; set; }

    public bool? SyncMl { get; set; }

    public bool BoldMl { get; set; }

    public virtual Gradedgame IdGameNavigation { get; set; } = null!;
}
