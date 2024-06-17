namespace DGSDataUtils.Entities.DGSEntities;

public partial class EposPlayerPhoto
{
    public int EposPlayerId { get; set; }

    public byte[] Photo { get; set; } = null!;

    public virtual EposPlayer EposPlayer { get; set; } = null!;
}
