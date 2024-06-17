namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playerblackbook
{
    public int IdPlayer { get; set; }

    public DateTime? SettleDate { get; set; }

    public string? Description { get; set; }

    public DateTime? LastModification { get; set; }

    public short? LastModificationUser { get; set; }

    public virtual Player IdPlayerNavigation { get; set; } = null!;
}
