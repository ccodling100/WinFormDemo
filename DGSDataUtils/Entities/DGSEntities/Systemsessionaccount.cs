namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemsessionaccount
{
    public int IdAccount { get; set; }

    public byte AccountType { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public DateTime LastModificacion { get; set; }

    public int LastModificationUser { get; set; }
}
