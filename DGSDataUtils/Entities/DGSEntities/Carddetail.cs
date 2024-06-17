namespace DGSDataUtils.Entities.DGSEntities;

public partial class Carddetail
{
    public int IdcardHeader { get; set; }

    public int IdGame { get; set; }

    public byte GameStat { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Cardheader IdcardHeaderNavigation { get; set; } = null!;
}
