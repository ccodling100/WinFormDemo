namespace DGSDataUtils.Entities.DGSEntities;

public partial class Affiltrack
{
    public int IdTrack { get; set; }

    public int IdAgent { get; set; }

    public int IdMedia { get; set; }

    public string MediaType { get; set; } = null!;

    public string? Ip { get; set; }

    public string? Refer { get; set; }

    public string? Extra { get; set; }

    public DateTime Date { get; set; }

    public virtual Agent IdAgentNavigation { get; set; } = null!;
}
