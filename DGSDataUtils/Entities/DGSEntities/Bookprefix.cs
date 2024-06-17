namespace DGSDataUtils.Entities.DGSEntities;

public partial class Bookprefix
{
    public short IdBook { get; set; }

    public string PreName { get; set; } = null!;

    public int Consecutive { get; set; }

    public virtual Book IdBookNavigation { get; set; } = null!;
}
