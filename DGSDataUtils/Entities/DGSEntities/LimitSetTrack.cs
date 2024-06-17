namespace DGSDataUtils.Entities.DGSEntities;

public partial class LimitSetTrack
{
    public int TrackId { get; set; }

    public int ProfileId { get; set; }

    public int LimitSetId { get; set; }

    public virtual LimitSet LimitSet { get; set; } = null!;

    public virtual ProfileTrack Profile { get; set; } = null!;

    public virtual Track Track { get; set; } = null!;
}
