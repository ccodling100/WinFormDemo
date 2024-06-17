namespace DGSDataUtils.Entities.DGSEntities;

public partial class Teamlang
{
    public int IdTeam { get; set; }

    public byte IdLanguage { get; set; }

    public string Name { get; set; } = null!;

    public string? ShortName { get; set; }

    public string? LongName { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Language IdLanguageNavigation { get; set; } = null!;

    public virtual Team IdTeamNavigation { get; set; } = null!;
}
