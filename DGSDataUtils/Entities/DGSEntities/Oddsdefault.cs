namespace DGSDataUtils.Entities.DGSEntities;

public partial class Oddsdefault
{
    public short IdProfile { get; set; }

    public string IdSport { get; set; } = null!;

    public short Odds { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Playerprofile IdProfileNavigation { get; set; } = null!;

    public virtual Sport IdSportNavigation { get; set; } = null!;
}
