namespace DGSDataUtils.Entities.DGSEntities;

public partial class Bannertypelang
{
    public short IdBannerType { get; set; }

    public byte IdLanguage { get; set; }

    public string? Line1 { get; set; }

    public string? Line2 { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Bannertype IdBannerTypeNavigation { get; set; } = null!;

    public virtual Language IdLanguageNavigation { get; set; } = null!;
}
