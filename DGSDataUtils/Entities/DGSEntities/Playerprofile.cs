namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playerprofile
{
    public short IdProfile { get; set; }

    public string ProfileName { get; set; } = null!;

    public string? Notes { get; set; }

    public short? AlternateProfile { get; set; }

    public bool? AlternateEnable { get; set; }

    public byte? PromotionPoints { get; set; }

    public bool? SlIfBets { get; set; }

    public bool? SlAlwaysActionMlbtotals { get; set; }

    public byte? PlMaxGames { get; set; }

    public bool? PlAllowProps { get; set; }

    public bool? PlAllowGolf { get; set; }

    public bool? PlAllowMatchUps { get; set; }

    public bool? PlNoListedPitchers { get; set; }

    public short? PlJuice2TeamParlay { get; set; }

    public bool? PlTrueOddsOption { get; set; }

    public int? PlMaxOdds { get; set; }

    public decimal? PlMaxPayout { get; set; }

    public byte? PlMaxTeamBuyPoints { get; set; }

    public float? PlMaxBuyPoints { get; set; }

    public bool? PlAlwaysAction { get; set; }

    public bool? PlAllowRunLineTotal { get; set; }

    public bool? PlAllowSpreadTotalHk { get; set; }

    public bool PlAllowSpreadTotalSoc { get; set; }

    public bool? PlTieLoses { get; set; }

    public byte? PlParlayFormula { get; set; }

    public bool? PlAllowOpenPlays { get; set; }

    public int? PlOddsDefault { get; set; }

    public bool? PlLowerUseDefault { get; set; }

    public bool PlMaxDogsSide { get; set; }

    public bool PlMaxDogsTotal { get; set; }

    public bool PlMaxDogsMoney { get; set; }

    public int PlMaxSumOdds { get; set; }

    public bool PlUseMaxSumOdds { get; set; }

    public byte? IlMaxParlays { get; set; }

    public byte? IlMaxLevelParlays { get; set; }

    public byte? IlMaxTeasers { get; set; }

    public byte? IlMaxLevelTeasers { get; set; }

    public byte? IlMaxNumberSb { get; set; }

    public bool? IlAskAmount { get; set; }

    public bool? IlAllowChildHigher { get; set; }

    public byte? PcPitcherChangeType { get; set; }

    public bool? TlOpenLose { get; set; }

    public bool? TlTeaserCancel { get; set; }

    public bool SgCancelSide { get; set; }

    public bool SgCancelTotal { get; set; }

    public bool SgCancelRunLine { get; set; }

    public bool PcSkipSide { get; set; }

    public bool PcSkipTotal { get; set; }

    public bool PcSkipRunLine { get; set; }

    public bool SocHookups { get; set; }

    public bool RevAllowOpen { get; set; }

    public bool DuplicateBetsCheckLineChange { get; set; }

    public bool DuplicateBetsCheckParlays { get; set; }

    public bool DuplicateBetsCheckTeasers { get; set; }

    public bool DuplicateBetsCheckReverses { get; set; }

    public bool DuplicateBetsCheckIfbets { get; set; }

    public bool DuplicateBetsCheckIfSbrev { get; set; }

    public bool DuplicateBetsCheckParlaysSb { get; set; }

    public bool DuplicateBetsCheckTeasersSb { get; set; }

    public bool DuplicateBetsCheckSameParlay { get; set; }

    public bool DuplicateBetsCheckSameTeaser { get; set; }

    public byte FpmaxFav { get; set; }

    public decimal FpmaxPayout { get; set; }

    public byte FpmaxTeams { get; set; }

    public int FpoddsLimit { get; set; }

    public bool FpallowDuplicatedBets { get; set; }

    public bool FpallowBothSides { get; set; }

    public bool FpcheckOfficeFilters { get; set; }

    public DateTime? LastModification { get; set; }

    public short? LastModificationUser { get; set; }

    public decimal ClmaxWager { get; set; }

    public int Iloddslimit { get; set; }

    public virtual ICollection<Gamerelatedoption> Gamerelatedoptions { get; set; } = new List<Gamerelatedoption>();

    public virtual ICollection<Oddsdefault> Oddsdefaults { get; set; } = new List<Oddsdefault>();

    public virtual ICollection<Pendingwagerheader> Pendingwagerheaders { get; set; } = new List<Pendingwagerheader>();

    public virtual ICollection<Playerprofilecustomteaser> Playerprofilecustomteasers { get; set; } = new List<Playerprofilecustomteaser>();

    public virtual ICollection<Playerprofilegametype> Playerprofilegametypes { get; set; } = new List<Playerprofilegametype>();

    public virtual ICollection<Playerprofilegametypesport> Playerprofilegametypesports { get; set; } = new List<Playerprofilegametypesport>();

    public virtual ICollection<Playerprofileparlaybasicsport> Playerprofileparlaybasicsports { get; set; } = new List<Playerprofileparlaybasicsport>();

    public virtual ICollection<Playerprofileparlaylimit> Playerprofileparlaylimits { get; set; } = new List<Playerprofileparlaylimit>();

    public virtual ICollection<Playerprofilestraightlimit> Playerprofilestraightlimits { get; set; } = new List<Playerprofilestraightlimit>();

    public virtual ICollection<Player> Players { get; set; } = new List<Player>();

    public virtual ICollection<TeaserBtnMain> TeaserBtnMains { get; set; } = new List<TeaserBtnMain>();

    public virtual ICollection<Wagerheader> Wagerheaders { get; set; } = new List<Wagerheader>();

    public virtual ICollection<Wagertype> Wagertypes { get; set; } = new List<Wagertype>();

    public virtual ICollection<Book> IdBooks { get; set; } = new List<Book>();
}
