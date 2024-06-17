namespace DGSDataUtils.Entities.DGSEntities;

public partial class SmtogameValueAdjustment
{
    public int IdAdjustment { get; set; }

    public short IdLineType { get; set; }

    public string? IdSport { get; set; }

    public short? IdLeague { get; set; }

    public int? IdGame { get; set; }

    public int VisitorOdds { get; set; }

    public int HomeOdds { get; set; }

    public float TotalOver { get; set; }

    public int OverOdds { get; set; }

    public float TotalUnder { get; set; }

    public int UnderOdds { get; set; }

    public float VisitorSpread { get; set; }

    public int VisitorSpreadOdds { get; set; }

    public float HomeSpread { get; set; }

    public int HomeSpreadOdds { get; set; }

    public float VisitorSpecial { get; set; }

    public int VisitorSpecialOdds { get; set; }

    public float HomeSpecial { get; set; }

    public int HomeSpecialOdds { get; set; }

    public short IdStatus { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsAutoDeleted { get; set; }

    public DateTime LastUpdate { get; set; }

    public virtual Game? IdGameNavigation { get; set; }

    public virtual League? IdLeagueNavigation { get; set; }

    public virtual Linetype IdLineTypeNavigation { get; set; } = null!;

    public virtual Sport? IdSportNavigation { get; set; }

    public virtual Smtostatus IdStatusNavigation { get; set; } = null!;

    public virtual ICollection<Smtolog> Smtologs { get; set; } = new List<Smtolog>();
}
