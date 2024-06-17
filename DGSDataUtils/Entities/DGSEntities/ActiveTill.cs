namespace DGSDataUtils.Entities.DGSEntities;

public partial class ActiveTill
{
    public int ActiveTillId { get; set; }

    public int TillId { get; set; }

    public int TerminalId { get; set; }

    public int OpenedBy { get; set; }

    public DateTime OpenedDateTime { get; set; }

    public decimal OpeningBalance { get; set; }

    public decimal Receipts { get; set; }

    public decimal Disbursements { get; set; }

    public DateTime? ClosedDateTime { get; set; }

    public DateTime OpDate { get; set; }

    public virtual TerminalManager OpenedByNavigation { get; set; } = null!;

    public virtual Terminal Terminal { get; set; } = null!;

    public virtual Till Till { get; set; } = null!;
}
