namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemdbsperiod
{
    public int IdSystemDbsperiod { get; set; }

    public int LeagueId { get; set; }

    public int Period { get; set; }

    public string IdSport { get; set; } = null!;

    public byte NumberOfPeriod { get; set; }
}
