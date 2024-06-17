namespace DGSDataUtils.Entities.DGSEntities;

public partial class Form
{
    public short IdForm { get; set; }

    public string FormName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string System { get; set; } = null!;

    public byte Category { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual ICollection<Userprofileright> Userprofilerights { get; set; } = new List<Userprofileright>();

    public virtual ICollection<Userright> Userrights { get; set; } = new List<Userright>();
}
