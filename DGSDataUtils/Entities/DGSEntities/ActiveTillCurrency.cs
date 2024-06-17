namespace DGSDataUtils.Entities.DGSEntities;

public partial class ActiveTillCurrency
{
    public int ActiveTillId { get; set; }

    public string CurrCode { get; set; } = null!;

    public decimal ExchangeRate { get; set; }
}
