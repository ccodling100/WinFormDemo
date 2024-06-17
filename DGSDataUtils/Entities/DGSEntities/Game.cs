namespace DGSDataUtils.Entities.DGSEntities;

public partial class Game
{
    public int IdGame { get; set; }

    public string VisitorTeam { get; set; } = null!;

    public string HomeTeam { get; set; } = null!;

    public string IdSport { get; set; } = null!;

    public short IdLeague { get; set; }

    public int IdGameType { get; set; }

    public short? IdEvent { get; set; }

    public DateTime GameDateTime { get; set; }

    public byte NormalGame { get; set; }

    public int VisitorNumber { get; set; }

    public int HomeNumber { get; set; }

    public string GameStat { get; set; } = null!;

    public bool Graded { get; set; }

    public bool HookUps { get; set; }

    public bool Online { get; set; }

    public bool? OnLocal { get; set; }

    public bool ShortGame { get; set; }

    public DateTime EventDate { get; set; }

    public bool DateChanged { get; set; }

    public bool TimeChanged { get; set; }

    public byte Period { get; set; }

    public int FamilyGame { get; set; }

    public int ParentGame { get; set; }

    public bool HasChildren { get; set; }

    public int? VisitorScore { get; set; }

    public int? HomeScore { get; set; }

    public string? VisitorPitcher { get; set; }

    public string? HomePitcher { get; set; }

    public DateTime? GradedDate { get; set; }

    public short NumTeams { get; set; }

    public byte PitcherChanged { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public int? IdTeamVisitor { get; set; }

    public int? IdTeamHome { get; set; }

    public short? IdBannerType { get; set; }

    public string? Description { get; set; }

    public bool? AcceptAutoChanges { get; set; }

    public virtual ICollection<BrbetRadarIdmap> BrbetRadarIdmaps { get; set; } = new List<BrbetRadarIdmap>();

    public virtual DbseventIdmap? DbseventIdmap { get; set; }

    public virtual ICollection<Gameactionbyagent> Gameactionbyagents { get; set; } = new List<Gameactionbyagent>();

    public virtual ICollection<Gameaction> Gameactions { get; set; } = new List<Gameaction>();

    public virtual ICollection<Gametntpropaction> Gametntpropactions { get; set; } = new List<Gametntpropaction>();

    public virtual ICollection<Gametntpropbyagentlog> Gametntpropbyagentlogs { get; set; } = new List<Gametntpropbyagentlog>();

    public virtual ICollection<Gametntpropbyagent> Gametntpropbyagents { get; set; } = new List<Gametntpropbyagent>();

    public virtual ICollection<Gametnt> Gametnts { get; set; } = new List<Gametnt>();

    public virtual ICollection<Gamevalue> Gamevalues { get; set; } = new List<Gamevalue>();

    public virtual ICollection<Gamevaluesbyagent> Gamevaluesbyagents { get; set; } = new List<Gamevaluesbyagent>();

    public virtual ICollection<Gamevalueslog> Gamevalueslogs { get; set; } = new List<Gamevalueslog>();

    public virtual Event? IdEventNavigation { get; set; }

    public virtual Gametype IdGameTypeNavigation { get; set; } = null!;

    public virtual League IdLeagueNavigation { get; set; } = null!;

    public virtual Sport IdSportNavigation { get; set; } = null!;

    public virtual Team? IdTeamHomeNavigation { get; set; }

    public virtual Team? IdTeamVisitorNavigation { get; set; }

    public virtual ICollection<Pendingwagerdetail> Pendingwagerdetails { get; set; } = new List<Pendingwagerdetail>();

    public virtual ICollection<Pitcherchangelog> Pitcherchangelogs { get; set; } = new List<Pitcherchangelog>();

    public virtual ICollection<SmtoagentGameValueAdjustment> SmtoagentGameValueAdjustments { get; set; } = new List<SmtoagentGameValueAdjustment>();

    public virtual ICollection<SmtoexcludedGame> SmtoexcludedGames { get; set; } = new List<SmtoexcludedGame>();

    public virtual ICollection<SmtogameValueAdjustment> SmtogameValueAdjustments { get; set; } = new List<SmtogameValueAdjustment>();

    public virtual ICollection<SmtologArchive> SmtologArchives { get; set; } = new List<SmtologArchive>();

    public virtual ICollection<Smtolog> Smtologs { get; set; } = new List<Smtolog>();

    public virtual ICollection<SmtoscoreLog> SmtoscoreLogs { get; set; } = new List<SmtoscoreLog>();

    public virtual ICollection<Systemdbsgamestatchange> Systemdbsgamestatchanges { get; set; } = new List<Systemdbsgamestatchange>();

    public virtual ICollection<Systemdbspitchingchange> Systemdbspitchingchanges { get; set; } = new List<Systemdbspitchingchange>();

    public virtual ICollection<Systemdbsscore> Systemdbsscores { get; set; } = new List<Systemdbsscore>();

    public virtual ICollection<Wagerdetail> Wagerdetails { get; set; } = new List<Wagerdetail>();
}
