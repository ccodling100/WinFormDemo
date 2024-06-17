namespace DGSDataUtils.Entities.DGSEntities;

public partial class TwGameScoresChecker
{
    public long Idgame { get; set; }

    public bool Check { get; set; }

    public bool Doublecheck { get; set; }

    public bool? Tcheck { get; set; }

    public int? IdUser { get; set; }

    public int? IduserDoubleCheck { get; set; }

    public DateTime? Regdate { get; set; }
}
