namespace DGSDataUtils.Entities.DGSEntities;

public partial class Smtobook
{
    public short IdBook { get; set; }

    public short SmtoidBook { get; set; }

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; }

    public short IdStatus { get; set; }

    public DateTime LastUpdate { get; set; }

    public virtual ICollection<SmtolineTypeBookLink> SmtolineTypeBookLinks { get; set; } = new List<SmtolineTypeBookLink>();

    public virtual ICollection<SmtolinksLog> SmtolinksLogs { get; set; } = new List<SmtolinksLog>();

    public virtual ICollection<SmtologArchive> SmtologArchives { get; set; } = new List<SmtologArchive>();

    public virtual ICollection<Smtolog> Smtologs { get; set; } = new List<Smtolog>();
}
