namespace DGSDataUtils.Entities.DGSEntities;

public partial class Juicerebate
{
    public short IdLineType { get; set; }

    public string IdSport { get; set; } = null!;

    public short Range { get; set; }

    public byte Line { get; set; }

    public int IdGameType { get; set; }

    public byte Online { get; set; }

    public short JuiceRebate1 { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Gametype IdGameTypeNavigation { get; set; } = null!;

    public virtual Linetype IdLineTypeNavigation { get; set; } = null!;

    public virtual Sport IdSportNavigation { get; set; } = null!;
}
