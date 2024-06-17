namespace DGSDataUtils.Entities.DGSEntities;

public partial class Wagertypegrouplang
{
    public byte Wagertype { get; set; }

    public byte IdLanguage { get; set; }

    public string Description { get; set; } = null!;

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Language IdLanguageNavigation { get; set; } = null!;
}
