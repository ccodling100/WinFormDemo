namespace DGSDataUtils.Entities.DGSEntities;

public partial class TwLoginRequest
{
    public long Id { get; set; }

    public string Otp { get; set; } = null!;

    public long Idplayer { get; set; }

    public string Player { get; set; } = null!;

    public DateTime Reg { get; set; }
}
