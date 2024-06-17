namespace DGSDataUtils.Entities.DGSEntities;

public partial class ActivityLock
{
    public string Activity { get; set; } = null!;

    public int ManagerId { get; set; }

    public DateTime StartDateTime { get; set; }
}
