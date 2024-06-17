namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemservicesreg
{
    public int IdServiceReg { get; set; }

    public byte IdService { get; set; }

    public string Ipaddress { get; set; } = null!;

    public bool Enable { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public short? IdUser { get; set; }

    public short? PhoneLine { get; set; }

    public virtual Systemservice IdServiceNavigation { get; set; } = null!;

    public virtual User? IdUserNavigation { get; set; }
}
