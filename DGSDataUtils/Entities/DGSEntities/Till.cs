namespace DGSDataUtils.Entities.DGSEntities;

public partial class Till
{
    public int TillId { get; set; }

    public int LocationId { get; set; }

    public string Description { get; set; } = null!;

    public byte TillStatus { get; set; }

    public int? ActiveTillId { get; set; }

    public virtual ICollection<ActiveTill> ActiveTills { get; set; } = new List<ActiveTill>();

    public virtual ICollection<InactiveTill> InactiveTills { get; set; } = new List<InactiveTill>();

    public virtual Location Location { get; set; } = null!;
}
