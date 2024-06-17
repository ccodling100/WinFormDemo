namespace DGSDataUtils.Entities.DGSEntities;

public partial class Linetypeflag
{
    public short Idlinetype { get; set; }

    public DateTime LastModification { get; set; }

    public virtual Linetype IdlinetypeNavigation { get; set; } = null!;
}
