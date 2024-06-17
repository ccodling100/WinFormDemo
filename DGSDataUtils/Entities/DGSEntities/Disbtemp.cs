namespace DGSDataUtils.Entities.DGSEntities;

public partial class Disbtemp
{
    public int Idagent { get; set; }

    public string Agent { get; set; } = null!;

    public double? MakeUp { get; set; }

    public double? ThisWeek { get; set; }

    public double? AdjWeek { get; set; }

    public double? NetWeek { get; set; }

    public double? CommWeek { get; set; }

    public string? Distributor { get; set; }

    public double? DistWeek { get; set; }

    public double? NewMakeUp { get; set; }

    public double? Pbalance { get; set; }

    public double? Nbalance { get; set; }

    public string? AgentType { get; set; }

    public string? GroupName { get; set; }

    public decimal? GrossAmount { get; set; }

    public string? CommDescription { get; set; }

    public bool? DontXfer { get; set; }

    public int? IdDistributor { get; set; }

    public bool? IsDistributed { get; set; }

    public double? PlayersWeek { get; set; }
}
