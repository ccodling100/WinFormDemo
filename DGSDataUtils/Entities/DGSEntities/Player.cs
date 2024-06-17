namespace DGSDataUtils.Entities.DGSEntities;

public partial class Player
{
    public int IdPlayer { get; set; }

    public short IdLineType { get; set; }

    public byte IdOffice { get; set; }

    public int? IdAgent { get; set; }

    public short IdCurrency { get; set; }

    public short? IdGrouping { get; set; }

    public short? IdSource { get; set; }

    public short IdProfile { get; set; }

    public byte? IdPlayerRate { get; set; }

    public short? IdBook { get; set; }

    /// <summary>
    /// timezone to adjust the schedule of the player   (online)
    /// </summary>
    public int IdTimeZone { get; set; }

    /// <summary>
    /// language for the player schedule (online)
    /// </summary>
    public byte IdLanguage { get; set; }

    /// <summary>
    /// Style of the Web Schedule, E=European, A=American
    /// </summary>
    public string ScheduleStyle { get; set; } = null!;

    public string Player1 { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Name { get; set; }

    public string? LastName { get; set; }

    public string? LastName2 { get; set; }

    public string? Title { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public string? Zip { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string Status { get; set; } = null!;

    public bool AutoPay { get; set; }

    public bool BalanceChecked { get; set; }

    public decimal CreditLimit { get; set; }

    public bool NoLimit { get; set; }

    public decimal TempCredit { get; set; }

    public byte SoftLimitPercent { get; set; }

    public DateTime TempCreditExpire { get; set; }

    public bool OnlineAccess { get; set; }

    public string? OnlinePassword { get; set; }

    public string? OnlineMessage { get; set; }

    public decimal OnlineMaxWager { get; set; }

    public decimal OnlineMinWager { get; set; }

    public decimal MaxWager { get; set; }

    public decimal MinWager { get; set; }

    public decimal? CapPerGame { get; set; }

    public short ChartPercent { get; set; }

    public short MasterChart { get; set; }

    public bool Master { get; set; }

    public string? FlagMessage { get; set; }

    public byte? IdFlagMessageType { get; set; }

    public byte MaxActionPoints { get; set; }

    public string BonusPointsStatus { get; set; } = null!;

    public DateTime? BonusPointsExpire { get; set; }

    public DateTime? BonusPointsStart { get; set; }

    public string LineStyle { get; set; } = null!;

    public string Nhlline { get; set; } = null!;

    public string Mlbline { get; set; } = null!;

    public byte PitcherDefault { get; set; }

    public bool DuplicatedBets { get; set; }

    public bool DuplicatedBetsOnline { get; set; }

    public decimal FreePlayAmount { get; set; }

    public string? FreePlayMessage { get; set; }

    public bool ScheduleFb { get; set; }

    public bool ScheduleBb { get; set; }

    public bool ScheduleHk { get; set; }

    public bool ScheduleBs { get; set; }

    public decimal SettledFigure { get; set; }

    public bool ShowInTicker { get; set; }

    public bool Eposplayer { get; set; }

    public bool EnableHorses { get; set; }

    public bool EnableCasino { get; set; }

    public bool? EnableSports { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string? SecQuestion { get; set; }

    public string? SecAnswer { get; set; }

    public string SignUpIp { get; set; } = null!;

    /// <summary>
    /// 1=Dont check neg. balance for transactions
    /// </summary>
    public bool AllowNegTrans { get; set; }

    public short? LastModificationUser { get; set; }

    public bool HoldBets { get; set; }

    public byte HoldDelay { get; set; }

    public short IdProfileLimits { get; set; }

    public bool? EnableCards { get; set; }

    public int? IdAffiliate { get; set; }

    public bool ResetPassword { get; set; }

    public virtual Bettakerplayer? Bettakerplayer { get; set; }

    public virtual Bettrackerplayer? Bettrackerplayer { get; set; }

    public virtual ICollection<EposPlayer> EposPlayers { get; set; } = new List<EposPlayer>();

    public virtual ICollection<EposSportsbookTransfer> EposSportsbookTransfers { get; set; } = new List<EposSportsbookTransfer>();

    public virtual Agent? IdAffiliateNavigation { get; set; }

    public virtual Book? IdBookNavigation { get; set; }

    public virtual Currency IdCurrencyNavigation { get; set; } = null!;

    public virtual Grouping? IdGroupingNavigation { get; set; }

    public virtual Language IdLanguageNavigation { get; set; } = null!;

    public virtual Linetype IdLineTypeNavigation { get; set; } = null!;

    public virtual Office IdOfficeNavigation { get; set; } = null!;

    public virtual Playerprofilelimit IdProfileLimitsNavigation { get; set; } = null!;

    public virtual Playerprofile IdProfileNavigation { get; set; } = null!;

    public virtual Timezone IdTimeZoneNavigation { get; set; } = null!;

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();

    public virtual ICollection<Onlinewagertracker> Onlinewagertrackers { get; set; } = new List<Onlinewagertracker>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<Pendingwagerheader> Pendingwagerheaders { get; set; } = new List<Pendingwagerheader>();

    public virtual ICollection<PlayerClaim> PlayerClaims { get; set; } = new List<PlayerClaim>();

    public virtual ICollection<Playeraccounting> Playeraccountings { get; set; } = new List<Playeraccounting>();

    public virtual Playerblackbook? Playerblackbook { get; set; }

    public virtual ICollection<Playerbonustransaction> Playerbonustransactions { get; set; } = new List<Playerbonustransaction>();

    public virtual ICollection<Playerholdsetting> Playerholdsettings { get; set; } = new List<Playerholdsetting>();

    public virtual ICollection<Playerlogon> Playerlogons { get; set; } = new List<Playerlogon>();

    public virtual ICollection<Playermessage> Playermessages { get; set; } = new List<Playermessage>();

    public virtual Playernote? Playernote { get; set; }

    public virtual Playerstatistic? Playerstatistic { get; set; }

    public virtual ICollection<Playertransaction> Playertransactions { get; set; } = new List<Playertransaction>();

    public virtual ICollection<Playerweeklybalance> Playerweeklybalances { get; set; } = new List<Playerweeklybalance>();

    public virtual ICollection<TerminalSessionActive> TerminalSessionActives { get; set; } = new List<TerminalSessionActive>();

    public virtual ICollection<Wagerheader> Wagerheaders { get; set; } = new List<Wagerheader>();
}
