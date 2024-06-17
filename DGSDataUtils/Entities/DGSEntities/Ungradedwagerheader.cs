namespace DGSDataUtils.Entities.DGSEntities;

public partial class Ungradedwagerheader
{
    public int IdWager { get; set; }

    public short IdLineType { get; set; }

    public int IdPlayer { get; set; }

    public short IdUser { get; set; }

    public short IdProfile { get; set; }

    public int IdWagerType { get; set; }

    public int IdCall { get; set; }

    public short PhoneLine { get; set; }

    public DateTime PlacedDate { get; set; }

    public decimal RiskAmount { get; set; }

    public decimal WinAmount { get; set; }

    public DateTime? SettledDate { get; set; }

    public byte Stat { get; set; }

    public string Description { get; set; } = null!;

    public decimal MoneyChange { get; set; }

    public decimal OriginalWagerAmount { get; set; }

    public byte ChartPct { get; set; }

    public decimal OriginalRiskAmount { get; set; }

    public decimal OriginalWinAmount { get; set; }

    public byte Result { get; set; }

    public bool Graded { get; set; }

    public bool OpenPlay { get; set; }

    public bool? FreePlay { get; set; }

    public byte RiskWin { get; set; }

    public float PointsPurchased { get; set; }

    public string CompleteDescription { get; set; } = null!;

    public int? IfParent { get; set; }

    public int? IfChild { get; set; }

    public bool IfParentGraded { get; set; }

    public byte? IfParentResult { get; set; }

    public decimal IfBetRiskAmount { get; set; }

    public byte IfBetWagerType { get; set; }

    public int TicketNumber { get; set; }

    public bool Epos { get; set; }

    public bool Epospaid { get; set; }

    public int? IdcardHeader { get; set; }

    public byte WagerType { get; set; }

    public short IdBook { get; set; }

    public decimal TaxAmount { get; set; }

    public short CrrnumDetails { get; set; }

    public DateTime LastModification { get; set; }

    public byte MasterChartPct { get; set; }

    public string Ip { get; set; } = null!;

    public int? IdAgent { get; set; }
}
