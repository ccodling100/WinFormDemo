namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systembetradarsport
{
    public byte SportId { get; set; }

    public string SportName { get; set; } = null!;

    public bool? Enabled { get; set; }

    public DateTime LastModification { get; set; }

    public int LastModificationUser { get; set; }

    public virtual ICollection<Systembetradarcategory> Systembetradarcategories { get; set; } = new List<Systembetradarcategory>();
}
