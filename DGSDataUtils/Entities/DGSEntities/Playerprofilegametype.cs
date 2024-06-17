namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playerprofilegametype
{
    public short IdProfile { get; set; }

    public int IdGameType { get; set; }

    public byte FreeHalfPoints { get; set; }

    public bool AllowOn3nfl { get; set; }

    public bool AllowOff3nfl { get; set; }

    public bool AllowOn3cfb { get; set; }

    public bool AllowOff3cfb { get; set; }

    public bool AllowOn7nfl { get; set; }

    public bool AllowOff7nfl { get; set; }

    public bool AllowOn7cfb { get; set; }

    public bool AllowOff7cfb { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public bool PlCheckSameTeam { get; set; }

    public byte PlMaxSameTeam { get; set; }

    public bool TlCheckSameTeam { get; set; }

    public byte TlMaxSameTeam { get; set; }

    public bool IlCheckSameTeam { get; set; }

    public byte IlMaxSameTeam { get; set; }

    public bool PlUseWideLine { get; set; }

    public bool? UseWideLine { get; set; }

    public bool SlCheckMlnSpread { get; set; }

    public bool PlCheckMlnSpread { get; set; }

    public bool PlCheckTonTu { get; set; }

    public bool TlCheckTonTu { get; set; }

    public bool RlCheckMlnSpread { get; set; }

    public bool RlCheckTonTu { get; set; }

    public virtual Gametype IdGameTypeNavigation { get; set; } = null!;

    public virtual Playerprofile IdProfileNavigation { get; set; } = null!;
}
