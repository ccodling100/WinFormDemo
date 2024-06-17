namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systempreferencesmanager
{
    public short IdSystemPreferencesManager { get; set; }

    public string ActionColumnDisplay { get; set; } = null!;

    public short DaysBeforeInactive { get; set; }

    public bool DefaultAmericanEven { get; set; }

    public short DefaultBook { get; set; }

    public int DefaultGameType { get; set; }

    public decimal DefaultLineHistory { get; set; }

    public short DefaultLineType { get; set; }

    public int DefaultPeriodGameType { get; set; }

    public bool EnabledBonusPoints { get; set; }

    public bool EnabledJuiceChart { get; set; }

    public byte GamesRefresh { get; set; }

    public byte HistoryShowDays { get; set; }

    public short ListMaxItems { get; set; }

    public bool LockDateTransac { get; set; }

    public bool LockAccountOpened { get; set; }

    public bool NewGamesOffBoard { get; set; }

    public bool RefreshAction { get; set; }

    public bool RefreshLines { get; set; }

    public bool SendAmericanLineToDbs { get; set; }

    public bool ShowActionOptions { get; set; }

    public string SoundServerPath { get; set; } = null!;

    public string SoundLocalPath { get; set; } = null!;

    public bool UseDecimals { get; set; }

    public byte UseLeagues { get; set; }

    public bool UseNewSynch { get; set; }

    public byte WeekStartsOn { get; set; }

    public bool? MoveCloseGames { get; set; }

    public bool ChartDefaultAll { get; set; }

    public bool UseRelatedLimit { get; set; }

    public bool UseSplitAgentComm { get; set; }

    public bool UseTaxes { get; set; }

    public bool UseLineSyncByGame { get; set; }

    public bool? SyncRunlineAsSpread { get; set; }

    public bool? SyncGoalLineAsSpread { get; set; }

    /// <summary>
    /// Display Decimals in Chart info if the option UseDecimals is ON
    /// </summary>
    public bool DecimalsChart { get; set; }

    /// <summary>
    /// Option for Action Points to count the 1 to -1 case, if on, then there are 2 AP, if off just 1
    /// </summary>
    public bool ApcountTie { get; set; }

    public bool UseRelatedLimitsOnTeasers { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public bool? IncludeApinChart { get; set; }

    public bool UseDynamicCharting { get; set; }

    public bool? EnforcePassRules { get; set; }

    public bool? SetGamesFinal { get; set; }

    public string LicenseServerIp { get; set; } = null!;

    public int LicenseServerPort { get; set; }
}
