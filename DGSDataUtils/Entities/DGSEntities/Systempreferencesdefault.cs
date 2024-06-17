namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systempreferencesdefault
{
    public short IdBook { get; set; }

    public byte DefaultActionPoints { get; set; }

    public short DefaultCurrency { get; set; }

    public decimal DefaultMaxWager { get; set; }

    public decimal DefaultMaxWagerOnline { get; set; }

    public decimal DefaultMinWager { get; set; }

    public decimal DefaultMinWagerOnline { get; set; }

    public string DefaultNhlline { get; set; } = null!;

    public string DefaultMlbline { get; set; } = null!;

    public short DefaultLineType { get; set; }

    public string DefaultLineStyle { get; set; } = null!;

    public byte DefaultOffice { get; set; }

    public short DefaultProfile { get; set; }

    public decimal DefaultSettleAmount { get; set; }

    public bool DefaultShowInTicker { get; set; }

    public byte DefaultSoftLimit { get; set; }

    public int? DefaultAgent { get; set; }

    public short? DefaultGroup { get; set; }

    public short DefaultPlayertype { get; set; }

    public short DefaultFlagType { get; set; }

    public bool DefaultMaster { get; set; }

    public string DefaultEnable { get; set; } = null!;

    public bool DefaultOnline { get; set; }

    public bool DefaultEnableSports { get; set; }

    public bool DefaultEnableCasino { get; set; }

    public bool DefaultEnableHorses { get; set; }

    public bool? DefaultEnableCards { get; set; }

    public short DefaultChart { get; set; }

    public short DefaultMasterChart { get; set; }

    public string DefaultBonusPointsStatus { get; set; } = null!;

    public DateTime DefaultBonusPointsStart { get; set; }

    public DateTime DefaultBonusPointsExpire { get; set; }

    public string? DefaultFlagMessage { get; set; }

    public string? DefaultOnlineMessage { get; set; }

    /// <summary>
    /// timezone to adjust the schedule of the player   (online)
    /// </summary>
    public int IdTimeZone { get; set; }

    /// <summary>
    /// language for the player schedule (online)
    /// </summary>
    public byte IdLanguage { get; set; }

    /// <summary>
    /// Style of the Web Schedule, E=European, A=American
    /// </summary>
    public string ScheduleStyle { get; set; } = null!;

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public short DefaultProfileLimit { get; set; }

    public virtual Book IdBookNavigation { get; set; } = null!;
}
