namespace DGSDataUtils.Entities.DGSEntities;

public partial class Flagmessagetype
{
    public byte IdFlagMessageType { get; set; }

    public string Description { get; set; } = null!;

    public int FkColor { get; set; }

    public int BkColor { get; set; }
}
