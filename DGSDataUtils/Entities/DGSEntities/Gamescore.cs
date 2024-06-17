namespace DGSDataUtils.Entities.DGSEntities;

public partial class Gamescore
{
    public int IdGameScores { get; set; }

    public int IdGame { get; set; }

    public byte Period { get; set; }

    public int? VisitorScore { get; set; }

    public int? HomeScore { get; set; }

    public bool Short { get; set; }

    public bool Cancel { get; set; }

    public bool Final { get; set; }

    public byte System { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }
}
