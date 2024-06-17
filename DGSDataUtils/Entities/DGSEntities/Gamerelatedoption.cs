namespace DGSDataUtils.Entities.DGSEntities;

public partial class Gamerelatedoption
{
    public short IdProfile { get; set; }

    public string IdSport { get; set; } = null!;

    public byte IdPeriod { get; set; }

    public bool MlfavOver { get; set; }

    public bool MlfavUnder { get; set; }

    public bool MldogOver { get; set; }

    public bool MldogUnder { get; set; }

    public bool SprFavOver { get; set; }

    public bool SprFavUnder { get; set; }

    public bool SprDogOver { get; set; }

    public bool SprDogUnder { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Playerprofile IdProfileNavigation { get; set; } = null!;

    public virtual Sport IdSportNavigation { get; set; } = null!;
}
