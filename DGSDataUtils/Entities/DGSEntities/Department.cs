namespace DGSDataUtils.Entities.DGSEntities;

public partial class Department
{
    public int IdDepartment { get; set; }

    public string Description { get; set; } = null!;

    public bool CallRecording { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
