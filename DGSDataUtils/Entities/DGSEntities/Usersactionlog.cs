namespace DGSDataUtils.Entities.DGSEntities;

public partial class Usersactionlog
{
    public int IdUserActionLog { get; set; }

    public short IdUser { get; set; }

    public DateTime AccessDate { get; set; }

    public int Account { get; set; }

    public string AccountType { get; set; } = null!;

    public string Description { get; set; } = null!;

    public short PhoneLine { get; set; }

    public string Ip { get; set; } = null!;
}
