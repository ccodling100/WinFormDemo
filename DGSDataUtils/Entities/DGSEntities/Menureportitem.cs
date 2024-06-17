namespace DGSDataUtils.Entities.DGSEntities;

public partial class Menureportitem
{
    public short Idreport { get; set; }

    public string Name { get; set; } = null!;

    public byte Tab { get; set; }

    public string Description { get; set; } = null!;

    public byte Idmenu { get; set; }

    public string System { get; set; } = null!;

    public virtual Menureportmenu IdmenuNavigation { get; set; } = null!;

    public virtual ICollection<Menureportfile> Menureportfiles { get; set; } = new List<Menureportfile>();

    public virtual ICollection<Menureportitemslang> Menureportitemslangs { get; set; } = new List<Menureportitemslang>();
}
