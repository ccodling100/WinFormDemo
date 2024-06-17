namespace DGSDataUtils.Entities.DGSEntities;

public partial class Gameactionbyagent
{
    public int IdAgent { get; set; }

    public int IdGame { get; set; }

    public decimal? VisitorRisk { get; set; }

    public decimal? VisitorWin { get; set; }

    public int? VisitorCount { get; set; }

    public decimal? HomeRisk { get; set; }

    public decimal? HomeWin { get; set; }

    public int? HomeCount { get; set; }

    public decimal? TotalOverRisk { get; set; }

    public decimal? TotalOverWin { get; set; }

    public int? TotalOverCount { get; set; }

    public decimal? TotalUnderRisk { get; set; }

    public decimal? TotalUnderWin { get; set; }

    public int? TotalUnderCount { get; set; }

    public decimal? VisitorSpreadRisk { get; set; }

    public decimal? VisitorSpreadWin { get; set; }

    public int? VisitorSpreadCount { get; set; }

    public decimal? HomeSpreadRisk { get; set; }

    public decimal? HomeSpreadWin { get; set; }

    public int? HomeSpreadCount { get; set; }

    public decimal? VisitorSpecialRisk { get; set; }

    public decimal? VisitorSpecialWin { get; set; }

    public int? VisitorSpecialCount { get; set; }

    public decimal? HomeSpecialRisk { get; set; }

    public decimal? HomeSpecialWin { get; set; }

    public int? HomeSpecialCount { get; set; }

    public decimal? MasterVisitorRisk { get; set; }

    public decimal? MasterVisitorWin { get; set; }

    public int? MasterVisitorCount { get; set; }

    public decimal? MasterHomeRisk { get; set; }

    public decimal? MasterHomeWin { get; set; }

    public int? MasterHomeCount { get; set; }

    public decimal? MasterTotalOverRisk { get; set; }

    public decimal? MasterTotalOverWin { get; set; }

    public int? MasterTotalOverCount { get; set; }

    public decimal? MasterTotalUnderRisk { get; set; }

    public decimal? MasterTotalUnderWin { get; set; }

    public int? MasterTotalUnderCount { get; set; }

    public decimal? MasterVisitorSpreadRisk { get; set; }

    public decimal? MasterVisitorSpreadWin { get; set; }

    public int? MasterVisitorSpreadCount { get; set; }

    public decimal? MasterHomeSpreadRisk { get; set; }

    public decimal? MasterHomeSpreadWin { get; set; }

    public int? MasterHomeSpreadCount { get; set; }

    public decimal? MasterVisitorSpecialRisk { get; set; }

    public decimal? MasterVisitorSpecialWin { get; set; }

    public int? MasterVisitorSpecialCount { get; set; }

    public decimal? MasterHomeSpecialRisk { get; set; }

    public decimal? MasterHomeSpecialWin { get; set; }

    public int? MasterHomeSpecialCount { get; set; }

    public decimal? SumVisitorRisk { get; set; }

    public decimal? SumVisitorWin { get; set; }

    public int? SumVisitorCount { get; set; }

    public decimal? SumHomeRisk { get; set; }

    public decimal? SumHomeWin { get; set; }

    public int? SumHomeCount { get; set; }

    public decimal? SumTotalOverRisk { get; set; }

    public decimal? SumTotalOverWin { get; set; }

    public int? SumTotalOverCount { get; set; }

    public decimal? SumTotalUnderRisk { get; set; }

    public decimal? SumTotalUnderWin { get; set; }

    public int? SumTotalUnderCount { get; set; }

    public decimal? SumVisitorSpreadRisk { get; set; }

    public decimal? SumVisitorSpreadWin { get; set; }

    public int? SumVisitorSpreadCount { get; set; }

    public decimal? SumHomeSpreadRisk { get; set; }

    public decimal? SumHomeSpreadWin { get; set; }

    public int? SumHomeSpreadCount { get; set; }

    public decimal? SumVisitorSpecialRisk { get; set; }

    public decimal? SumVisitorSpecialWin { get; set; }

    public int? SumVisitorSpecialCount { get; set; }

    public decimal? SumHomeSpecialRisk { get; set; }

    public decimal? SumHomeSpecialWin { get; set; }

    public int? SumHomeSpecialCount { get; set; }

    public virtual Agent IdAgentNavigation { get; set; } = null!;

    public virtual Game IdGameNavigation { get; set; } = null!;
}
