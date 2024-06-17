namespace DGSDataUtils.Entities.DGSEntities;

public partial class Language
{
    public byte IdLanguage { get; set; }

    public string LangDesc { get; set; } = null!;

    public string? CultureInfo { get; set; }

    public virtual ICollection<Agent> Agents { get; set; } = new List<Agent>();

    public virtual ICollection<Bannertypelang> Bannertypelangs { get; set; } = new List<Bannertypelang>();

    public virtual ICollection<GameLang> GameLangs { get; set; } = new List<GameLang>();

    public virtual ICollection<GameTntlang> GameTntlangs { get; set; } = new List<GameTntlang>();

    public virtual ICollection<Leaguelang> Leaguelangs { get; set; } = new List<Leaguelang>();

    public virtual ICollection<Leagueregionlang> Leagueregionlangs { get; set; } = new List<Leagueregionlang>();

    public virtual ICollection<Menureportitemslang> Menureportitemslangs { get; set; } = new List<Menureportitemslang>();

    public virtual ICollection<Menureportmenulang> Menureportmenulangs { get; set; } = new List<Menureportmenulang>();

    public virtual ICollection<Menureportparamslang> Menureportparamslangs { get; set; } = new List<Menureportparamslang>();

    public virtual ICollection<Pitcherlang> Pitcherlangs { get; set; } = new List<Pitcherlang>();

    public virtual ICollection<Player> Players { get; set; } = new List<Player>();

    public virtual ICollection<Teamlang> Teamlangs { get; set; } = new List<Teamlang>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public virtual ICollection<Wagertypegrouplang> Wagertypegrouplangs { get; set; } = new List<Wagertypegrouplang>();

    public virtual ICollection<Wagertypelang> Wagertypelangs { get; set; } = new List<Wagertypelang>();

    public virtual ICollection<Webrowlang> Webrowlangs { get; set; } = new List<Webrowlang>();

    public virtual ICollection<User> IdUsers { get; set; } = new List<User>();
}
