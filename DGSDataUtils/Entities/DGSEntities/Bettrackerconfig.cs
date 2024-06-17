namespace DGSDataUtils.Entities.DGSEntities;

public partial class Bettrackerconfig
{
    public short IdBook { get; set; }

    public string PartnerId { get; set; } = null!;

    public bool Enable { get; set; }

    public bool RequestCodes { get; set; }

    public string? Url { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }
}
