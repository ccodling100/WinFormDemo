namespace DGSDataUtils.Entities.DGSEntities;

public partial class Agentnote
{
    public int IdAgent { get; set; }

    public string? Notes { get; set; }

    public string? Notes1 { get; set; }

    public string? Notes2 { get; set; }

    public string? Notes3 { get; set; }

    public virtual Agent IdAgentNavigation { get; set; } = null!;
}
