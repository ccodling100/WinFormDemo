namespace DGSDataUtils.Entities.DGSEntities;

public partial class RaceTicketBatchDetail
{
    public int BatchId { get; set; }

    public int TicketId { get; set; }

    public byte BatchType { get; set; }

    public int WagerId { get; set; }

    public int AccountId { get; set; }

    public decimal TotalStake { get; set; }

    public decimal WinAmount { get; set; }

    public decimal RefundAmount { get; set; }

    public DateTime SettleDate { get; set; }

    public virtual RaceTicketBatchHeader Batch { get; set; } = null!;
}
