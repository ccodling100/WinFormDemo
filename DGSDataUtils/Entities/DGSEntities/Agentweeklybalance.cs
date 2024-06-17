namespace DGSDataUtils.Entities.DGSEntities;

public partial class Agentweeklybalance
{
    public int IdAgent { get; set; }

    public DateTime Week { get; set; }

    public decimal Balance { get; set; }

    public decimal MakeUp { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Agent IdAgentNavigation { get; set; } = null!;
}
