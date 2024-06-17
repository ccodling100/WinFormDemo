namespace DGSDataUtils.Entities.DGSEntities;

public partial class RaceControl
{
    public byte Pk { get; set; }

    public string MetaVer { get; set; } = null!;

    public string? AmtoteGateway { get; set; }

    public string? AmtoteAccount { get; set; }

    public string? AmtotePin { get; set; }

    public byte? EposTransferPaymentMethod { get; set; }

    public string? BetTickerServer { get; set; }

    public virtual Paymentmethod? EposTransferPaymentMethodNavigation { get; set; }
}
