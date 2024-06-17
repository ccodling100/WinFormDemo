namespace DGSDataUtils.Entities.DGSEntities;

public partial class Pitcherlang
{
    public int IdGame { get; set; }

    public byte Idlanguage { get; set; }

    public string? VisitorPitcher { get; set; }

    public string? HomePitcher { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Language IdlanguageNavigation { get; set; } = null!;
}
