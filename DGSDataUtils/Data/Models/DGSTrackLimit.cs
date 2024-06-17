namespace DGSDataUtils.Data.Models
{
    public class DGSTrackLimit
    {
        public int PlayerId { get; set; }
        public string ProfileName { get; set; }
        public int ProfileId { get; set; }
        public int TrackId { get; set; }
        public bool? TrackEnabled { get; set; }
        public byte ParlayMaxSize { get; set; }
        public decimal MaxRaceWin { get; set; }
        public byte MaxRaceWinType { get; set; }
        public decimal MaxStake { get; set; }
        public decimal MaxPayoutOdds { get; set; }
        public decimal MaxPayoutCap { get; set; }
        public int BetType { get; set; }
        public decimal MinStake { get; set; }
    }
}