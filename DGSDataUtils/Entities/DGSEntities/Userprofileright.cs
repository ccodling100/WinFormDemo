namespace DGSDataUtils.Entities.DGSEntities;

public partial class Userprofileright
{
    public short IdUserProfile { get; set; }

    public short IdRight { get; set; }

    public short IdForm { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Form IdFormNavigation { get; set; } = null!;

    public virtual Right IdRightNavigation { get; set; } = null!;

    public virtual Userprofile IdUserProfileNavigation { get; set; } = null!;
}
