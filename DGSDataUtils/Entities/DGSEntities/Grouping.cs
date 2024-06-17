namespace DGSDataUtils.Entities.DGSEntities;

public partial class Grouping
{
    public short IdGrouping { get; set; }

    public string GroupName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual ICollection<Agent> Agents { get; set; } = new List<Agent>();

    public virtual ICollection<Player> Players { get; set; } = new List<Player>();
}
