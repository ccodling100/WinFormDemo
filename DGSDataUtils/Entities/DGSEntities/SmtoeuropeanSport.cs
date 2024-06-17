namespace DGSDataUtils.Entities.DGSEntities;

public partial class SmtoeuropeanSport
{
    public short IdEuropeanSport { get; set; }

    public string IdSport { get; set; } = null!;

    public virtual Sport IdSportNavigation { get; set; } = null!;
}
