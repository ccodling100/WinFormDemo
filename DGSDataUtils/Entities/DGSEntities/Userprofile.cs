namespace DGSDataUtils.Entities.DGSEntities;

public partial class Userprofile
{
    public short IdUserProfile { get; set; }

    public string ProfileName { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual ICollection<Userprofileright> Userprofilerights { get; set; } = new List<Userprofileright>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public virtual ICollection<Userprofile> IdUserProfileSources { get; set; } = new List<Userprofile>();

    public virtual ICollection<Userprofile> IdUserProfileTargets { get; set; } = new List<Userprofile>();
}
