namespace DGSDataUtils.Entities.DGSEntities;

public partial class Terminal
{
    public int TerminalId { get; set; }

    public string Description { get; set; } = null!;

    public byte PrinterModel { get; set; }

    public byte PrinterInterface { get; set; }

    public byte PrinterPort { get; set; }

    public byte PrinterModel2 { get; set; }

    public byte PrinterInterface2 { get; set; }

    public byte PrinterPort2 { get; set; }

    public byte CashDrawerType { get; set; }

    public bool CashDrawerCompulsion { get; set; }

    public byte CustomerDisplay { get; set; }

    public byte Cdinterface { get; set; }

    public byte Cdport { get; set; }

    public byte Scanner1 { get; set; }

    public byte Scanner1Port { get; set; }

    public byte Scanner2 { get; set; }

    public byte Scanner2Port { get; set; }

    public int LocationId { get; set; }

    public int TicketTemplateId { get; set; }

    public int VoucherTemplateId { get; set; }

    public int CashedTicketTemplateId { get; set; }

    public byte Language { get; set; }

    public bool Enabled { get; set; }

    public virtual ICollection<ActiveTill> ActiveTills { get; set; } = new List<ActiveTill>();

    public virtual CashedTicketTemplate CashedTicketTemplate { get; set; } = null!;

    public virtual ICollection<EposSportsbookTransfer> EposSportsbookTransfers { get; set; } = new List<EposSportsbookTransfer>();

    public virtual ICollection<InactiveTill> InactiveTills { get; set; } = new List<InactiveTill>();

    public virtual Location Location { get; set; } = null!;

    public virtual ICollection<TerminalSessionActive> TerminalSessionActives { get; set; } = new List<TerminalSessionActive>();

    public virtual ICollection<TerminalSessionClosed> TerminalSessionCloseds { get; set; } = new List<TerminalSessionClosed>();

    public virtual ICollection<TicketMain> TicketMainCashedTerminals { get; set; } = new List<TicketMain>();

    public virtual ICollection<TicketMain> TicketMainSoldTerminals { get; set; } = new List<TicketMain>();

    public virtual Tickettemplate TicketTemplate { get; set; } = null!;

    public virtual ICollection<Voucher> Vouchers { get; set; } = new List<Voucher>();
}
