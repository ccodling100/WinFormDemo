namespace DGSDataUtils.Entities.DGSEntities;

public partial class ProfileTrackEnable
{
    public int ProfileId { get; set; }

    public byte Uitype { get; set; }

    public int TrackId { get; set; }

    public virtual ProfileTrack Profile { get; set; } = null!;

    public virtual Track Track { get; set; } = null!;
}
