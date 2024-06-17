namespace DGSDataUtils.Entities.DGSEntities;

public partial class Office
{
    public byte IdOffice { get; set; }

    public string OfficeName { get; set; } = null!;

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual ICollection<Freeplayofficeoption> Freeplayofficeoptions { get; set; } = new List<Freeplayofficeoption>();

    public virtual ICollection<Player> Players { get; set; } = new List<Player>();
}
