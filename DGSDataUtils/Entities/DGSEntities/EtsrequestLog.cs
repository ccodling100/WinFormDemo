namespace DGSDataUtils.Entities.DGSEntities;

public partial class EtsrequestLog
{
    public int ReqId { get; set; }

    public string EtsserverName { get; set; } = null!;

    public string PathInfo { get; set; } = null!;

    public string ClientIp { get; set; } = null!;

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public int? Duration { get; set; }

    public int? TermSessId { get; set; }

    public int? RequestBytes { get; set; }

    public int? ResponseBytes { get; set; }
}
