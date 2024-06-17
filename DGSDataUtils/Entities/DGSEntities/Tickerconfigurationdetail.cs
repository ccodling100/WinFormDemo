namespace DGSDataUtils.Entities.DGSEntities;

public partial class Tickerconfigurationdetail
{
    public short IdUser { get; set; }

    public decimal MaxValue { get; set; }

    public decimal MinValue { get; set; }

    public int Color { get; set; }

    public virtual Tickerconfiguration IdUserNavigation { get; set; } = null!;
}
