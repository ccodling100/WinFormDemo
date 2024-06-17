namespace DGSDataUtils.Entities.DGSEntities;

public partial class Carddefsport
{
    public int IdCardDef { get; set; }

    public string IdSport { get; set; } = null!;

    public double SpreadPoints { get; set; }

    public double TotalPoints { get; set; }

    public bool Enable { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Carddef IdCardDefNavigation { get; set; } = null!;
}
