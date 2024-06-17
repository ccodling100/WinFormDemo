namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemcolor
{
    public short IdSystemColors { get; set; }

    public string GameStat { get; set; } = null!;

    public int FkColor { get; set; }

    public int BkColor { get; set; }

    public string Description { get; set; } = null!;

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }
}
