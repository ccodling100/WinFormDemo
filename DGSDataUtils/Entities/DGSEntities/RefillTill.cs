namespace DGSDataUtils.Entities.DGSEntities;

public partial class RefillTill
{
    public int RefillId { get; set; }

    public int LocationId { get; set; }

    public int TerminalId { get; set; }

    public DateTime RefillDateTime { get; set; }

    public string CurrCode { get; set; } = null!;

    public decimal CurrAmount { get; set; }

    public decimal ExchangeRate { get; set; }

    public int ManagerId { get; set; }

    public short IdUser { get; set; }

    public DateTime OpDate { get; set; }

    public virtual ICollection<TillTransact> TillTransacts { get; set; } = new List<TillTransact>();
}
