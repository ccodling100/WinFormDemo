namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemservice
{
    public byte IdService { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool MultipleRuns { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual ICollection<Systemservicesreg> Systemservicesregs { get; set; } = new List<Systemservicesreg>();
}
