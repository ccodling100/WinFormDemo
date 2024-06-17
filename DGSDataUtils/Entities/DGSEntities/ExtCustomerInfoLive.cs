namespace DGSDataUtils.Entities.DGSEntities;

public partial class ExtCustomerInfoLive
{
    public int Idplayer { get; set; }

    public int Idagent { get; set; }

    public string CustomerId { get; set; } = null!;

    public string AgentId { get; set; } = null!;

    public string? Token { get; set; }

    public DateTime? TokenExpTime { get; set; }

    public double? CreditLimit { get; set; }

    public string? Active { get; set; }

    public int? PercentBook { get; set; }

    public double? WagerLimit { get; set; }

    public string? StaticLinesFlag { get; set; }

    public string? CreditAcctFlag { get; set; }

    public string? BaseballAction { get; set; }

    public string? UsePuckLineFlag { get; set; }

    public string? ZeroBalanceFlag { get; set; }

    public string? Currency { get; set; }

    public double? CurrentBalance { get; set; }

    public double? PendingWagerBalance { get; set; }

    public int? PendingWagerCount { get; set; }

    public string? PriceType { get; set; }

    public string? Company { get; set; }

    public string? Store { get; set; }

    public double? TempCreditAdj { get; set; }

    public DateTime? TempCreditAdjExpDate { get; set; }
}
