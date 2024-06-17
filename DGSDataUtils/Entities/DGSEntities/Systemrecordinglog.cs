namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemrecordinglog
{
    public short PhoneLine { get; set; }

    public int? IdCall { get; set; }

    public string Application { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime ErrorDate { get; set; }
}
