namespace DGSDataUtils.Entities.DGSEntities;

public partial class Agentcommission
{
    public int IdAgent { get; set; }

    public byte CommSports { get; set; }

    public byte CommCasino { get; set; }

    public byte CommHorses { get; set; }

    public decimal CommPerHead { get; set; }
}
