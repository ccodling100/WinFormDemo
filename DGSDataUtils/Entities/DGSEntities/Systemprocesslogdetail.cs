namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemprocesslogdetail
{
    public int IdSystemProcessDetail { get; set; }

    public int IdSystemProcess { get; set; }

    public string? Step { get; set; }

    public DateTime? TotalTime { get; set; }

    public virtual Systemprocesslog IdSystemProcessNavigation { get; set; } = null!;
}
