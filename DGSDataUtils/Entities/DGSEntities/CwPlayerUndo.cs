namespace DGSDataUtils.Entities.DGSEntities;

public partial class CwPlayerUndo
{
    public int Id { get; set; }

    public int IdPlayer { get; set; }

    public string Description { get; set; } = null!;

    public decimal Amount { get; set; }

    public decimal TaxAmount { get; set; }

    public decimal MoneyChange { get; set; }
}
