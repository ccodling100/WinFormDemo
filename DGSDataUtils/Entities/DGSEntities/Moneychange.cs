namespace DGSDataUtils.Entities.DGSEntities;

public partial class Moneychange
{
    public short IdCurrency { get; set; }

    public DateTime ToDate { get; set; }

    public decimal AmountPerUnit { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Currency IdCurrencyNavigation { get; set; } = null!;
}
