namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playerrate
{
    public short IdPlayerRate { get; set; }

    public string Description { get; set; } = null!;

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }
}
