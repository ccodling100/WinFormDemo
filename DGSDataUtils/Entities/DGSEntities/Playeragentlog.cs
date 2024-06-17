namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playeragentlog
{
    public int IdPlayerAgentLog { get; set; }

    public int IdAgent { get; set; }

    public int IdPlayer { get; set; }

    public string FieldName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public DateTime PlacedDate { get; set; }

    public string Ip { get; set; } = null!;
}
