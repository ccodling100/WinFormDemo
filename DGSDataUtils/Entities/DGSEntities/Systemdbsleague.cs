namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemdbsleague
{
    public int LeagueId { get; set; }

    public string Description { get; set; } = null!;

    public string Abbreviation { get; set; } = null!;

    public virtual ICollection<DbseventIdmap> DbseventIdmaps { get; set; } = new List<DbseventIdmap>();

    public virtual Systemdbssport? Systemdbssport { get; set; }
}
