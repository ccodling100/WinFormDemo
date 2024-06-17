namespace DGSDataUtils.Entities.DGSEntities;

public partial class Tickerconfiguration
{
    public short IdUser { get; set; }

    public short RefreshFrecuency { get; set; }

    public bool WagerPosition { get; set; }

    public bool ShowNfl { get; set; }

    public bool ShowCfb { get; set; }

    public bool ShowNba { get; set; }

    public bool ShowCbb { get; set; }

    public bool ShowMlb { get; set; }

    public bool ShowNhl { get; set; }

    public bool ShowMu { get; set; }

    public bool ShowSoc { get; set; }

    public bool? ShowEsoc { get; set; }

    public bool ShowTnt { get; set; }

    public bool ShowProp { get; set; }

    public bool ShowRac { get; set; }

    public bool StraightBets { get; set; }

    public bool Parlays { get; set; }

    public bool Teasers { get; set; }

    public bool IfBets { get; set; }

    public bool Reverses { get; set; }

    public bool ActionPoints { get; set; }

    public bool LocalWagers { get; set; }

    public bool OnlineWagers { get; set; }

    public bool Games { get; set; }

    public bool Halves { get; set; }

    public bool Quarters { get; set; }

    public bool Periods { get; set; }

    public bool NormalPlayers { get; set; }

    public bool MasterPlayers { get; set; }

    public bool CreditPlayers { get; set; }

    public bool CashPlayers { get; set; }

    public bool SearchPlayer { get; set; }

    public int? IdPlayer { get; set; }

    public bool SearchAgent { get; set; }

    public int? IdAgent { get; set; }

    public bool SearchPlayerType { get; set; }

    public short? IdPlayerType { get; set; }

    public bool SearchBook { get; set; }

    public short? IdBook { get; set; }

    public bool SearchProfile { get; set; }

    public short? IdProfile { get; set; }

    public bool SearchOffice { get; set; }

    public short? IdOffice { get; set; }

    public bool SearchGrouping { get; set; }

    public short? IdGrouping { get; set; }

    public bool SearchCurrency { get; set; }

    public short? IdCurrency { get; set; }

    public bool DisplayHoldBets { get; set; }

    public string? Player { get; set; }

    public string? Agent { get; set; }

    public string? Profile { get; set; }

    public virtual User IdUserNavigation { get; set; } = null!;

    public virtual ICollection<Tickerconfigurationdetail> Tickerconfigurationdetails { get; set; } = new List<Tickerconfigurationdetail>();
}
