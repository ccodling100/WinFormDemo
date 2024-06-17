namespace DGSDataUtils.Entities.DGSEntities;

public partial class Location
{
    public int LocationId { get; set; }

    public string LocationDesc { get; set; } = null!;

    public int IdPlayer { get; set; }

    public string LocationGroup { get; set; } = null!;

    public virtual ICollection<EposPlayer> EposPlayers { get; set; } = new List<EposPlayer>();

    public virtual ICollection<EposSportsbookTransfer> EposSportsbookTransfers { get; set; } = new List<EposSportsbookTransfer>();

    public virtual Player IdPlayerNavigation { get; set; } = null!;

    public virtual ICollection<LocationCurrency> LocationCurrencies { get; set; } = new List<LocationCurrency>();

    public virtual ICollection<TerminalSessionActive> TerminalSessionActives { get; set; } = new List<TerminalSessionActive>();

    public virtual ICollection<Terminal> Terminals { get; set; } = new List<Terminal>();

    public virtual ICollection<TicketMain> TicketMains { get; set; } = new List<TicketMain>();

    public virtual ICollection<TillTransact> TillTransacts { get; set; } = new List<TillTransact>();

    public virtual ICollection<Till> Tills { get; set; } = new List<Till>();

    public virtual ICollection<VoucherTran> VoucherTrans { get; set; } = new List<VoucherTran>();

    public virtual ICollection<Voucher> Vouchers { get; set; } = new List<Voucher>();

    public virtual ICollection<TerminalManager> Managers { get; set; } = new List<TerminalManager>();

    public virtual ICollection<Tax> Taxes { get; set; } = new List<Tax>();
}
