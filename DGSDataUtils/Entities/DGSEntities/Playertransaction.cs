namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playertransaction
{
    public int IdTransaction { get; set; }

    public int IdPlayer { get; set; }

    public DateTime PlacedDate { get; set; }

    public string Description { get; set; } = null!;

    public decimal Amount { get; set; }

    public string Reference { get; set; } = null!;

    public decimal Fee { get; set; }

    public decimal Bonus { get; set; }

    public byte IdPaymentMethod { get; set; }

    public byte? IdAdjustmentType { get; set; }

    public string TransactionType { get; set; } = null!;

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Adjustmenttype? IdAdjustmentTypeNavigation { get; set; }

    public virtual Paymentmethod IdPaymentMethodNavigation { get; set; } = null!;

    public virtual Player IdPlayerNavigation { get; set; } = null!;
}
