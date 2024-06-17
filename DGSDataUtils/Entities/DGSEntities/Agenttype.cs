namespace DGSDataUtils.Entities.DGSEntities;

public partial class Agenttype
{
    public byte IdAgentType { get; set; }

    public string? AgentType1 { get; set; }

    public virtual ICollection<Agent> Agents { get; set; } = new List<Agent>();
}
