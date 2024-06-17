namespace DGSDataUtils.Entities.DGSEntities;

public partial class MaxPayoutWork
{
    public int RaceId { get; set; }

    public int AccountId { get; set; }

    public decimal AmountPaid { get; set; }

    public decimal Stake { get; set; }
}
