namespace DGSDataUtils.Entities.DGSEntities;

public partial class ManagerRight
{
    public int ManagerId { get; set; }

    public short IdRight { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Right IdRightNavigation { get; set; } = null!;

    public virtual TerminalManager Manager { get; set; } = null!;
}
