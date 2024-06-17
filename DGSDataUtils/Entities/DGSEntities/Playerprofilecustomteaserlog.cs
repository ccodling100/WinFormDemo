namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playerprofilecustomteaserlog
{
    public int IdPlayerProfileCustomTeaserLog { get; set; }

    public short IdProfile { get; set; }

    public int IdWagerType { get; set; }

    public string FieldName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public short IdUser { get; set; }

    public DateTime PlacedDate { get; set; }

    public short PhoneLine { get; set; }

    public string Ip { get; set; } = null!;
}
