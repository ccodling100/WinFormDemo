namespace DGSDataUtils.Entities.DGSEntities;

public partial class CwAgentUndo
{
    public int Id { get; set; }

    public int IdAgent { get; set; }

    public string Description { get; set; } = null!;

    public decimal Amount { get; set; }

    public decimal MoneyChange { get; set; }

    public string? TransactionType { get; set; }
}
