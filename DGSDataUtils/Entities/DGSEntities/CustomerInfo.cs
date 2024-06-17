namespace DGSDataUtils.Entities.DGSEntities;

public partial class CustomerInfo
{
    public int CustomerId { get; set; }

    public string Account { get; set; } = null!;

    public string? Password { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public bool Active { get; set; }

    public int? GroupId { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Country { get; set; }

    public string? State { get; set; }

    public string? City { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? ZipCode { get; set; }

    public string? Reference { get; set; }

    public string? CreatedBy { get; set; }

    public string? UsedBy { get; set; }

    public DateTime? FirstDepositDate { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? PhoneDialed { get; set; }

    public bool BypassCheck { get; set; }

    public bool RestrictWithdrawals { get; set; }

    public string? ClerkMessage { get; set; }

    public string? ChartMessage { get; set; }

    public int RemainingCountChart { get; set; }

    public string? CservMessage { get; set; }

    public int RemainingCountCserv { get; set; }

    public int? Agent { get; set; }

    public string? CservClerkMsg { get; set; }

    public int RemainingCountCservClerk { get; set; }

    public string? SecurityQuestion { get; set; }

    public string? SecurityAnswer { get; set; }

    public int? SessionId { get; set; }

    public DateTime? SessionStart { get; set; }

    public bool? Sharpie { get; set; }

    public decimal? SettlementFigure { get; set; }

    public int? LimitRuleId { get; set; }

    public decimal? MaxBetPhone { get; set; }

    public decimal? MaxBetWeb { get; set; }

    public int LineGroupId { get; set; }

    public DateTime? LastAccess { get; set; }

    public short NotationId { get; set; }

    public short CurrencyId { get; set; }

    public decimal? MinBetPhone { get; set; }

    public decimal? MinBetWeb { get; set; }

    public bool ReachedCcCap { get; set; }

    public bool Demo { get; set; }

    public bool ReachedCcStmt { get; set; }

    public string DispatchMethod { get; set; } = null!;

    public int RemainingCountClerk { get; set; }

    public short? ReceiveMailsBook { get; set; }

    public short? ReceiveMailsPartners { get; set; }
}
