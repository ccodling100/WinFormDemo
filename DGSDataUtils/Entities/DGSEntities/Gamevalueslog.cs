namespace DGSDataUtils.Entities.DGSEntities;

public partial class Gamevalueslog
{
    public int IdGameValuesLog { get; set; }

    public short IdLineType { get; set; }

    public int IdGame { get; set; }

    public string FieldName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Game IdGameNavigation { get; set; } = null!;

    public virtual Linetype IdLineTypeNavigation { get; set; } = null!;
}
