namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemsoconfig
{
    public string? ServerIp { get; set; }

    public short? ServerPort { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public DateTime? LastModification { get; set; }

    public short? LastModificationUser { get; set; }

    public bool Enabled { get; set; }
}
