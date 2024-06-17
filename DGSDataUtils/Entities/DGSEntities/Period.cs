namespace DGSDataUtils.Entities.DGSEntities;

public partial class Period
{
    public string IdSport { get; set; } = null!;

    public byte NumberOfPeriod { get; set; }

    public string PeriodDescription { get; set; } = null!;

    public virtual Sport IdSportNavigation { get; set; } = null!;
}
