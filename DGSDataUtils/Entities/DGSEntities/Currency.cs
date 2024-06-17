namespace DGSDataUtils.Entities.DGSEntities;

public partial class Currency
{
    public short IdCurrency { get; set; }

    public string Currency1 { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Symbol { get; set; } = null!;

    public decimal? LastMoneyChange { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual ICollection<Agent> Agents { get; set; } = new List<Agent>();

    public virtual ICollection<Moneychange> Moneychanges { get; set; } = new List<Moneychange>();

    public virtual ICollection<Player> Players { get; set; } = new List<Player>();
}
