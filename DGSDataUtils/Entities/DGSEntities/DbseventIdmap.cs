namespace DGSDataUtils.Entities.DGSEntities;

public partial class DbseventIdmap
{
    public int DbseventId { get; set; }

    public int IdGame { get; set; }

    public byte DbsgameType { get; set; }

    public int LeagueId { get; set; }

    public virtual Game IdGameNavigation { get; set; } = null!;

    public virtual Systemdbsleague League { get; set; } = null!;
}
