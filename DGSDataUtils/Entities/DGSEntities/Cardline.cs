namespace DGSDataUtils.Entities.DGSEntities;

public partial class Cardline
{
    public int IdcardHeader { get; set; }

    public int IdGame { get; set; }

    public byte Play { get; set; }

    public short GameNumber { get; set; }

    public double? Points { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Cardheader IdcardHeaderNavigation { get; set; } = null!;
}
