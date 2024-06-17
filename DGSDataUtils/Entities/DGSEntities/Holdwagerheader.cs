namespace DGSDataUtils.Entities.DGSEntities;

public partial class Holdwagerheader
{
    public int IdHoldWagerHeader { get; set; }

    public string Player { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal WagerAmount { get; set; }

    public short IdBook { get; set; }

    public DateTime LastModification { get; set; }

    public virtual ICollection<Holdwagerdetail> Holdwagerdetails { get; set; } = new List<Holdwagerdetail>();
}
