namespace DGSDataUtils.Entities.DGSEntities;

public partial class Banner
{
    public int IdBanner { get; set; }

    public int IdTargetUrl { get; set; }

    public short Width { get; set; }

    public short Height { get; set; }

    public string Description { get; set; } = null!;

    public byte[]? ImageData { get; set; }

    public string? ImageMime { get; set; }
}
