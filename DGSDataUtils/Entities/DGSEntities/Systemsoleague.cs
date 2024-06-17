namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemsoleague
{
    public int LeagueId { get; set; }

    public string Description { get; set; } = null!;

    public string Abbreviation { get; set; } = null!;

    public virtual Systemsosport? Systemsosport { get; set; }
}
