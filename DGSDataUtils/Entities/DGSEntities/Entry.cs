namespace DGSDataUtils.Entities.DGSEntities;

public partial class Entry
{
    public int EntryId { get; set; }

    public int RaceId { get; set; }

    public string? SaddleNum { get; set; }

    public byte? EntryNum { get; set; }

    public string? CoupleChar { get; set; }

    public string EntryName { get; set; } = null!;

    public string? RiderName { get; set; }

    public short? FinishPos { get; set; }

    public double? Ml { get; set; }

    public string? BkColor { get; set; }

    public string? FkColor { get; set; }

    public string? TrainerName { get; set; }

    public string? OwnerName { get; set; }

    public int? Weight { get; set; }

    public string? Equipment { get; set; }

    public string? Medication { get; set; }

    public virtual Race Race { get; set; } = null!;
}
