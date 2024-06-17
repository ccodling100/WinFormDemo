namespace DGSDataUtils.Entities.DGSEntities;

public partial class Carddefodd
{
    public int IdCardDef { get; set; }

    public byte TeamsNumber { get; set; }

    public byte NumWins { get; set; }

    public byte NumLosses { get; set; }

    public byte NumTies { get; set; }

    public int Odds { get; set; }

    public bool Enable { get; set; }

    public string CaseTie { get; set; } = null!;

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Carddef IdCardDefNavigation { get; set; } = null!;
}
