namespace DGSDataUtils.Entities.DGSEntities;

public partial class Atrisklog
{
    public int IdAtRiskLog { get; set; }

    public int IdPlayer { get; set; }

    public double OldCurrentBalance { get; set; }

    public double NewCurrentBalance { get; set; }

    public double OldAmountAtRisk { get; set; }

    public double NewAmountAtRisk { get; set; }

    public double OldAvailBalance { get; set; }

    public double NewAvailBalance { get; set; }

    public DateTime DateTime { get; set; }
}
