namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemdbssport
{
    public int LeagueId { get; set; }

    public int? BookId { get; set; }

    public short IdLeague { get; set; }

    public int? BookIdTnt { get; set; }

    public short? IdTntleague { get; set; }

    public int? BookIdProps { get; set; }

    public bool ProcessSchedule { get; set; }

    public bool ProcessLineChanges { get; set; }

    public byte ProcessScores { get; set; }

    public bool? ProcessProps { get; set; }

    public DateTime LastModification { get; set; }

    public int LastModificationUser { get; set; }

    public virtual Systemdbsbook? Book { get; set; }

    public virtual Systemdbsbook? BookIdPropsNavigation { get; set; }

    public virtual Systemdbsbook? BookIdTntNavigation { get; set; }

    public virtual League IdLeagueNavigation { get; set; } = null!;

    public virtual Systemdbsleague League { get; set; } = null!;
}
