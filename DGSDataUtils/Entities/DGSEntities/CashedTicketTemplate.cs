namespace DGSDataUtils.Entities.DGSEntities;

public partial class CashedTicketTemplate
{
    public int CashedTicketTemplateId { get; set; }

    public string Description { get; set; } = null!;

    public string CashedTicketTemplate1 { get; set; } = null!;

    public virtual ICollection<Terminal> Terminals { get; set; } = new List<Terminal>();
}
