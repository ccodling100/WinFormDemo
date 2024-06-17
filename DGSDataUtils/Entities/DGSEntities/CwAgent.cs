namespace DGSDataUtils.Entities.DGSEntities;

public partial class CwAgent
{
    public int Idagent { get; set; }

    public int? IdAgentPerHead { get; set; }

    public string Agent { get; set; } = null!;

    public bool IsDistributor { get; set; }

    public int? IdDistributor { get; set; }

    public string? Distributor { get; set; }

    public byte IdAgentType { get; set; }

    public string AgentType { get; set; } = null!;

    public bool DontXfer { get; set; }

    public bool IsDistributed { get; set; }

    public double MakeUp { get; set; }

    public double NewMakeUp { get; set; }

    public double Pbalance { get; set; }

    public double Nbalance { get; set; }

    public short? IdGroup { get; set; }

    public byte IdCurrency { get; set; }

    public decimal GrossSports { get; set; }

    public decimal GrossCasino { get; set; }

    public decimal GrossHorses { get; set; }

    public decimal WeeklySports { get; set; }

    public decimal WeeklyCasino { get; set; }

    public decimal WeeklyHorses { get; set; }

    public decimal CommPctSports { get; set; }

    public decimal CommPctCasino { get; set; }

    public decimal CommPctHorses { get; set; }

    public decimal CommSports { get; set; }

    public decimal CommCasino { get; set; }

    public decimal CommHorses { get; set; }

    public int TotalPlayersOnlineSports { get; set; }

    public int TotalPlayersCasino { get; set; }

    public int TotalPlayersOnlineHorses { get; set; }

    public int TotalPlayersLocalSports { get; set; }

    public int TotalPlayersLocalHorses { get; set; }

    public decimal PhonlineSports { get; set; }

    public decimal Phcasino { get; set; }

    public decimal PhonlineHorses { get; set; }

    public decimal PhlocalSports { get; set; }

    public decimal PhlocalHorses { get; set; }

    public decimal ToDistSports { get; set; }

    public decimal ToDistCasino { get; set; }

    public decimal ToDistHorses { get; set; }

    public decimal ToDistPhonlineSports { get; set; }

    public decimal ToDistPhcasino { get; set; }

    public decimal ToDistPhonlineHorses { get; set; }

    public decimal ToDistPhlocalSports { get; set; }

    public decimal ToDistPhlocalHorses { get; set; }
}
