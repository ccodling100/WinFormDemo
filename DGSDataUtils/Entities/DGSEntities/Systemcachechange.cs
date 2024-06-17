namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemcachechange
{
    public int IdSystemCacheChange { get; set; }

    public int IdSystemCacheTable { get; set; }

    public int Pk { get; set; }

    public string? SubPk { get; set; }

    public DateTime TimeStamp { get; set; }

    public byte Action { get; set; }

    public virtual Systemcachetable IdSystemCacheTableNavigation { get; set; } = null!;
}
