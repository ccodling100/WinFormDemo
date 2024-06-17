namespace DGSDataUtils.Entities.DGSEntities;

public partial class Agenttransaction
{
    public int IdTransaction { get; set; }

    public int IdAgent { get; set; }

    public DateTime PlacedDate { get; set; }

    public string Description { get; set; } = null!;

    public decimal Amount { get; set; }

    public string Reference { get; set; } = null!;

    public byte IdPaymentMethod { get; set; }

    public string TransactionType { get; set; } = null!;

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Agent IdAgentNavigation { get; set; } = null!;

    public virtual Paymentmethod IdPaymentMethodNavigation { get; set; } = null!;
}
