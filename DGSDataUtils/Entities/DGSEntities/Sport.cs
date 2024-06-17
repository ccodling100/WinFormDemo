namespace DGSDataUtils.Entities.DGSEntities;

public partial class Sport
{
    public string IdSport { get; set; } = null!;

    public string SportName { get; set; } = null!;

    public byte SportOrder { get; set; }

    public bool OnlineStatus { get; set; }

    public bool LocalStatus { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual ICollection<Gamerelatedoption> Gamerelatedoptions { get; set; } = new List<Gamerelatedoption>();

    public virtual ICollection<Game> Games { get; set; } = new List<Game>();

    public virtual ICollection<Juicerebate> Juicerebates { get; set; } = new List<Juicerebate>();

    public virtual ICollection<League> Leagues { get; set; } = new List<League>();

    public virtual ICollection<Oddsbysport> Oddsbysports { get; set; } = new List<Oddsbysport>();

    public virtual ICollection<Oddsdefault> Oddsdefaults { get; set; } = new List<Oddsdefault>();

    public virtual ICollection<Period> Periods { get; set; } = new List<Period>();

    public virtual ICollection<Playerprofilegametypesport> Playerprofilegametypesports { get; set; } = new List<Playerprofilegametypesport>();

    public virtual ICollection<Playerprofilelimitsdetail> Playerprofilelimitsdetails { get; set; } = new List<Playerprofilelimitsdetail>();

    public virtual ICollection<Playerprofileparlaybasicsport> Playerprofileparlaybasicsports { get; set; } = new List<Playerprofileparlaybasicsport>();

    public virtual ICollection<Playerprofileparlaylimitdetail> Playerprofileparlaylimitdetails { get; set; } = new List<Playerprofileparlaylimitdetail>();

    public virtual ICollection<Playerprofilestraightlimit> Playerprofilestraightlimits { get; set; } = new List<Playerprofilestraightlimit>();

    public virtual ICollection<SmtocustomPeriod> SmtocustomPeriods { get; set; } = new List<SmtocustomPeriod>();

    public virtual ICollection<SmtoeuropeanSport> SmtoeuropeanSports { get; set; } = new List<SmtoeuropeanSport>();

    public virtual ICollection<SmtogameValueAdjustment> SmtogameValueAdjustments { get; set; } = new List<SmtogameValueAdjustment>();

    public virtual ICollection<SmtoleagueAdjustment> SmtoleagueAdjustments { get; set; } = new List<SmtoleagueAdjustment>();

    public virtual ICollection<Smtolimit> Smtolimits { get; set; } = new List<Smtolimit>();

    public virtual ICollection<SmtolineTypeBookLink> SmtolineTypeBookLinks { get; set; } = new List<SmtolineTypeBookLink>();

    public virtual ICollection<SmtolinksLog> SmtolinksLogs { get; set; } = new List<SmtolinksLog>();

    public virtual ICollection<Smtosport> Smtosports { get; set; } = new List<Smtosport>();

    public virtual ICollection<Systemchangedline> Systemchangedlines { get; set; } = new List<Systemchangedline>();

    public virtual ICollection<Team> Teams { get; set; } = new List<Team>();

    public virtual ICollection<Wagertypesport> Wagertypesports { get; set; } = new List<Wagertypesport>();
}
