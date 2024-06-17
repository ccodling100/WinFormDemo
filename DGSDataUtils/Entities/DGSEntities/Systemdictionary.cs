namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemdictionary
{
    public short IdLanguage { get; set; }

    public string IdMessage { get; set; } = null!;

    public string Page { get; set; } = null!;

    public string? Message { get; set; }

    public virtual Systemlanguage IdLanguageNavigation { get; set; } = null!;
}
