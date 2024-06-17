namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemdbsscorelog
{
    public decimal IdScore { get; set; }

    public int DbseventId { get; set; }

    public DateTime EventDate { get; set; }

    public int IdGame { get; set; }

    public int? VisitorScore { get; set; }

    public int? HomeScore { get; set; }

    public bool Processed { get; set; }

    public DateTime LastModification { get; set; }
}
