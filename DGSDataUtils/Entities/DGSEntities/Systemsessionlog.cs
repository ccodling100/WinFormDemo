namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemsessionlog
{
    public int IdSystemSessionLog { get; set; }

    public int IdSession { get; set; }

    public string Session { get; set; } = null!;

    public int? IdPlayer { get; set; }

    public int? IdAgent { get; set; }

    public int IdUser { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public DateTime Expiration { get; set; }

    public int PostedBets { get; set; }

    public int PendingBets { get; set; }

    public string System { get; set; } = null!;

    public string Ip { get; set; } = null!;

    public DateTime LastModification { get; set; }

    public int LastModificationUser { get; set; }

    public int? IdCall { get; set; }
}
