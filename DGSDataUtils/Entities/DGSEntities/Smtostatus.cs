namespace DGSDataUtils.Entities.DGSEntities;

public partial class Smtostatus
{
    public short IdStatus { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<SmtoagentGameValueAdjustment> SmtoagentGameValueAdjustments { get; set; } = new List<SmtoagentGameValueAdjustment>();

    public virtual ICollection<SmtoexcludedGame> SmtoexcludedGames { get; set; } = new List<SmtoexcludedGame>();

    public virtual ICollection<SmtogameValueAdjustment> SmtogameValueAdjustments { get; set; } = new List<SmtogameValueAdjustment>();

    public virtual ICollection<Smtolimit> Smtolimits { get; set; } = new List<Smtolimit>();

    public virtual ICollection<SmtolineTypeBookLink> SmtolineTypeBookLinks { get; set; } = new List<SmtolineTypeBookLink>();

    public virtual ICollection<SmtolinksLog> SmtolinksLogs { get; set; } = new List<SmtolinksLog>();
}
