namespace DGSDataUtils.Entities.DGSEntities;

public partial class SmtolineTypeBookLink
{
    public int IdLink { get; set; }

    public short IdLineType { get; set; }

    public string? IdSport { get; set; }

    public short? IdLeague { get; set; }

    public short IdBook { get; set; }

    public short IdStatus { get; set; }

    public bool? IsActive { get; set; }

    public DateTime LastUpdate { get; set; }

    public bool? SyncSpreads { get; set; }

    public bool? SyncTotals { get; set; }

    public bool? SyncMoneylines { get; set; }

    public bool? SyncSpreadOdds { get; set; }

    public bool? SyncTotalOdds { get; set; }

    public bool? ApplyOddsBySport { get; set; }

    public virtual Smtobook IdBookNavigation { get; set; } = null!;

    public virtual League? IdLeagueNavigation { get; set; }

    public virtual Linetype IdLineTypeNavigation { get; set; } = null!;

    public virtual Sport? IdSportNavigation { get; set; }

    public virtual Smtostatus IdStatusNavigation { get; set; } = null!;

    public virtual ICollection<Smtolog> Smtologs { get; set; } = new List<Smtolog>();
}
