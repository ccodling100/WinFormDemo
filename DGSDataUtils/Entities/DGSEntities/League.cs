namespace DGSDataUtils.Entities.DGSEntities;

public partial class League
{
    public short IdLeague { get; set; }

    public string IdSport { get; set; } = null!;

    public short IdLeagueRegion { get; set; }

    public string Description { get; set; } = null!;

    public string ShortDescription { get; set; } = null!;

    public short LeagueOrder { get; set; }

    public bool TeamFkrequired { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual ICollection<Event> EventIdLeagueNavigations { get; set; } = new List<Event>();

    public virtual ICollection<Event> EventIdTargetLeagueNavigations { get; set; } = new List<Event>();

    public virtual ICollection<Game> Games { get; set; } = new List<Game>();

    public virtual Leagueregion IdLeagueRegionNavigation { get; set; } = null!;

    public virtual Sport IdSportNavigation { get; set; } = null!;

    public virtual ICollection<Leaguelang> Leaguelangs { get; set; } = new List<Leaguelang>();

    public virtual ICollection<SmtogameValueAdjustment> SmtogameValueAdjustments { get; set; } = new List<SmtogameValueAdjustment>();

    public virtual ICollection<SmtoleagueAdjustment> SmtoleagueAdjustments { get; set; } = new List<SmtoleagueAdjustment>();

    public virtual ICollection<Smtoleague> SmtoleagueIdLeagueInGameNavigations { get; set; } = new List<Smtoleague>();

    public virtual ICollection<Smtoleague> SmtoleagueIdLeagueNavigations { get; set; } = new List<Smtoleague>();

    public virtual ICollection<Smtolimit> Smtolimits { get; set; } = new List<Smtolimit>();

    public virtual ICollection<SmtolineTypeBookLink> SmtolineTypeBookLinks { get; set; } = new List<SmtolineTypeBookLink>();

    public virtual ICollection<SmtolinksLog> SmtolinksLogs { get; set; } = new List<SmtolinksLog>();

    public virtual SmtoscoringExcludedLeague? SmtoscoringExcludedLeague { get; set; }

    public virtual ICollection<Systembetradarcategory> Systembetradarcategories { get; set; } = new List<Systembetradarcategory>();

    public virtual ICollection<Systembetradartournament> SystembetradartournamentIdLeagueCsNavigations { get; set; } = new List<Systembetradartournament>();

    public virtual ICollection<Systembetradartournament> SystembetradartournamentIdLeagueNavigations { get; set; } = new List<Systembetradartournament>();

    public virtual ICollection<Systemdbssport> Systemdbssports { get; set; } = new List<Systemdbssport>();

    public virtual ICollection<Systemsosport> SystemsosportIdLeagueNavigations { get; set; } = new List<Systemsosport>();

    public virtual ICollection<Systemsosport> SystemsosportIdPropLeagueNavigations { get; set; } = new List<Systemsosport>();

    public virtual ICollection<Webrowdetail> Webrowdetails { get; set; } = new List<Webrowdetail>();
}
