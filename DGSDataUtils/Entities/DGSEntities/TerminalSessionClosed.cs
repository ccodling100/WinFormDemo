namespace DGSDataUtils.Entities.DGSEntities;

public partial class TerminalSessionClosed
{
    public int TermSessId { get; set; }

    public int TerminalId { get; set; }

    public short IdUser { get; set; }

    public int ActiveTillId { get; set; }

    public byte Lang { get; set; }

    public DateTime OpenedDateTime { get; set; }

    public DateTime ClosedDateTime { get; set; }

    public virtual User IdUserNavigation { get; set; } = null!;

    public virtual Terminal Terminal { get; set; } = null!;
}
