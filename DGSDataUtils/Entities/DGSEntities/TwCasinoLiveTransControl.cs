namespace DGSDataUtils.Entities.DGSEntities;

public partial class TwCasinoLiveTransControl
{
    public long Idtran { get; set; }

    public string Player { get; set; } = null!;

    public string CasinoLiveTransId { get; set; } = null!;

    public long Dgstransaction { get; set; }

    public double Amount { get; set; }

    public string Type { get; set; } = null!;

    public DateTime Reg { get; set; }
}
