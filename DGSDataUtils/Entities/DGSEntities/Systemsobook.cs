namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemsobook
{
    public int BookId { get; set; }

    public string Description { get; set; } = null!;

    public string Abbreviation { get; set; } = null!;

    public virtual ICollection<Systemsosport> Systemsosports { get; set; } = new List<Systemsosport>();
}
