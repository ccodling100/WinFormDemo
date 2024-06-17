namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemdbsevent
{
    public byte SystemDbseventId { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
