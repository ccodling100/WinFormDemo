namespace DGSDataUtils.Entities.DGSEntities;

public partial class Casinotransaction
{
    public int TransactionId { get; set; }

    public int? IdPlayerAccounting { get; set; }

    public string? Login { get; set; }

    public decimal? Amount { get; set; }

    public int? CasinoGameId { get; set; }

    public int? GameId { get; set; }

    public int? PlayerId { get; set; }

    public string? Mode { get; set; }

    public DateTime? GameDate { get; set; }
}
