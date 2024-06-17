namespace DGSDataUtils.Entities.DGSEntities;

public partial class TerminalManager
{
    public int ManagerId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool Enabled { get; set; }

    public virtual ICollection<ActiveTill> ActiveTills { get; set; } = new List<ActiveTill>();

    public virtual ICollection<EposPlayerChangeLog> EposPlayerChangeLogs { get; set; } = new List<EposPlayerChangeLog>();

    public virtual ICollection<EposPlayer> EposPlayers { get; set; } = new List<EposPlayer>();

    public virtual ICollection<EposVoid> EposVoids { get; set; } = new List<EposVoid>();

    public virtual ICollection<InactiveTill> InactiveTillOpenedByNavigations { get; set; } = new List<InactiveTill>();

    public virtual ICollection<InactiveTill> InactiveTillReconciledByNavigations { get; set; } = new List<InactiveTill>();

    public virtual ICollection<ManagerRight> ManagerRights { get; set; } = new List<ManagerRight>();

    public virtual ICollection<TicketHoldRelease> TicketHoldReleaseManagers { get; set; } = new List<TicketHoldRelease>();

    public virtual ICollection<TicketHoldRelease> TicketHoldReleaseReleaseManagers { get; set; } = new List<TicketHoldRelease>();

    public virtual ICollection<TicketHold> TicketHolds { get; set; } = new List<TicketHold>();

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();
}
