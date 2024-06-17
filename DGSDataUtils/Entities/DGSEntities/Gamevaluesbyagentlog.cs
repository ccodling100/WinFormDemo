namespace DGSDataUtils.Entities.DGSEntities;

public partial class Gamevaluesbyagentlog
{
    public int IdGameValuesByAgentLog { get; set; }

    public int IdAgent { get; set; }

    public int IdGame { get; set; }

    public string FieldName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public int Play { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }
}
