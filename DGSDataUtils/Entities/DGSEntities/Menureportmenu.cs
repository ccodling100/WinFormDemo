namespace DGSDataUtils.Entities.DGSEntities;

public partial class Menureportmenu
{
    public byte IdMenu { get; set; }

    public short Tab { get; set; }

    public string Description { get; set; } = null!;

    public string System { get; set; } = null!;

    public virtual ICollection<Menureportitem> Menureportitems { get; set; } = new List<Menureportitem>();

    public virtual ICollection<Menureportmenulang> Menureportmenulangs { get; set; } = new List<Menureportmenulang>();
}
