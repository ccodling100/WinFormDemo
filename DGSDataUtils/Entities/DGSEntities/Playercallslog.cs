namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playercallslog
{
    public int IdCall { get; set; }

    public short PhoneLine { get; set; }

    public int IdPlayer { get; set; }

    public short IdUser { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public short? BetsTaked { get; set; }

    public string Ip { get; set; } = null!;

    public bool Rec { get; set; }

    public string? System { get; set; }

    public string? Url { get; set; }

    public short? IdUserLogout { get; set; }
}
