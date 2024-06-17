namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playerlog
{
    public int IdPlayerLog { get; set; }

    public int IdPlayer { get; set; }

    public string? Player { get; set; }

    public string FieldName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public short IdUser { get; set; }

    public DateTime PlacedDate { get; set; }

    public short PhoneLine { get; set; }

    public string Ip { get; set; } = null!;
}
