namespace DGSDataUtils.Entities.DGSEntities;

public partial class EposPlayerCardQ
{
    public int EposPlayerId { get; set; }

    public int LocationId { get; set; }

    public virtual EposPlayer EposPlayer { get; set; } = null!;
}
