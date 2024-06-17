namespace DGSDataUtils.Entities.DGSEntities;

public partial class Linetypelink
{
    public short IdLineTypeOut { get; set; }

    public short IdLineTypeIn { get; set; }

    public string IdSport { get; set; } = null!;

    public bool SpreadSync { get; set; }

    public bool SpreadOddsSync { get; set; }

    public bool TotalSync { get; set; }

    public bool TotalOddsSync { get; set; }

    public bool MoneyLineSync { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public byte LinkType { get; set; }

    public virtual Linetype IdLineTypeInNavigation { get; set; } = null!;

    public virtual Linetype IdLineTypeOutNavigation { get; set; } = null!;
}
