namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playerprofileparlaybasicsportslog
{
    public int IdLog { get; set; }

    public short IdProfile { get; set; }

    public string Idsport { get; set; } = null!;

    public string FieldName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? Newvalue { get; set; }

    public short IdUser { get; set; }

    public DateTime Placeddate { get; set; }

    public short PhoneLine { get; set; }

    public string Ip { get; set; } = null!;
}
