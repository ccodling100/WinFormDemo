namespace DGSDataUtils.Entities.DGSEntities;

public partial class EposPlayerChangeLog
{
    public int ChangeId { get; set; }

    public int EposPlayerId { get; set; }

    public int ManagerId { get; set; }

    public DateTime ChangeDate { get; set; }

    public string FieldName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public virtual EposPlayer EposPlayer { get; set; } = null!;

    public virtual TerminalManager Manager { get; set; } = null!;
}
