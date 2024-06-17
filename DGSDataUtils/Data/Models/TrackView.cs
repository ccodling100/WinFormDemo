namespace DGSDataUtils.Data.Models;

public class TrackView
{
    public int RaceProfileId { get; set; }
    public int TrackId { get; set; }
    public string TrackName { get; set; }
    public bool IsEnabled { get; set; }
    public decimal MinBet { get; set; }
    public decimal MaxBit { get; set; }
    public int BetTypeId { get; set; }
    public string BetName { get; set; }
    public decimal PerBetMaxWin { get; set; }
    public decimal MaxPayoutOdds { get; set; }
}