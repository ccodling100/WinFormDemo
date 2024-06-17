namespace DGSDataUtils.Entities.DGSEntities;

public partial class Agentaccounting
{
    public int IdAgentAccounting { get; set; }

    public int IdAgent { get; set; }

    public int IdTransaction { get; set; }

    public string TransactionType { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Amount { get; set; }

    public decimal MoneyChange { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Agent IdAgentNavigation { get; set; } = null!;
}
