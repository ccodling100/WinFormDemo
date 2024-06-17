namespace DGSDataUtils.Entities.DGSEntities;

public partial class Wagertypesport
{
    public int IdWagerType { get; set; }

    public string IdSport { get; set; } = null!;

    public bool Online { get; set; }

    public bool Local { get; set; }

    public virtual Sport IdSportNavigation { get; set; } = null!;

    public virtual Wagertype IdWagerTypeNavigation { get; set; } = null!;
}
