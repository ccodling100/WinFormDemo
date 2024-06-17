namespace DGSDataUtils.Entities.DGSEntities;

public partial class Gametnt
{
    public int IdGame { get; set; }

    public int TeamNumber { get; set; }

    public string TeamName { get; set; } = null!;

    public byte Result { get; set; }

    public bool Graded { get; set; }

    public int? IdTeam { get; set; }

    public virtual Game IdGameNavigation { get; set; } = null!;

    public virtual Team? IdTeamNavigation { get; set; }
}
