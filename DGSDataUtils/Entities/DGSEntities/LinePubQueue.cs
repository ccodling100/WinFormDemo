namespace DGSDataUtils.Entities.DGSEntities;

public partial class LinePubQueue
{
    public int IdQueue { get; set; }

    public DateTime QueueDateTime { get; set; }

    public short IdLineType { get; set; }

    public short IdLeague { get; set; }

    public string IdSport { get; set; } = null!;

    public int IdGame { get; set; }

    public int Play { get; set; }
}
