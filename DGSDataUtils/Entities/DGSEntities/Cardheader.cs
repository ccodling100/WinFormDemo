namespace DGSDataUtils.Entities.DGSEntities;

public partial class Cardheader
{
    public int IdCardHeader { get; set; }

    public int IdCardDef { get; set; }

    public string Description { get; set; } = null!;

    public bool? PaperCard { get; set; }

    public DateTime CreationDate { get; set; }

    public string Status { get; set; } = null!;

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual ICollection<Carddetail> Carddetails { get; set; } = new List<Carddetail>();

    public virtual ICollection<Cardline> Cardlines { get; set; } = new List<Cardline>();

    public virtual Carddef IdCardDefNavigation { get; set; } = null!;

    public virtual ICollection<Pendingwagerheader> Pendingwagerheaders { get; set; } = new List<Pendingwagerheader>();

    public virtual ICollection<Wagerheader> Wagerheaders { get; set; } = new List<Wagerheader>();
}
