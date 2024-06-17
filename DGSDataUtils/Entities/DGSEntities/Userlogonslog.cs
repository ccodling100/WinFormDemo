namespace DGSDataUtils.Entities.DGSEntities;

public partial class Userlogonslog
{
    public int? LogonSessionId { get; set; }

    public short IdUser { get; set; }

    public string System { get; set; } = null!;

    public short PhoneLine { get; set; }

    public DateTime LoginTime { get; set; }

    public DateTime LogoutTime { get; set; }

    public short PhoneLine1 { get; set; }

    public string Ip { get; set; } = null!;

    public short? IdUserLogout { get; set; }
}
