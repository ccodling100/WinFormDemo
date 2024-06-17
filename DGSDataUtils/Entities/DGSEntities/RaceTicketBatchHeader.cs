namespace DGSDataUtils.Entities.DGSEntities;

public partial class RaceTicketBatchHeader
{
    public int BatchId { get; set; }

    public byte BatchType { get; set; }

    public DateTime BatchDateTime { get; set; }

    public bool BatchReady { get; set; }

    public virtual ICollection<RaceTicketBatchDetail> RaceTicketBatchDetails { get; set; } = new List<RaceTicketBatchDetail>();
}
