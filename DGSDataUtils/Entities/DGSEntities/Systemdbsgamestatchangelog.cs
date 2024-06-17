namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemdbsgamestatchangelog
{
    public int IdGameStatChange { get; set; }

    public int DbseventId { get; set; }

    public DateTime EventDate { get; set; }

    public int IdGame { get; set; }

    public byte Type { get; set; }

    public string NewValue { get; set; } = null!;

    public bool Processed { get; set; }

    public DateTime LastModification { get; set; }
}
