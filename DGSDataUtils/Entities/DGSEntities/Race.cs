namespace DGSDataUtils.Entities.DGSEntities;

public partial class Race
{
    public int RaceId { get; set; }

    public int TrackId { get; set; }

    public DateTime RaceDate { get; set; }

    public short RaceNumber { get; set; }

    public string RaceStatus { get; set; } = null!;

    public DateTime PostTime { get; set; }

    public DateTime SystemRaceDateTime { get; set; }

    public byte CloseMethod { get; set; }

    public short PostCutoff { get; set; }

    public DateTime? OffTime { get; set; }

    public DateTime? SystemOffDateTime { get; set; }

    public string RaceDescription { get; set; } = null!;

    public string RaceShortDesc { get; set; } = null!;

    public bool Double1 { get; set; }

    public bool Double2 { get; set; }

    public bool Pk31 { get; set; }

    public bool Pk33 { get; set; }

    public bool Pk41 { get; set; }

    public bool Pk44 { get; set; }

    public bool Pk61 { get; set; }

    public bool Pk66 { get; set; }

    public bool? Win { get; set; }

    public bool? Place { get; set; }

    public bool? Show { get; set; }

    public bool? Exacta { get; set; }

    public bool? Trifecta { get; set; }

    public bool Superfecta { get; set; }

    public bool? Quinella { get; set; }

    public bool HouseQ { get; set; }

    public bool Euro { get; set; }

    public bool Post { get; set; }

    public byte? Mtp { get; set; }

    public string? Distance { get; set; }

    public string? Surface { get; set; }

    public string? Class { get; set; }

    public decimal? Purse { get; set; }

    public string? TrackCond { get; set; }

    public string? RaceDesc { get; set; }

    public byte? ActualCloseMethod { get; set; }

    public virtual ICollection<Entry> Entries { get; set; } = new List<Entry>();

    public virtual ICollection<EntryOdd> EntryOdds { get; set; } = new List<EntryOdd>();

    public virtual ICollection<EntryOddsHist> EntryOddsHists { get; set; } = new List<EntryOddsHist>();

    public virtual ICollection<PoolPayout> PoolPayouts { get; set; } = new List<PoolPayout>();

    public virtual ICollection<RaceTicketDetail> RaceTicketDetails { get; set; } = new List<RaceTicketDetail>();

    public virtual Track Track { get; set; } = null!;
}
