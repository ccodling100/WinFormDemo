namespace DGSDataUtils.Entities.DGSEntities;

public partial class Userlogon
{
    public int LogonSessionId { get; set; }

    public short IdUser { get; set; }

    public string System { get; set; } = null!;

    public short PhoneLine { get; set; }

    public DateTime LoginTime { get; set; }

    public string Ip { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
