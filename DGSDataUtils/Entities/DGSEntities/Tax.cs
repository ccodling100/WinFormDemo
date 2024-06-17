namespace DGSDataUtils.Entities.DGSEntities;

public partial class Tax
{
    public int TaxId { get; set; }

    public string TaxDesc { get; set; } = null!;

    public byte TaxType { get; set; }

    public string AppliesTo { get; set; } = null!;

    public decimal TaxRate { get; set; }

    public decimal TaxAmount { get; set; }

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();
}
