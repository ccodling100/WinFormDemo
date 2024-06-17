namespace DGSDataUtils.Entities.DGSEntities;

public partial class Clientchangedline
{
    public int IdLineType { get; set; }

    public int IdGame { get; set; }

    public int TeamNumber { get; set; }

    public DateTime VisitorSpreadDate { get; set; }

    public DateTime HomeSpreadDate { get; set; }

    public DateTime TotalOverDate { get; set; }

    public DateTime TotalUnderDate { get; set; }

    public DateTime VisitorMoneyLineDate { get; set; }

    public DateTime HomeMoneyLineDate { get; set; }

    public DateTime VisitorSpecialDate { get; set; }

    public DateTime HomeSpecialDate { get; set; }
}
