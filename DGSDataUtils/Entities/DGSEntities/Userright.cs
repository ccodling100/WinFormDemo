namespace DGSDataUtils.Entities.DGSEntities;

public partial class Userright
{
    public short IdUser { get; set; }

    public short IdForm { get; set; }

    public short IdRight { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Form IdFormNavigation { get; set; } = null!;

    public virtual Right IdRightNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
