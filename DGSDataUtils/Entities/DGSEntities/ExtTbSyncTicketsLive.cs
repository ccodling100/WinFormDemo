namespace DGSDataUtils.Entities.DGSEntities;

public partial class ExtTbSyncTicketsLive
{
    public int TicketNumber { get; set; }

    public byte WagerNumber { get; set; }

    public int TicketIds { get; set; }

    public DateTime TicketDate { get; set; }

    public string CustomerId { get; set; } = null!;

    public string TicketStatus { get; set; } = null!;

    public string SyncStatus { get; set; } = null!;

    public int? MatchId1 { get; set; }

    public int? MatchId2 { get; set; }

    public int? MatchId3 { get; set; }

    public int? TicketDgs { get; set; }

    public int? PayOutRec { get; set; }
}
