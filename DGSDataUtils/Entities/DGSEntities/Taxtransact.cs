namespace DGSDataUtils.Entities.DGSEntities;

public partial class Taxtransact
{
    public int TaxTransactId { get; set; }

    public int TaxId { get; set; }

    public int? ActiveTillId { get; set; }

    public int? LocationId { get; set; }

    public int? IdBook { get; set; }

    public int? IdPlayer { get; set; }

    public int? IdWager { get; set; }

    public int MoneyChange { get; set; }

    public DateTime TransactDateTime { get; set; }

    public decimal TransactAmount { get; set; }

    public DateTime OpDate { get; set; }
}
