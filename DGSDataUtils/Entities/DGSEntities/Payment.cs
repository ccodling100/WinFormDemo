namespace DGSDataUtils.Entities.DGSEntities;

public partial class Payment
{
    public short IdPayment { get; set; }

    public int IdPlayer { get; set; }

    public byte? TransType { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? FinalAmount { get; set; }

    public string? RequestData { get; set; }

    public string? ResponseData { get; set; }

    public byte? PaymentType { get; set; }

    public string? PaymentMethod { get; set; }

    public virtual Player IdPlayerNavigation { get; set; } = null!;
}
