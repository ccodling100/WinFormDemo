namespace DGSDataUtils.Entities.DGSEntities;

public partial class Gametntpropbyagentlog
{
    public int IdGameTntpropbyAgentLog { get; set; }

    public int IdAgent { get; set; }

    public int IdGame { get; set; }

    public int TeamNumber { get; set; }

    public string FieldName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public int Play { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Agent IdAgentNavigation { get; set; } = null!;

    public virtual Game IdGameNavigation { get; set; } = null!;
}
