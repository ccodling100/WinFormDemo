namespace DGSDataUtils.Entities.DGSEntities;

public partial class TrackAmtote
{
    public int TrackId { get; set; }

    public byte BetType { get; set; }

    public bool Enabled { get; set; }

    public decimal Threshold { get; set; }

    public virtual Track Track { get; set; } = null!;
}
