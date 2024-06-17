namespace DGSDataUtils.Entities.DGSEntities;

public partial class Timezone
{
    public int IdTimeZone { get; set; }

    public string Description { get; set; } = null!;

    public float? Gmt { get; set; }

    public virtual ICollection<Player> Players { get; set; } = new List<Player>();
}
