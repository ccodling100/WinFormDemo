namespace DGSDataUtils.Entities.DGSEntities;

public partial class GameTntlang
{
    public int IdGame { get; set; }

    public int TeamNumber { get; set; }

    public byte IdLanguage { get; set; }

    public string TeamName { get; set; } = null!;

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Language IdLanguageNavigation { get; set; } = null!;
}
