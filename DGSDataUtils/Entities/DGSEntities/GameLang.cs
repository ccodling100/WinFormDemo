namespace DGSDataUtils.Entities.DGSEntities;

public partial class GameLang
{
    public int IdGame { get; set; }

    public byte IdLanguage { get; set; }

    public string VisitorTeam { get; set; } = null!;

    public string HomeTeam { get; set; } = null!;

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public string? Description { get; set; }

    public virtual Language IdLanguageNavigation { get; set; } = null!;
}
