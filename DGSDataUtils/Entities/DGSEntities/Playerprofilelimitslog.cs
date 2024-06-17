namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playerprofilelimitslog
{
    public int IdProfileLimitsLog { get; set; }

    public int IdProfileLimits { get; set; }

    public string FieldName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public int IdUser { get; set; }

    public DateTime PlacedDate { get; set; }

    public short PhoneLine { get; set; }

    public string Ip { get; set; } = null!;
}
