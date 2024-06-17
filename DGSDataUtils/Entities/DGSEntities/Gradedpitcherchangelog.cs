namespace DGSDataUtils.Entities.DGSEntities;

public partial class Gradedpitcherchangelog
{
    public int IdpitcherChangeLog { get; set; }

    public int IdGame { get; set; }

    public string? OldVisitorPitcher { get; set; }

    public string? NewVisitorPitcher { get; set; }

    public string? OldHomePitcher { get; set; }

    public string? NewHomePitcher { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public int? OldVisitorOdds { get; set; }

    public int? NewVisitorOdds { get; set; }

    public int? OldHomeOdds { get; set; }

    public int? NewHomeOdds { get; set; }

    public bool Complete { get; set; }
}
