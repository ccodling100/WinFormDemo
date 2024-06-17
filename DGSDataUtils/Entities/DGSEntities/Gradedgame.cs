namespace DGSDataUtils.Entities.DGSEntities;

public partial class Gradedgame
{
    public int IdGame { get; set; }

    public string VisitorTeam { get; set; } = null!;

    public string HomeTeam { get; set; } = null!;

    public string IdSport { get; set; } = null!;

    public int IdLeague { get; set; }

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

    public bool OnLocal { get; set; }

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

    public virtual ICollection<Gradedgameactionbyagent> Gradedgameactionbyagents { get; set; } = new List<Gradedgameactionbyagent>();

    public virtual ICollection<Gradedgameaction> Gradedgameactions { get; set; } = new List<Gradedgameaction>();

    public virtual ICollection<Gradedgametntpropaction> Gradedgametntpropactions { get; set; } = new List<Gradedgametntpropaction>();

    public virtual ICollection<Gradedgametntpropbyagentlog> Gradedgametntpropbyagentlogs { get; set; } = new List<Gradedgametntpropbyagentlog>();

    public virtual ICollection<Gradedgametntpropbyagent> Gradedgametntpropbyagents { get; set; } = new List<Gradedgametntpropbyagent>();

    public virtual ICollection<Gradedgametnt> Gradedgametnts { get; set; } = new List<Gradedgametnt>();

    public virtual ICollection<Gradedgamevalue> Gradedgamevalues { get; set; } = new List<Gradedgamevalue>();

    public virtual ICollection<Gradedgamevaluesbyagentlog> Gradedgamevaluesbyagentlogs { get; set; } = new List<Gradedgamevaluesbyagentlog>();

    public virtual ICollection<Gradedgamevaluesbyagent> Gradedgamevaluesbyagents { get; set; } = new List<Gradedgamevaluesbyagent>();

    public virtual Event? IdEventNavigation { get; set; }
}
