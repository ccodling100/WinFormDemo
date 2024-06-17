namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playeraccounting
{
    public int IdPlayerAccounting { get; set; }

    public int IdPlayer { get; set; }

    public int IdTransaction { get; set; }

    public string Description { get; set; } = null!;

    public string TransactionType { get; set; } = null!;

    public decimal Amount { get; set; }

    public decimal MoneyChange { get; set; }

    public decimal TaxAmount { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Player IdPlayerNavigation { get; set; } = null!;
}
