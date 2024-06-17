namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemsosport
{
    public int LeagueId { get; set; }

    public int? BookId { get; set; }

    public short? IdLeague { get; set; }

    public short? IdPropLeague { get; set; }

    public bool ProcessSchedule { get; set; }

    public bool ProcessLineChanges { get; set; }

    public byte ProcessScores { get; set; }

    public DateTime LastModification { get; set; }

    public int LastModificationUser { get; set; }

    public virtual Systemsobook? Book { get; set; }

    public virtual League? IdLeagueNavigation { get; set; }

    public virtual League? IdPropLeagueNavigation { get; set; }

    public virtual Systemsoleague League { get; set; } = null!;
}
