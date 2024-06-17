namespace DGSDataUtils.Entities.DGSEntities;

public partial class Agentlogonslog
{
    public int IdAgentLogons { get; set; }

    public int IdAgent { get; set; }

    public DateTime PlacedDate { get; set; }

    public string? Ip { get; set; }

    public short? IdUserLogout { get; set; }

    public string? System { get; set; }
}
