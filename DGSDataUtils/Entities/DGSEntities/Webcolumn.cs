namespace DGSDataUtils.Entities.DGSEntities;

public partial class Webcolumn
{
    public int IdWebColumn { get; set; }

    public string Description { get; set; } = null!;

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();

    public virtual ICollection<Webcolumndetail> Webcolumndetails { get; set; } = new List<Webcolumndetail>();
}
