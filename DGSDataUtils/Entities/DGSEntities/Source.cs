namespace DGSDataUtils.Entities.DGSEntities;

public partial class Source
{
    public short IdSource { get; set; }

    public string SourceName { get; set; } = null!;

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }
}
