namespace DGSDataUtils.Entities.DGSEntities;

public partial class Gamestatpubqueue
{
    public int IdGameStatPubQueue { get; set; }

    public int IdGame { get; set; }

    public string IdSport { get; set; } = null!;

    public DateTime GameDateTime { get; set; }

    public int VisitorNumber { get; set; }

    public string GameStat { get; set; } = null!;

    public bool HookUps { get; set; }

    public bool Online { get; set; }

    public bool? OnLocal { get; set; }

    public bool ShortGame { get; set; }

    public DateTime EventDate { get; set; }

    public bool DateChanged { get; set; }

    public bool TimeChanged { get; set; }

    public int? VisitorScore { get; set; }

    public int? HomeScore { get; set; }

    public string? VisitorPitcher { get; set; }

    public string? HomePitcher { get; set; }

    public byte PitcherChanged { get; set; }

    public byte SportType { get; set; }

    public short IdUser { get; set; }

    public short? IdEvent { get; set; }

    public virtual Event? IdEventNavigation { get; set; }
}
