namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemdbsscore
{
    public int IdScore { get; set; }

    public int DbseventId { get; set; }

    public DateTime EventDate { get; set; }

    public int IdGame { get; set; }

    public int? VisitorScore { get; set; }

    public int? HomeScore { get; set; }

    public bool Processed { get; set; }

    public DateTime LastModification { get; set; }

    public virtual Game IdGameNavigation { get; set; } = null!;
}
