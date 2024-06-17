namespace DGSDataUtils.Entities.DGSEntities;

public partial class BrbetRadarIdmap
{
    public int IdSystemBetRadar { get; set; }

    public int BetRadarId { get; set; }

    public int IdGame { get; set; }

    public virtual Game IdGameNavigation { get; set; } = null!;
}
