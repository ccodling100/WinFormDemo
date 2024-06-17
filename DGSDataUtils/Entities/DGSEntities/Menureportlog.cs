namespace DGSDataUtils.Entities.DGSEntities;

public partial class Menureportlog
{
    public int IdLog { get; set; }

    public string ReportName { get; set; } = null!;

    public short IdUser { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }
}
