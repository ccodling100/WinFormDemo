namespace DGSDataUtils.Entities.DGSEntities;

public partial class Gamelog
{
    public int IdGameLog { get; set; }

    public int IdGame { get; set; }

    public int? TeamNumber { get; set; }

    public string FieldName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public short IdUser { get; set; }

    public string LoginName { get; set; } = null!;

    public DateTime PlacedDate { get; set; }

    public short PhoneLine { get; set; }

    public string Ip { get; set; } = null!;
}
