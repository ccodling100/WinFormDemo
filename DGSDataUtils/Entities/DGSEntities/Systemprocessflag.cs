namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemprocessflag
{
    public string ProcessName { get; set; } = null!;

    public short IdUser { get; set; }

    public DateTime StartDate { get; set; }

    public short? PhoneLine { get; set; }

    public string? Ip { get; set; }
}
