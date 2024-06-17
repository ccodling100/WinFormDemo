namespace DGSDataUtils.Data.Models;

public class TrackLimitsView
{
    public string Category { get; set; }
    public bool Status { get; set; }
    public decimal PerRaceMaxWin { get; set; }
    public decimal Min { get; set; }
    public decimal Max { get; set; }
    public decimal Payout { get; set; }
    public decimal Odds { get; set; }
}