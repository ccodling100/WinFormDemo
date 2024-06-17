namespace DGSDataUtils.Entities.DGSEntities;

public partial class Leagueregion
{
    public short IdleagueRegion { get; set; }

    public string Description { get; set; } = null!;

    public short RegionOrder { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual ICollection<Leagueregionlang> Leagueregionlangs { get; set; } = new List<Leagueregionlang>();

    public virtual ICollection<League> Leagues { get; set; } = new List<League>();
}
