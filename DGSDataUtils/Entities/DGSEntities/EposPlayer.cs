namespace DGSDataUtils.Entities.DGSEntities;

public partial class EposPlayer
{
    public int EposPlayerId { get; set; }

    public string AcctNum { get; set; } = null!;

    public int? IdPlayer { get; set; }

    public string? Pin { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? Addr1 { get; set; }

    public string? Addr2 { get; set; }

    public string? City { get; set; }

    public string? Province { get; set; }

    public string? Country { get; set; }

    public string? Zip { get; set; }

    public string? Email { get; set; }

    public string? Phone1Desc { get; set; }

    public string? Phone1 { get; set; }

    public string? Phone2Desc { get; set; }

    public string? Phone2 { get; set; }

    public DateTime CreateDate { get; set; }

    public int CreateManagerId { get; set; }

    public int CreateLocationId { get; set; }

    public DateTime LastUpdate { get; set; }

    public virtual Location CreateLocation { get; set; } = null!;

    public virtual TerminalManager CreateManager { get; set; } = null!;

    public virtual EposPlayerCardQ? EposPlayerCardQ { get; set; }

    public virtual ICollection<EposPlayerChangeLog> EposPlayerChangeLogs { get; set; } = new List<EposPlayerChangeLog>();

    public virtual EposPlayerPhoto? EposPlayerPhoto { get; set; }

    public virtual ICollection<EposSportsbookTransfer> EposSportsbookTransfers { get; set; } = new List<EposSportsbookTransfer>();

    public virtual Player? IdPlayerNavigation { get; set; }

    public virtual ICollection<TicketMain> TicketMains { get; set; } = new List<TicketMain>();
}
