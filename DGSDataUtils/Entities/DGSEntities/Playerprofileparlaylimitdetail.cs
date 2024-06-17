namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playerprofileparlaylimitdetail
{
    public short IdProfile { get; set; }

    public string IdSport { get; set; } = null!;

    public byte NumTeams { get; set; }

    public byte MaxGames { get; set; }

    public byte MaxDogs { get; set; }

    public bool? UseFormula { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public byte MaxMoneyLines { get; set; }

    public byte MaxTotalLines { get; set; }

    public virtual Sport IdSportNavigation { get; set; } = null!;
}
