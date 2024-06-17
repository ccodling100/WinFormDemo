namespace DGSDataUtils.Entities.DGSEntities;

public partial class Menureportitemslang
{
    public short IdReport { get; set; }

    public byte IdLanguage { get; set; }

    public string Description { get; set; } = null!;

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Language IdLanguageNavigation { get; set; } = null!;

    public virtual Menureportitem IdReportNavigation { get; set; } = null!;
}
