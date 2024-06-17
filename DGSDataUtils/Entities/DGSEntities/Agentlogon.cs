namespace DGSDataUtils.Entities.DGSEntities;

public partial class Agentlogon
{
    public int IdAgentLogons { get; set; }

    public int IdAgent { get; set; }

    public DateTime PlacedDate { get; set; }

    public string? Ip { get; set; }

    public string? System { get; set; }

    public virtual Agent IdAgentNavigation { get; set; } = null!;
}
