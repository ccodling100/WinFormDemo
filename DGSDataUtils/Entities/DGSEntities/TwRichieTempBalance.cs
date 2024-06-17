namespace DGSDataUtils.Entities.DGSEntities;

public partial class TwRichieTempBalance
{
    public string Player { get; set; } = null!;

    public decimal? Historybalance { get; set; }

    public decimal? Currentbalance { get; set; }

    public decimal? Bow { get; set; }

    public int Idplayer { get; set; }
}
