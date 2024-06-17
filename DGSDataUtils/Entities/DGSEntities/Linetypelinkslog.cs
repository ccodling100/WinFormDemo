namespace DGSDataUtils.Entities.DGSEntities;

public partial class Linetypelinkslog
{
    public short IdLineTypeOut { get; set; }

    public short IdLineTypeIn { get; set; }

    public string IdSport { get; set; } = null!;

    public string FieldName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public short IdUser { get; set; }

    public DateTime PlacedDate { get; set; }

    public short PhoneLine { get; set; }

    public string Ip { get; set; } = null!;
}
