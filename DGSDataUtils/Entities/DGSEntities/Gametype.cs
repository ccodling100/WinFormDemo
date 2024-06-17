namespace DGSDataUtils.Entities.DGSEntities;

public partial class Gametype
{
    public int IdGameType { get; set; }

    public string Short { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool AllowHookUps { get; set; }

    public bool AllowBuyPoints { get; set; }

    public int BkColor { get; set; }

    public int FkColor { get; set; }

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual ICollection<Game> Games { get; set; } = new List<Game>();

    public virtual ICollection<Juicerebate> Juicerebates { get; set; } = new List<Juicerebate>();

    public virtual ICollection<Oddsbysport> Oddsbysports { get; set; } = new List<Oddsbysport>();

    public virtual ICollection<Playerprofilegametype> Playerprofilegametypes { get; set; } = new List<Playerprofilegametype>();

    public virtual ICollection<Playerprofilegametypesport> Playerprofilegametypesports { get; set; } = new List<Playerprofilegametypesport>();

    public virtual ICollection<Playerprofilelimitsdetail> Playerprofilelimitsdetails { get; set; } = new List<Playerprofilelimitsdetail>();

    public virtual ICollection<Smtoleague> SmtoleagueIdGameTypeInGameNavigations { get; set; } = new List<Smtoleague>();

    public virtual ICollection<Smtoleague> SmtoleagueIdGameTypeNavigations { get; set; } = new List<Smtoleague>();

    public virtual ICollection<Systembetradarcategory> Systembetradarcategories { get; set; } = new List<Systembetradarcategory>();

    public virtual ICollection<Systembetradartournament> Systembetradartournaments { get; set; } = new List<Systembetradartournament>();
}
