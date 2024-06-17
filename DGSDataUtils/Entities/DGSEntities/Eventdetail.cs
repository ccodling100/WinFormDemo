namespace DGSDataUtils.Entities.DGSEntities;

public partial class Eventdetail
{
    public short IdEventDetail { get; set; }

    public short IdEvent { get; set; }

    public string Description { get; set; } = null!;

    public int Odds { get; set; }

    public byte DisplayOrder { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Event IdEventNavigation { get; set; } = null!;
}
