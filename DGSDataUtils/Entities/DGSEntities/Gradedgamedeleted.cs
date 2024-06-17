namespace DGSDataUtils.Entities.DGSEntities;

public partial class Gradedgamedeleted
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

    public DateTime LastUpdate { get; set; }

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
}
