namespace DGSDataUtils.Entities.DGSEntities;

public partial class Eventlang
{
    public short IdEvent { get; set; }

    public byte IdLanguage { get; set; }

    public string GameDescription { get; set; } = null!;

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Event IdEventNavigation { get; set; } = null!;
}
