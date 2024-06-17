namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemchangedlineslog
{
    public int IdSystemChangedLines { get; set; }

    public short? IdLineType { get; set; }

    public string? IdSport { get; set; }

    public short? IdUser { get; set; }

    public int? IdGame { get; set; }

    public int? TeamNumber { get; set; }

    public byte? ColumnNumber { get; set; }

    public string? ChangeValue { get; set; }

    public short? PhoneLine { get; set; }

    public DateTime? PlacedDate { get; set; }

    public int? Play { get; set; }

    public int? IdAgent { get; set; }
}
