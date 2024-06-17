namespace DGSDataUtils.Entities.DGSEntities;

public partial class RaceTicketMain
{
    public int TicketId { get; set; }

    public int AccountId { get; set; }

    public int ProfileId { get; set; }

    public int HostWagerId { get; set; }

    public DateTime PlacedDateTime { get; set; }

    public byte TicketStatus { get; set; }

    public decimal UnitStake { get; set; }

    public decimal TotalStake { get; set; }

    public decimal WinPaid { get; set; }

    public decimal RefundAmount { get; set; }

    public byte TicketType { get; set; }

    public string TicketDesc { get; set; } = null!;

    public string Selections { get; set; } = null!;

    public string MachineName { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public DateTime? SettleDate { get; set; }

    public byte VoidReason { get; set; }

    public int? ActiveTillId { get; set; }

    public DateTime? Redeemed { get; set; }

    public int? RactiveTillId { get; set; }

    public byte ToteType { get; set; }

    public string? ToteTicketNumber { get; set; }

    public byte Uitype { get; set; }

    public DateTime? RebatePaidDate { get; set; }

    public decimal? RebateAmount { get; set; }

    public decimal ExchangeRate { get; set; }

    public string CurrCode { get; set; } = null!;

    public decimal TheoWinAmount { get; set; }

    public int? TrackId { get; set; }

    public decimal MinOddsStake { get; set; }

    public decimal MinOddsStakeP { get; set; }

    public decimal MinOddsStakeS { get; set; }

    public bool RacebookResolved { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual ICollection<AggLimitWork> AggLimitWorks { get; set; } = new List<AggLimitWork>();

    public virtual ManualScoreQ? ManualScoreQ { get; set; }

    public virtual ProfileTrack Profile { get; set; } = null!;

    public virtual ICollection<RaceTicketDetail> RaceTicketDetails { get; set; } = new List<RaceTicketDetail>();
}
