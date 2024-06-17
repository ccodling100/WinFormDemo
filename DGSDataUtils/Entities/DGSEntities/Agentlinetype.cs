namespace DGSDataUtils.Entities.DGSEntities;

public partial class Agentlinetype
{
    public int Idagent { get; set; }

    public short IdLineType { get; set; }

    public DateTime Lastmodification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Linetype IdLineTypeNavigation { get; set; } = null!;

    public virtual Agent IdagentNavigation { get; set; } = null!;
}
