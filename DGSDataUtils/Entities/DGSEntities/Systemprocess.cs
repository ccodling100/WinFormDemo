namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemprocess
{
    public int IdSystemProcess { get; set; }

    public string ProcessType { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime RequestingTime { get; set; }

    public DateTime? StartingTime { get; set; }

    public DateTime? EndingTime { get; set; }

    public short? Games { get; set; }

    public short? Wagers { get; set; }

    public int? ChangedWagers { get; set; }

    public short? Skips { get; set; }

    public short? WinBets { get; set; }

    public short? LoseBets { get; set; }

    public short? PushBets { get; set; }

    public decimal? WinAmount { get; set; }

    public decimal? LoseAmount { get; set; }

    public short IdUser { get; set; }

    public short? PhoneLine { get; set; }

    public string? Ip { get; set; }

    public int? IdPlayer { get; set; }

    public int? IdGame { get; set; }

    public byte? Vhchange { get; set; }

    public string? VisitorPitcher { get; set; }

    public string? HomePitcher { get; set; }

    public int? VisitorOdds { get; set; }

    public int? HomeOdds { get; set; }

    public string? OldVisitorPitcher { get; set; }

    public string? OldHomePitcher { get; set; }

    public int? OldVisitorOdds { get; set; }

    public int? OldHomeOdds { get; set; }

    public int? GamesSkipped { get; set; }

    public virtual ICollection<Systemprocessdetail> Systemprocessdetails { get; set; } = new List<Systemprocessdetail>();
}
