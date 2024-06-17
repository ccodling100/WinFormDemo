namespace DGSDataUtils.Entities.DGSEntities;

public partial class Webrow
{
    public int IdWebRow { get; set; }

    public string Description { get; set; } = null!;

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual ICollection<Webcolumndetail> Webcolumndetails { get; set; } = new List<Webcolumndetail>();

    public virtual ICollection<Webrowdetail> Webrowdetails { get; set; } = new List<Webrowdetail>();

    public virtual ICollection<Webrowlang> Webrowlangs { get; set; } = new List<Webrowlang>();
}
