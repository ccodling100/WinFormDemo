namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playerprofilelimit
{
    public short IdProfileLimits { get; set; }

    public string ProfileName { get; set; } = null!;

    public string? Notes { get; set; }

    public short? AlternateProfile { get; set; }

    public bool? AlternateEnable { get; set; }

    public DateTime? LastModification { get; set; }

    public short? LastModificationUser { get; set; }

    public virtual ICollection<Playerprofilelimitsdetail> Playerprofilelimitsdetails { get; set; } = new List<Playerprofilelimitsdetail>();

    public virtual ICollection<Player> Players { get; set; } = new List<Player>();

    public virtual ICollection<Book> IdBooks { get; set; } = new List<Book>();
}
