namespace DGSDataUtils.Entities.DGSEntities;

public partial class CwPlayer
{
    public int Idplayer { get; set; }

    public int? Idagent { get; set; }

    public string Player { get; set; } = null!;

    public decimal CurrentBalance { get; set; }

    public byte IdCurrency { get; set; }

    public decimal WeeklySports { get; set; }

    public decimal WeeklyCasino { get; set; }

    public decimal WeeklyHorses { get; set; }

    public bool PlayOnlineSports { get; set; }

    public bool PlayCasino { get; set; }

    public bool PlayOnlineHorses { get; set; }

    public bool PlayLocalSports { get; set; }

    public bool PlayLocalHorses { get; set; }

    public decimal AfterCwsports { get; set; }

    public decimal AfterCwcasino { get; set; }

    public decimal AfterCwhorses { get; set; }

    public decimal SettledFigure { get; set; }
}
