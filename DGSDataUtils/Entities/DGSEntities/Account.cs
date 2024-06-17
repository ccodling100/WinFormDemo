namespace DGSDataUtils.Entities.DGSEntities;

public partial class Account
{
    public int AccountId { get; set; }

    public string AccountUserName { get; set; } = null!;

    public virtual ICollection<AggLimitWork> AggLimitWorks { get; set; } = new List<AggLimitWork>();

    public virtual ICollection<RaceTicketMain> RaceTicketMains { get; set; } = new List<RaceTicketMain>();

    public virtual ICollection<RebateHeader> RebateHeaders { get; set; } = new List<RebateHeader>();

    public virtual ICollection<Track> Tracks { get; set; } = new List<Track>();
}
