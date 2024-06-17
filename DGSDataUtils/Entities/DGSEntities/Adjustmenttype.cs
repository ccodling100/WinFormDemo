namespace DGSDataUtils.Entities.DGSEntities;

public partial class Adjustmenttype
{
    public byte IdAdjustmentType { get; set; }

    public string AdjustmentType1 { get; set; } = null!;

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual ICollection<Playertransaction> Playertransactions { get; set; } = new List<Playertransaction>();
}
