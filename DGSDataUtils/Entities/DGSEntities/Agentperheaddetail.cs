namespace DGSDataUtils.Entities.DGSEntities;

public partial class Agentperheaddetail
{
    public int IdAgentPerHead { get; set; }

    public int ToRange { get; set; }

    public decimal LocalSportsFee { get; set; }

    public decimal LocalHorsesFee { get; set; }

    public decimal OnlineSportsFee { get; set; }

    public decimal CasinoFee { get; set; }

    public decimal OnlineHorsesFee { get; set; }

    public DateTime LastModification { get; set; }

    public int LastModificationUser { get; set; }

    public virtual Agentperhead IdAgentPerHeadNavigation { get; set; } = null!;
}
