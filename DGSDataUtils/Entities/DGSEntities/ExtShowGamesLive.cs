namespace DGSDataUtils.Entities.DGSEntities;

public partial class ExtShowGamesLive
{
    public int MatchId { get; set; }

    public DateTime? GameDateTime { get; set; }

    public string? SportType { get; set; }

    public string? Team1Id { get; set; }

    public string? Team2Id { get; set; }

    public short? Time { get; set; }

    public short? ScoreHome { get; set; }

    public short? ScoreAway { get; set; }

    public string? Status { get; set; }

    public int? GameNum { get; set; }
}
