namespace DGSDataUtils.Entities.DGSEntities;

public partial class IcontentScheduleDetail
{
    public long IdDetails { get; set; }

    public string? Title { get; set; }

    public string? Away { get; set; }

    public string? Home { get; set; }

    public int? AwayMoneyLine { get; set; }

    public int? HomeMoneyLine { get; set; }

    public decimal? AwaySpread { get; set; }

    public decimal? HomeSpread { get; set; }

    public decimal? AwayTotal { get; set; }

    public decimal? HomeTotal { get; set; }

    public bool? Enable { get; set; }

    public long? IdSchedule { get; set; }

    public DateTime? Regdate { get; set; }

    public DateTime? GameDatetime { get; set; }

    public long? Dgsidgame { get; set; }

    public decimal? ContestValues { get; set; }

    public DateTime? ProcessDate { get; set; }

    public bool? Graded { get; set; }
}
