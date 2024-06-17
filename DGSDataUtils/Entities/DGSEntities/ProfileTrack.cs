namespace DGSDataUtils.Entities.DGSEntities;

public partial class ProfileTrack
{
    public int ProfileId { get; set; }

    public string ProfileName { get; set; } = null!;

    public virtual ICollection<LimitSetTrack> LimitSetTracks { get; set; } = new List<LimitSetTrack>();

    public virtual ICollection<ProfileTrackEnable> ProfileTrackEnables { get; set; } = new List<ProfileTrackEnable>();

    public virtual ICollection<RaceTicketMain> RaceTicketMains { get; set; } = new List<RaceTicketMain>();
}
