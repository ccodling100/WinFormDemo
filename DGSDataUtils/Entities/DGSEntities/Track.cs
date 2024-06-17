namespace DGSDataUtils.Entities.DGSEntities;

public partial class Track
{
    public int TrackId { get; set; }

    public bool? Enabled { get; set; }

    public string TrackName { get; set; } = null!;

    public string TrackCode { get; set; } = null!;

    public string? ShortName { get; set; }

    public string? TrackTimeZone { get; set; }

    public byte DefaultCloseMethod { get; set; }

    public short DefaultPostCutoff { get; set; }

    public byte TrackType { get; set; }

    public string? AmtoteTrackCode { get; set; }

    public virtual ICollection<LimitSetTrack> LimitSetTracks { get; set; } = new List<LimitSetTrack>();

    public virtual ICollection<ProfileTrackEnable> ProfileTrackEnables { get; set; } = new List<ProfileTrackEnable>();

    public virtual ICollection<Race> Races { get; set; } = new List<Race>();

    public virtual ICollection<TrackAmtote> TrackAmtotes { get; set; } = new List<TrackAmtote>();

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
