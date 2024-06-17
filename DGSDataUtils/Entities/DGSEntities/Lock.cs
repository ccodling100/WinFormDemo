namespace DGSDataUtils.Entities.DGSEntities;

public partial class Lock
{
    public int LockId { get; set; }

    public byte LockType { get; set; }

    public int LockTypeId { get; set; }

    public short IdUser { get; set; }

    public int LogonSessionId { get; set; }

    public DateTime Acquired { get; set; }
}
