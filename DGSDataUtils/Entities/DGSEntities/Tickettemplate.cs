namespace DGSDataUtils.Entities.DGSEntities;

public partial class Tickettemplate
{
    public int TicketTemplateId { get; set; }

    public string Description { get; set; } = null!;

    public string TicketTemplate1 { get; set; } = null!;

    public virtual ICollection<Terminal> Terminals { get; set; } = new List<Terminal>();
}
