namespace DGSDataUtils.Entities.DGSEntities;

public partial class Vipaccount
{
    public int DgsaccountId { get; set; }

    public int AccountId { get; set; }

    public int LicenseId { get; set; }

    public string AccountName { get; set; } = null!;
}
