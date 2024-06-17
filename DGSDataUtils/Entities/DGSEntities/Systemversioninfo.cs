namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemversioninfo
{
    public short IdSystemVersioninfo { get; set; }

    public string DbVersion { get; set; } = null!;

    public short CustoId { get; set; }

    public bool EposEnabled { get; set; }

    public bool HorseEnabled { get; set; }

    public bool BonusPointsEnabled { get; set; }

    public bool CasinoEnabled { get; set; }

    public bool CardsEnabled { get; set; }

    public byte DaysBeforeExpirationWarning { get; set; }

    public bool UseWindowsUser { get; set; }

    public DateTime? LastArchivingDate { get; set; }

    public bool GameSyncEnabled { get; set; }

    public DateTime LastModification { get; set; }

    public string LastModificationUser { get; set; } = null!;

    public bool UsePassEncryptPlayers { get; set; }

    public bool UsePassEncryptUsers { get; set; }

    public bool UsePassEncryptAgents { get; set; }

    public bool UseNewAgentProcess { get; set; }

    public bool EnableCacheTriggers { get; set; }

    public bool DisplayEventsAsGames { get; set; }

    public bool AllowRotationChanges { get; set; }
}
