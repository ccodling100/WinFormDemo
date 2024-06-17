namespace DGSDataUtils.Entities.DGSEntities;

public partial class VoucherTran
{
    public int VtransId { get; set; }

    public int VoucherId { get; set; }

    public DateTime TransactDateTime { get; set; }

    public int LocationId { get; set; }

    public byte TransactType { get; set; }

    public string CurrCode { get; set; } = null!;

    public decimal CurrAmount { get; set; }

    public int? TicketNumber { get; set; }

    public int? ActiveTillId { get; set; }

    public int? NewVoucherId { get; set; }

    public DateTime OpDate { get; set; }

    public virtual EposCurrency CurrCodeNavigation { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;

    public virtual Voucher? NewVoucher { get; set; }

    public virtual TicketMain? TicketNumberNavigation { get; set; }

    public virtual Voucher Voucher { get; set; } = null!;
}
