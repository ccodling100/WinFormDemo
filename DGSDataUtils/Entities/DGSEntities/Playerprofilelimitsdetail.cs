namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playerprofilelimitsdetail
{
    public short IdProfileLimits { get; set; }

    public byte Online { get; set; }

    public int IdGameType { get; set; }

    public string IdSport { get; set; } = null!;

    public decimal Side { get; set; }

    public decimal Total { get; set; }

    public decimal MoneyLine { get; set; }

    public decimal Parlays { get; set; }

    public decimal Teasers { get; set; }

    public decimal IfBets { get; set; }

    public decimal Reverses { get; set; }

    public decimal Related { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Gametype IdGameTypeNavigation { get; set; } = null!;

    public virtual Playerprofilelimit IdProfileLimitsNavigation { get; set; } = null!;

    public virtual Sport IdSportNavigation { get; set; } = null!;
}
