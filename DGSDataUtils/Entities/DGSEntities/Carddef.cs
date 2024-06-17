namespace DGSDataUtils.Entities.DGSEntities;

public partial class Carddef
{
    public int IdCardDef { get; set; }

    public string Name { get; set; } = null!;

    public byte Type { get; set; }

    public decimal MaxPayout { get; set; }

    public decimal MinRisk { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual ICollection<Carddefodd> Carddefodds { get; set; } = new List<Carddefodd>();

    public virtual ICollection<Carddefsport> Carddefsports { get; set; } = new List<Carddefsport>();

    public virtual ICollection<Cardheader> Cardheaders { get; set; } = new List<Cardheader>();
}
