namespace DGSDataUtils.Entities.DGSEntities;

public partial class Gradedgamevaluesbyagentlog
{
    public int IdGradedGameValuesByAgentLog { get; set; }

    public int IdAgent { get; set; }

    public int IdGame { get; set; }

    public string FieldName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public int Play { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Agent IdAgentNavigation { get; set; } = null!;

    public virtual Gradedgame IdGameNavigation { get; set; } = null!;
}
