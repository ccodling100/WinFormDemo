namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemdbspitchingchange
{
    public int IdPitchingChange { get; set; }

    public int DbseventId { get; set; }

    public DateTime EventDate { get; set; }

    public int IdGame { get; set; }

    public string? Side { get; set; }

    public string? NewPitcher { get; set; }

    public bool Processed { get; set; }

    public DateTime LastModification { get; set; }

    public virtual Game IdGameNavigation { get; set; } = null!;
}
