namespace DGSDataUtils.Entities.DGSEntities;

public partial class TerminalSessionActive
{
    public int TermSessId { get; set; }

    public int TerminalId { get; set; }

    public int LocationId { get; set; }

    public short IdUser { get; set; }

    public int ActiveTillId { get; set; }

    public byte Lang { get; set; }

    public DateTime OpenedDateTime { get; set; }

    public DateTime LastActivity { get; set; }

    public int IdPlayer { get; set; }

    public short IdLineType { get; set; }

    public string Nhlline { get; set; } = null!;

    public string Mlbline { get; set; } = null!;

    public int IdCall { get; set; }

    public virtual Player IdPlayerNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;

    public virtual Terminal Terminal { get; set; } = null!;
}
