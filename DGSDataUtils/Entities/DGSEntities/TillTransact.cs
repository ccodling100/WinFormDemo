namespace DGSDataUtils.Entities.DGSEntities;

public partial class TillTransact
{
    public int TillTransactId { get; set; }

    public int ActiveTillId { get; set; }

    public int LocationId { get; set; }

    public DateTime TransactDateTime { get; set; }

    public decimal TransactAmount { get; set; }

    public int? TicketNumber { get; set; }

    public int? VoucherId { get; set; }

    public int? TransferId { get; set; }

    public int? RefillId { get; set; }

    public short? IdUser { get; set; }

    public string CurrCode { get; set; } = null!;

    public decimal ExchangeRate { get; set; }

    public decimal CurrencyDiff { get; set; }

    public DateTime OpDate { get; set; }

    public virtual EposCurrency CurrCodeNavigation { get; set; } = null!;

    public virtual User? IdUserNavigation { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual RefillTill? Refill { get; set; }

    public virtual TicketMain? TicketNumberNavigation { get; set; }

    public virtual EposSportsbookTransfer? Transfer { get; set; }

    public virtual Voucher? Voucher { get; set; }
}
