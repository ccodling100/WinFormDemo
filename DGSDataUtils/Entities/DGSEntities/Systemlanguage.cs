namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemlanguage
{
    public short IdLanguage { get; set; }

    public string? Description { get; set; }

    public string? Meta { get; set; }

    public string? Home { get; set; }

    public virtual ICollection<Systemdictionary> Systemdictionaries { get; set; } = new List<Systemdictionary>();
}
