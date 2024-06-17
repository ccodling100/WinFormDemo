namespace DGSDataUtils.Entities.DGSEntities;

public partial class PcasystemInfo
{
    public int Id { get; set; }

    public string Version { get; set; } = null!;

    public bool Enabled { get; set; }

    public string SystemUser { get; set; } = null!;

    public string SystemPass { get; set; } = null!;

    public string DbdataSource { get; set; } = null!;

    public string Dbcatalog { get; set; } = null!;

    public string Dbusername { get; set; } = null!;

    public string Dbpassword { get; set; } = null!;

    public bool UseLinkedLineTypes { get; set; }

    public bool UseOddsBySports { get; set; }

    public bool AutoImportGames { get; set; }

    public bool OnlyUpdateOpenGames { get; set; }

    public bool AutoMoveWhenOpenGames { get; set; }

    public bool DontUpdateAfterGameTime { get; set; }

    public int DefaultLineType { get; set; }

    public int DefaultGameType { get; set; }

    public int DefaultNss { get; set; }

    public int DefaultTimeOffset { get; set; }

    public string StreamEndpoint { get; set; } = null!;

    public string StreamLogin { get; set; } = null!;

    public string StreamPassword { get; set; } = null!;

    public DateTime UpdatedAt { get; set; }

    public int UpdatedBy { get; set; }
}
