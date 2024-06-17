namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemcachetable
{
    public int IdSystemCacheTable { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Systemcachechange> Systemcachechanges { get; set; } = new List<Systemcachechange>();
}
