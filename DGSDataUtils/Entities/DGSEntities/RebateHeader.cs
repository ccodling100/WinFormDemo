namespace DGSDataUtils.Entities.DGSEntities;

public partial class RebateHeader
{
    public int RebateId { get; set; }

    public int AccountId { get; set; }

    public DateTime RebatePaidDate { get; set; }

    public DateTime CutoffDate { get; set; }

    public decimal RebateAmount { get; set; }

    public decimal ExchangeRate { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public virtual Account Account { get; set; } = null!;

    public virtual ICollection<RebateDetail> RebateDetails { get; set; } = new List<RebateDetail>();
}
