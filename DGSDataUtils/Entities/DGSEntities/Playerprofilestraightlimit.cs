namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playerprofilestraightlimit
{
    public short IdProfile { get; set; }

    public string IdSport { get; set; } = null!;

    public float SpreadPointsPurchaseMax { get; set; }

    public short SpreadPriceHalfPoints { get; set; }

    public short SpreadJuiceDefault { get; set; }

    public float TotalPointsPurchaseMax { get; set; }

    public short TotalPriceHalfPoints { get; set; }

    public short TotalJuiceDefault { get; set; }

    public short On3Surcharge { get; set; }

    public short Off3Surcharge { get; set; }

    public short On7Surcharge { get; set; }

    public short Off7Surcharge { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public bool SurchargeTwice3pts { get; set; }

    public bool SurchargeTwice7pts { get; set; }

    public bool SkipHalfPoint { get; set; }

    public bool CanBuyOn3 { get; set; }

    public bool CanBuyOff3 { get; set; }

    public bool CanBuyOn7 { get; set; }

    public bool CanBuyOff7 { get; set; }

    public virtual Playerprofile IdProfileNavigation { get; set; } = null!;

    public virtual Sport IdSportNavigation { get; set; } = null!;
}
