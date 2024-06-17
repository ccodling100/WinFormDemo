namespace DGSDataUtils.Entities.DGSEntities;

public partial class Voucher
{
    public int VoucherId { get; set; }

    public string VoucherNum { get; set; } = null!;

    public byte VoucherType { get; set; }

    public int LocationId { get; set; }

    public int IssuedTerminalId { get; set; }

    public byte VoucherStatus { get; set; }

    public DateTime IssuedDateTime { get; set; }

    public DateTime? RedeemedDateTime { get; set; }

    public string CurrCode { get; set; } = null!;

    public decimal CurrBalance { get; set; }

    public decimal CurrOriginalBalance { get; set; }

    public decimal? CurrRedeemedBalance { get; set; }

    public DateTime IssuedOpDate { get; set; }

    public DateTime? RedeemedOpDate { get; set; }

    public virtual EposCurrency CurrCodeNavigation { get; set; } = null!;

    public virtual Terminal IssuedTerminal { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;

    public virtual ICollection<TillTransact> TillTransacts { get; set; } = new List<TillTransact>();

    public virtual ICollection<VoucherTran> VoucherTranNewVouchers { get; set; } = new List<VoucherTran>();

    public virtual ICollection<VoucherTran> VoucherTranVouchers { get; set; } = new List<VoucherTran>();
}
