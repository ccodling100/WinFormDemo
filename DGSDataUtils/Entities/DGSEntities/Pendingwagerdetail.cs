namespace DGSDataUtils.Entities.DGSEntities;

public partial class Pendingwagerdetail
{
    public int IdWagerDetail { get; set; }

    public int IdWager { get; set; }

    public string? IdSport { get; set; }

    public int? IdGame { get; set; }

    public int Play { get; set; }

    public byte Period { get; set; }

    public float Points { get; set; }

    public int Odds { get; set; }

    public byte Stat { get; set; }

    public string? VisitorPitcher { get; set; }

    public string? HomePitcher { get; set; }

    public byte? ListedPitcher { get; set; }

    public string Description { get; set; } = null!;

    public DateTime? GameDateTime { get; set; }

    public float PointsPurchased { get; set; }

    public bool Graded { get; set; }

    public byte PitcherStat { get; set; }

    public byte Result { get; set; }

    public string CompleteDescription { get; set; } = null!;

    public int? Vscore { get; set; }

    public int? Hscore { get; set; }

    public bool? IsPastPost { get; set; }

    public float Juice { get; set; }

    public bool KeyDetail { get; set; }

    public decimal ChartDetailRisk { get; set; }

    public decimal ChartDetailWin { get; set; }

    public decimal IfbetAmount { get; set; }

    public byte RiskWin { get; set; }

    public bool ShortGame { get; set; }

    public bool PitcherChange { get; set; }

    /// <summary>
    /// Event.IdEvent. 0= is a match
    /// </summary>
    public short? IdEvent { get; set; }

    public bool LineFromAgent { get; set; }

    public short? IdLeague { get; set; }

    public decimal MasterChartDetailRisk { get; set; }

    public decimal MasterChartDetailWin { get; set; }

    public byte AlternateLine { get; set; }

    public decimal SumChartDetailRisk { get; set; }

    public decimal SumChartDetailWin { get; set; }

    public float? OriginalPoints { get; set; }

    public int? OriginalOdds { get; set; }

    public virtual Game? IdGameNavigation { get; set; }

    public virtual Pendingwagerheader IdWagerNavigation { get; set; } = null!;
}
