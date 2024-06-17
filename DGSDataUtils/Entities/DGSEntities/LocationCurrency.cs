namespace DGSDataUtils.Entities.DGSEntities;

public partial class LocationCurrency
{
    public int LocationId { get; set; }

    public string CurrCode { get; set; } = null!;

    public decimal ExchangeRate { get; set; }

    public virtual EposCurrency CurrCodeNavigation { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;
}
