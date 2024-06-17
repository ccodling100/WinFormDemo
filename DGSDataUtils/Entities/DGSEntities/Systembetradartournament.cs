namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systembetradartournament
{
    public int TournamentId { get; set; }

    public int CategoryId { get; set; }

    public string TournamentName { get; set; } = null!;

    public int UniqueTournamentId { get; set; }

    public string UniqueTournamentName { get; set; } = null!;

    public short? IdLeague { get; set; }

    public int? IdGametype { get; set; }

    public bool Enabled { get; set; }

    public bool ImportOdds { get; set; }

    public byte ImportScores { get; set; }

    public short ImportCsasProps { get; set; }

    public short? IdLeagueCs { get; set; }

    public DateTime LastModification { get; set; }

    public int LastModificationUser { get; set; }

    public virtual Systembetradarcategory Category { get; set; } = null!;

    public virtual Gametype? IdGametypeNavigation { get; set; }

    public virtual League? IdLeagueCsNavigation { get; set; }

    public virtual League? IdLeagueNavigation { get; set; }
}
