namespace DGSDataUtils.Entities.DGSEntities;

public partial class SmtoexcludedGame
{
    public int IdExcludedGame { get; set; }

    public int IdGame { get; set; }

    public string LineTypeIds { get; set; } = null!;

    public bool? ExcludeSpreads { get; set; }

    public bool? ExcludeTotals { get; set; }

    public bool? ExcludeMoneylines { get; set; }

    public bool? IsActive { get; set; }

    public short IdStatus { get; set; }

    public DateTime LastUpdate { get; set; }

    public bool? ExcludeSpreadOdds { get; set; }

    public bool? ExcludeTotalOdds { get; set; }

    public virtual Game IdGameNavigation { get; set; } = null!;

    public virtual Smtostatus IdStatusNavigation { get; set; } = null!;
}
