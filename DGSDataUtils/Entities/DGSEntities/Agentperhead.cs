namespace DGSDataUtils.Entities.DGSEntities;

public partial class Agentperhead
{
    public int IdAgentPerHead { get; set; }

    public string Description { get; set; } = null!;

    public bool SplitLocalOnline { get; set; }

    public bool SplitComm { get; set; }

    public DateTime LastModification { get; set; }

    public int LastModificationUser { get; set; }

    public virtual ICollection<Agentperheaddetail> Agentperheaddetails { get; set; } = new List<Agentperheaddetail>();

    public virtual ICollection<Agent> Agents { get; set; } = new List<Agent>();
}
