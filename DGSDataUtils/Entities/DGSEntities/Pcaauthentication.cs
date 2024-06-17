namespace DGSDataUtils.Entities.DGSEntities;

public partial class Pcaauthentication
{
    public int Id { get; set; }

    public string LoginName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime LastLogin { get; set; }

    public string LastIpaddress { get; set; } = null!;

    public string LastDeviceId { get; set; } = null!;

    public string Token { get; set; } = null!;
}
