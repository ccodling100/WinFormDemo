namespace DGSDataUtils.Entities.DGSEntities;

public partial class Agentadjustment
{
    public int IdAdjustment { get; set; }

    public int? IdAgent { get; set; }

    public int? IdSubAgent { get; set; }

    public decimal? CommAmount { get; set; }

    public decimal? CommPayment { get; set; }

    public int? CommType { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? LastModification { get; set; }
}
