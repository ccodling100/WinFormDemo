namespace DGSDataUtils.Entities.DGSEntities;

public partial class Paymentmethod
{
    public byte IdPaymentMethod { get; set; }

    public string PaymentMethod1 { get; set; } = null!;

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual ICollection<Agenttransaction> Agenttransactions { get; set; } = new List<Agenttransaction>();

    public virtual ICollection<Playertransaction> Playertransactions { get; set; } = new List<Playertransaction>();

    public virtual ICollection<RaceControl> RaceControls { get; set; } = new List<RaceControl>();
}
