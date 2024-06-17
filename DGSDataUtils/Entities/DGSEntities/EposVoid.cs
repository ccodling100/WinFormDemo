namespace DGSDataUtils.Entities.DGSEntities;

public partial class EposVoid
{
    public int WagerId { get; set; }

    public string TicketType { get; set; } = null!;

    public int TicketNumber { get; set; }

    public DateTime VoidDateTime { get; set; }

    public short IdUser { get; set; }

    public int ManagerId { get; set; }

    public DateTime OpDate { get; set; }

    public virtual User IdUserNavigation { get; set; } = null!;

    public virtual TerminalManager Manager { get; set; } = null!;
}
