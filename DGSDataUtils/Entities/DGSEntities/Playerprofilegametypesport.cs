namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playerprofilegametypesport
{
    public short IdProfile { get; set; }

    public int IdGameType { get; set; }

    public string IdSport { get; set; } = null!;

    public byte WagerType { get; set; }

    public bool CheckDogOver { get; set; }

    public bool CheckDogUnder { get; set; }

    public bool CheckFavOver { get; set; }

    public bool CheckFavUnder { get; set; }

    public double MaxPoints { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Gametype IdGameTypeNavigation { get; set; } = null!;

    public virtual Playerprofile IdProfileNavigation { get; set; } = null!;

    public virtual Sport IdSportNavigation { get; set; } = null!;
}
