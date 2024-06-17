namespace DGSDataUtils.Entities.DGSEntities;

public partial class PcaeventMap
{
    public int Id { get; set; }

    public int FromId { get; set; }

    public int MasterId { get; set; }

    public int SlaveId { get; set; }

    public int GameTypeId { get; set; }

    public int Rot { get; set; }

    public int EventId { get; set; }

    public DateTime AddedAt { get; set; }

    public int AddedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int UpdatedBy { get; set; }
}
