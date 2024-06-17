namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemsessiondetail
{
    public int IdSessionDetail { get; set; }

    public int IdSession { get; set; }

    public string Session { get; set; } = null!;

    public string Action { get; set; } = null!;

    public DateTime ActionTime { get; set; }

    public DateTime LastModification { get; set; }

    public int LastModificationUser { get; set; }
}
