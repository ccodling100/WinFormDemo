namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemerrorlog
{
    public int IdsystemErrorLog { get; set; }

    public string ErrorMessage { get; set; } = null!;

    public string? Comments { get; set; }

    public string? System { get; set; }

    public DateTime ErrorDate { get; set; }

    public short IdUser { get; set; }
}
