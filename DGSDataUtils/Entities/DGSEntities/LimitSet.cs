namespace DGSDataUtils.Entities.DGSEntities;

public partial class LimitSet
{
    public int LimitSetId { get; set; }

    public string LimitSetName { get; set; } = null!;

    public byte ParlayMaxSize { get; set; }

    public decimal MaxRaceWin { get; set; }

    public byte MaxRaceWinType { get; set; }

    public virtual ICollection<LimitSetBetType> LimitSetBetTypes { get; set; } = new List<LimitSetBetType>();

    public virtual ICollection<LimitSetTrack> LimitSetTracks { get; set; } = new List<LimitSetTrack>();
}
