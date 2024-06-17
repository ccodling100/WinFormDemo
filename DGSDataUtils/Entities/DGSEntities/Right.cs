namespace DGSDataUtils.Entities.DGSEntities;

public partial class Right
{
    public short IdRight { get; set; }

    public string Description { get; set; } = null!;

    public string System { get; set; } = null!;

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual ICollection<ManagerRight> ManagerRights { get; set; } = new List<ManagerRight>();

    public virtual ICollection<Userprofileright> Userprofilerights { get; set; } = new List<Userprofileright>();

    public virtual ICollection<Userright> Userrights { get; set; } = new List<Userright>();
}
