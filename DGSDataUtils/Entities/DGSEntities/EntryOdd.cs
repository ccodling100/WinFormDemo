namespace DGSDataUtils.Entities.DGSEntities;

public partial class EntryOdd
{
    public int RaceId { get; set; }

    public byte EntryNum { get; set; }

    public byte? Mtp { get; set; }

    public string? Mlfrac { get; set; }

    public string? WinOdds { get; set; }

    public decimal? WinProb { get; set; }

    public decimal? WinTotal { get; set; }

    public decimal? PlaceTotal { get; set; }

    public decimal? ShowTotal { get; set; }

    public DateTime LastUpdate { get; set; }

    public virtual Race Race { get; set; } = null!;
}
