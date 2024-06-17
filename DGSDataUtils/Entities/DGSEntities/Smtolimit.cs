namespace DGSDataUtils.Entities.DGSEntities;

public partial class Smtolimit
{
    public int IdLimit { get; set; }

    public short IdLineType { get; set; }

    public string? IdSport { get; set; }

    public short? IdLeague { get; set; }

    public int MoneyLines { get; set; }

    public float Totals { get; set; }

    public int TotalOdds { get; set; }

    public float Spreads { get; set; }

    public int SpreadOdds { get; set; }

    public bool DoClearOdds { get; set; }

    public short IdStatus { get; set; }

    public bool IsActive { get; set; }

    public DateTime LastUpdate { get; set; }

    public virtual League? IdLeagueNavigation { get; set; }

    public virtual Linetype IdLineTypeNavigation { get; set; } = null!;

    public virtual Sport? IdSportNavigation { get; set; }

    public virtual Smtostatus IdStatusNavigation { get; set; } = null!;
}
