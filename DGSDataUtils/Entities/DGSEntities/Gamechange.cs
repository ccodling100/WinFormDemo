namespace DGSDataUtils.Entities.DGSEntities;

public partial class Gamechange
{
    public int IdGame { get; set; }

    public int TeamNumber { get; set; }

    public DateTime? DateTimeBefore { get; set; }

    public DateTime? DateTimeAfter { get; set; }

    public string? OldStatus { get; set; }

    public string? NewStatus { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public int? OldIdGameType { get; set; }

    public int? NewIdGameType { get; set; }

    public virtual Game IdGameNavigation { get; set; } = null!;
}
