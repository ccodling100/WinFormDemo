namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemdbsgamestatchange
{
    public int IdGameStatChange { get; set; }

    public int DbseventId { get; set; }

    public DateTime EventDate { get; set; }

    public int IdGame { get; set; }

    public byte Type { get; set; }

    public string NewValue { get; set; } = null!;

    public bool Processed { get; set; }

    public DateTime LastModification { get; set; }

    public virtual Game IdGameNavigation { get; set; } = null!;
}
