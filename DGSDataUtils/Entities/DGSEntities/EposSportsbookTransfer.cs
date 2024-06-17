namespace DGSDataUtils.Entities.DGSEntities;

public partial class EposSportsbookTransfer
{
    public int TransferId { get; set; }

    public int EposPlayerId { get; set; }

    public int IdPlayer { get; set; }

    public DateTime TransferDateTime { get; set; }

    public string CurrCode { get; set; } = null!;

    public decimal CurrAmount { get; set; }

    public decimal ExchangeRate { get; set; }

    public int LocationId { get; set; }

    public int TerminalId { get; set; }

    public short IdUser { get; set; }

    public DateTime OpDate { get; set; }

    public virtual EposPlayer EposPlayer { get; set; } = null!;

    public virtual Player IdPlayerNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;

    public virtual Terminal Terminal { get; set; } = null!;

    public virtual ICollection<TillTransact> TillTransacts { get; set; } = new List<TillTransact>();
}
