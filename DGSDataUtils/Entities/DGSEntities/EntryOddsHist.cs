namespace DGSDataUtils.Entities.DGSEntities;

public partial class EntryOddsHist
{
    public int RaceId { get; set; }

    public byte EntryNum { get; set; }

    public byte Mtp { get; set; }

    public string? Mlfrac { get; set; }

    public string? WinOdds { get; set; }

    public decimal? WinProb { get; set; }

    public DateTime LastUpdate { get; set; }

    public virtual Race Race { get; set; } = null!;
}
