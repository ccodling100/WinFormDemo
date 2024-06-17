namespace DGSDataUtils.Entities.DGSEntities;

public partial class EposCurrency
{
    public string CurrCode { get; set; } = null!;

    public string CurrName { get; set; } = null!;

    public short RoundTo { get; set; }

    public string FormatStr { get; set; } = null!;

    public virtual ICollection<LocationCurrency> LocationCurrencies { get; set; } = new List<LocationCurrency>();

    public virtual ICollection<TicketMain> TicketMains { get; set; } = new List<TicketMain>();

    public virtual ICollection<TillTransact> TillTransacts { get; set; } = new List<TillTransact>();

    public virtual ICollection<VoucherTran> VoucherTrans { get; set; } = new List<VoucherTran>();

    public virtual ICollection<Voucher> Vouchers { get; set; } = new List<Voucher>();
}
