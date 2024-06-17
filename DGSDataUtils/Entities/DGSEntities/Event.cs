namespace DGSDataUtils.Entities.DGSEntities;

public partial class Event
{
    public short IdEvent { get; set; }

    public short IdLeague { get; set; }

    public short IdTargetLeague { get; set; }

    public int IdGameType { get; set; }

    public string Description { get; set; } = null!;

    public string GameDescription { get; set; } = null!;

    public byte RotCalcMethod { get; set; }

    public int RotCalcArg1 { get; set; }

    public int RotCalcArg2 { get; set; }

    public int RotCalcArg3 { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public bool IncludePitchers { get; set; }

    public byte? SystemDbseventId { get; set; }

    public virtual ICollection<Eventdetail> Eventdetails { get; set; } = new List<Eventdetail>();

    public virtual ICollection<Eventlang> Eventlangs { get; set; } = new List<Eventlang>();

    public virtual ICollection<Game> Games { get; set; } = new List<Game>();

    public virtual ICollection<Gamestatpubqueue> Gamestatpubqueues { get; set; } = new List<Gamestatpubqueue>();

    public virtual ICollection<Gradedgame> Gradedgames { get; set; } = new List<Gradedgame>();

    public virtual Gametype IdGameTypeNavigation { get; set; } = null!;

    public virtual League IdLeagueNavigation { get; set; } = null!;

    public virtual League IdTargetLeagueNavigation { get; set; } = null!;

    public virtual Systemdbsevent? SystemDbsevent { get; set; }

    public virtual ICollection<Wagerdetail> Wagerdetails { get; set; } = new List<Wagerdetail>();
}
