namespace DGSDataUtils.Entities.DGSEntities;

public partial class TicketMain
{
    public int TicketNumber { get; set; }

    public int LocationId { get; set; }

    public string TicketType { get; set; } = null!;

    public DateTime SoldDate { get; set; }

    public DateTime? CashedDate { get; set; }

    public decimal SoldValue { get; set; }

    public decimal? CashedValue { get; set; }

    public decimal MoneyChange { get; set; }

    public short? SoldIdUser { get; set; }

    public int? SoldTerminalId { get; set; }

    public short? CashedIdUser { get; set; }

    public int? CashedTerminalId { get; set; }

    public string CurrCode { get; set; } = null!;

    public decimal ExchangeRate { get; set; }

    public byte VoidReason { get; set; }

    public int? EposPlayerId { get; set; }

    public string Etsn { get; set; } = null!;

    public DateTime SoldOpDate { get; set; }

    public DateTime? CashedOpDate { get; set; }

    public DateTime? SettledOpDate { get; set; }

    public decimal? SettledValue { get; set; }

    public decimal? SettledRefund { get; set; }

    public virtual User? CashedIdUserNavigation { get; set; }

    public virtual Terminal? CashedTerminal { get; set; }

    public virtual EposCurrency CurrCodeNavigation { get; set; } = null!;

    public virtual EposPlayer? EposPlayer { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual User? SoldIdUserNavigation { get; set; }

    public virtual Terminal? SoldTerminal { get; set; }

    public virtual ICollection<TicketDetail> TicketDetails { get; set; } = new List<TicketDetail>();

    public virtual TicketHold? TicketHold { get; set; }

    public virtual ICollection<TillTransact> TillTransacts { get; set; } = new List<TillTransact>();

    public virtual ICollection<VoucherTran> VoucherTrans { get; set; } = new List<VoucherTran>();
}
