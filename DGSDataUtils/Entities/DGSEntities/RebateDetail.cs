namespace DGSDataUtils.Entities.DGSEntities;

public partial class RebateDetail
{
    public int RebateId { get; set; }

    public byte BetType { get; set; }

    public byte Uitype { get; set; }

    public decimal Volume { get; set; }

    public decimal Rebate { get; set; }

    public decimal WinLoss { get; set; }

    public decimal VolumeRebate { get; set; }

    public virtual RebateHeader RebateNavigation { get; set; } = null!;
}
