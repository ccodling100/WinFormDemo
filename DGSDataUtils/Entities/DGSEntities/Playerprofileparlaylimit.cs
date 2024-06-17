namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playerprofileparlaylimit
{
    public short IdProfile { get; set; }

    public byte NumTeams { get; set; }

    public int IdWagerType { get; set; }

    public decimal Odds { get; set; }

    public decimal MaxRisk { get; set; }

    public decimal MaxPayout { get; set; }

    public byte ExtraJuice { get; set; }

    public byte MaxOpenSpots { get; set; }

    public byte MaxDogLines { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public byte MaxMoneyLines { get; set; }

    public byte MaxTotalLines { get; set; }

    public virtual Playerprofile IdProfileNavigation { get; set; } = null!;

    public virtual Wagertype IdWagerTypeNavigation { get; set; } = null!;
}
