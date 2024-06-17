namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systembetradarcategory
{
    public int CategoryId { get; set; }

    public byte SportId { get; set; }

    public string CategoryName { get; set; } = null!;

    public bool Enabled { get; set; }

    public DateTime LastModification { get; set; }

    public int LastModificationUser { get; set; }

    public short? OutrightIdLeague { get; set; }

    public int? OutrightIdGametype { get; set; }

    public bool OutrightEnabled { get; set; }

    public bool OutrightImportOdds { get; set; }

    public byte OutrightImportScores { get; set; }

    public bool? HasTournaments { get; set; }

    public virtual Gametype? OutrightIdGametypeNavigation { get; set; }

    public virtual League? OutrightIdLeagueNavigation { get; set; }

    public virtual Systembetradarsport Sport { get; set; } = null!;

    public virtual ICollection<Systembetradartournament> Systembetradartournaments { get; set; } = new List<Systembetradartournament>();
}
