namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systembonussettingdetail
{
    public byte WagerType { get; set; }

    public string? Description { get; set; }

    public decimal? PointsPerUnit { get; set; }

    public DateTime? LastModification { get; set; }

    public short? LastModificationUser { get; set; }
}
