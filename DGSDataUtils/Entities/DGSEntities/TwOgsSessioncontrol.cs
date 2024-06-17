namespace DGSDataUtils.Entities.DGSEntities;

public partial class TwOgsSessioncontrol
{
    public long Idsession { get; set; }

    public string Player { get; set; } = null!;

    public string Session { get; set; } = null!;

    public DateTime Datetime { get; set; }

    public string? Status { get; set; }
}
