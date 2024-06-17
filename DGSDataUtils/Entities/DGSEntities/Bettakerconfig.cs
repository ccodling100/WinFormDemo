namespace DGSDataUtils.Entities.DGSEntities;

public partial class Bettakerconfig
{
    public short IdBook { get; set; }

    public string PartnerId { get; set; } = null!;

    public bool Enable { get; set; }

    public string Url { get; set; } = null!;

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }
}
