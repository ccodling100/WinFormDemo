namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playerweeklybalance
{
    public int IdPlayer { get; set; }

    public DateTime Week { get; set; }

    public decimal Balance { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Player IdPlayerNavigation { get; set; } = null!;
}
