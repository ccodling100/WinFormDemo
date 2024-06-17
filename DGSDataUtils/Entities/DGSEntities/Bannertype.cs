namespace DGSDataUtils.Entities.DGSEntities;

public partial class Bannertype
{
    public short IdBannerType { get; set; }

    public string Description { get; set; } = null!;

    public string? Line1 { get; set; }

    public string? Line2 { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual ICollection<Bannertypelang> Bannertypelangs { get; set; } = new List<Bannertypelang>();
}
