using DGSDataUtils.Entities.DGSEntities;
using Microsoft.EntityFrameworkCore;

namespace DGSDataUtils.Contexts;

public partial class DGSDbContext : DbContext
{
    private readonly string _connectionString = String.Empty;

    public DGSDbContext()
    {
        _connectionString = "Server=192.168.0.27;Database=DGSData;User Id=sa;Password=devuser3212!;Persist Security Info=False;Encrypt=False";
    }

    public DGSDbContext(string connectionString)
    {
        _connectionString = connectionString;
    }

    public DGSDbContext(DbContextOptions<DGSDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<AceAgentimportedplayerslog> AceAgentimportedplayerslogs { get; set; }

    public virtual DbSet<AceAgentpromoplayer> AceAgentpromoplayers { get; set; }

    public virtual DbSet<ActiveTill> ActiveTills { get; set; }

    public virtual DbSet<ActiveTillCurrency> ActiveTillCurrencies { get; set; }

    public virtual DbSet<ActivityLock> ActivityLocks { get; set; }

    public virtual DbSet<Adjustmenttype> Adjustmenttypes { get; set; }

    public virtual DbSet<Affiliate> Affiliates { get; set; }

    public virtual DbSet<Affilstat> Affilstats { get; set; }

    public virtual DbSet<Affiltrack> Affiltracks { get; set; }

    public virtual DbSet<Agent> Agents { get; set; }

    public virtual DbSet<Agentaccounting> Agentaccountings { get; set; }

    public virtual DbSet<Agentadjustment> Agentadjustments { get; set; }

    public virtual DbSet<Agentcommission> Agentcommissions { get; set; }

    public virtual DbSet<Agentlinetype> Agentlinetypes { get; set; }

    public virtual DbSet<Agentlinetypelog> Agentlinetypelogs { get; set; }

    public virtual DbSet<Agentlog> Agentlogs { get; set; }

    public virtual DbSet<Agentlogon> Agentlogons { get; set; }

    public virtual DbSet<Agentlogonslog> Agentlogonslogs { get; set; }

    public virtual DbSet<Agentnote> Agentnotes { get; set; }

    public virtual DbSet<Agentperhead> Agentperheads { get; set; }

    public virtual DbSet<Agentperheaddetail> Agentperheaddetails { get; set; }

    public virtual DbSet<Agentright> Agentrights { get; set; }

    public virtual DbSet<Agentrightslog> Agentrightslogs { get; set; }

    public virtual DbSet<Agentstatistic> Agentstatistics { get; set; }

    public virtual DbSet<Agenttransaction> Agenttransactions { get; set; }

    public virtual DbSet<Agenttype> Agenttypes { get; set; }

    public virtual DbSet<Agentweeklybalance> Agentweeklybalances { get; set; }

    public virtual DbSet<Agerheaderrat> Agerheaderrats { get; set; }

    public virtual DbSet<AggLimitWork> AggLimitWorks { get; set; }

    public virtual DbSet<Artemp> Artemps { get; set; }

    public virtual DbSet<Asicustomer> Asicustomers { get; set; }

    public virtual DbSet<Asiprofile> Asiprofiles { get; set; }

    public virtual DbSet<Asiuser> Asiusers { get; set; }

    public virtual DbSet<Atrisklog> Atrisklogs { get; set; }

    public virtual DbSet<Banner> Banners { get; set; }

    public virtual DbSet<Bannertype> Bannertypes { get; set; }

    public virtual DbSet<Bannertypelang> Bannertypelangs { get; set; }

    public virtual DbSet<BetTickerRacingQueue> BetTickerRacingQueues { get; set; }

    public virtual DbSet<Bettakerconfig> Bettakerconfigs { get; set; }

    public virtual DbSet<Bettakerplayer> Bettakerplayers { get; set; }

    public virtual DbSet<Bettakerqueue> Bettakerqueues { get; set; }

    public virtual DbSet<Bettrackerconfig> Bettrackerconfigs { get; set; }

    public virtual DbSet<Bettrackerplayer> Bettrackerplayers { get; set; }

    public virtual DbSet<Bettrackerqueue> Bettrackerqueues { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Bookclientpreference> Bookclientpreferences { get; set; }

    public virtual DbSet<Bookclientpreferenceslog> Bookclientpreferenceslogs { get; set; }

    public virtual DbSet<Bookprefix> Bookprefixes { get; set; }

    public virtual DbSet<Booktax> Booktaxes { get; set; }

    public virtual DbSet<BrbetRadarIdmap> BrbetRadarIdmaps { get; set; }

    public virtual DbSet<BrbetRadarIdtntmap> BrbetRadarIdtntmaps { get; set; }

    public virtual DbSet<Carddef> Carddefs { get; set; }

    public virtual DbSet<Carddefodd> Carddefodds { get; set; }

    public virtual DbSet<Carddefsport> Carddefsports { get; set; }

    public virtual DbSet<Carddetail> Carddetails { get; set; }

    public virtual DbSet<Cardheader> Cardheaders { get; set; }

    public virtual DbSet<Cardline> Cardlines { get; set; }

    public virtual DbSet<CashedTicketTemplate> CashedTicketTemplates { get; set; }

    public virtual DbSet<CasinoSolutionsPlayerAccounting> CasinoSolutionsPlayerAccountings { get; set; }

    public virtual DbSet<CasinoSolutionsSetup> CasinoSolutionsSetups { get; set; }

    public virtual DbSet<Casinotransaction> Casinotransactions { get; set; }

    public virtual DbSet<Changedwagerdetail> Changedwagerdetails { get; set; }

    public virtual DbSet<Changedwagerheader> Changedwagerheaders { get; set; }

    public virtual DbSet<Chartlog> Chartlogs { get; set; }

    public virtual DbSet<Cj87ma> Cj87mas { get; set; }

    public virtual DbSet<Clientchangedline> Clientchangedlines { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<CustomerInfo> CustomerInfos { get; set; }

    public virtual DbSet<CwAgent> CwAgents { get; set; }

    public virtual DbSet<CwAgentUndo> CwAgentUndos { get; set; }

    public virtual DbSet<CwAgentlog> CwAgentlogs { get; set; }

    public virtual DbSet<CwPlayer> CwPlayers { get; set; }

    public virtual DbSet<CwPlayerUndo> CwPlayerUndos { get; set; }

    public virtual DbSet<CwsConfig> CwsConfigs { get; set; }

    public virtual DbSet<DbseventIdmap> DbseventIdmaps { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<DgsToteConfig> DgsToteConfigs { get; set; }

    public virtual DbSet<Disbtemp> Disbtemps { get; set; }

    public virtual DbSet<EAffiliate> EAffiliates { get; set; }

    public virtual DbSet<Entry> Entries { get; set; }

    public virtual DbSet<EntryOdd> EntryOdds { get; set; }

    public virtual DbSet<EntryOddsHist> EntryOddsHists { get; set; }

    public virtual DbSet<EntryPastPerf> EntryPastPerves { get; set; }

    public virtual DbSet<EposCurrency> EposCurrencies { get; set; }

    public virtual DbSet<EposPlayer> EposPlayers { get; set; }

    public virtual DbSet<EposPlayerCardQ> EposPlayerCardQs { get; set; }

    public virtual DbSet<EposPlayerChangeLog> EposPlayerChangeLogs { get; set; }

    public virtual DbSet<EposPlayerPhoto> EposPlayerPhotos { get; set; }

    public virtual DbSet<EposSportsbookTransfer> EposSportsbookTransfers { get; set; }

    public virtual DbSet<EposVoid> EposVoids { get; set; }

    public virtual DbSet<EtsrequestLog> EtsrequestLogs { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<Eventdetail> Eventdetails { get; set; }

    public virtual DbSet<Eventlang> Eventlangs { get; set; }

    public virtual DbSet<ExpiredTicketTransact> ExpiredTicketTransacts { get; set; }

    public virtual DbSet<ExtCustomerInfoLive> ExtCustomerInfoLives { get; set; }

    public virtual DbSet<ExtShowGamesLive> ExtShowGamesLives { get; set; }

    public virtual DbSet<ExtTbSyncTicketsLive> ExtTbSyncTicketsLives { get; set; }

    public virtual DbSet<ExtTbWagerContestItemLive> ExtTbWagerContestItemLives { get; set; }

    public virtual DbSet<ExtTbWagerGameItemLive> ExtTbWagerGameItemLives { get; set; }

    public virtual DbSet<Ezplay> Ezplays { get; set; }

    public virtual DbSet<Flagmessagetype> Flagmessagetypes { get; set; }

    public virtual DbSet<Form> Forms { get; set; }

    public virtual DbSet<Freeplayofficeoption> Freeplayofficeoptions { get; set; }

    public virtual DbSet<Game> Games { get; set; }

    public virtual DbSet<GameLang> GameLangs { get; set; }

    public virtual DbSet<GamePidScore> GamePidScores { get; set; }

    public virtual DbSet<GameTntlang> GameTntlangs { get; set; }

    public virtual DbSet<Gameaction> Gameactions { get; set; }

    public virtual DbSet<Gameactionbyagent> Gameactionbyagents { get; set; }

    public virtual DbSet<Gamechange> Gamechanges { get; set; }

    public virtual DbSet<Gamedeleted> Gamedeleteds { get; set; }

    public virtual DbSet<Gameimporteroption> Gameimporteroptions { get; set; }

    public virtual DbSet<Gameimportersource> Gameimportersources { get; set; }

    public virtual DbSet<Gamelog> Gamelogs { get; set; }

    public virtual DbSet<Gamerelatedoption> Gamerelatedoptions { get; set; }

    public virtual DbSet<Gamerelatedoptionslog> Gamerelatedoptionslogs { get; set; }

    public virtual DbSet<Gamescore> Gamescores { get; set; }

    public virtual DbSet<Gamestatpubqueue> Gamestatpubqueues { get; set; }

    public virtual DbSet<Gamesyncgame> Gamesyncgames { get; set; }

    public virtual DbSet<Gametnt> Gametnts { get; set; }

    public virtual DbSet<Gametntpropaction> Gametntpropactions { get; set; }

    public virtual DbSet<Gametntpropbyagent> Gametntpropbyagents { get; set; }

    public virtual DbSet<Gametntpropbyagentlog> Gametntpropbyagentlogs { get; set; }

    public virtual DbSet<Gametype> Gametypes { get; set; }

    public virtual DbSet<Gamevalue> Gamevalues { get; set; }

    public virtual DbSet<Gamevaluesbyagent> Gamevaluesbyagents { get; set; }

    public virtual DbSet<Gamevaluesbyagentlog> Gamevaluesbyagentlogs { get; set; }

    public virtual DbSet<Gamevalueslog> Gamevalueslogs { get; set; }

    public virtual DbSet<Gradedgame> Gradedgames { get; set; }

    public virtual DbSet<Gradedgameaction> Gradedgameactions { get; set; }

    public virtual DbSet<Gradedgameactionbyagent> Gradedgameactionbyagents { get; set; }

    public virtual DbSet<Gradedgamechange> Gradedgamechanges { get; set; }

    public virtual DbSet<Gradedgamedeleted> Gradedgamedeleteds { get; set; }

    public virtual DbSet<Gradedgametnt> Gradedgametnts { get; set; }

    public virtual DbSet<Gradedgametntpropaction> Gradedgametntpropactions { get; set; }

    public virtual DbSet<Gradedgametntpropbyagent> Gradedgametntpropbyagents { get; set; }

    public virtual DbSet<Gradedgametntpropbyagentlog> Gradedgametntpropbyagentlogs { get; set; }

    public virtual DbSet<Gradedgamevalue> Gradedgamevalues { get; set; }

    public virtual DbSet<Gradedgamevaluesbyagent> Gradedgamevaluesbyagents { get; set; }

    public virtual DbSet<Gradedgamevaluesbyagentlog> Gradedgamevaluesbyagentlogs { get; set; }

    public virtual DbSet<Gradedgamevalueslog> Gradedgamevalueslogs { get; set; }

    public virtual DbSet<Gradedpitcherchangelog> Gradedpitcherchangelogs { get; set; }

    public virtual DbSet<Gradedwagerdetail> Gradedwagerdetails { get; set; }

    public virtual DbSet<Gradedwagerheader> Gradedwagerheaders { get; set; }

    public virtual DbSet<Grouping> Groupings { get; set; }

    public virtual DbSet<Holdwagerdetail> Holdwagerdetails { get; set; }

    public virtual DbSet<Holdwagerheader> Holdwagerheaders { get; set; }

    public virtual DbSet<IcontentContestValue> IcontentContestValues { get; set; }

    public virtual DbSet<IcontentSchedule> IcontentSchedules { get; set; }

    public virtual DbSet<IcontentScheduleDetail> IcontentScheduleDetails { get; set; }

    public virtual DbSet<InactiveTill> InactiveTills { get; set; }

    public virtual DbSet<Itevent> Itevents { get; set; }

    public virtual DbSet<ItfeedState> ItfeedStates { get; set; }

    public virtual DbSet<Itmeet> Itmeets { get; set; }

    public virtual DbSet<Juicerebate> Juicerebates { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<LbticketCorrelation> LbticketCorrelations { get; set; }

    public virtual DbSet<League> Leagues { get; set; }

    public virtual DbSet<Leaguelang> Leaguelangs { get; set; }

    public virtual DbSet<Leagueregion> Leagueregions { get; set; }

    public virtual DbSet<Leagueregionlang> Leagueregionlangs { get; set; }

    public virtual DbSet<License> Licenses { get; set; }

    public virtual DbSet<LimitSet> LimitSets { get; set; }

    public virtual DbSet<LimitSetBetType> LimitSetBetTypes { get; set; }

    public virtual DbSet<LimitSetTrack> LimitSetTracks { get; set; }

    public virtual DbSet<LinePubQueue> LinePubQueues { get; set; }

    public virtual DbSet<LineSubscriber> LineSubscribers { get; set; }

    public virtual DbSet<LineSubscriberType> LineSubscriberTypes { get; set; }

    public virtual DbSet<Linesubscriberdgsinfo> Linesubscriberdgsinfos { get; set; }

    public virtual DbSet<Linetype> Linetypes { get; set; }

    public virtual DbSet<Linetypeflag> Linetypeflags { get; set; }

    public virtual DbSet<Linetypelink> Linetypelinks { get; set; }

    public virtual DbSet<Linetypelinkslog> Linetypelinkslogs { get; set; }

    public virtual DbSet<Linetypelog> Linetypelogs { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<LocationCurrency> LocationCurrencies { get; set; }

    public virtual DbSet<Lock> Locks { get; set; }

    public virtual DbSet<ManagerRight> ManagerRights { get; set; }

    public virtual DbSet<ManualScoreQ> ManualScoreQs { get; set; }

    public virtual DbSet<MaxPayoutWork> MaxPayoutWorks { get; set; }

    public virtual DbSet<Menureportfile> Menureportfiles { get; set; }

    public virtual DbSet<Menureportitem> Menureportitems { get; set; }

    public virtual DbSet<Menureportitemslang> Menureportitemslangs { get; set; }

    public virtual DbSet<Menureportlog> Menureportlogs { get; set; }

    public virtual DbSet<Menureportmenu> Menureportmenus { get; set; }

    public virtual DbSet<Menureportmenulang> Menureportmenulangs { get; set; }

    public virtual DbSet<Menureportparam> Menureportparams { get; set; }

    public virtual DbSet<Menureportparamslang> Menureportparamslangs { get; set; }

    public virtual DbSet<Mlbeasternline> Mlbeasternlines { get; set; }

    public virtual DbSet<Mlbwideline> Mlbwidelines { get; set; }

    public virtual DbSet<Moneychange> Moneychanges { get; set; }

    public virtual DbSet<Oddsbysport> Oddsbysports { get; set; }

    public virtual DbSet<Oddsdefault> Oddsdefaults { get; set; }

    public virtual DbSet<Office> Offices { get; set; }

    public virtual DbSet<Onlinewagertracker> Onlinewagertrackers { get; set; }

    public virtual DbSet<OperationDate> OperationDates { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Paymentmethod> Paymentmethods { get; set; }

    public virtual DbSet<PcaaggregateSecurity> PcaaggregateSecurities { get; set; }

    public virtual DbSet<PcaaggregateSetting> PcaaggregateSettings { get; set; }

    public virtual DbSet<Pcaauthentication> Pcaauthentications { get; set; }

    public virtual DbSet<PcaeventMap> PcaeventMaps { get; set; }

    public virtual DbSet<PcapropGameMap> PcapropGameMaps { get; set; }

    public virtual DbSet<PcapropImportMap> PcapropImportMaps { get; set; }

    public virtual DbSet<PcasystemInfo> PcasystemInfos { get; set; }

    public virtual DbSet<Pendingwagerdetail> Pendingwagerdetails { get; set; }

    public virtual DbSet<Pendingwagerheader> Pendingwagerheaders { get; set; }

    public virtual DbSet<Period> Periods { get; set; }

    public virtual DbSet<Pitcher> Pitchers { get; set; }

    public virtual DbSet<Pitcherchangelog> Pitcherchangelogs { get; set; }

    public virtual DbSet<Pitcherlang> Pitcherlangs { get; set; }

    public virtual DbSet<Player> Players { get; set; }

    public virtual DbSet<PlayerClaim> PlayerClaims { get; set; }

    public virtual DbSet<PlayerRule> PlayerRules { get; set; }

    public virtual DbSet<Playeraccounting> Playeraccountings { get; set; }

    public virtual DbSet<Playeragentlog> Playeragentlogs { get; set; }

    public virtual DbSet<Playerblackbook> Playerblackbooks { get; set; }

    public virtual DbSet<Playerbonustransaction> Playerbonustransactions { get; set; }

    public virtual DbSet<Playercallslog> Playercallslogs { get; set; }

    public virtual DbSet<Playerdeleted> Playerdeleteds { get; set; }

    public virtual DbSet<Playerfw> Playerfws { get; set; }

    public virtual DbSet<Playerholdsetting> Playerholdsettings { get; set; }

    public virtual DbSet<Playerid> Playerids { get; set; }

    public virtual DbSet<Playerlog> Playerlogs { get; set; }

    public virtual DbSet<Playerlogon> Playerlogons { get; set; }

    public virtual DbSet<Playermessage> Playermessages { get; set; }

    public virtual DbSet<Playernote> Playernotes { get; set; }

    public virtual DbSet<Playerprofile> Playerprofiles { get; set; }

    public virtual DbSet<Playerprofilecustomteaser> Playerprofilecustomteasers { get; set; }

    public virtual DbSet<Playerprofilecustomteaserlog> Playerprofilecustomteaserlogs { get; set; }

    public virtual DbSet<Playerprofilegametype> Playerprofilegametypes { get; set; }

    public virtual DbSet<Playerprofilegametypelog> Playerprofilegametypelogs { get; set; }

    public virtual DbSet<Playerprofilegametypesport> Playerprofilegametypesports { get; set; }

    public virtual DbSet<Playerprofilegametypesportlog> Playerprofilegametypesportlogs { get; set; }

    public virtual DbSet<Playerprofilelimit> Playerprofilelimits { get; set; }

    public virtual DbSet<Playerprofilelimitsdetail> Playerprofilelimitsdetails { get; set; }

    public virtual DbSet<Playerprofilelimitsdetailslog> Playerprofilelimitsdetailslogs { get; set; }

    public virtual DbSet<Playerprofilelimitslog> Playerprofilelimitslogs { get; set; }

    public virtual DbSet<Playerprofilelog> Playerprofilelogs { get; set; }

    public virtual DbSet<Playerprofileparlaybasicsport> Playerprofileparlaybasicsports { get; set; }

    public virtual DbSet<Playerprofileparlaybasicsportslog> Playerprofileparlaybasicsportslogs { get; set; }

    public virtual DbSet<Playerprofileparlaylimit> Playerprofileparlaylimits { get; set; }

    public virtual DbSet<Playerprofileparlaylimitdetail> Playerprofileparlaylimitdetails { get; set; }

    public virtual DbSet<Playerprofileparlaylimitdetaillog> Playerprofileparlaylimitdetaillogs { get; set; }

    public virtual DbSet<Playerprofileparlaylimitlog> Playerprofileparlaylimitlogs { get; set; }

    public virtual DbSet<Playerprofilestraightlimit> Playerprofilestraightlimits { get; set; }

    public virtual DbSet<Playerprofilestraightlimitlog> Playerprofilestraightlimitlogs { get; set; }

    public virtual DbSet<Playerrate> Playerrates { get; set; }

    public virtual DbSet<Playerstatistic> Playerstatistics { get; set; }

    public virtual DbSet<Playertransaction> Playertransactions { get; set; }

    public virtual DbSet<Playerweeklybalance> Playerweeklybalances { get; set; }

    public virtual DbSet<PoolPayout> PoolPayouts { get; set; }

    public virtual DbSet<ProfileTrack> ProfileTracks { get; set; }

    public virtual DbSet<ProfileTrackEnable> ProfileTrackEnables { get; set; }

    public virtual DbSet<PropDstSpVersion> PropDstSpVersions { get; set; }

    public virtual DbSet<Race> Races { get; set; }

    public virtual DbSet<RaceChart> RaceCharts { get; set; }

    public virtual DbSet<RaceChartQueue> RaceChartQueues { get; set; }

    public virtual DbSet<RaceControl> RaceControls { get; set; }

    public virtual DbSet<RaceTicketBatchDetail> RaceTicketBatchDetails { get; set; }

    public virtual DbSet<RaceTicketBatchHeader> RaceTicketBatchHeaders { get; set; }

    public virtual DbSet<RaceTicketDetail> RaceTicketDetails { get; set; }

    public virtual DbSet<RaceTicketMain> RaceTicketMains { get; set; }

    public virtual DbSet<RaceTicketType> RaceTicketTypes { get; set; }

    public virtual DbSet<RebateDetail> RebateDetails { get; set; }

    public virtual DbSet<RebateHeader> RebateHeaders { get; set; }

    public virtual DbSet<RefactorLog> RefactorLogs { get; set; }

    public virtual DbSet<RefillTill> RefillTills { get; set; }

    public virtual DbSet<Right> Rights { get; set; }

    public virtual DbSet<SmtoagentGameValueAdjustment> SmtoagentGameValueAdjustments { get; set; }

    public virtual DbSet<Smtobook> Smtobooks { get; set; }

    public virtual DbSet<SmtocustomPeriod> SmtocustomPeriods { get; set; }

    public virtual DbSet<SmtoeuropeanSport> SmtoeuropeanSports { get; set; }

    public virtual DbSet<SmtoexcludedGame> SmtoexcludedGames { get; set; }

    public virtual DbSet<SmtogameValueAdjustment> SmtogameValueAdjustments { get; set; }

    public virtual DbSet<SmtogameValueChangeReason> SmtogameValueChangeReasons { get; set; }

    public virtual DbSet<Smtoleague> Smtoleagues { get; set; }

    public virtual DbSet<SmtoleagueAdjustment> SmtoleagueAdjustments { get; set; }

    public virtual DbSet<Smtolimit> Smtolimits { get; set; }

    public virtual DbSet<SmtolineTypeBookLink> SmtolineTypeBookLinks { get; set; }

    public virtual DbSet<SmtolinksLog> SmtolinksLogs { get; set; }

    public virtual DbSet<Smtolog> Smtologs { get; set; }

    public virtual DbSet<SmtologArchive> SmtologArchives { get; set; }

    public virtual DbSet<SmtoperiodCreationDefault> SmtoperiodCreationDefaults { get; set; }

    public virtual DbSet<SmtoscoreLog> SmtoscoreLogs { get; set; }

    public virtual DbSet<SmtoscoringExcludedLeague> SmtoscoringExcludedLeagues { get; set; }

    public virtual DbSet<SmtoserviceReset> SmtoserviceResets { get; set; }

    public virtual DbSet<Smtosetting> Smtosettings { get; set; }

    public virtual DbSet<Smtosport> Smtosports { get; set; }

    public virtual DbSet<Smtostatus> Smtostatuses { get; set; }

    public virtual DbSet<Source> Sources { get; set; }

    public virtual DbSet<Sourcebybook> Sourcebybooks { get; set; }

    public virtual DbSet<Sport> Sports { get; set; }

    public virtual DbSet<SwfeedState> SwfeedStates { get; set; }

    public virtual DbSet<Systembannedip> Systembannedips { get; set; }

    public virtual DbSet<Systembetradarcategory> Systembetradarcategories { get; set; }

    public virtual DbSet<Systembetradarconfig> Systembetradarconfigs { get; set; }

    public virtual DbSet<Systembetradarsport> Systembetradarsports { get; set; }

    public virtual DbSet<Systembetradartournament> Systembetradartournaments { get; set; }

    public virtual DbSet<Systembonusoption> Systembonusoptions { get; set; }

    public virtual DbSet<Systembonussetting> Systembonussettings { get; set; }

    public virtual DbSet<Systembonussettingdetail> Systembonussettingdetails { get; set; }

    public virtual DbSet<Systemcachechange> Systemcachechanges { get; set; }

    public virtual DbSet<Systemcachetable> Systemcachetables { get; set; }

    public virtual DbSet<Systemcall> Systemcalls { get; set; }

    public virtual DbSet<Systemchangedline> Systemchangedlines { get; set; }

    public virtual DbSet<Systemchangedlines2> Systemchangedlines2s { get; set; }

    public virtual DbSet<Systemchangedlineslog> Systemchangedlineslogs { get; set; }

    public virtual DbSet<Systemchangedlineslog2> Systemchangedlineslog2s { get; set; }

    public virtual DbSet<Systemcolor> Systemcolors { get; set; }

    public virtual DbSet<Systemdbsbook> Systemdbsbooks { get; set; }

    public virtual DbSet<Systemdbsconfig> Systemdbsconfigs { get; set; }

    public virtual DbSet<Systemdbsevent> Systemdbsevents { get; set; }

    public virtual DbSet<Systemdbsgamestatchange> Systemdbsgamestatchanges { get; set; }

    public virtual DbSet<Systemdbsgamestatchangelog> Systemdbsgamestatchangelogs { get; set; }

    public virtual DbSet<Systemdbsleague> Systemdbsleagues { get; set; }

    public virtual DbSet<Systemdbsperiod> Systemdbsperiods { get; set; }

    public virtual DbSet<Systemdbspitchingchange> Systemdbspitchingchanges { get; set; }

    public virtual DbSet<Systemdbspitchingchangelog> Systemdbspitchingchangelogs { get; set; }

    public virtual DbSet<Systemdbsscore> Systemdbsscores { get; set; }

    public virtual DbSet<Systemdbsscorelog> Systemdbsscorelogs { get; set; }

    public virtual DbSet<Systemdbssport> Systemdbssports { get; set; }

    public virtual DbSet<Systemdictionary> Systemdictionaries { get; set; }

    public virtual DbSet<Systemdistributioninfo> Systemdistributioninfos { get; set; }

    public virtual DbSet<Systemdistributionlog> Systemdistributionlogs { get; set; }

    public virtual DbSet<Systemerrorlog> Systemerrorlogs { get; set; }

    public virtual DbSet<Systemlanguage> Systemlanguages { get; set; }

    public virtual DbSet<Systemoddsconversion> Systemoddsconversions { get; set; }

    public virtual DbSet<Systempreferencesclient> Systempreferencesclients { get; set; }

    public virtual DbSet<Systempreferencesclientlog> Systempreferencesclientlogs { get; set; }

    public virtual DbSet<Systempreferencesdefault> Systempreferencesdefaults { get; set; }

    public virtual DbSet<Systempreferencesdefaultlog> Systempreferencesdefaultlogs { get; set; }

    public virtual DbSet<Systempreferencesmanager> Systempreferencesmanagers { get; set; }

    public virtual DbSet<Systempreferencesmanagerlog> Systempreferencesmanagerlogs { get; set; }

    public virtual DbSet<Systemprocess> Systemprocesses { get; set; }

    public virtual DbSet<Systemprocessdetail> Systemprocessdetails { get; set; }

    public virtual DbSet<Systemprocessflag> Systemprocessflags { get; set; }

    public virtual DbSet<Systemprocesslog> Systemprocesslogs { get; set; }

    public virtual DbSet<Systemprocesslogdetail> Systemprocesslogdetails { get; set; }

    public virtual DbSet<Systemrecordinglog> Systemrecordinglogs { get; set; }

    public virtual DbSet<Systemservice> Systemservices { get; set; }

    public virtual DbSet<Systemservicesreg> Systemservicesregs { get; set; }

    public virtual DbSet<Systemsession> Systemsessions { get; set; }

    public virtual DbSet<Systemsessionaccount> Systemsessionaccounts { get; set; }

    public virtual DbSet<Systemsessiondetail> Systemsessiondetails { get; set; }

    public virtual DbSet<Systemsessionlog> Systemsessionlogs { get; set; }

    public virtual DbSet<Systemsobook> Systemsobooks { get; set; }

    public virtual DbSet<Systemsoconfig> Systemsoconfigs { get; set; }

    public virtual DbSet<Systemsoleague> Systemsoleagues { get; set; }

    public virtual DbSet<Systemsosport> Systemsosports { get; set; }

    public virtual DbSet<Systemversioninfo> Systemversioninfos { get; set; }

    public virtual DbSet<Targeturl> Targeturls { get; set; }

    public virtual DbSet<Tax> Taxes { get; set; }

    public virtual DbSet<Taxtransact> Taxtransacts { get; set; }

    public virtual DbSet<Team> Teams { get; set; }

    public virtual DbSet<Teamlang> Teamlangs { get; set; }

    public virtual DbSet<TeaserBtnDetail> TeaserBtnDetails { get; set; }

    public virtual DbSet<TeaserBtnMain> TeaserBtnMains { get; set; }

    public virtual DbSet<Terminal> Terminals { get; set; }

    public virtual DbSet<TerminalManager> TerminalManagers { get; set; }

    public virtual DbSet<TerminalSessionActive> TerminalSessionActives { get; set; }

    public virtual DbSet<TerminalSessionClosed> TerminalSessionCloseds { get; set; }

    public virtual DbSet<Tickerconfiguration> Tickerconfigurations { get; set; }

    public virtual DbSet<Tickerconfigurationdetail> Tickerconfigurationdetails { get; set; }

    public virtual DbSet<TicketDetail> TicketDetails { get; set; }

    public virtual DbSet<TicketHold> TicketHolds { get; set; }

    public virtual DbSet<TicketHoldRelease> TicketHoldReleases { get; set; }

    public virtual DbSet<TicketMain> TicketMains { get; set; }

    public virtual DbSet<Tickettemplate> Tickettemplates { get; set; }

    public virtual DbSet<Till> Tills { get; set; }

    public virtual DbSet<TillTransact> TillTransacts { get; set; }

    public virtual DbSet<Timezone> Timezones { get; set; }

    public virtual DbSet<Track> Tracks { get; set; }

    public virtual DbSet<TrackAmtote> TrackAmtotes { get; set; }

    public virtual DbSet<TwCasinoLiveTransControl> TwCasinoLiveTransControls { get; set; }

    public virtual DbSet<TwGameScoresChecker> TwGameScoresCheckers { get; set; }

    public virtual DbSet<TwGradeLog> TwGradeLogs { get; set; }

    public virtual DbSet<TwLoginRequest> TwLoginRequests { get; set; }

    public virtual DbSet<TwMarketingOfficeStat> TwMarketingOfficeStats { get; set; }

    public virtual DbSet<TwOgsSessioncontrol> TwOgsSessioncontrols { get; set; }

    public virtual DbSet<TwRichieTempBalance> TwRichieTempBalances { get; set; }

    public virtual DbSet<TwSiteIdcontrolClive> TwSiteIdcontrolClives { get; set; }

    public virtual DbSet<TwSptUserLogAction> TwSptUserLogActions { get; set; }

    public virtual DbSet<Ungradedwagerdetail> Ungradedwagerdetails { get; set; }

    public virtual DbSet<Ungradedwagerheader> Ungradedwagerheaders { get; set; }

    public virtual DbSet<UpdTbchange> UpdTbchanges { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Userlogon> Userlogons { get; set; }

    public virtual DbSet<Userlogonslog> Userlogonslogs { get; set; }

    public virtual DbSet<Usermessage> Usermessages { get; set; }

    public virtual DbSet<Userprofile> Userprofiles { get; set; }

    public virtual DbSet<Userprofileright> Userprofilerights { get; set; }

    public virtual DbSet<Userprofilerightslog> Userprofilerightslogs { get; set; }

    public virtual DbSet<Userright> Userrights { get; set; }

    public virtual DbSet<Userrightslog> Userrightslogs { get; set; }

    public virtual DbSet<Usersactionlog> Usersactionlogs { get; set; }

    public virtual DbSet<Usersdeleted> Usersdeleteds { get; set; }

    public virtual DbSet<Userslog> Userslogs { get; set; }

    public virtual DbSet<Vipaccount> Vipaccounts { get; set; }

    public virtual DbSet<VipuserSession> VipuserSessions { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    public virtual DbSet<VoucherTemplate> VoucherTemplates { get; set; }

    public virtual DbSet<VoucherTran> VoucherTrans { get; set; }

    public virtual DbSet<Wagerdetail> Wagerdetails { get; set; }

    public virtual DbSet<Wagerheader> Wagerheaders { get; set; }

    public virtual DbSet<Wagertracker> Wagertrackers { get; set; }

    public virtual DbSet<Wagertype> Wagertypes { get; set; }

    public virtual DbSet<Wagertypegrouplang> Wagertypegrouplangs { get; set; }

    public virtual DbSet<Wagertypelang> Wagertypelangs { get; set; }

    public virtual DbSet<Wagertypesport> Wagertypesports { get; set; }

    public virtual DbSet<Webcolumn> Webcolumns { get; set; }

    public virtual DbSet<Webcolumndetail> Webcolumndetails { get; set; }

    public virtual DbSet<Webrow> Webrows { get; set; }

    public virtual DbSet<Webrowdetail> Webrowdetails { get; set; }

    public virtual DbSet<Webrowlang> Webrowlangs { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(_connectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.ToTable("Account");

            entity.Property(e => e.AccountId)
                .ValueGeneratedNever()
                .HasColumnName("AccountID");
            entity.Property(e => e.AccountUserName)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasMany(d => d.Tracks).WithMany(p => p.Accounts)
                .UsingEntity<Dictionary<string, object>>(
                    "FavTrack",
                    r => r.HasOne<Track>().WithMany()
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_FavTracks_Track"),
                    l => l.HasOne<Account>().WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_FavTracks_Account"),
                    j =>
                    {
                        j.HasKey("AccountId", "TrackId");
                        j.ToTable("FavTracks");
                        j.IndexerProperty<int>("AccountId").HasColumnName("AccountID");
                        j.IndexerProperty<int>("TrackId").HasColumnName("TrackID");
                    });
        });

        modelBuilder.Entity<AceAgentimportedplayerslog>(entity =>
        {
            entity.HasKey(e => e.IdImportedPlayersLog);

            entity.ToTable("ACE_AGENTIMPORTEDPLAYERSLOG");

            entity.Property(e => e.Balance).HasColumnType("money");
            entity.Property(e => e.CreditLimit).HasColumnType("money");
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LocalMaxWager).HasColumnType("money");
            entity.Property(e => e.LocalMinWager).HasColumnType("money");
            entity.Property(e => e.OnlineMaxWager).HasColumnType("money");
            entity.Property(e => e.OnlineMinWager).HasColumnType("money");
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PlacedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AceAgentpromoplayer>(entity =>
        {
            entity.HasKey(e => e.IdAgentPromoPlayer);

            entity.ToTable("ACE_AGENTPROMOPLAYER");

            entity.Property(e => e.PlacedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ActiveTill>(entity =>
        {
            entity.ToTable("ActiveTill");

            entity.Property(e => e.ActiveTillId).HasColumnName("ActiveTillID");
            entity.Property(e => e.ClosedDateTime).HasColumnType("smalldatetime");
            entity.Property(e => e.Disbursements).HasColumnType("money");
            entity.Property(e => e.OpDate).HasColumnType("datetime");
            entity.Property(e => e.OpenedDateTime).HasColumnType("smalldatetime");
            entity.Property(e => e.OpeningBalance).HasColumnType("money");
            entity.Property(e => e.Receipts).HasColumnType("money");
            entity.Property(e => e.TerminalId).HasColumnName("TerminalID");
            entity.Property(e => e.TillId).HasColumnName("TillID");

            entity.HasOne(d => d.OpenedByNavigation).WithMany(p => p.ActiveTills)
                .HasForeignKey(d => d.OpenedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ActiveTill_TerminalManager");

            entity.HasOne(d => d.Terminal).WithMany(p => p.ActiveTills)
                .HasForeignKey(d => d.TerminalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ActiveTill_Terminal");

            entity.HasOne(d => d.Till).WithMany(p => p.ActiveTills)
                .HasForeignKey(d => d.TillId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ActiveTill_Till");
        });

        modelBuilder.Entity<ActiveTillCurrency>(entity =>
        {
            entity.HasKey(e => new { e.ActiveTillId, e.CurrCode });

            entity.ToTable("ActiveTillCurrency");

            entity.Property(e => e.ActiveTillId).HasColumnName("ActiveTillID");
            entity.Property(e => e.CurrCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ExchangeRate).HasColumnType("money");
        });

        modelBuilder.Entity<ActivityLock>(entity =>
        {
            entity.HasKey(e => e.Activity);

            entity.ToTable("ActivityLock");

            entity.Property(e => e.Activity)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
            entity.Property(e => e.StartDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<Adjustmenttype>(entity =>
        {
            entity.HasKey(e => e.IdAdjustmentType).HasName("PK_ADJUSTMENTMETHOD");

            entity.ToTable("ADJUSTMENTTYPE");

            entity.Property(e => e.IdAdjustmentType).ValueGeneratedOnAdd();
            entity.Property(e => e.AdjustmentType1)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("AdjustmentType");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
        });

        modelBuilder.Entity<Affiliate>(entity =>
        {
            entity.HasKey(e => e.IdPlayer);

            entity.ToTable("AFFILIATE");

            entity.Property(e => e.IdPlayer).ValueGeneratedNever();
            entity.Property(e => e.AdvertId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("AdvertID");
        });

        modelBuilder.Entity<Affilstat>(entity =>
        {
            entity.HasKey(e => e.IdAgent);

            entity.ToTable("AFFILSTATS");

            entity.Property(e => e.IdAgent).ValueGeneratedNever();

            entity.HasOne(d => d.IdAgentNavigation).WithOne(p => p.Affilstat)
                .HasForeignKey<Affilstat>(d => d.IdAgent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AFFILSTATS_AGENT");
        });

        modelBuilder.Entity<Affiltrack>(entity =>
        {
            entity.HasKey(e => e.IdTrack);

            entity.ToTable("AFFILTRACK");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Extra)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ip)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IP");
            entity.Property(e => e.MediaType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Refer)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAgentNavigation).WithMany(p => p.Affiltracks)
                .HasForeignKey(d => d.IdAgent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AFFILTRACK_AGENT");
        });

        modelBuilder.Entity<Agent>(entity =>
        {
            entity.HasKey(e => e.IdAgent);

            entity.ToTable("AGENT");

            entity.HasIndex(e => e.Agent1, "IX_AGENT_Agent").IsUnique();

            entity.Property(e => e.Address1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Address2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Agent1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Agent");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Enable)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Fax)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.IdBook).HasDefaultValueSql("((1))");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.MasterAgentEnabled)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.OnlineAccess)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("if 1, the agent can access the agent site");
            entity.Property(e => e.OnlineMessage)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Online message for agents in the agent site");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ResetPassword).HasColumnName("Reset_Password");
            entity.Property(e => e.State)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.DistributorNavigation).WithMany(p => p.InverseDistributorNavigation)
                .HasForeignKey(d => d.Distributor)
                .HasConstraintName("FK_AGENT_AGENT");

            entity.HasOne(d => d.IdAgentPerHeadNavigation).WithMany(p => p.Agents)
                .HasForeignKey(d => d.IdAgentPerHead)
                .HasConstraintName("FK_AGENT_AGENTPERHEAD");

            entity.HasOne(d => d.IdAgentTypeNavigation).WithMany(p => p.Agents)
                .HasForeignKey(d => d.IdAgentType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AGENT_AgentType");

            entity.HasOne(d => d.IdBookNavigation).WithMany(p => p.Agents)
                .HasForeignKey(d => d.IdBook)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AGENT_BOOK");

            entity.HasOne(d => d.IdCurrencyNavigation).WithMany(p => p.Agents)
                .HasForeignKey(d => d.IdCurrency)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AGENT_CURRENCY");

            entity.HasOne(d => d.IdGroupingNavigation).WithMany(p => p.Agents)
                .HasForeignKey(d => d.IdGrouping)
                .HasConstraintName("FK_AGENT_GROUPING");

            entity.HasOne(d => d.IdLanguageNavigation).WithMany(p => p.Agents)
                .HasForeignKey(d => d.IdLanguage)
                .HasConstraintName("FK_AGENT_LANGUAGE");

            entity.HasOne(d => d.IdLineTypeNavigation).WithMany(p => p.Agents)
                .HasForeignKey(d => d.IdLineType)
                .HasConstraintName("FK_AGENT_LINETYPE");
        });

        modelBuilder.Entity<Agentaccounting>(entity =>
        {
            entity.HasKey(e => e.IdAgentAccounting).HasName("PK_AgentAccounting");

            entity.ToTable("AGENTACCOUNTING");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.MoneyChange).HasColumnType("money");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdAgentNavigation).WithMany(p => p.Agentaccountings)
                .HasForeignKey(d => d.IdAgent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AgentAccounting_AGENT");
        });

        modelBuilder.Entity<Agentadjustment>(entity =>
        {
            entity.HasKey(e => e.IdAdjustment).HasName("PK__AGENTADJ__DD32C0455B2A58E6");

            entity.ToTable("AGENTADJUSTMENTS");

            entity.Property(e => e.CommAmount).HasColumnType("money");
            entity.Property(e => e.CommPayment).HasColumnType("money");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastModification)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Agentcommission>(entity =>
        {
            entity.HasKey(e => e.IdAgent);

            entity.ToTable("AGENTCOMMISSION");

            entity.Property(e => e.IdAgent).ValueGeneratedNever();
            entity.Property(e => e.CommPerHead).HasColumnType("money");
        });

        modelBuilder.Entity<Agentlinetype>(entity =>
        {
            entity.HasKey(e => new { e.Idagent, e.IdLineType });

            entity.ToTable("AGENTLINETYPE");

            entity.Property(e => e.LastModificationUser).HasDefaultValueSql("((1))");
            entity.Property(e => e.Lastmodification)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.IdLineTypeNavigation).WithMany(p => p.Agentlinetypes)
                .HasForeignKey(d => d.IdLineType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AGENTLINETYPE_LINETYPE");

            entity.HasOne(d => d.IdagentNavigation).WithMany(p => p.Agentlinetypes)
                .HasForeignKey(d => d.Idagent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AGENTLINETYPE_AGENT");
        });

        modelBuilder.Entity<Agentlinetypelog>(entity =>
        {
            entity.HasKey(e => e.IdLog);

            entity.ToTable("AGENTLINETYPELOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Idagent).HasColumnName("IDAgent");
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.NewValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Agentlog>(entity =>
        {
            entity.HasKey(e => e.IdAgentLog).HasName("PK_AgentLog");

            entity.ToTable("AGENTLOG");

            entity.Property(e => e.Agent)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FieldName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.NewValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Agentlogon>(entity =>
        {
            entity.HasKey(e => e.IdAgentLogons).HasName("PK_AgentLogons");

            entity.ToTable("AGENTLOGONS");

            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IP");
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
            entity.Property(e => e.System)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('I')")
                .IsFixedLength();

            entity.HasOne(d => d.IdAgentNavigation).WithMany(p => p.Agentlogons)
                .HasForeignKey(d => d.IdAgent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AgentLogons_AGENT");
        });

        modelBuilder.Entity<Agentlogonslog>(entity =>
        {
            entity.HasKey(e => e.IdAgentLogons);

            entity.ToTable("AGENTLOGONSLOG");

            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IP");
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
            entity.Property(e => e.System)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('I')")
                .IsFixedLength();
        });

        modelBuilder.Entity<Agentnote>(entity =>
        {
            entity.HasKey(e => e.IdAgent);

            entity.ToTable("AGENTNOTES");

            entity.Property(e => e.IdAgent).ValueGeneratedNever();
            entity.Property(e => e.Notes).HasColumnType("text");
            entity.Property(e => e.Notes1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Notes2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Notes3)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAgentNavigation).WithOne(p => p.Agentnote)
                .HasForeignKey<Agentnote>(d => d.IdAgent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AGENTNOTES_AGENT");
        });

        modelBuilder.Entity<Agentperhead>(entity =>
        {
            entity.HasKey(e => e.IdAgentPerHead);

            entity.ToTable("AGENTPERHEAD");

            entity.Property(e => e.Description)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LastModification)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Agentperheaddetail>(entity =>
        {
            entity.HasKey(e => new { e.IdAgentPerHead, e.ToRange });

            entity.ToTable("AGENTPERHEADDETAIL");

            entity.Property(e => e.CasinoFee).HasColumnType("money");
            entity.Property(e => e.LastModification)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LocalHorsesFee).HasColumnType("money");
            entity.Property(e => e.LocalSportsFee).HasColumnType("money");
            entity.Property(e => e.OnlineHorsesFee).HasColumnType("money");
            entity.Property(e => e.OnlineSportsFee).HasColumnType("money");

            entity.HasOne(d => d.IdAgentPerHeadNavigation).WithMany(p => p.Agentperheaddetails)
                .HasForeignKey(d => d.IdAgentPerHead)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AGENTPERHEADDETAIL_AGENTPERHEAD");
        });

        modelBuilder.Entity<Agentright>(entity =>
        {
            entity.HasKey(e => new { e.IdAgent, e.IdForm, e.IdRight });

            entity.ToTable("AGENTRIGHTS");

            entity.Property(e => e.LastModification).HasColumnType("datetime");
        });

        modelBuilder.Entity<Agentrightslog>(entity =>
        {
            entity.HasKey(e => e.IdLog);

            entity.ToTable("AGENTRIGHTSLOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Idagent).HasColumnName("IDAgent");
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.NewValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Agentstatistic>(entity =>
        {
            entity.HasKey(e => e.IdAgent).HasName("PK_AgentStatistic");

            entity.ToTable("AGENTSTATISTIC");

            entity.Property(e => e.IdAgent).ValueGeneratedNever();
            entity.Property(e => e.AccountOpened)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CurrentBalance).HasColumnType("money");
            entity.Property(e => e.LastModification)
                .HasDefaultValueSql("((0))")
                .HasColumnType("datetime");
            entity.Property(e => e.LastWeek).HasColumnType("money");
            entity.Property(e => e.LastWeekMakeUp).HasColumnType("money");
            entity.Property(e => e.LifeTimeComm).HasColumnType("money");
            entity.Property(e => e.LifeTimeLose).HasColumnType("money");
            entity.Property(e => e.LifetimeWin).HasColumnType("money");
            entity.Property(e => e.MakeUp).HasColumnType("money");
            entity.Property(e => e.ThisWeek).HasColumnType("money");
            entity.Property(e => e.Ytdcomm)
                .HasColumnType("money")
                .HasColumnName("YTDComm");
            entity.Property(e => e.Ytdlose)
                .HasColumnType("money")
                .HasColumnName("YTDLose");
            entity.Property(e => e.Ytdwin)
                .HasColumnType("money")
                .HasColumnName("YTDWin");

            entity.HasOne(d => d.IdAgentNavigation).WithOne(p => p.Agentstatistic)
                .HasForeignKey<Agentstatistic>(d => d.IdAgent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AgentStatistic_AGENT");
        });

        modelBuilder.Entity<Agenttransaction>(entity =>
        {
            entity.HasKey(e => e.IdTransaction).HasName("PK_AgentTransaction");

            entity.ToTable("AGENTTRANSACTION");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransactionType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdAgentNavigation).WithMany(p => p.Agenttransactions)
                .HasForeignKey(d => d.IdAgent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AgentTransaction_AGENT");

            entity.HasOne(d => d.IdPaymentMethodNavigation).WithMany(p => p.Agenttransactions)
                .HasForeignKey(d => d.IdPaymentMethod)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AgentTransaction_PAYMENTMETHOD");
        });

        modelBuilder.Entity<Agenttype>(entity =>
        {
            entity.HasKey(e => e.IdAgentType).HasName("PK_AgentType");

            entity.ToTable("AGENTTYPE");

            entity.Property(e => e.IdAgentType).ValueGeneratedOnAdd();
            entity.Property(e => e.AgentType1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AgentType");
        });

        modelBuilder.Entity<Agentweeklybalance>(entity =>
        {
            entity.HasKey(e => new { e.IdAgent, e.Week });

            entity.ToTable("AGENTWEEKLYBALANCE");

            entity.Property(e => e.Week).HasColumnType("datetime");
            entity.Property(e => e.Balance).HasColumnType("money");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.MakeUp).HasColumnType("money");

            entity.HasOne(d => d.IdAgentNavigation).WithMany(p => p.Agentweeklybalances)
                .HasForeignKey(d => d.IdAgent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AGENTWEEKLYBALANCE_AGENT");
        });

        modelBuilder.Entity<Agerheaderrat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AGERHEADERRAT");

            entity.Property(e => e.CompleteDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CrrnumDetails).HasColumnName("CRRNumDetails");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Epos).HasColumnName("EPOS");
            entity.Property(e => e.Epospaid).HasColumnName("EPOSPaid");
            entity.Property(e => e.IfBetRiskAmount).HasColumnType("money");
            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IP");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.MoneyChange).HasColumnType("money");
            entity.Property(e => e.OriginalRiskAmount).HasColumnType("money");
            entity.Property(e => e.OriginalWagerAmount).HasColumnType("money");
            entity.Property(e => e.OriginalWinAmount).HasColumnType("money");
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
            entity.Property(e => e.RiskAmount).HasColumnType("money");
            entity.Property(e => e.SettledDate).HasColumnType("datetime");
            entity.Property(e => e.TaxAmount).HasColumnType("money");
            entity.Property(e => e.WinAmount).HasColumnType("money");
        });

        modelBuilder.Entity<AggLimitWork>(entity =>
        {
            entity.HasKey(e => e.Key);

            entity.ToTable("AggLimitWork");

            entity.Property(e => e.AccountId).HasColumnName("AccountID");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.RaceId).HasColumnName("RaceID");
            entity.Property(e => e.Selections)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TicketId).HasColumnName("TicketID");

            entity.HasOne(d => d.Account).WithMany(p => p.AggLimitWorks)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AggLimitWork_Account");

            entity.HasOne(d => d.Ticket).WithMany(p => p.AggLimitWorks)
                .HasForeignKey(d => d.TicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AggLimitWork_RaceTicketMain");
        });

        modelBuilder.Entity<Artemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ARTemp");

            entity.Property(e => e.Agent)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FormName)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Asicustomer>(entity =>
        {
            entity.HasKey(e => e.AccountId);

            entity.ToTable("ASICustomer");

            entity.HasIndex(e => e.AsicustomerId, "IX_ASICustomer_CustomerID").IsUnique();

            entity.Property(e => e.AccountId).HasColumnName("AccountID");
            entity.Property(e => e.AsicustomerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ASICustomerID");
        });

        modelBuilder.Entity<Asiprofile>(entity =>
        {
            entity.HasKey(e => e.ProfileId);

            entity.ToTable("ASIProfile");

            entity.HasIndex(e => e.ProfileName, "IX_ASIProfile_Name").IsUnique();

            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.ProfileName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Asiuser>(entity =>
        {
            entity.ToTable("ASIUser");

            entity.HasIndex(e => e.AsiuserName, "IX_ASIUser_UserName").IsUnique();

            entity.Property(e => e.AsiuserId).HasColumnName("ASIUserID");
            entity.Property(e => e.AsiuserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ASIUserName");
        });

        modelBuilder.Entity<Atrisklog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ATRISKLOG");

            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.IdAtRiskLog).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Banner>(entity =>
        {
            entity.HasKey(e => e.IdBanner).HasName("PK_Banners");

            entity.ToTable("BANNERS");

            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ImageData).HasColumnType("image");
            entity.Property(e => e.ImageMime)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ImageMIME");
        });

        modelBuilder.Entity<Bannertype>(entity =>
        {
            entity.HasKey(e => e.IdBannerType);

            entity.ToTable("BANNERTYPE");

            entity.Property(e => e.Description)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.Line1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Line2)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Bannertypelang>(entity =>
        {
            entity.HasKey(e => new { e.IdBannerType, e.IdLanguage });

            entity.ToTable("BANNERTYPELANG");

            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.Line1).HasMaxLength(100);
            entity.Property(e => e.Line2).HasMaxLength(100);

            entity.HasOne(d => d.IdBannerTypeNavigation).WithMany(p => p.Bannertypelangs)
                .HasForeignKey(d => d.IdBannerType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BANNERTYPELANG_BANNERTYPE");

            entity.HasOne(d => d.IdLanguageNavigation).WithMany(p => p.Bannertypelangs)
                .HasForeignKey(d => d.IdLanguage)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BANNERTYPELANG_Language");
        });

        modelBuilder.Entity<BetTickerRacingQueue>(entity =>
        {
            entity.HasKey(e => e.TicketId);

            entity.ToTable("BetTickerRacingQueue");

            entity.Property(e => e.TicketId)
                .ValueGeneratedNever()
                .HasColumnName("TicketID");
        });

        modelBuilder.Entity<Bettakerconfig>(entity =>
        {
            entity.HasKey(e => e.IdBook);

            entity.ToTable("BETTAKERCONFIG");

            entity.Property(e => e.IdBook).ValueGeneratedNever();
            entity.Property(e => e.LastModification)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastModificationUser).HasDefaultValueSql("((1))");
            entity.Property(e => e.PartnerId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<Bettakerplayer>(entity =>
        {
            entity.HasKey(e => e.IdPlayer);

            entity.ToTable("BETTAKERPLAYER");

            entity.Property(e => e.IdPlayer).ValueGeneratedNever();
            entity.Property(e => e.Placeddate).HasColumnType("datetime");

            entity.HasOne(d => d.IdPlayerNavigation).WithOne(p => p.Bettakerplayer)
                .HasForeignKey<Bettakerplayer>(d => d.IdPlayer)
                .HasConstraintName("FK_BETTAKERPLAYER_PLAYER");
        });

        modelBuilder.Entity<Bettakerqueue>(entity =>
        {
            entity.HasKey(e => e.IdWager);

            entity.ToTable("BETTAKERQUEUE");

            entity.Property(e => e.IdWager).ValueGeneratedNever();
        });

        modelBuilder.Entity<Bettrackerconfig>(entity =>
        {
            entity.HasKey(e => e.IdBook);

            entity.ToTable("BETTRACKERCONFIG");

            entity.Property(e => e.IdBook).ValueGeneratedNever();
            entity.Property(e => e.LastModification)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastModificationUser).HasDefaultValueSql("((1))");
            entity.Property(e => e.PartnerId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<Bettrackerplayer>(entity =>
        {
            entity.HasKey(e => e.IdPlayer);

            entity.ToTable("BETTRACKERPLAYER");

            entity.Property(e => e.IdPlayer).ValueGeneratedNever();
            entity.Property(e => e.Placeddate).HasColumnType("datetime");
            entity.Property(e => e.PromoCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdPlayerNavigation).WithOne(p => p.Bettrackerplayer)
                .HasForeignKey<Bettrackerplayer>(d => d.IdPlayer)
                .HasConstraintName("FK_BETTRACKERPLAYER_PLAYER");
        });

        modelBuilder.Entity<Bettrackerqueue>(entity =>
        {
            entity.HasKey(e => e.IdWager);

            entity.ToTable("BETTRACKERQUEUE");

            entity.Property(e => e.IdWager).ValueGeneratedNever();
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.IdBook);

            entity.ToTable("BOOK");

            entity.HasIndex(e => e.Description, "IX_BOOK").IsUnique();

            entity.Property(e => e.Description)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdWebColumnNavigation).WithMany(p => p.Books)
                .HasForeignKey(d => d.IdWebColumn)
                .HasConstraintName("FK_BOOK_WEBCOLUMN");

            entity.HasMany(d => d.IdProfileLimits).WithMany(p => p.IdBooks)
                .UsingEntity<Dictionary<string, object>>(
                    "Playerprofilelimitsbook",
                    r => r.HasOne<Playerprofilelimit>().WithMany()
                        .HasForeignKey("IdProfileLimits")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PLAYERPROFILELIMITSBOOK_PLAYERPROFILELIMITS"),
                    l => l.HasOne<Book>().WithMany()
                        .HasForeignKey("IdBook")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PLAYERPROFILELIMITSBOOK_BOOK"),
                    j =>
                    {
                        j.HasKey("IdBook", "IdProfileLimits");
                        j.ToTable("PLAYERPROFILELIMITSBOOK");
                    });

            entity.HasMany(d => d.IdProfiles).WithMany(p => p.IdBooks)
                .UsingEntity<Dictionary<string, object>>(
                    "Playerprofilebook",
                    r => r.HasOne<Playerprofile>().WithMany()
                        .HasForeignKey("IdProfile")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PLAYERPROFILEBOOK_PLAYERPROFILE"),
                    l => l.HasOne<Book>().WithMany()
                        .HasForeignKey("IdBook")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PLAYERPROFILEBOOK_BOOK"),
                    j =>
                    {
                        j.HasKey("IdBook", "IdProfile");
                        j.ToTable("PLAYERPROFILEBOOK");
                    });
        });

        modelBuilder.Entity<Bookclientpreference>(entity =>
        {
            entity.HasKey(e => e.IdBook);

            entity.ToTable("BOOKCLIENTPREFERENCES");

            entity.Property(e => e.IdBook).HasDefaultValueSql("((1))");
            entity.Property(e => e.DisplayBothTeamsOnTotals)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.LastModification)
                .HasDefaultValueSql("('1/1/1800')")
                .HasColumnType("datetime");
            entity.Property(e => e.LastModificationUser).HasDefaultValueSql("((1))");
            entity.Property(e => e.MaxWagerCheck)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasComment("R=Risk, W=Win, A=WagerAmount");
            entity.Property(e => e.MlbhalvesUseLp).HasColumnName("MLBHalvesUseLP");

            entity.HasOne(d => d.IdBookNavigation).WithOne(p => p.Bookclientpreference)
                .HasForeignKey<Bookclientpreference>(d => d.IdBook)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BOOKCLIENTPREFERENCES_BOOK");
        });

        modelBuilder.Entity<Bookclientpreferenceslog>(entity =>
        {
            entity.HasKey(e => e.IdClientPreferencestLog);

            entity.ToTable("BOOKCLIENTPREFERENCESLOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdBook).HasDefaultValueSql("((1))");
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.NewValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Bookprefix>(entity =>
        {
            entity.HasKey(e => new { e.IdBook, e.PreName });

            entity.ToTable("BOOKPREFIX");

            entity.HasIndex(e => new { e.IdBook, e.PreName }, "IX_BOOKPREFIX").IsUnique();

            entity.Property(e => e.PreName)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.IdBookNavigation).WithMany(p => p.Bookprefixes)
                .HasForeignKey(d => d.IdBook)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BOOKPREFIX_BOOK");
        });

        modelBuilder.Entity<Booktax>(entity =>
        {
            entity.HasKey(e => new { e.Idbook, e.IdTax });

            entity.ToTable("BOOKTAX");

            entity.Property(e => e.LastModification)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastModificationUser).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<BrbetRadarIdmap>(entity =>
        {
            entity.HasKey(e => e.IdSystemBetRadar).HasName("PK_SYSTEMBETRADAR");

            entity.ToTable("BRBetRadarIDMap");

            entity.Property(e => e.BetRadarId).HasColumnName("BetRadarID");

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.BrbetRadarIdmaps)
                .HasForeignKey(d => d.IdGame)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SYSTEMBETRADARGAME_GAME");
        });

        modelBuilder.Entity<BrbetRadarIdtntmap>(entity =>
        {
            entity.HasKey(e => new { e.BetRadarId, e.IdSystemBetRadar }).HasName("PK_SYSTEMBETRADARTNT");

            entity.ToTable("BRBetRadarIDTNTMap");
        });

        modelBuilder.Entity<Carddef>(entity =>
        {
            entity.HasKey(e => e.IdCardDef);

            entity.ToTable("CARDDEF");

            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.MaxPayout)
                .HasDefaultValueSql("((100000))")
                .HasColumnType("money");
            entity.Property(e => e.MinRisk).HasColumnType("money");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Carddefodd>(entity =>
        {
            entity.HasKey(e => new { e.IdCardDef, e.TeamsNumber, e.NumWins, e.NumLosses, e.NumTies });

            entity.ToTable("CARDDEFODDS");

            entity.Property(e => e.CaseTie)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdCardDefNavigation).WithMany(p => p.Carddefodds)
                .HasForeignKey(d => d.IdCardDef)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CARDDEFODDS_CARDDEF");
        });

        modelBuilder.Entity<Carddefsport>(entity =>
        {
            entity.HasKey(e => new { e.IdCardDef, e.IdSport });

            entity.ToTable("CARDDEFSPORTS");

            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.LastModificationUser).HasColumnName("lastModificationUser");

            entity.HasOne(d => d.IdCardDefNavigation).WithMany(p => p.Carddefsports)
                .HasForeignKey(d => d.IdCardDef)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CARDDEFSPORTS_CARDDEF");
        });

        modelBuilder.Entity<Carddetail>(entity =>
        {
            entity.HasKey(e => new { e.IdcardHeader, e.IdGame });

            entity.ToTable("CARDDETAIL");

            entity.Property(e => e.IdcardHeader).HasColumnName("IDCardHeader");
            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdcardHeaderNavigation).WithMany(p => p.Carddetails)
                .HasForeignKey(d => d.IdcardHeader)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CARDDETAIL_CARDHEADER");
        });

        modelBuilder.Entity<Cardheader>(entity =>
        {
            entity.HasKey(e => e.IdCardHeader);

            entity.ToTable("CARDHEADER");

            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.PaperCard)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdCardDefNavigation).WithMany(p => p.Cardheaders)
                .HasForeignKey(d => d.IdCardDef)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CARDHEADER_CARDDEF");
        });

        modelBuilder.Entity<Cardline>(entity =>
        {
            entity.HasKey(e => new { e.IdcardHeader, e.IdGame, e.Play }).HasName("PK_CardLines");

            entity.ToTable("CARDLINES");

            entity.Property(e => e.IdcardHeader).HasColumnName("IDCardHeader");
            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdcardHeaderNavigation).WithMany(p => p.Cardlines)
                .HasForeignKey(d => d.IdcardHeader)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CARDLINES_CARDHEADER");
        });

        modelBuilder.Entity<CashedTicketTemplate>(entity =>
        {
            entity.ToTable("CashedTicketTemplate");

            entity.Property(e => e.CashedTicketTemplateId).HasColumnName("CashedTicketTemplateID");
            entity.Property(e => e.CashedTicketTemplate1)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("CashedTicketTemplate");
            entity.Property(e => e.Description)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CasinoSolutionsPlayerAccounting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CasinoSolutions_PlayerAccounting");

            entity.Property(e => e.LastModification).HasColumnType("datetime");
        });

        modelBuilder.Entity<CasinoSolutionsSetup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CasinoSolutions_Setup");

            entity.Property(e => e.DatabaseName).HasMaxLength(128);
            entity.Property(e => e.LinkedServer).HasMaxLength(128);
        });

        modelBuilder.Entity<Casinotransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CASINOTRANSACTIONS");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.GameDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Login)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Mode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TransactionId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Changedwagerdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CHANGEDWAGERDETAIL");

            entity.Property(e => e.ChartDetailRisk).HasColumnType("money");
            entity.Property(e => e.ChartDetailWin).HasColumnType("money");
            entity.Property(e => e.CompleteDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.GameDateTime).HasColumnType("datetime");
            entity.Property(e => e.HomePitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hscore).HasColumnName("HScore");
            entity.Property(e => e.IdEvent).HasComment("Event.IdEvent. 0= is a match");
            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.IfBetAmount).HasColumnType("money");
            entity.Property(e => e.MasterChartDetailRisk).HasColumnType("money");
            entity.Property(e => e.MasterChartDetailWin).HasColumnType("money");
            entity.Property(e => e.SumChartDetailRisk).HasColumnType("money");
            entity.Property(e => e.SumChartDetailWin).HasColumnType("money");
            entity.Property(e => e.VisitorPitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Vscore).HasColumnName("VScore");

            entity.HasOne(d => d.IdChangedWagerNavigation).WithMany()
                .HasForeignKey(d => d.IdChangedWager)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CHANGEDWAGERDETAIL_CHANGEDWAGERHEADER");
        });

        modelBuilder.Entity<Changedwagerheader>(entity =>
        {
            entity.HasKey(e => e.IdChangedWager);

            entity.ToTable("CHANGEDWAGERHEADER");

            entity.Property(e => e.CompleteDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CrrnumDetails).HasColumnName("CRRNumDetails");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Epos).HasColumnName("EPOS");
            entity.Property(e => e.Epospaid).HasColumnName("EPOSPaid");
            entity.Property(e => e.IdBook).HasDefaultValueSql("((1))");
            entity.Property(e => e.IdcardHeader).HasColumnName("IDCardHeader");
            entity.Property(e => e.IfBetRiskAmount).HasColumnType("money");
            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.MoneyChange).HasColumnType("money");
            entity.Property(e => e.OriginalRiskAmount).HasColumnType("money");
            entity.Property(e => e.OriginalWagerAmount).HasColumnType("money");
            entity.Property(e => e.OriginalWinAmount).HasColumnType("money");
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
            entity.Property(e => e.RiskAmount).HasColumnType("money");
            entity.Property(e => e.SettledDate).HasColumnType("datetime");
            entity.Property(e => e.TaxAmount).HasColumnType("money");
            entity.Property(e => e.WagerType).HasDefaultValueSql("((1))");
            entity.Property(e => e.WinAmount).HasColumnType("money");
        });

        modelBuilder.Entity<Chartlog>(entity =>
        {
            entity.HasKey(e => e.IdChartLog).HasName("PK_ChartLog");

            entity.ToTable("CHARTLOG");
        });

        modelBuilder.Entity<Cj87ma>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cj87ma");

            entity.Property(e => e.Agent)
                .HasMaxLength(50)
                .HasColumnName("agent");
            entity.Property(e => e.CreditLimit)
                .HasMaxLength(50)
                .HasColumnName("Credit_Limit");
            entity.Property(e => e.LastWager)
                .HasMaxLength(50)
                .HasColumnName("Last_Wager");
            entity.Property(e => e.MaxWager).HasColumnName("Max_Wager");
            entity.Property(e => e.MinWager)
                .HasMaxLength(50)
                .HasColumnName("Min_Wager");
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Player).HasMaxLength(50);
            entity.Property(e => e.WebMaxWager).HasColumnName("Web_Max_Wager");
            entity.Property(e => e.WebMinWager)
                .HasMaxLength(50)
                .HasColumnName("Web_Min_Wager");
            entity.Property(e => e.WebPassword)
                .HasMaxLength(50)
                .HasColumnName("Web_Password");
        });

        modelBuilder.Entity<Clientchangedline>(entity =>
        {
            entity.HasKey(e => new { e.IdGame, e.IdLineType, e.TeamNumber });

            entity.ToTable("CLIENTCHANGEDLINES");

            entity.Property(e => e.HomeMoneyLineDate).HasColumnType("datetime");
            entity.Property(e => e.HomeSpecialDate).HasColumnType("datetime");
            entity.Property(e => e.HomeSpreadDate).HasColumnType("datetime");
            entity.Property(e => e.TotalOverDate).HasColumnType("datetime");
            entity.Property(e => e.TotalUnderDate).HasColumnType("datetime");
            entity.Property(e => e.VisitorMoneyLineDate).HasColumnType("datetime");
            entity.Property(e => e.VisitorSpecialDate).HasColumnType("datetime");
            entity.Property(e => e.VisitorSpreadDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.HasKey(e => e.IdCurrency);

            entity.ToTable("CURRENCY");

            entity.Property(e => e.Currency1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Currency");
            entity.Property(e => e.Description)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.LastMoneyChange)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.Symbol)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<CustomerInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CustomerInfo");

            entity.Property(e => e.Account)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Address1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Address2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChartMessage)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClerkMessage)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CservClerkMsg)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CServClerkMsg");
            entity.Property(e => e.CservMessage)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CServMessage");
            entity.Property(e => e.DispatchMethod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Email)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("EMail");
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FirstDepositDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LastAccess).HasColumnType("smalldatetime");
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MaxBetPhone).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MaxBetWeb).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MinBetPhone).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MinBetWeb).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Password)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PhoneDialed)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ReachedCcCap).HasColumnName("Reached_CC_Cap");
            entity.Property(e => e.ReachedCcStmt).HasColumnName("Reached_CC_Stmt");
            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RemainingCountCserv).HasColumnName("RemainingCountCServ");
            entity.Property(e => e.RemainingCountCservClerk).HasColumnName("RemainingCountCServClerk");
            entity.Property(e => e.SecurityAnswer)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.SecurityQuestion)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.SessionStart).HasColumnType("smalldatetime");
            entity.Property(e => e.SettlementFigure).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.State)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.UsedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ZipCode)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CwAgent>(entity =>
        {
            entity.HasKey(e => e.Idagent);

            entity.ToTable("CW_AGENT");

            entity.Property(e => e.Idagent)
                .ValueGeneratedNever()
                .HasColumnName("IDAgent");
            entity.Property(e => e.Agent)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AgentType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('Split')");
            entity.Property(e => e.CommCasino).HasColumnType("money");
            entity.Property(e => e.CommHorses).HasColumnType("money");
            entity.Property(e => e.CommPctCasino).HasColumnType("money");
            entity.Property(e => e.CommPctHorses).HasColumnType("money");
            entity.Property(e => e.CommPctSports).HasColumnType("money");
            entity.Property(e => e.CommSports).HasColumnType("money");
            entity.Property(e => e.Distributor)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.GrossCasino).HasColumnType("money");
            entity.Property(e => e.GrossHorses).HasColumnType("money");
            entity.Property(e => e.GrossSports).HasColumnType("money");
            entity.Property(e => e.IdAgentType).HasDefaultValueSql("((1))");
            entity.Property(e => e.IdDistributor).HasColumnName("idDistributor");
            entity.Property(e => e.IsDistributor).HasColumnName("isDistributor");
            entity.Property(e => e.Nbalance).HasColumnName("NBalance");
            entity.Property(e => e.Pbalance).HasColumnName("PBalance");
            entity.Property(e => e.Phcasino)
                .HasColumnType("money")
                .HasColumnName("PHCasino");
            entity.Property(e => e.PhlocalHorses)
                .HasColumnType("money")
                .HasColumnName("PHLocalHorses");
            entity.Property(e => e.PhlocalSports)
                .HasColumnType("money")
                .HasColumnName("PHLocalSports");
            entity.Property(e => e.PhonlineHorses)
                .HasColumnType("money")
                .HasColumnName("PHOnlineHorses");
            entity.Property(e => e.PhonlineSports)
                .HasColumnType("money")
                .HasColumnName("PHOnlineSports");
            entity.Property(e => e.ToDistCasino).HasColumnType("money");
            entity.Property(e => e.ToDistHorses).HasColumnType("money");
            entity.Property(e => e.ToDistPhcasino)
                .HasColumnType("money")
                .HasColumnName("ToDistPHCasino");
            entity.Property(e => e.ToDistPhlocalHorses)
                .HasColumnType("money")
                .HasColumnName("ToDistPHLocalHorses");
            entity.Property(e => e.ToDistPhlocalSports)
                .HasColumnType("money")
                .HasColumnName("ToDistPHLocalSports");
            entity.Property(e => e.ToDistPhonlineHorses)
                .HasColumnType("money")
                .HasColumnName("ToDistPHOnlineHorses");
            entity.Property(e => e.ToDistPhonlineSports)
                .HasColumnType("money")
                .HasColumnName("ToDistPHOnlineSports");
            entity.Property(e => e.ToDistSports).HasColumnType("money");
            entity.Property(e => e.WeeklyCasino).HasColumnType("money");
            entity.Property(e => e.WeeklyHorses).HasColumnType("money");
            entity.Property(e => e.WeeklySports).HasColumnType("money");
        });

        modelBuilder.Entity<CwAgentUndo>(entity =>
        {
            entity.ToTable("CW_AGENT_UNDO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.MoneyChange).HasColumnType("money");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<CwAgentlog>(entity =>
        {
            entity.HasKey(e => new { e.DistributionDate, e.Idagent });

            entity.ToTable("CW_AGENTLOG");

            entity.Property(e => e.DistributionDate).HasColumnType("datetime");
            entity.Property(e => e.Idagent).HasColumnName("IDAgent");
            entity.Property(e => e.Agent)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AgentType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CommCasino).HasColumnType("money");
            entity.Property(e => e.CommHorses).HasColumnType("money");
            entity.Property(e => e.CommPctCasino).HasColumnType("money");
            entity.Property(e => e.CommPctHorses).HasColumnType("money");
            entity.Property(e => e.CommPctSports).HasColumnType("money");
            entity.Property(e => e.CommSports).HasColumnType("money");
            entity.Property(e => e.Distributor)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.GrossCasino).HasColumnType("money");
            entity.Property(e => e.GrossHorses).HasColumnType("money");
            entity.Property(e => e.GrossSports).HasColumnType("money");
            entity.Property(e => e.IdDistributor).HasColumnName("idDistributor");
            entity.Property(e => e.IsDistributor).HasColumnName("isDistributor");
            entity.Property(e => e.Nbalance).HasColumnName("NBalance");
            entity.Property(e => e.Pbalance).HasColumnName("PBalance");
            entity.Property(e => e.Phcasino)
                .HasColumnType("money")
                .HasColumnName("PHCasino");
            entity.Property(e => e.PhlocalHorses)
                .HasColumnType("money")
                .HasColumnName("PHLocalHorses");
            entity.Property(e => e.PhlocalSports)
                .HasColumnType("money")
                .HasColumnName("PHLocalSports");
            entity.Property(e => e.PhonlineHorses)
                .HasColumnType("money")
                .HasColumnName("PHOnlineHorses");
            entity.Property(e => e.PhonlineSports)
                .HasColumnType("money")
                .HasColumnName("PHOnlineSports");
            entity.Property(e => e.ToDistCasino).HasColumnType("money");
            entity.Property(e => e.ToDistHorses).HasColumnType("money");
            entity.Property(e => e.ToDistPhcasino)
                .HasColumnType("money")
                .HasColumnName("ToDistPHCasino");
            entity.Property(e => e.ToDistPhlocalHorses)
                .HasColumnType("money")
                .HasColumnName("ToDistPHLocalHorses");
            entity.Property(e => e.ToDistPhlocalSports)
                .HasColumnType("money")
                .HasColumnName("ToDistPHLocalSports");
            entity.Property(e => e.ToDistPhonlineHorses)
                .HasColumnType("money")
                .HasColumnName("ToDistPHOnlineHorses");
            entity.Property(e => e.ToDistPhonlineSports)
                .HasColumnType("money")
                .HasColumnName("ToDistPHOnlineSports");
            entity.Property(e => e.ToDistSports).HasColumnType("money");
            entity.Property(e => e.WeeklyCasino).HasColumnType("money");
            entity.Property(e => e.WeeklyHorses).HasColumnType("money");
            entity.Property(e => e.WeeklySports).HasColumnType("money");
        });

        modelBuilder.Entity<CwPlayer>(entity =>
        {
            entity.HasKey(e => e.Idplayer).HasName("PK_CW_Players");

            entity.ToTable("CW_PLAYER");

            entity.Property(e => e.Idplayer).ValueGeneratedNever();
            entity.Property(e => e.AfterCwcasino)
                .HasColumnType("money")
                .HasColumnName("AfterCWCasino");
            entity.Property(e => e.AfterCwhorses)
                .HasColumnType("money")
                .HasColumnName("AfterCWHorses");
            entity.Property(e => e.AfterCwsports)
                .HasColumnType("money")
                .HasColumnName("AfterCWSports");
            entity.Property(e => e.CurrentBalance).HasColumnType("money");
            entity.Property(e => e.Player)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SettledFigure).HasColumnType("money");
            entity.Property(e => e.WeeklyCasino).HasColumnType("money");
            entity.Property(e => e.WeeklyHorses).HasColumnType("money");
            entity.Property(e => e.WeeklySports).HasColumnType("money");
        });

        modelBuilder.Entity<CwPlayerUndo>(entity =>
        {
            entity.ToTable("CW_PLAYER_UNDO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.MoneyChange).HasColumnType("money");
            entity.Property(e => e.TaxAmount).HasColumnType("money");
        });

        modelBuilder.Entity<CwsConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cws_config");

            entity.Property(e => e.DataKey)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("data_key");
            entity.Property(e => e.DataValue)
                .HasColumnType("text")
                .HasColumnName("data_value");
        });

        modelBuilder.Entity<DbseventIdmap>(entity =>
        {
            entity.HasKey(e => e.DbseventId);

            entity.ToTable("DBSEventIDMap");

            entity.HasIndex(e => e.IdGame, "IX_DBSEventIDMap_IdGame").IsUnique();

            entity.Property(e => e.DbseventId)
                .ValueGeneratedNever()
                .HasColumnName("DBSEventID");
            entity.Property(e => e.DbsgameType).HasColumnName("DBSGameType");
            entity.Property(e => e.LeagueId).HasColumnName("LeagueID");

            entity.HasOne(d => d.IdGameNavigation).WithOne(p => p.DbseventIdmap)
                .HasForeignKey<DbseventIdmap>(d => d.IdGame)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DBSEventIDMap_GAME");

            entity.HasOne(d => d.League).WithMany(p => p.DbseventIdmaps)
                .HasForeignKey(d => d.LeagueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DBSEventIDMap_SYSTEMDBSLEAGUE");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.IdDepartment);

            entity.ToTable("DEPARTMENT");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
        });

        modelBuilder.Entity<DgsToteConfig>(entity =>
        {
            entity.HasKey(e => e.LocationId);

            entity.ToTable("DgsToteConfig");

            entity.Property(e => e.LocationId)
                .ValueGeneratedNever()
                .HasColumnName("LocationID");
            entity.Property(e => e.DgstoteBrokerId).HasColumnName("DGSToteBrokerID");
            entity.Property(e => e.DgstotePassword)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DGSTotePassword");
            entity.Property(e => e.DgstoteServer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DGSToteServer");
        });

        modelBuilder.Entity<Disbtemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DISBTEMP");

            entity.Property(e => e.Agent)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AgentType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CommDescription)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Distributor)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.GrossAmount).HasColumnType("money");
            entity.Property(e => e.GroupName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Idagent).HasColumnName("IDAgent");
            entity.Property(e => e.Nbalance).HasColumnName("NBalance");
            entity.Property(e => e.Pbalance).HasColumnName("PBalance");
        });

        modelBuilder.Entity<EAffiliate>(entity =>
        {
            entity.HasKey(e => e.IdPlayer);

            entity.ToTable("E-AFFILIATE");

            entity.Property(e => e.IdPlayer).ValueGeneratedNever();
            entity.Property(e => e.AdvertId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("AdvertID");
        });

        modelBuilder.Entity<Entry>(entity =>
        {
            entity.ToTable("Entry");

            entity.Property(e => e.EntryId).HasColumnName("EntryID");
            entity.Property(e => e.BkColor)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CoupleChar)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.EntryName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Equipment)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FkColor)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Medication)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ml).HasColumnName("ML");
            entity.Property(e => e.OwnerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RaceId).HasColumnName("RaceID");
            entity.Property(e => e.RiderName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SaddleNum)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.TrainerName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Race).WithMany(p => p.Entries)
                .HasForeignKey(d => d.RaceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Entry_Race");
        });

        modelBuilder.Entity<EntryOdd>(entity =>
        {
            entity.HasKey(e => new { e.RaceId, e.EntryNum });

            entity.Property(e => e.RaceId).HasColumnName("RaceID");
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.Mlfrac)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MLFrac");
            entity.Property(e => e.Mtp).HasColumnName("MTP");
            entity.Property(e => e.PlaceTotal).HasColumnType("money");
            entity.Property(e => e.ShowTotal).HasColumnType("money");
            entity.Property(e => e.WinOdds)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.WinProb).HasColumnType("money");
            entity.Property(e => e.WinTotal).HasColumnType("money");

            entity.HasOne(d => d.Race).WithMany(p => p.EntryOdds)
                .HasForeignKey(d => d.RaceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EntryOdds_Race");
        });

        modelBuilder.Entity<EntryOddsHist>(entity =>
        {
            entity.HasKey(e => new { e.RaceId, e.EntryNum, e.Mtp });

            entity.ToTable("EntryOddsHist");

            entity.Property(e => e.RaceId).HasColumnName("RaceID");
            entity.Property(e => e.Mtp).HasColumnName("MTP");
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.Mlfrac)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MLFrac");
            entity.Property(e => e.WinOdds)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.WinProb).HasColumnType("money");

            entity.HasOne(d => d.Race).WithMany(p => p.EntryOddsHists)
                .HasForeignKey(d => d.RaceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EntryOddsHist_Race");
        });

        modelBuilder.Entity<EntryPastPerf>(entity =>
        {
            entity.HasKey(e => new { e.RaceId, e.EntryId });

            entity.ToTable("EntryPastPerf");

            entity.Property(e => e.RaceId).HasColumnName("RaceID");
            entity.Property(e => e.EntryId).HasColumnName("EntryID");
            entity.Property(e => e.PastPerfXml)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("PastPerfXML");
        });

        modelBuilder.Entity<EposCurrency>(entity =>
        {
            entity.HasKey(e => e.CurrCode);

            entity.ToTable("EposCurrency");

            entity.HasIndex(e => e.CurrName, "IX_EposCurrency").IsUnique();

            entity.Property(e => e.CurrCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CurrName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FormatStr)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EposPlayer>(entity =>
        {
            entity.ToTable("EposPlayer");

            entity.HasIndex(e => e.AcctNum, "IX_EposPlayer_AcctNum").IsUnique();

            entity.Property(e => e.EposPlayerId).HasColumnName("EposPlayerID");
            entity.Property(e => e.AcctNum)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Addr1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Addr2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreateLocationId).HasColumnName("CreateLocationID");
            entity.Property(e => e.CreateManagerId).HasColumnName("CreateManagerID");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdate).HasColumnType("smalldatetime");
            entity.Property(e => e.Phone1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone1Desc)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Phone2)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Phone2Desc)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pin)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("PIN");
            entity.Property(e => e.Province)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.CreateLocation).WithMany(p => p.EposPlayers)
                .HasForeignKey(d => d.CreateLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EposPlayer_Location");

            entity.HasOne(d => d.CreateManager).WithMany(p => p.EposPlayers)
                .HasForeignKey(d => d.CreateManagerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EposPlayer_TerminalManager");

            entity.HasOne(d => d.IdPlayerNavigation).WithMany(p => p.EposPlayers)
                .HasForeignKey(d => d.IdPlayer)
                .HasConstraintName("FK_EposPlayer_Player");
        });

        modelBuilder.Entity<EposPlayerCardQ>(entity =>
        {
            entity.HasKey(e => e.EposPlayerId);

            entity.ToTable("EposPlayerCardQ");

            entity.Property(e => e.EposPlayerId)
                .ValueGeneratedNever()
                .HasColumnName("EposPlayerID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");

            entity.HasOne(d => d.EposPlayer).WithOne(p => p.EposPlayerCardQ)
                .HasForeignKey<EposPlayerCardQ>(d => d.EposPlayerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EposPlayerCardQ_EposPlayer");
        });

        modelBuilder.Entity<EposPlayerChangeLog>(entity =>
        {
            entity.HasKey(e => e.ChangeId);

            entity.ToTable("EposPlayerChangeLog");

            entity.Property(e => e.ChangeId).HasColumnName("ChangeID");
            entity.Property(e => e.ChangeDate).HasColumnType("smalldatetime");
            entity.Property(e => e.EposPlayerId).HasColumnName("EposPlayerID");
            entity.Property(e => e.FieldName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
            entity.Property(e => e.NewValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.EposPlayer).WithMany(p => p.EposPlayerChangeLogs)
                .HasForeignKey(d => d.EposPlayerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EposPlayerChangeLog_EposPlayer");

            entity.HasOne(d => d.Manager).WithMany(p => p.EposPlayerChangeLogs)
                .HasForeignKey(d => d.ManagerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EposPlayerChangeLog_TerminalManager");
        });

        modelBuilder.Entity<EposPlayerPhoto>(entity =>
        {
            entity.HasKey(e => e.EposPlayerId);

            entity.ToTable("EposPlayerPhoto");

            entity.Property(e => e.EposPlayerId)
                .ValueGeneratedNever()
                .HasColumnName("EposPlayerID");
            entity.Property(e => e.Photo).HasColumnType("image");

            entity.HasOne(d => d.EposPlayer).WithOne(p => p.EposPlayerPhoto)
                .HasForeignKey<EposPlayerPhoto>(d => d.EposPlayerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EposPlayerPhoto_EposPlayer");
        });

        modelBuilder.Entity<EposSportsbookTransfer>(entity =>
        {
            entity.HasKey(e => e.TransferId);

            entity.ToTable("EposSportsbookTransfer");

            entity.Property(e => e.TransferId).HasColumnName("TransferID");
            entity.Property(e => e.CurrAmount).HasColumnType("money");
            entity.Property(e => e.CurrCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EposPlayerId).HasColumnName("EposPlayerID");
            entity.Property(e => e.ExchangeRate).HasColumnType("money");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.OpDate).HasColumnType("datetime");
            entity.Property(e => e.TerminalId).HasColumnName("TerminalID");
            entity.Property(e => e.TransferDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.EposPlayer).WithMany(p => p.EposSportsbookTransfers)
                .HasForeignKey(d => d.EposPlayerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EposSportsbookTransfer_EposPlayer");

            entity.HasOne(d => d.IdPlayerNavigation).WithMany(p => p.EposSportsbookTransfers)
                .HasForeignKey(d => d.IdPlayer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EposSportsbookTransfer_PLAYER");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.EposSportsbookTransfers)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EposSportsbookTransfer_USERS");

            entity.HasOne(d => d.Location).WithMany(p => p.EposSportsbookTransfers)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EposSportsbookTransfer_Location");

            entity.HasOne(d => d.Terminal).WithMany(p => p.EposSportsbookTransfers)
                .HasForeignKey(d => d.TerminalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EposSportsbookTransfer_Terminal");
        });

        modelBuilder.Entity<EposVoid>(entity =>
        {
            entity.HasKey(e => new { e.WagerId, e.TicketType });

            entity.ToTable("EposVoid");

            entity.Property(e => e.WagerId).HasColumnName("WagerID");
            entity.Property(e => e.TicketType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
            entity.Property(e => e.OpDate).HasColumnType("datetime");
            entity.Property(e => e.VoidDateTime).HasColumnType("smalldatetime");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.EposVoids)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EposVoid_USERS");

            entity.HasOne(d => d.Manager).WithMany(p => p.EposVoids)
                .HasForeignKey(d => d.ManagerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EposVoid_TerminalManager");
        });

        modelBuilder.Entity<EtsrequestLog>(entity =>
        {
            entity.HasKey(e => e.ReqId);

            entity.ToTable("ETSRequestLog");

            entity.Property(e => e.ReqId).HasColumnName("ReqID");
            entity.Property(e => e.ClientIp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ClientIP");
            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.EtsserverName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ETSServerName");
            entity.Property(e => e.PathInfo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StartTime).HasColumnType("datetime");
            entity.Property(e => e.TermSessId).HasColumnName("TermSessID");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.IdEvent).HasName("PK_Event");

            entity.ToTable("EVENT");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GameDescription)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LastModification)
                .HasDefaultValueSql("((0))")
                .HasColumnType("datetime");
            entity.Property(e => e.SystemDbseventId).HasColumnName("SystemDBSEventID");

            entity.HasOne(d => d.IdGameTypeNavigation).WithMany(p => p.Events)
                .HasForeignKey(d => d.IdGameType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EVENT_GAMETYPE");

            entity.HasOne(d => d.IdLeagueNavigation).WithMany(p => p.EventIdLeagueNavigations)
                .HasForeignKey(d => d.IdLeague)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EVENT_LEAGUE");

            entity.HasOne(d => d.IdTargetLeagueNavigation).WithMany(p => p.EventIdTargetLeagueNavigations)
                .HasForeignKey(d => d.IdTargetLeague)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EVENT_LEAGUE_TARGET");

            entity.HasOne(d => d.SystemDbsevent).WithMany(p => p.Events)
                .HasForeignKey(d => d.SystemDbseventId)
                .HasConstraintName("FK_EVENT_SYSTEMDBSEVENT");
        });

        modelBuilder.Entity<Eventdetail>(entity =>
        {
            entity.HasKey(e => e.IdEventDetail);

            entity.ToTable("EVENTDETAIL");

            entity.Property(e => e.Description)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LastModification)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.IdEventNavigation).WithMany(p => p.Eventdetails)
                .HasForeignKey(d => d.IdEvent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EVENTDETAIL_EVENT");
        });

        modelBuilder.Entity<Eventlang>(entity =>
        {
            entity.HasKey(e => new { e.IdEvent, e.IdLanguage });

            entity.ToTable("EVENTLANG");

            entity.Property(e => e.GameDescription).HasMaxLength(100);
            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdEventNavigation).WithMany(p => p.Eventlangs)
                .HasForeignKey(d => d.IdEvent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EVENTLANG_EVENT");
        });

        modelBuilder.Entity<ExpiredTicketTransact>(entity =>
        {
            entity.HasKey(e => e.TransactId);

            entity.ToTable("ExpiredTicketTransact");

            entity.Property(e => e.TransactId).HasColumnName("TransactID");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
            entity.Property(e => e.OpDate).HasColumnType("datetime");
            entity.Property(e => e.TransactDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<ExtCustomerInfoLive>(entity =>
        {
            entity.HasKey(e => e.Idplayer);

            entity.ToTable("EXT_CustomerINFO_Live");

            entity.Property(e => e.Idplayer)
                .ValueGeneratedNever()
                .HasColumnName("IDPlayer");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AgentId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AgentID");
            entity.Property(e => e.BaseballAction)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Company)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.CreditAcctFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Currency)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Idagent).HasColumnName("IDAgent");
            entity.Property(e => e.PriceType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.StaticLinesFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Store)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TempCreditAdjExpDate).HasColumnType("datetime");
            entity.Property(e => e.Token)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.TokenExpTime).HasColumnType("datetime");
            entity.Property(e => e.UsePuckLineFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ZeroBalanceFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ExtShowGamesLive>(entity =>
        {
            entity.HasKey(e => e.MatchId);

            entity.ToTable("EXT_ShowGames_Live");

            entity.Property(e => e.MatchId)
                .ValueGeneratedNever()
                .HasColumnName("MatchID");
            entity.Property(e => e.GameDateTime).HasColumnType("datetime");
            entity.Property(e => e.SportType)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Team1Id)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Team1ID");
            entity.Property(e => e.Team2Id)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Team2ID");
        });

        modelBuilder.Entity<ExtTbSyncTicketsLive>(entity =>
        {
            entity.HasKey(e => new { e.TicketNumber, e.WagerNumber });

            entity.ToTable("EXT_TbSync_TicketsLive");

            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CustomerID");
            entity.Property(e => e.MatchId1).HasColumnName("MatchID1");
            entity.Property(e => e.MatchId2).HasColumnName("MatchID2");
            entity.Property(e => e.MatchId3).HasColumnName("MatchID3");
            entity.Property(e => e.SyncStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TicketDate).HasColumnType("datetime");
            entity.Property(e => e.TicketDgs).HasColumnName("TicketDGS");
            entity.Property(e => e.TicketIds).HasColumnName("TicketIDS");
            entity.Property(e => e.TicketStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ExtTbWagerContestItemLive>(entity =>
        {
            entity.HasKey(e => new { e.TicketNumber, e.WagerNumber, e.ItemNumber }).HasName("PK_tbWagerContestItem_Live");

            entity.ToTable("Ext_tbWagerContestItem_Live");

            entity.Property(e => e.AgentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AgentID");
            entity.Property(e => e.AhResultFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ArchiveFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ContestDateTime).HasColumnType("datetime");
            entity.Property(e => e.ContestDesc).HasMaxLength(75);
            entity.Property(e => e.ContestType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ContestType2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ContestType3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ContestantName).HasMaxLength(50);
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CustProfile)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DailyFigureDate).HasColumnType("datetime");
            entity.Property(e => e.FreePlayFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LayoffFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MatchId).HasColumnName("MatchID");
            entity.Property(e => e.Outcome)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PriceType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength();
            entity.Property(e => e.ShowOnChartFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Store)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ThresholdType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ThresholdUnits)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ValueDate).HasColumnType("datetime");
            entity.Property(e => e.WinPlaceOrShow)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WinRatio).HasDefaultValueSql("((1.0))");
            entity.Property(e => e.WiseActionFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.XtoYlineRep)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("XtoYLineRep");
        });

        modelBuilder.Entity<ExtTbWagerGameItemLive>(entity =>
        {
            entity.HasKey(e => new { e.TicketNumber, e.WagerNumber, e.ItemNumber }).HasName("PK_tbWagerGameItem_live");

            entity.ToTable("Ext_tbWagerGameItem_Live");

            entity.Property(e => e.AdjustableOddsFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AgentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AgentID");
            entity.Property(e => e.AhResultFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ArchiveFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ChosenTeamId)
                .HasMaxLength(85)
                .IsUnicode(false)
                .HasColumnName("ChosenTeamID");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CustProfile)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DailyFigureDate).HasColumnType("datetime");
            entity.Property(e => e.FreePlayFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GameDateTime).HasColumnType("datetime");
            entity.Property(e => e.LayoffFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ListedPitcher1)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.ListedPitcher2)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.MatchId).HasColumnName("MatchID");
            entity.Property(e => e.Outcome)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PeriodDescription)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Pitcher1ReqFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Pitcher2ReqFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PriceType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength();
            entity.Property(e => e.ShowOnChartFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SportSubType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SportType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Store)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TotalPointsOu)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TotalPointsOU");
            entity.Property(e => e.ValueDate).HasColumnType("datetime");
            entity.Property(e => e.WagerType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WiseActionFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Ezplay>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EZPLAYS");

            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.C).HasMaxLength(50);
            entity.Property(e => e.Clienteid).HasColumnName("clienteid");
            entity.Property(e => e.Createtime).HasColumnName("createtime");
            entity.Property(e => e.G).HasMaxLength(50);
            entity.Property(e => e.Grade).HasMaxLength(50);
            entity.Property(e => e.H).HasMaxLength(50);
            entity.Property(e => e.I)
                .HasMaxLength(50)
                .HasColumnName("i");
            entity.Property(e => e.Idez).HasColumnName("IDEZ");
            entity.Property(e => e.Playerid).HasColumnName("playerid");
            entity.Property(e => e.Voided)
                .HasMaxLength(50)
                .HasColumnName("voided");
            entity.Property(e => e.Y)
                .HasMaxLength(50)
                .HasColumnName("y");
        });

        modelBuilder.Entity<Flagmessagetype>(entity =>
        {
            entity.HasKey(e => e.IdFlagMessageType);

            entity.ToTable("FLAGMESSAGETYPE");

            entity.Property(e => e.IdFlagMessageType).ValueGeneratedOnAdd();
            entity.Property(e => e.Description)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Form>(entity =>
        {
            entity.HasKey(e => e.IdForm);

            entity.ToTable("FORM");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FormName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.System)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Freeplayofficeoption>(entity =>
        {
            entity.HasKey(e => new { e.IdOffice, e.IdSport, e.Line, e.WagerType }).HasName("PK_FREEPLAYOPTIONS");

            entity.ToTable("FREEPLAYOFFICEOPTIONS");

            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdOfficeNavigation).WithMany(p => p.Freeplayofficeoptions)
                .HasForeignKey(d => d.IdOffice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FREEPLAYOFFICEOPTIONS_OFFICE");
        });

        modelBuilder.Entity<Game>(entity =>
        {
            entity.HasKey(e => e.IdGame);

            entity.ToTable("GAME");

            entity.Property(e => e.AcceptAutoChanges)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EventDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GameDateTime).HasColumnType("datetime");
            entity.Property(e => e.GameStat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GradedDate).HasColumnType("datetime");
            entity.Property(e => e.HomePitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HomeTeam)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEvent).HasDefaultValueSql("((0))");
            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.OnLocal)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.VisitorPitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VisitorTeam)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEventNavigation).WithMany(p => p.Games)
                .HasForeignKey(d => d.IdEvent)
                .HasConstraintName("FK_GAME_EVENT");

            entity.HasOne(d => d.IdGameTypeNavigation).WithMany(p => p.Games)
                .HasForeignKey(d => d.IdGameType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GAME_GAMETYPE");

            entity.HasOne(d => d.IdLeagueNavigation).WithMany(p => p.Games)
                .HasForeignKey(d => d.IdLeague)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GAME_LEAGUE");

            entity.HasOne(d => d.IdSportNavigation).WithMany(p => p.Games)
                .HasForeignKey(d => d.IdSport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GAME_SPORT");

            entity.HasOne(d => d.IdTeamHomeNavigation).WithMany(p => p.GameIdTeamHomeNavigations)
                .HasForeignKey(d => d.IdTeamHome)
                .HasConstraintName("FK_GAME_TEAM1");

            entity.HasOne(d => d.IdTeamVisitorNavigation).WithMany(p => p.GameIdTeamVisitorNavigations)
                .HasForeignKey(d => d.IdTeamVisitor)
                .HasConstraintName("FK_GAME_TEAM");
        });

        modelBuilder.Entity<GameLang>(entity =>
        {
            entity.HasKey(e => new { e.IdGame, e.IdLanguage });

            entity.ToTable("GameLang");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HomeTeam).HasMaxLength(100);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.VisitorTeam).HasMaxLength(100);

            entity.HasOne(d => d.IdLanguageNavigation).WithMany(p => p.GameLangs)
                .HasForeignKey(d => d.IdLanguage)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GameLang_Language");
        });

        modelBuilder.Entity<GamePidScore>(entity =>
        {
            entity.HasKey(e => e.IdGame);

            entity.ToTable("GamePidScore");

            entity.Property(e => e.IdGame).ValueGeneratedNever();
            entity.Property(e => e.Hcomment)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("HComment");
            entity.Property(e => e.Hscore)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("HScore");
            entity.Property(e => e.Vcomment)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("VComment");
            entity.Property(e => e.Vscore)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("VScore");
        });

        modelBuilder.Entity<GameTntlang>(entity =>
        {
            entity.HasKey(e => new { e.IdGame, e.TeamNumber, e.IdLanguage });

            entity.ToTable("GameTNTLang");

            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.TeamName).HasMaxLength(100);

            entity.HasOne(d => d.IdLanguageNavigation).WithMany(p => p.GameTntlangs)
                .HasForeignKey(d => d.IdLanguage)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GameTNTLang_Language");
        });

        modelBuilder.Entity<Gameaction>(entity =>
        {
            entity.HasKey(e => new { e.IdGame, e.IdLineType });

            entity.ToTable("GAMEACTION");

            entity.Property(e => e.HomeCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.HomeRisk)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.HomeSpecialCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.HomeSpecialRisk)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.HomeSpecialWin)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.HomeSpreadCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.HomeSpreadRisk)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.HomeSpreadWin)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.HomeWin)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.MasterHomeCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.MasterHomeRisk)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.MasterHomeSpecialCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.MasterHomeSpecialRisk)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.MasterHomeSpecialWin)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.MasterHomeSpreadCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.MasterHomeSpreadRisk)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.MasterHomeSpreadWin)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.MasterHomeWin)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.MasterTotalOverCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.MasterTotalOverRisk)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.MasterTotalOverWin)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.MasterTotalUnderCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.MasterTotalUnderRisk)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.MasterTotalUnderWin)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.MasterVisitorCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.MasterVisitorRisk)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.MasterVisitorSpecialCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.MasterVisitorSpecialRisk)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.MasterVisitorSpecialWin)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.MasterVisitorSpreadCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.MasterVisitorSpreadRisk)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.MasterVisitorSpreadWin)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.MasterVisitorWin)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.SumHomeCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.SumHomeRisk)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.SumHomeSpecialCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.SumHomeSpecialRisk)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.SumHomeSpecialWin)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.SumHomeSpreadCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.SumHomeSpreadRisk)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.SumHomeSpreadWin)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.SumHomeWin)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.SumTotalOverCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.SumTotalOverRisk)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.SumTotalOverWin)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.SumTotalUnderCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.SumTotalUnderRisk)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.SumTotalUnderWin)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.SumVisitorCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.SumVisitorRisk)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.SumVisitorSpecialCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.SumVisitorSpecialRisk)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.SumVisitorSpecialWin)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.SumVisitorSpreadCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.SumVisitorSpreadRisk)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.SumVisitorSpreadWin)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.SumVisitorWin)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.TotalOverCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.TotalOverRisk)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.TotalOverWin)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.TotalUnderCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.TotalUnderRisk)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.TotalUnderWin)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.VisitorCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.VisitorRisk)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.VisitorSpecialCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.VisitorSpecialRisk)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.VisitorSpecialWin)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.VisitorSpreadCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.VisitorSpreadRisk)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.VisitorSpreadWin)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.VisitorWin)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.Gameactions)
                .HasForeignKey(d => d.IdGame)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GAMEACTION_GAME");

            entity.HasOne(d => d.IdLineTypeNavigation).WithMany(p => p.Gameactions)
                .HasForeignKey(d => d.IdLineType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GAMEACTION_LINETYPE");
        });

        modelBuilder.Entity<Gameactionbyagent>(entity =>
        {
            entity.HasKey(e => new { e.IdAgent, e.IdGame });

            entity.ToTable("GAMEACTIONBYAGENT");

            entity.Property(e => e.HomeRisk).HasColumnType("money");
            entity.Property(e => e.HomeSpecialRisk).HasColumnType("money");
            entity.Property(e => e.HomeSpecialWin).HasColumnType("money");
            entity.Property(e => e.HomeSpreadRisk).HasColumnType("money");
            entity.Property(e => e.HomeSpreadWin).HasColumnType("money");
            entity.Property(e => e.HomeWin).HasColumnType("money");
            entity.Property(e => e.MasterHomeRisk).HasColumnType("money");
            entity.Property(e => e.MasterHomeSpecialRisk).HasColumnType("money");
            entity.Property(e => e.MasterHomeSpecialWin).HasColumnType("money");
            entity.Property(e => e.MasterHomeSpreadRisk).HasColumnType("money");
            entity.Property(e => e.MasterHomeSpreadWin).HasColumnType("money");
            entity.Property(e => e.MasterHomeWin).HasColumnType("money");
            entity.Property(e => e.MasterTotalOverRisk).HasColumnType("money");
            entity.Property(e => e.MasterTotalOverWin).HasColumnType("money");
            entity.Property(e => e.MasterTotalUnderRisk).HasColumnType("money");
            entity.Property(e => e.MasterTotalUnderWin).HasColumnType("money");
            entity.Property(e => e.MasterVisitorRisk).HasColumnType("money");
            entity.Property(e => e.MasterVisitorSpecialRisk).HasColumnType("money");
            entity.Property(e => e.MasterVisitorSpecialWin).HasColumnType("money");
            entity.Property(e => e.MasterVisitorSpreadRisk).HasColumnType("money");
            entity.Property(e => e.MasterVisitorSpreadWin).HasColumnType("money");
            entity.Property(e => e.MasterVisitorWin).HasColumnType("money");
            entity.Property(e => e.SumHomeRisk).HasColumnType("money");
            entity.Property(e => e.SumHomeSpecialRisk).HasColumnType("money");
            entity.Property(e => e.SumHomeSpecialWin).HasColumnType("money");
            entity.Property(e => e.SumHomeSpreadRisk).HasColumnType("money");
            entity.Property(e => e.SumHomeSpreadWin).HasColumnType("money");
            entity.Property(e => e.SumHomeWin).HasColumnType("money");
            entity.Property(e => e.SumTotalOverRisk).HasColumnType("money");
            entity.Property(e => e.SumTotalOverWin).HasColumnType("money");
            entity.Property(e => e.SumTotalUnderRisk).HasColumnType("money");
            entity.Property(e => e.SumTotalUnderWin).HasColumnType("money");
            entity.Property(e => e.SumVisitorRisk).HasColumnType("money");
            entity.Property(e => e.SumVisitorSpecialRisk).HasColumnType("money");
            entity.Property(e => e.SumVisitorSpecialWin).HasColumnType("money");
            entity.Property(e => e.SumVisitorSpreadRisk).HasColumnType("money");
            entity.Property(e => e.SumVisitorSpreadWin).HasColumnType("money");
            entity.Property(e => e.SumVisitorWin).HasColumnType("money");
            entity.Property(e => e.TotalOverRisk).HasColumnType("money");
            entity.Property(e => e.TotalOverWin).HasColumnType("money");
            entity.Property(e => e.TotalUnderRisk).HasColumnType("money");
            entity.Property(e => e.TotalUnderWin).HasColumnType("money");
            entity.Property(e => e.VisitorRisk).HasColumnType("money");
            entity.Property(e => e.VisitorSpecialRisk).HasColumnType("money");
            entity.Property(e => e.VisitorSpecialWin).HasColumnType("money");
            entity.Property(e => e.VisitorSpreadRisk).HasColumnType("money");
            entity.Property(e => e.VisitorSpreadWin).HasColumnType("money");
            entity.Property(e => e.VisitorWin).HasColumnType("money");

            entity.HasOne(d => d.IdAgentNavigation).WithMany(p => p.Gameactionbyagents)
                .HasForeignKey(d => d.IdAgent)
                .HasConstraintName("FK_GAMEACTIONBYAGENT_AGENT");

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.Gameactionbyagents)
                .HasForeignKey(d => d.IdGame)
                .HasConstraintName("FK_GAMEACTIONBYAGENT_GAME");
        });

        modelBuilder.Entity<Gamechange>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GAMECHANGE");

            entity.Property(e => e.DateTimeAfter).HasColumnType("datetime");
            entity.Property(e => e.DateTimeBefore).HasColumnType("datetime");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.NewStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OldStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TeamNumber).HasDefaultValueSql("((-1))");

            entity.HasOne(d => d.IdGameNavigation).WithMany()
                .HasForeignKey(d => d.IdGame)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GAMECHANGE_GAME");
        });

        modelBuilder.Entity<Gamedeleted>(entity =>
        {
            entity.HasKey(e => e.IdGame);

            entity.ToTable("GAMEDELETED");

            entity.Property(e => e.IdGame).ValueGeneratedNever();
            entity.Property(e => e.AcceptAutoChanges)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EventDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GameDateTime).HasColumnType("datetime");
            entity.Property(e => e.GameStat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GradedDate).HasColumnType("datetime");
            entity.Property(e => e.HomePitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HomeTeam)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEvent).HasDefaultValueSql("((0))");
            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.VisitorPitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VisitorTeam)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Gameimporteroption>(entity =>
        {
            entity.HasKey(e => e.IdSport);

            entity.ToTable("GAMEIMPORTEROPTIONS");

            entity.Property(e => e.IdSport).ValueGeneratedNever();
        });

        modelBuilder.Entity<Gameimportersource>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GAMEIMPORTERSOURCES");

            entity.Property(e => e.LineChangesUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("LineChangesURL");
            entity.Property(e => e.ScheduleUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ScheduleURL");
            entity.Property(e => e.ScoresUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ScoresURL");
        });

        modelBuilder.Entity<Gamelog>(entity =>
        {
            entity.HasKey(e => e.IdGameLog);

            entity.ToTable("GAMELOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.LoginName)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.NewValue)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Gamerelatedoption>(entity =>
        {
            entity.HasKey(e => new { e.IdProfile, e.IdSport, e.IdPeriod });

            entity.ToTable("GAMERELATEDOPTIONS");

            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.MldogOver).HasColumnName("MLDog_Over");
            entity.Property(e => e.MldogUnder).HasColumnName("MLDog_Under");
            entity.Property(e => e.MlfavOver).HasColumnName("MLFav_Over");
            entity.Property(e => e.MlfavUnder).HasColumnName("MLFav_Under");
            entity.Property(e => e.SprDogOver).HasColumnName("SprDog_Over");
            entity.Property(e => e.SprDogUnder).HasColumnName("SprDog_Under");
            entity.Property(e => e.SprFavOver).HasColumnName("SprFav_Over");
            entity.Property(e => e.SprFavUnder).HasColumnName("SprFav_Under");

            entity.HasOne(d => d.IdProfileNavigation).WithMany(p => p.Gamerelatedoptions)
                .HasForeignKey(d => d.IdProfile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GAMERELATEDOPTIONS_PLAYERPROFILE");

            entity.HasOne(d => d.IdSportNavigation).WithMany(p => p.Gamerelatedoptions)
                .HasForeignKey(d => d.IdSport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GAMERELATEDOPTIONS_SPORT");
        });

        modelBuilder.Entity<Gamerelatedoptionslog>(entity =>
        {
            entity.HasKey(e => e.IdLog);

            entity.ToTable("GAMERELATEDOPTIONSLOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.Newvalue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Placeddate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Gamescore>(entity =>
        {
            entity.HasKey(e => e.IdGameScores);

            entity.ToTable("GAMESCORES");

            entity.Property(e => e.LastModification)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastModificationUser).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<Gamestatpubqueue>(entity =>
        {
            entity.HasKey(e => e.IdGameStatPubQueue);

            entity.ToTable("GAMESTATPUBQUEUE");

            entity.Property(e => e.EventDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GameDateTime).HasColumnType("datetime");
            entity.Property(e => e.GameStat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.HomePitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEvent).HasDefaultValueSql("((0))");
            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OnLocal)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.VisitorPitcher)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEventNavigation).WithMany(p => p.Gamestatpubqueues)
                .HasForeignKey(d => d.IdEvent)
                .HasConstraintName("FK_GAMESTATPUBQUEUE_EVENT");
        });

        modelBuilder.Entity<Gamesyncgame>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GAMESYNCGAMES");

            entity.Property(e => e.OldDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Gametnt>(entity =>
        {
            entity.HasKey(e => new { e.IdGame, e.TeamNumber });

            entity.ToTable("GAMETNT");

            entity.Property(e => e.TeamName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.Gametnts)
                .HasForeignKey(d => d.IdGame)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GAMETNT_GAME");

            entity.HasOne(d => d.IdTeamNavigation).WithMany(p => p.Gametnts)
                .HasForeignKey(d => d.IdTeam)
                .HasConstraintName("FK_GAMETNT_TEAM");
        });

        modelBuilder.Entity<Gametntpropaction>(entity =>
        {
            entity.HasKey(e => new { e.IdGame, e.IdLineType, e.TeamNumber }).HasName("PK_GAMEPROP");

            entity.ToTable("GAMETNTPROPACTION");

            entity.Property(e => e.ActionRisk).HasColumnType("money");
            entity.Property(e => e.ActionWin).HasColumnType("money");
            entity.Property(e => e.BoldMl).HasColumnName("BoldML");
            entity.Property(e => e.MasterActionRisk).HasColumnType("money");
            entity.Property(e => e.MasterActionWin).HasColumnType("money");
            entity.Property(e => e.SendToLs)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("SendToLS");
            entity.Property(e => e.SumActionRisk).HasColumnType("money");
            entity.Property(e => e.SumActionWin).HasColumnType("money");
            entity.Property(e => e.SyncMl)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("SyncML");

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.Gametntpropactions)
                .HasForeignKey(d => d.IdGame)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GAMEPROP_GAME");

            entity.HasOne(d => d.IdLineTypeNavigation).WithMany(p => p.Gametntpropactions)
                .HasForeignKey(d => d.IdLineType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GAMEPROP_LINETYPE");
        });

        modelBuilder.Entity<Gametntpropbyagent>(entity =>
        {
            entity.HasKey(e => new { e.IdAgent, e.IdGame, e.TeamNumber });

            entity.ToTable("GAMETNTPROPBYAGENT");

            entity.Property(e => e.ActionRisk).HasColumnType("money");
            entity.Property(e => e.ActionWin).HasColumnType("money");
            entity.Property(e => e.LastModification)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MasterActionRisk).HasColumnType("money");
            entity.Property(e => e.MasterActionWin).HasColumnType("money");
            entity.Property(e => e.SumActionRisk).HasColumnType("money");
            entity.Property(e => e.SumActionWin).HasColumnType("money");

            entity.HasOne(d => d.IdAgentNavigation).WithMany(p => p.Gametntpropbyagents)
                .HasForeignKey(d => d.IdAgent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GAMETNTPROPBYAGENT_AGENT");

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.Gametntpropbyagents)
                .HasForeignKey(d => d.IdGame)
                .HasConstraintName("FK_GAMETNTPROPBYAGENT_GAME");
        });

        modelBuilder.Entity<Gametntpropbyagentlog>(entity =>
        {
            entity.HasKey(e => e.IdGameTntpropbyAgentLog);

            entity.ToTable("GAMETNTPROPBYAGENTLOG");

            entity.Property(e => e.IdGameTntpropbyAgentLog).HasColumnName("IdGameTNTPROPByAgentLog");
            entity.Property(e => e.FieldName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.NewValue)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Play).HasDefaultValueSql("((-1))");

            entity.HasOne(d => d.IdAgentNavigation).WithMany(p => p.Gametntpropbyagentlogs)
                .HasForeignKey(d => d.IdAgent)
                .HasConstraintName("FK_GAMETNTPROPBYAGENTLOG_AGENT");

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.Gametntpropbyagentlogs)
                .HasForeignKey(d => d.IdGame)
                .HasConstraintName("FK_GAMETNTPROPBYAGENTLOG_GAME1");
        });

        modelBuilder.Entity<Gametype>(entity =>
        {
            entity.HasKey(e => e.IdGameType);

            entity.ToTable("GAMETYPE");

            entity.Property(e => e.Description)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Short)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Gamevalue>(entity =>
        {
            entity.HasKey(e => new { e.IdGame, e.IdLineType });

            entity.ToTable("GAMEVALUES");

            entity.Property(e => e.BoldMl).HasColumnName("BoldML");
            entity.Property(e => e.SendToLs)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("SendToLS");
            entity.Property(e => e.SyncMl)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("SyncML");
            entity.Property(e => e.SyncSpread)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.SyncTotal)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.Gamevalues)
                .HasForeignKey(d => d.IdGame)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GAMEVALUES_GAME");

            entity.HasOne(d => d.IdLineTypeNavigation).WithMany(p => p.Gamevalues)
                .HasForeignKey(d => d.IdLineType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GAMEVALUES_LINETYPE");
        });

        modelBuilder.Entity<Gamevaluesbyagent>(entity =>
        {
            entity.HasKey(e => new { e.IdAgent, e.IdGame }).HasName("PK_GAMEVALUESAGENT");

            entity.ToTable("GAMEVALUESBYAGENT");

            entity.Property(e => e.LastModification)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.IdAgentNavigation).WithMany(p => p.Gamevaluesbyagents)
                .HasForeignKey(d => d.IdAgent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GAMEVALUESBYAGENT_AGENT");

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.Gamevaluesbyagents)
                .HasForeignKey(d => d.IdGame)
                .HasConstraintName("FK_GAMEVALUESBYAGENT_GAME");
        });

        modelBuilder.Entity<Gamevaluesbyagentlog>(entity =>
        {
            entity.HasKey(e => e.IdGameValuesByAgentLog);

            entity.ToTable("GAMEVALUESBYAGENTLOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.NewValue)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Play).HasDefaultValueSql("((-1))");
        });

        modelBuilder.Entity<Gamevalueslog>(entity =>
        {
            entity.HasKey(e => e.IdGameValuesLog).HasName("PK_GameValuesLog");

            entity.ToTable("GAMEVALUESLOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.NewValue)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.Gamevalueslogs)
                .HasForeignKey(d => d.IdGame)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GameValuesLog_GAME");

            entity.HasOne(d => d.IdLineTypeNavigation).WithMany(p => p.Gamevalueslogs)
                .HasForeignKey(d => d.IdLineType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GAMEVALUESLOG_LINETYPE");
        });

        modelBuilder.Entity<Gradedgame>(entity =>
        {
            entity.HasKey(e => e.IdGame).HasName("PK_GRADEGAME");

            entity.ToTable("GRADEDGAME");

            entity.Property(e => e.IdGame).ValueGeneratedNever();
            entity.Property(e => e.AcceptAutoChanges)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EventDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GameDateTime).HasColumnType("datetime");
            entity.Property(e => e.GameStat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GradedDate).HasColumnType("datetime");
            entity.Property(e => e.HomePitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HomeTeam)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEvent).HasDefaultValueSql("((0))");
            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.VisitorPitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VisitorTeam)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEventNavigation).WithMany(p => p.Gradedgames)
                .HasForeignKey(d => d.IdEvent)
                .HasConstraintName("FK_GRADEDGAME_EVENT");
        });

        modelBuilder.Entity<Gradedgameaction>(entity =>
        {
            entity.HasKey(e => new { e.IdLineType, e.IdGame }).HasName("PK_GRADEGAMEACTION");

            entity.ToTable("GRADEDGAMEACTION");

            entity.Property(e => e.HomeRisk).HasColumnType("money");
            entity.Property(e => e.HomeSpecialRisk).HasColumnType("money");
            entity.Property(e => e.HomeSpecialWin).HasColumnType("money");
            entity.Property(e => e.HomeSpreadRisk).HasColumnType("money");
            entity.Property(e => e.HomeSpreadWin).HasColumnType("money");
            entity.Property(e => e.HomeWin).HasColumnType("money");
            entity.Property(e => e.MasterHomeRisk).HasColumnType("money");
            entity.Property(e => e.MasterHomeSpecialRisk).HasColumnType("money");
            entity.Property(e => e.MasterHomeSpecialWin).HasColumnType("money");
            entity.Property(e => e.MasterHomeSpreadRisk).HasColumnType("money");
            entity.Property(e => e.MasterHomeSpreadWin).HasColumnType("money");
            entity.Property(e => e.MasterHomeWin).HasColumnType("money");
            entity.Property(e => e.MasterTotalOverRisk).HasColumnType("money");
            entity.Property(e => e.MasterTotalOverWin).HasColumnType("money");
            entity.Property(e => e.MasterTotalUnderRisk).HasColumnType("money");
            entity.Property(e => e.MasterTotalUnderWin).HasColumnType("money");
            entity.Property(e => e.MasterVisitorRisk).HasColumnType("money");
            entity.Property(e => e.MasterVisitorSpecialRisk).HasColumnType("money");
            entity.Property(e => e.MasterVisitorSpecialWin).HasColumnType("money");
            entity.Property(e => e.MasterVisitorSpreadRisk).HasColumnType("money");
            entity.Property(e => e.MasterVisitorSpreadWin).HasColumnType("money");
            entity.Property(e => e.MasterVisitorWin).HasColumnType("money");
            entity.Property(e => e.SumHomeRisk).HasColumnType("money");
            entity.Property(e => e.SumHomeSpecialRisk).HasColumnType("money");
            entity.Property(e => e.SumHomeSpecialWin).HasColumnType("money");
            entity.Property(e => e.SumHomeSpreadRisk).HasColumnType("money");
            entity.Property(e => e.SumHomeSpreadWin).HasColumnType("money");
            entity.Property(e => e.SumHomeWin).HasColumnType("money");
            entity.Property(e => e.SumTotalOverRisk).HasColumnType("money");
            entity.Property(e => e.SumTotalOverWin).HasColumnType("money");
            entity.Property(e => e.SumTotalUnderRisk).HasColumnType("money");
            entity.Property(e => e.SumTotalUnderWin).HasColumnType("money");
            entity.Property(e => e.SumVisitorRisk).HasColumnType("money");
            entity.Property(e => e.SumVisitorSpecialRisk).HasColumnType("money");
            entity.Property(e => e.SumVisitorSpecialWin).HasColumnType("money");
            entity.Property(e => e.SumVisitorSpreadRisk).HasColumnType("money");
            entity.Property(e => e.SumVisitorSpreadWin).HasColumnType("money");
            entity.Property(e => e.SumVisitorWin).HasColumnType("money");
            entity.Property(e => e.TotalOverRisk).HasColumnType("money");
            entity.Property(e => e.TotalOverWin).HasColumnType("money");
            entity.Property(e => e.TotalUnderRisk).HasColumnType("money");
            entity.Property(e => e.TotalUnderWin).HasColumnType("money");
            entity.Property(e => e.VisitorRisk).HasColumnType("money");
            entity.Property(e => e.VisitorSpecialRisk).HasColumnType("money");
            entity.Property(e => e.VisitorSpecialWin).HasColumnType("money");
            entity.Property(e => e.VisitorSpreadRisk).HasColumnType("money");
            entity.Property(e => e.VisitorSpreadWin).HasColumnType("money");
            entity.Property(e => e.VisitorWin).HasColumnType("money");

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.Gradedgameactions)
                .HasForeignKey(d => d.IdGame)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GRADEGAMEACTION_GRADEGAME");
        });

        modelBuilder.Entity<Gradedgameactionbyagent>(entity =>
        {
            entity.HasKey(e => new { e.IdAgent, e.IdGame });

            entity.ToTable("GRADEDGAMEACTIONBYAGENT");

            entity.Property(e => e.HomeRisk).HasColumnType("money");
            entity.Property(e => e.HomeSpecialRisk).HasColumnType("money");
            entity.Property(e => e.HomeSpecialWin).HasColumnType("money");
            entity.Property(e => e.HomeSpreadRisk).HasColumnType("money");
            entity.Property(e => e.HomeSpreadWin).HasColumnType("money");
            entity.Property(e => e.HomeWin).HasColumnType("money");
            entity.Property(e => e.MasterHomeRisk).HasColumnType("money");
            entity.Property(e => e.MasterHomeSpecialRisk).HasColumnType("money");
            entity.Property(e => e.MasterHomeSpecialWin).HasColumnType("money");
            entity.Property(e => e.MasterHomeSpreadRisk).HasColumnType("money");
            entity.Property(e => e.MasterHomeSpreadWin).HasColumnType("money");
            entity.Property(e => e.MasterHomeWin).HasColumnType("money");
            entity.Property(e => e.MasterTotalOverRisk).HasColumnType("money");
            entity.Property(e => e.MasterTotalOverWin).HasColumnType("money");
            entity.Property(e => e.MasterTotalUnderRisk).HasColumnType("money");
            entity.Property(e => e.MasterTotalUnderWin).HasColumnType("money");
            entity.Property(e => e.MasterVisitorRisk).HasColumnType("money");
            entity.Property(e => e.MasterVisitorSpecialRisk).HasColumnType("money");
            entity.Property(e => e.MasterVisitorSpecialWin).HasColumnType("money");
            entity.Property(e => e.MasterVisitorSpreadRisk).HasColumnType("money");
            entity.Property(e => e.MasterVisitorSpreadWin).HasColumnType("money");
            entity.Property(e => e.MasterVisitorWin).HasColumnType("money");
            entity.Property(e => e.SumHomeRisk).HasColumnType("money");
            entity.Property(e => e.SumHomeSpecialRisk).HasColumnType("money");
            entity.Property(e => e.SumHomeSpecialWin).HasColumnType("money");
            entity.Property(e => e.SumHomeSpreadRisk).HasColumnType("money");
            entity.Property(e => e.SumHomeSpreadWin).HasColumnType("money");
            entity.Property(e => e.SumHomeWin).HasColumnType("money");
            entity.Property(e => e.SumTotalOverRisk).HasColumnType("money");
            entity.Property(e => e.SumTotalOverWin).HasColumnType("money");
            entity.Property(e => e.SumTotalUnderRisk).HasColumnType("money");
            entity.Property(e => e.SumTotalUnderWin).HasColumnType("money");
            entity.Property(e => e.SumVisitorRisk).HasColumnType("money");
            entity.Property(e => e.SumVisitorSpecialRisk).HasColumnType("money");
            entity.Property(e => e.SumVisitorSpecialWin).HasColumnType("money");
            entity.Property(e => e.SumVisitorSpreadRisk).HasColumnType("money");
            entity.Property(e => e.SumVisitorSpreadWin).HasColumnType("money");
            entity.Property(e => e.SumVisitorWin).HasColumnType("money");
            entity.Property(e => e.TotalOverRisk).HasColumnType("money");
            entity.Property(e => e.TotalOverWin).HasColumnType("money");
            entity.Property(e => e.TotalUnderRisk).HasColumnType("money");
            entity.Property(e => e.TotalUnderWin).HasColumnType("money");
            entity.Property(e => e.VisitorRisk).HasColumnType("money");
            entity.Property(e => e.VisitorSpecialRisk).HasColumnType("money");
            entity.Property(e => e.VisitorSpecialWin).HasColumnType("money");
            entity.Property(e => e.VisitorSpreadRisk).HasColumnType("money");
            entity.Property(e => e.VisitorSpreadWin).HasColumnType("money");
            entity.Property(e => e.VisitorWin).HasColumnType("money");

            entity.HasOne(d => d.IdAgentNavigation).WithMany(p => p.Gradedgameactionbyagents)
                .HasForeignKey(d => d.IdAgent)
                .HasConstraintName("FK_GRADEDGAMEACTIONBYAGENT_AGENT");

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.Gradedgameactionbyagents)
                .HasForeignKey(d => d.IdGame)
                .HasConstraintName("FK_GRADEDGAMEACTIONBYAGENT_GRADEDGAME");
        });

        modelBuilder.Entity<Gradedgamechange>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRADEDGAMECHANGE");

            entity.Property(e => e.DateTimeAfter).HasColumnType("datetime");
            entity.Property(e => e.DateTimeBefore).HasColumnType("datetime");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.NewStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OldStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TeamNumber).HasDefaultValueSql("((-1))");

            entity.HasOne(d => d.IdGameNavigation).WithMany()
                .HasForeignKey(d => d.IdGame)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GRADEDGAMECHANGE_GRADEDGAME");
        });

        modelBuilder.Entity<Gradedgamedeleted>(entity =>
        {
            entity.HasKey(e => e.IdGame);

            entity.ToTable("GRADEDGAMEDELETED");

            entity.Property(e => e.IdGame).ValueGeneratedNever();
            entity.Property(e => e.AcceptAutoChanges)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GameDateTime).HasColumnType("datetime");
            entity.Property(e => e.GameStat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GradedDate).HasColumnType("datetime");
            entity.Property(e => e.HomePitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HomeTeam)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEvent).HasDefaultValueSql("((0))");
            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.VisitorPitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VisitorTeam)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Gradedgametnt>(entity =>
        {
            entity.HasKey(e => new { e.IdGame, e.TeamNumber }).HasName("PK_GRADEGAMETNT");

            entity.ToTable("GRADEDGAMETNT");

            entity.Property(e => e.TeamName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.Gradedgametnts)
                .HasForeignKey(d => d.IdGame)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GRADEGAMETNT_GRADEGAME");
        });

        modelBuilder.Entity<Gradedgametntpropaction>(entity =>
        {
            entity.HasKey(e => new { e.IdGame, e.IdLineType, e.TeamNumber }).HasName("PK_GRADEGAMETNTPROPACTION");

            entity.ToTable("GRADEDGAMETNTPROPACTION");

            entity.Property(e => e.ActionRisk).HasColumnType("money");
            entity.Property(e => e.ActionWin).HasColumnType("money");
            entity.Property(e => e.BoldMl).HasColumnName("BoldML");
            entity.Property(e => e.MasterActionRisk).HasColumnType("money");
            entity.Property(e => e.MasterActionWin).HasColumnType("money");
            entity.Property(e => e.SendToLs)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("SendToLS");
            entity.Property(e => e.SumActionRisk).HasColumnType("money");
            entity.Property(e => e.SumActionWin).HasColumnType("money");
            entity.Property(e => e.SyncMl)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("SyncML");

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.Gradedgametntpropactions)
                .HasForeignKey(d => d.IdGame)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GRADEGAMETNTPROPACTION_GRADEGAME");
        });

        modelBuilder.Entity<Gradedgametntpropbyagent>(entity =>
        {
            entity.HasKey(e => new { e.IdAgent, e.IdGame, e.TeamNumber });

            entity.ToTable("GRADEDGAMETNTPROPBYAGENT");

            entity.Property(e => e.ActionRisk).HasColumnType("money");
            entity.Property(e => e.ActionWin).HasColumnType("money");
            entity.Property(e => e.LastModification)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MasterActionRisk).HasColumnType("money");
            entity.Property(e => e.MasterActionWin).HasColumnType("money");
            entity.Property(e => e.SumActionRisk).HasColumnType("money");
            entity.Property(e => e.SumActionWin).HasColumnType("money");

            entity.HasOne(d => d.IdAgentNavigation).WithMany(p => p.Gradedgametntpropbyagents)
                .HasForeignKey(d => d.IdAgent)
                .HasConstraintName("FK_GRADEDGAMETNTPROPBYAGENT_AGENT");

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.Gradedgametntpropbyagents)
                .HasForeignKey(d => d.IdGame)
                .HasConstraintName("FK_GRADEDGAMETNTPROPBYAGENT_GRADEDGAME");
        });

        modelBuilder.Entity<Gradedgametntpropbyagentlog>(entity =>
        {
            entity.HasKey(e => e.IdGradedGameTntpropbyAgentLog);

            entity.ToTable("GRADEDGAMETNTPROPBYAGENTLOG");

            entity.Property(e => e.IdGradedGameTntpropbyAgentLog).HasColumnName("IdGradedGameTNTPROPByAgentLog");
            entity.Property(e => e.FieldName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.LastModificationUser).HasDefaultValueSql("((0))");
            entity.Property(e => e.NewValue)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Play).HasDefaultValueSql("((-1))");

            entity.HasOne(d => d.IdAgentNavigation).WithMany(p => p.Gradedgametntpropbyagentlogs)
                .HasForeignKey(d => d.IdAgent)
                .HasConstraintName("FK_GRADEDGAMETNTPROPBYAGENTLOG_AGENT");

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.Gradedgametntpropbyagentlogs)
                .HasForeignKey(d => d.IdGame)
                .HasConstraintName("FK_GRADEDGAMETNTPROPBYAGENTLOG_GRADEDGAME");
        });

        modelBuilder.Entity<Gradedgamevalue>(entity =>
        {
            entity.HasKey(e => new { e.IdLineType, e.IdGame }).HasName("PK_GRADEGAMEVALUES");

            entity.ToTable("GRADEDGAMEVALUES");

            entity.Property(e => e.BoldMl).HasColumnName("BoldML");
            entity.Property(e => e.SendToLs)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("SendToLS");
            entity.Property(e => e.SyncMl)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("SyncML");
            entity.Property(e => e.SyncSpread)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.SyncTotal)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.Gradedgamevalues)
                .HasForeignKey(d => d.IdGame)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GRADEGAMEVALUES_GRADEGAME");
        });

        modelBuilder.Entity<Gradedgamevaluesbyagent>(entity =>
        {
            entity.HasKey(e => new { e.IdAgent, e.IdGame });

            entity.ToTable("GRADEDGAMEVALUESBYAGENT");

            entity.Property(e => e.LastModification)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.IdAgentNavigation).WithMany(p => p.Gradedgamevaluesbyagents)
                .HasForeignKey(d => d.IdAgent)
                .HasConstraintName("FK_GRADEDGAMEVALUESBYAGENT_AGENT");

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.Gradedgamevaluesbyagents)
                .HasForeignKey(d => d.IdGame)
                .HasConstraintName("FK_GRADEDGAMEVALUESBYAGENT_GRADEDGAME");
        });

        modelBuilder.Entity<Gradedgamevaluesbyagentlog>(entity =>
        {
            entity.HasKey(e => e.IdGradedGameValuesByAgentLog);

            entity.ToTable("GRADEDGAMEVALUESBYAGENTLOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.NewValue)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Play).HasDefaultValueSql("((-1))");

            entity.HasOne(d => d.IdAgentNavigation).WithMany(p => p.Gradedgamevaluesbyagentlogs)
                .HasForeignKey(d => d.IdAgent)
                .HasConstraintName("FK_GRADEDGAMEVALUESBYAGENTLOG_AGENT");

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.Gradedgamevaluesbyagentlogs)
                .HasForeignKey(d => d.IdGame)
                .HasConstraintName("FK_GRADEDGAMEVALUESBYAGENTLOG_GRADEDGAME");
        });

        modelBuilder.Entity<Gradedgamevalueslog>(entity =>
        {
            entity.HasKey(e => e.IdGameValuesLog).HasName("PK_GradedGameValuesLog");

            entity.ToTable("GRADEDGAMEVALUESLOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.NewValue)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Gradedpitcherchangelog>(entity =>
        {
            entity.HasKey(e => e.IdpitcherChangeLog);

            entity.ToTable("GRADEDPITCHERCHANGELOG");

            entity.Property(e => e.IdpitcherChangeLog)
                .ValueGeneratedNever()
                .HasColumnName("IDPitcherChangeLog");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.NewHomePitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NewVisitorPitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OldHomePitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OldVisitorPitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Gradedwagerdetail>(entity =>
        {
            entity.HasKey(e => new { e.IdWager, e.IdWagerDetail }).HasName("PK_GRADEWAGERDETAIL");

            entity.ToTable("GRADEDWAGERDETAIL");

            entity.Property(e => e.ChartDetailRisk).HasColumnType("money");
            entity.Property(e => e.ChartDetailWin).HasColumnType("money");
            entity.Property(e => e.CompleteDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.GameDateTime).HasColumnType("datetime");
            entity.Property(e => e.HomePitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hscore).HasColumnName("HScore");
            entity.Property(e => e.IdEvent).HasComment("Event.IdEvent. 0= is a match");
            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.IfBetAmount).HasColumnType("money");
            entity.Property(e => e.MasterChartDetailRisk).HasColumnType("money");
            entity.Property(e => e.MasterChartDetailWin).HasColumnType("money");
            entity.Property(e => e.SumChartDetailRisk).HasColumnType("money");
            entity.Property(e => e.SumChartDetailWin).HasColumnType("money");
            entity.Property(e => e.VisitorPitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Vscore).HasColumnName("VScore");

            entity.HasOne(d => d.IdWagerNavigation).WithMany(p => p.Gradedwagerdetails)
                .HasForeignKey(d => d.IdWager)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GRADEWAGERDETAIL_GRADEWAGERHEADER");
        });

        modelBuilder.Entity<Gradedwagerheader>(entity =>
        {
            entity.HasKey(e => e.IdWager).HasName("PK_GRADEWAGERHEADER");

            entity.ToTable("GRADEDWAGERHEADER");

            entity.Property(e => e.IdWager).ValueGeneratedNever();
            entity.Property(e => e.CompleteDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CrrnumDetails).HasColumnName("CRRNumDetails");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Epos).HasColumnName("EPOS");
            entity.Property(e => e.Epospaid).HasColumnName("EPOSPaid");
            entity.Property(e => e.IdBook).HasDefaultValueSql("((1))");
            entity.Property(e => e.IdcardHeader).HasColumnName("IDCardHeader");
            entity.Property(e => e.IfBetRiskAmount).HasColumnType("money");
            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.MoneyChange).HasColumnType("money");
            entity.Property(e => e.OriginalRiskAmount).HasColumnType("money");
            entity.Property(e => e.OriginalWagerAmount).HasColumnType("money");
            entity.Property(e => e.OriginalWinAmount).HasColumnType("money");
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
            entity.Property(e => e.RiskAmount).HasColumnType("money");
            entity.Property(e => e.SettledDate).HasColumnType("datetime");
            entity.Property(e => e.TaxAmount).HasColumnType("money");
            entity.Property(e => e.WagerType).HasDefaultValueSql("((1))");
            entity.Property(e => e.WinAmount).HasColumnType("money");
        });

        modelBuilder.Entity<Grouping>(entity =>
        {
            entity.HasKey(e => e.IdGrouping);

            entity.ToTable("GROUPING");

            entity.HasIndex(e => e.GroupName, "IX_GROUPNAME").IsUnique();

            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
        });

        modelBuilder.Entity<Holdwagerdetail>(entity =>
        {
            entity.HasKey(e => new { e.IdHoldWagerDetail, e.IdHoldWagerHeader });

            entity.ToTable("HOLDWAGERDETAIL");

            entity.Property(e => e.IdHoldWagerDetail).ValueGeneratedOnAdd();
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.IdWager).HasDefaultValueSql("((-1))");

            entity.HasOne(d => d.IdHoldWagerHeaderNavigation).WithMany(p => p.Holdwagerdetails)
                .HasForeignKey(d => d.IdHoldWagerHeader)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HOLDWAGERDETAIL_HoldWAGERHEADER");
        });

        modelBuilder.Entity<Holdwagerheader>(entity =>
        {
            entity.HasKey(e => e.IdHoldWagerHeader);

            entity.ToTable("HOLDWAGERHEADER");

            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.Player)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.WagerAmount).HasColumnType("money");
        });

        modelBuilder.Entity<IcontentContestValue>(entity =>
        {
            entity.HasKey(e => e.IdContent);

            entity.ToTable("ICONTENT_ContestValues");

            entity.Property(e => e.IdScheduleDetails).HasColumnName("IdSchedule_details");
            entity.Property(e => e.IdUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Regdate).HasColumnType("datetime");
            entity.Property(e => e.SideChoose).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.TieBreaker).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ValueSelected).HasMaxLength(50);
            entity.Property(e => e.ValueType).HasMaxLength(50);
        });

        modelBuilder.Entity<IcontentSchedule>(entity =>
        {
            entity.HasKey(e => e.IdSchedule).HasName("PK_Schedule");

            entity.ToTable("ICONTENT_Schedule");

            entity.Property(e => e.CloseTime).HasColumnType("datetime");
            entity.Property(e => e.Dgssports)
                .HasMaxLength(10)
                .HasColumnName("DGSSports");
            entity.Property(e => e.OpenTime).HasColumnType("datetime");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<IcontentScheduleDetail>(entity =>
        {
            entity.HasKey(e => e.IdDetails).HasName("PK_ScheduleDetail");

            entity.ToTable("ICONTENT_ScheduleDetails");

            entity.Property(e => e.Away).HasMaxLength(50);
            entity.Property(e => e.AwaySpread).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.AwayTotal).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ContestValues).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Dgsidgame).HasColumnName("dgsidgame");
            entity.Property(e => e.GameDatetime).HasColumnType("datetime");
            entity.Property(e => e.Home).HasMaxLength(50);
            entity.Property(e => e.HomeSpread).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.HomeTotal).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ProcessDate).HasColumnType("datetime");
            entity.Property(e => e.Regdate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<InactiveTill>(entity =>
        {
            entity.HasKey(e => e.ActiveTillId);

            entity.ToTable("InactiveTill");

            entity.Property(e => e.ActiveTillId)
                .ValueGeneratedNever()
                .HasColumnName("ActiveTillID");
            entity.Property(e => e.ClosedDateTime).HasColumnType("smalldatetime");
            entity.Property(e => e.Disbursements).HasColumnType("money");
            entity.Property(e => e.OpDate).HasColumnType("datetime");
            entity.Property(e => e.OpenedDateTime).HasColumnType("smalldatetime");
            entity.Property(e => e.OpeningBalance).HasColumnType("money");
            entity.Property(e => e.OverShort).HasColumnType("money");
            entity.Property(e => e.PhysicalCount).HasColumnType("money");
            entity.Property(e => e.Receipts).HasColumnType("money");
            entity.Property(e => e.ReconciledDateTime).HasColumnType("smalldatetime");
            entity.Property(e => e.TerminalId).HasColumnName("TerminalID");
            entity.Property(e => e.TillId).HasColumnName("TillID");

            entity.HasOne(d => d.OpenedByNavigation).WithMany(p => p.InactiveTillOpenedByNavigations)
                .HasForeignKey(d => d.OpenedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InactiveTill_TerminalManager");

            entity.HasOne(d => d.ReconciledByNavigation).WithMany(p => p.InactiveTillReconciledByNavigations)
                .HasForeignKey(d => d.ReconciledBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InactiveTill_TerminalManager1");

            entity.HasOne(d => d.Terminal).WithMany(p => p.InactiveTills)
                .HasForeignKey(d => d.TerminalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InactiveTill_Terminal");

            entity.HasOne(d => d.Till).WithMany(p => p.InactiveTills)
                .HasForeignKey(d => d.TillId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InactiveTill_Till");
        });

        modelBuilder.Entity<Itevent>(entity =>
        {
            entity.HasKey(e => new { e.MeetingCode, e.EventNumber });

            entity.ToTable("ITEvent");

            entity.Property(e => e.MeetingCode)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RunnerStatusFlags)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ItfeedState>(entity =>
        {
            entity.HasKey(e => e.FeedDate);

            entity.ToTable("ITFeedState");

            entity.Property(e => e.FeedDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<Itmeet>(entity =>
        {
            entity.HasKey(e => e.MeetingCode);

            entity.ToTable("ITMeet");

            entity.Property(e => e.MeetingCode)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RaceDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TrackId).HasColumnName("TrackID");
        });

        modelBuilder.Entity<Juicerebate>(entity =>
        {
            entity.HasKey(e => new { e.IdLineType, e.IdSport, e.Range, e.Line, e.IdGameType, e.Online }).HasName("PK_ONLINEJUICEREBATE");

            entity.ToTable("JUICEREBATE");

            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdGameType).HasDefaultValueSql("((1))");
            entity.Property(e => e.Online).HasDefaultValueSql("((1))");
            entity.Property(e => e.JuiceRebate1).HasColumnName("JuiceRebate");
            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdGameTypeNavigation).WithMany(p => p.Juicerebates)
                .HasForeignKey(d => d.IdGameType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ONLINEJUICEREBATE_GAMETYPE");

            entity.HasOne(d => d.IdLineTypeNavigation).WithMany(p => p.Juicerebates)
                .HasForeignKey(d => d.IdLineType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ONLINEJUICEREBATE_LINETYPE");

            entity.HasOne(d => d.IdSportNavigation).WithMany(p => p.Juicerebates)
                .HasForeignKey(d => d.IdSport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ONLINEJUICEREBATE_SPORT");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.IdLanguage);

            entity.ToTable("Language");

            entity.HasIndex(e => e.LangDesc, "IX_Language").IsUnique();

            entity.Property(e => e.CultureInfo)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.LangDesc)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LbticketCorrelation>(entity =>
        {
            entity.HasKey(e => e.RemoteTicketId);

            entity.ToTable("LBTicketCorrelation");

            entity.Property(e => e.RemoteTicketId)
                .ValueGeneratedNever()
                .HasColumnName("RemoteTicketID");
            entity.Property(e => e.DgsticketId).HasColumnName("DGSTicketID");
        });

        modelBuilder.Entity<League>(entity =>
        {
            entity.HasKey(e => e.IdLeague);

            entity.ToTable("LEAGUE");

            entity.HasIndex(e => e.Description, "IX_LEAGUE").IsUnique();

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdLeagueRegion).HasDefaultValueSql("((1))");
            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.ShortDescription)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.TeamFkrequired).HasColumnName("TeamFKRequired");

            entity.HasOne(d => d.IdLeagueRegionNavigation).WithMany(p => p.Leagues)
                .HasForeignKey(d => d.IdLeagueRegion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LEAGUE_LEAGUEREGION");

            entity.HasOne(d => d.IdSportNavigation).WithMany(p => p.Leagues)
                .HasForeignKey(d => d.IdSport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LEAGUE_SPORT");
        });

        modelBuilder.Entity<Leaguelang>(entity =>
        {
            entity.HasKey(e => new { e.IdLeague, e.IdLanguage });

            entity.ToTable("LEAGUELANG");

            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdLanguageNavigation).WithMany(p => p.Leaguelangs)
                .HasForeignKey(d => d.IdLanguage)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LEAGUELANG_Language");

            entity.HasOne(d => d.IdLeagueNavigation).WithMany(p => p.Leaguelangs)
                .HasForeignKey(d => d.IdLeague)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LEAGUELANG_LEAGUE");
        });

        modelBuilder.Entity<Leagueregion>(entity =>
        {
            entity.HasKey(e => e.IdleagueRegion);

            entity.ToTable("LEAGUEREGION");

            entity.Property(e => e.IdleagueRegion).HasColumnName("IDLeagueRegion");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
        });

        modelBuilder.Entity<Leagueregionlang>(entity =>
        {
            entity.HasKey(e => new { e.IdLeagueRegion, e.IdLanguage });

            entity.ToTable("LEAGUEREGIONLANG");

            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdLanguageNavigation).WithMany(p => p.Leagueregionlangs)
                .HasForeignKey(d => d.IdLanguage)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LEAGUEREGIONLANG_Language");

            entity.HasOne(d => d.IdLeagueRegionNavigation).WithMany(p => p.Leagueregionlangs)
                .HasForeignKey(d => d.IdLeagueRegion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LEAGUEREGIONLANG_LEAGUEREGION");
        });

        modelBuilder.Entity<License>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("License");

            entity.Property(e => e.License1)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("License");
        });

        modelBuilder.Entity<LimitSet>(entity =>
        {
            entity.ToTable("LimitSet");

            entity.HasIndex(e => e.LimitSetName, "IX_LimitSet_LimitSetName").IsUnique();

            entity.Property(e => e.LimitSetId).HasColumnName("LimitSetID");
            entity.Property(e => e.LimitSetName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaxRaceWin).HasColumnType("money");
        });

        modelBuilder.Entity<LimitSetBetType>(entity =>
        {
            entity.HasKey(e => new { e.LimitSetId, e.BetType });

            entity.ToTable("LimitSetBetType");

            entity.Property(e => e.LimitSetId).HasColumnName("LimitSetID");
            entity.Property(e => e.AddPayoutOdds).HasColumnType("money");
            entity.Property(e => e.MaxPayoutCap).HasColumnType("money");
            entity.Property(e => e.MaxPayoutOdds).HasColumnType("money");
            entity.Property(e => e.MaxStake).HasColumnType("money");
            entity.Property(e => e.MaxStakeOnline).HasColumnType("money");
            entity.Property(e => e.MinStake).HasColumnType("money");
            entity.Property(e => e.MinStakeOnline).HasColumnType("money");
            entity.Property(e => e.Rebate).HasColumnType("numeric(4, 2)");
            entity.Property(e => e.RebateOnline).HasColumnType("numeric(4, 2)");
            entity.Property(e => e.ToteThreshold).HasColumnType("money");

            entity.HasOne(d => d.LimitSet).WithMany(p => p.LimitSetBetTypes)
                .HasForeignKey(d => d.LimitSetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LimitSetBetType_LimitSet");
        });

        modelBuilder.Entity<LimitSetTrack>(entity =>
        {
            entity.HasKey(e => new { e.TrackId, e.ProfileId });

            entity.ToTable("LimitSetTrack");

            entity.Property(e => e.TrackId).HasColumnName("TrackID");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.LimitSetId).HasColumnName("LimitSetID");

            entity.HasOne(d => d.LimitSet).WithMany(p => p.LimitSetTracks)
                .HasForeignKey(d => d.LimitSetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LimitSetTrack_LimitSet");

            entity.HasOne(d => d.Profile).WithMany(p => p.LimitSetTracks)
                .HasForeignKey(d => d.ProfileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LimitSetTrack_ProfileTrack");

            entity.HasOne(d => d.Track).WithMany(p => p.LimitSetTracks)
                .HasForeignKey(d => d.TrackId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LimitSetTrack_Track");
        });

        modelBuilder.Entity<LinePubQueue>(entity =>
        {
            entity.HasKey(e => e.IdQueue);

            entity.ToTable("LinePubQueue");

            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.QueueDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<LineSubscriber>(entity =>
        {
            entity.HasKey(e => e.IdSubscriber);

            entity.ToTable("LineSubscriber");

            entity.Property(e => e.ConfigurationData)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.SubscriberName)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.IdLineTypeNavigation).WithMany(p => p.LineSubscribers)
                .HasForeignKey(d => d.IdLineType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LineSubscriber_LINETYPE");

            entity.HasOne(d => d.IdSubscriberTypeNavigation).WithMany(p => p.LineSubscribers)
                .HasForeignKey(d => d.IdSubscriberType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LineSubscriber_LineSubscriberType");
        });

        modelBuilder.Entity<LineSubscriberType>(entity =>
        {
            entity.HasKey(e => e.IdSubscriberType);

            entity.ToTable("LineSubscriberType");

            entity.Property(e => e.IdSubscriberType).ValueGeneratedNever();
            entity.Property(e => e.SubscriberType)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Linesubscriberdgsinfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LINESUBSCRIBERDGSINFO");

            entity.Property(e => e.Ip)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Login)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Linetype>(entity =>
        {
            entity.HasKey(e => e.IdLineType);

            entity.ToTable("LINETYPE");

            entity.Property(e => e.Description)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FbbbmoneyLineSync).HasColumnName("FBBBMoneyLineSync");
            entity.Property(e => e.FbbbspreadOddsSync).HasColumnName("FBBBSpreadOddsSync");
            entity.Property(e => e.FbbbspreadSync).HasColumnName("FBBBSpreadSync");
            entity.Property(e => e.FbbbtotalOddsSync).HasColumnName("FBBBTotalOddsSync");
            entity.Property(e => e.FbbbtotalSync).HasColumnName("FBBBTotalSync");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.Mlbincrease).HasColumnName("MLBIncrease");
            entity.Property(e => e.MlbmoneyLineSync).HasColumnName("MLBMoneyLineSync");
            entity.Property(e => e.MlbrunOddsSync).HasColumnName("MLBRunOddsSync");
            entity.Property(e => e.MlbrunSync).HasColumnName("MLBRunSync");
            entity.Property(e => e.MlbtotalOddsSync).HasColumnName("MLBTotalOddsSync");
            entity.Property(e => e.MlbtotalSync).HasColumnName("MLBTotalSync");
            entity.Property(e => e.MumoneyLineSync).HasColumnName("MUMoneyLineSync");
            entity.Property(e => e.MuspreadOddsSync).HasColumnName("MUSpreadOddsSync");
            entity.Property(e => e.MuspreadSync).HasColumnName("MUSpreadSync");
            entity.Property(e => e.MutotalOddsSync).HasColumnName("MUTotalOddsSync");
            entity.Property(e => e.MutotalSync).HasColumnName("MUTotalSync");
            entity.Property(e => e.Nbaincrease).HasColumnName("NBAIncrease");
            entity.Property(e => e.NhlamericanOddsSync).HasColumnName("NHLAmericanOddsSync");
            entity.Property(e => e.NhlamericanSync).HasColumnName("NHLAmericanSync");
            entity.Property(e => e.NhlcanadianOddsSync).HasColumnName("NHLCanadianOddsSync");
            entity.Property(e => e.NhlcanadianSync).HasColumnName("NHLCanadianSync");
            entity.Property(e => e.Nhlincrease)
                .HasDefaultValueSql("((1))")
                .HasColumnName("NHLIncrease");
            entity.Property(e => e.NhlmoneyLineSync).HasColumnName("NHLMoneyLineSync");
            entity.Property(e => e.NhltotalOddsSync).HasColumnName("NHLTotalOddsSync");
            entity.Property(e => e.NhltotalSync).HasColumnName("NHLTotalSync");
            entity.Property(e => e.SocgoalsOddsSync).HasColumnName("SOCGoalsOddsSync");
            entity.Property(e => e.SocgoalsSync).HasColumnName("SOCGoalsSync");
            entity.Property(e => e.SocmoneyLineSync).HasColumnName("SOCMoneyLineSync");
            entity.Property(e => e.SoctotalOddsSync).HasColumnName("SOCTotalOddsSync");
            entity.Property(e => e.SoctotalSync).HasColumnName("SOCTotalSync");
        });

        modelBuilder.Entity<Linetypeflag>(entity =>
        {
            entity.HasKey(e => e.Idlinetype);

            entity.ToTable("LINETYPEFLAG");

            entity.Property(e => e.Idlinetype).ValueGeneratedNever();
            entity.Property(e => e.LastModification)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.IdlinetypeNavigation).WithOne(p => p.Linetypeflag)
                .HasForeignKey<Linetypeflag>(d => d.Idlinetype)
                .HasConstraintName("FK_LINETYPEFLAG_LINETYPE");
        });

        modelBuilder.Entity<Linetypelink>(entity =>
        {
            entity.HasKey(e => new { e.IdLineTypeOut, e.IdLineTypeIn, e.IdSport });

            entity.ToTable("LINETYPELINKS");

            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('NBA')")
                .IsFixedLength();
            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdLineTypeInNavigation).WithMany(p => p.LinetypelinkIdLineTypeInNavigations)
                .HasForeignKey(d => d.IdLineTypeIn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LINETYPELINKS_LINETYPE1");

            entity.HasOne(d => d.IdLineTypeOutNavigation).WithMany(p => p.LinetypelinkIdLineTypeOutNavigations)
                .HasForeignKey(d => d.IdLineTypeOut)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LINETYPELINKS_LINETYPE");
        });

        modelBuilder.Entity<Linetypelinkslog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LINETYPELINKSLOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.NewValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Linetypelog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LINETYPELOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdLineType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.NewValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.ToTable("Location");

            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.LocationDesc)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.LocationGroup)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.IdPlayerNavigation).WithMany(p => p.Locations)
                .HasForeignKey(d => d.IdPlayer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Location_PLAYER");

            entity.HasMany(d => d.Taxes).WithMany(p => p.Locations)
                .UsingEntity<Dictionary<string, object>>(
                    "Locationtax",
                    r => r.HasOne<Tax>().WithMany()
                        .HasForeignKey("TaxId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_LocationTax_Tax"),
                    l => l.HasOne<Location>().WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_LocationTax_Location"),
                    j =>
                    {
                        j.HasKey("LocationId", "TaxId").HasName("PK_LocationTax");
                        j.ToTable("LOCATIONTAX");
                        j.IndexerProperty<int>("LocationId").HasColumnName("LocationID");
                        j.IndexerProperty<int>("TaxId").HasColumnName("TaxID");
                    });
        });

        modelBuilder.Entity<LocationCurrency>(entity =>
        {
            entity.HasKey(e => new { e.LocationId, e.CurrCode });

            entity.ToTable("LocationCurrency");

            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.CurrCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ExchangeRate).HasColumnType("money");

            entity.HasOne(d => d.CurrCodeNavigation).WithMany(p => p.LocationCurrencies)
                .HasForeignKey(d => d.CurrCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocationCurrency_EposCurrency");

            entity.HasOne(d => d.Location).WithMany(p => p.LocationCurrencies)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocationCurrency_Location");
        });

        modelBuilder.Entity<Lock>(entity =>
        {
            entity.HasKey(e => e.LockId).HasName("PK_Lock");

            entity.ToTable("LOCK");

            entity.HasIndex(e => new { e.LockType, e.LockTypeId }, "IX_Lock_LockType_ID").IsUnique();

            entity.Property(e => e.LockId).HasColumnName("LockID");
            entity.Property(e => e.Acquired).HasColumnType("datetime");
            entity.Property(e => e.LockTypeId).HasColumnName("LockTypeID");
            entity.Property(e => e.LogonSessionId).HasColumnName("LogonSessionID");
        });

        modelBuilder.Entity<ManagerRight>(entity =>
        {
            entity.HasKey(e => new { e.ManagerId, e.IdRight });

            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdRightNavigation).WithMany(p => p.ManagerRights)
                .HasForeignKey(d => d.IdRight)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ManagerRights_RIGHTS");

            entity.HasOne(d => d.Manager).WithMany(p => p.ManagerRights)
                .HasForeignKey(d => d.ManagerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ManagerRights_TerminalManager");
        });

        modelBuilder.Entity<ManualScoreQ>(entity =>
        {
            entity.HasKey(e => e.TicketId);

            entity.ToTable("ManualScoreQ");

            entity.Property(e => e.TicketId)
                .ValueGeneratedNever()
                .HasColumnName("TicketID");

            entity.HasOne(d => d.Ticket).WithOne(p => p.ManualScoreQ)
                .HasForeignKey<ManualScoreQ>(d => d.TicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ManualScoreQ_RaceTicketMain");
        });

        modelBuilder.Entity<MaxPayoutWork>(entity =>
        {
            entity.HasKey(e => new { e.RaceId, e.AccountId });

            entity.ToTable("MaxPayoutWork");

            entity.Property(e => e.RaceId).HasColumnName("RaceID");
            entity.Property(e => e.AccountId).HasColumnName("AccountID");
            entity.Property(e => e.AmountPaid).HasColumnType("money");
            entity.Property(e => e.Stake).HasColumnType("money");
        });

        modelBuilder.Entity<Menureportfile>(entity =>
        {
            entity.HasKey(e => new { e.IdReport, e.CustoId });

            entity.ToTable("MENUREPORTFILES");

            entity.Property(e => e.CustoId).HasColumnName("CustoID");
            entity.Property(e => e.FileName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdReportNavigation).WithMany(p => p.Menureportfiles)
                .HasForeignKey(d => d.IdReport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MENUREPORTFILES_MENUREPORTITEMS");
        });

        modelBuilder.Entity<Menureportitem>(entity =>
        {
            entity.HasKey(e => e.Idreport).HasName("PK_MenuReportItems");

            entity.ToTable("MENUREPORTITEMS");

            entity.Property(e => e.Idreport).HasColumnName("IDReport");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Idmenu).HasColumnName("IDMenu");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.System)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('R')")
                .IsFixedLength();

            entity.HasOne(d => d.IdmenuNavigation).WithMany(p => p.Menureportitems)
                .HasForeignKey(d => d.Idmenu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MENUREPORTITEMS_MENUREPORTMENU");
        });

        modelBuilder.Entity<Menureportitemslang>(entity =>
        {
            entity.HasKey(e => new { e.IdReport, e.IdLanguage });

            entity.ToTable("MENUREPORTITEMSLANG");

            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdLanguageNavigation).WithMany(p => p.Menureportitemslangs)
                .HasForeignKey(d => d.IdLanguage)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MENUREPORTITEMSLANG_LANGUAGE");

            entity.HasOne(d => d.IdReportNavigation).WithMany(p => p.Menureportitemslangs)
                .HasForeignKey(d => d.IdReport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MENUREPORTITEMSLANG_MENUREPORTITEMS");
        });

        modelBuilder.Entity<Menureportlog>(entity =>
        {
            entity.HasKey(e => e.IdLog);

            entity.ToTable("MENUREPORTLOG");

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.ReportName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Menureportmenu>(entity =>
        {
            entity.HasKey(e => e.IdMenu).HasName("PK_MenuReportMenu");

            entity.ToTable("MENUREPORTMENU");

            entity.Property(e => e.IdMenu).ValueGeneratedOnAdd();
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.System)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('R')")
                .IsFixedLength();
        });

        modelBuilder.Entity<Menureportmenulang>(entity =>
        {
            entity.HasKey(e => new { e.IdMenu, e.IdLanguage });

            entity.ToTable("MENUREPORTMENULANG");

            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdLanguageNavigation).WithMany(p => p.Menureportmenulangs)
                .HasForeignKey(d => d.IdLanguage)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MENUREPORTMENULANG_LANGUAGE");

            entity.HasOne(d => d.IdMenuNavigation).WithMany(p => p.Menureportmenulangs)
                .HasForeignKey(d => d.IdMenu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MENUREPORTMENULANG_MENUREPORTMENU");
        });

        modelBuilder.Entity<Menureportparam>(entity =>
        {
            entity.HasKey(e => e.IdParam);

            entity.ToTable("MENUREPORTPARAMS");

            entity.Property(e => e.CustoId).HasColumnName("CustoID");
            entity.Property(e => e.Idreport).HasColumnName("IDReport");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Parent)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.HasOne(d => d.Menureportfile).WithMany(p => p.Menureportparams)
                .HasForeignKey(d => new { d.Idreport, d.CustoId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MENUREPORTPARAMS_MENUREPORTFILES");
        });

        modelBuilder.Entity<Menureportparamslang>(entity =>
        {
            entity.HasKey(e => new { e.IdParam, e.IdLanguage });

            entity.ToTable("MENUREPORTPARAMSLANG");

            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdLanguageNavigation).WithMany(p => p.Menureportparamslangs)
                .HasForeignKey(d => d.IdLanguage)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MENUREPORTPARAMSLANG_LANGUAGE");

            entity.HasOne(d => d.IdParamNavigation).WithMany(p => p.Menureportparamslangs)
                .HasForeignKey(d => d.IdParam)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MENUREPORTPARAMSLANG_MENUREPORTPARAMS");
        });

        modelBuilder.Entity<Mlbeasternline>(entity =>
        {
            entity.HasKey(e => e.IdmlbeasternLine);

            entity.ToTable("MLBEASTERNLINE");

            entity.Property(e => e.IdmlbeasternLine)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDMLBEasternLine");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
        });

        modelBuilder.Entity<Mlbwideline>(entity =>
        {
            entity.HasKey(e => e.IdMlbwideLine).HasName("PK_WIDELINE");

            entity.ToTable("MLBWIDELINE");

            entity.Property(e => e.IdMlbwideLine).HasColumnName("IdMLBWideLine");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
        });

        modelBuilder.Entity<Moneychange>(entity =>
        {
            entity.HasKey(e => new { e.IdCurrency, e.ToDate });

            entity.ToTable("MONEYCHANGE");

            entity.Property(e => e.ToDate).HasColumnType("datetime");
            entity.Property(e => e.AmountPerUnit).HasColumnType("money");
            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdCurrencyNavigation).WithMany(p => p.Moneychanges)
                .HasForeignKey(d => d.IdCurrency)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MONEYCHANGE_CURRENCY");
        });

        modelBuilder.Entity<Oddsbysport>(entity =>
        {
            entity.HasKey(e => new { e.IdLineType, e.IdSport, e.Range, e.Line, e.IdGameType });

            entity.ToTable("ODDSBYSPORT");

            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdGameType).HasDefaultValueSql("((1))");
            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdGameTypeNavigation).WithMany(p => p.Oddsbysports)
                .HasForeignKey(d => d.IdGameType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ODDSBYSPORT_GAMETYPE");

            entity.HasOne(d => d.IdLineTypeNavigation).WithMany(p => p.Oddsbysports)
                .HasForeignKey(d => d.IdLineType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ODDSBYSPORT_LINETYPE");

            entity.HasOne(d => d.IdSportNavigation).WithMany(p => p.Oddsbysports)
                .HasForeignKey(d => d.IdSport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ODDSBYSPORT_SPORT");
        });

        modelBuilder.Entity<Oddsdefault>(entity =>
        {
            entity.HasKey(e => new { e.IdProfile, e.IdSport });

            entity.ToTable("ODDSDEFAULT");

            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdProfileNavigation).WithMany(p => p.Oddsdefaults)
                .HasForeignKey(d => d.IdProfile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ODDSDEFAULT_PLAYERPROFILE");

            entity.HasOne(d => d.IdSportNavigation).WithMany(p => p.Oddsdefaults)
                .HasForeignKey(d => d.IdSport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ODDSDEFAULT_SPORT");
        });

        modelBuilder.Entity<Office>(entity =>
        {
            entity.HasKey(e => e.IdOffice).HasName("PK_OFFICES");

            entity.ToTable("OFFICE");

            entity.HasIndex(e => e.OfficeName, "IX_OFFICENAME").IsUnique();

            entity.Property(e => e.IdOffice).ValueGeneratedOnAdd();
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.OfficeName)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Onlinewagertracker>(entity =>
        {
            entity.HasKey(e => e.IdWagerTracker);

            entity.ToTable("ONLINEWAGERTRACKER");

            entity.HasOne(d => d.IdPlayerNavigation).WithMany(p => p.Onlinewagertrackers)
                .HasForeignKey(d => d.IdPlayer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ONLINEWAGERTRACKER_PLAYER");
        });

        modelBuilder.Entity<OperationDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OperationDate");

            entity.Property(e => e.CurrentOpDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.IdPayment);

            entity.ToTable("PAYMENTS");

            entity.Property(e => e.FinalAmount).HasColumnType("money");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RequestData)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.ResponseData)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.TotalAmount).HasColumnType("money");

            entity.HasOne(d => d.IdPlayerNavigation).WithMany(p => p.Payments)
                .HasForeignKey(d => d.IdPlayer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PAYMENTS_PLAYER");

        });

        modelBuilder.Entity<Paymentmethod>(entity =>
        {
            entity.HasKey(e => e.IdPaymentMethod);

            entity.ToTable("PAYMENTMETHOD");

            entity.HasIndex(e => e.PaymentMethod1, "IX_PAYMENTMETHOD").IsUnique();

            entity.Property(e => e.IdPaymentMethod).ValueGeneratedOnAdd();
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.PaymentMethod1)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PaymentMethod");
        });

        modelBuilder.Entity<PcaaggregateSecurity>(entity =>
        {
            entity.ToTable("PCAAggregateSecurity");

            entity.Property(e => e.Endtime)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.SkipMlover).HasColumnName("SkipMLOver");
            entity.Property(e => e.SkipOuover).HasColumnName("SkipOUOver");
            entity.Property(e => e.SkipPsover).HasColumnName("SkipPSOver");
            entity.Property(e => e.Starttime)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PcaaggregateSetting>(entity =>
        {
            entity.ToTable("PCAAggregateSetting");

            entity.Property(e => e.AddedAt).HasColumnType("datetime");
            entity.Property(e => e.Ml).HasColumnName("ML");
            entity.Property(e => e.MllineOffset)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("MLLineOffset");
            entity.Property(e => e.MlpriceOffset).HasColumnName("MLPriceOffset");
            entity.Property(e => e.MlproviderId).HasColumnName("MLProviderId");
            entity.Property(e => e.OulineOffset)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("OULineOffset");
            entity.Property(e => e.OupriceOffset).HasColumnName("OUPriceOffset");
            entity.Property(e => e.Ps).HasColumnName("PS");
            entity.Property(e => e.PslineOffset)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PSLineOffset");
            entity.Property(e => e.PspriceOffset).HasColumnName("PSPriceOffset");
            entity.Property(e => e.PsproviderId).HasColumnName("PSProviderId");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<Pcaauthentication>(entity =>
        {
            entity.ToTable("PCAAuthentication");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.LastDeviceId)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.LastIpaddress)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("LastIPAddress");
            entity.Property(e => e.LastLogin).HasColumnType("datetime");
            entity.Property(e => e.LoginName)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.Token)
                .HasMaxLength(64)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PcaeventMap>(entity =>
        {
            entity.ToTable("PCAEventMap");

            entity.Property(e => e.AddedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<PcapropGameMap>(entity =>
        {
            entity.HasKey(e => e.FromId);

            entity.ToTable("PCAPropGameMap");

            entity.Property(e => e.FromId).ValueGeneratedNever();
            entity.Property(e => e.Am).HasColumnName("AM");
            entity.Property(e => e.Ap)
                .HasColumnType("smallmoney")
                .HasColumnName("AP");
            entity.Property(e => e.Apm).HasColumnName("APM");
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.Dm).HasColumnName("DM");
            entity.Property(e => e.Hm).HasColumnName("HM");
            entity.Property(e => e.Hp)
                .HasColumnType("smallmoney")
                .HasColumnName("HP");
            entity.Property(e => e.Hpm).HasColumnName("HPM");
            entity.Property(e => e.KickOff).HasColumnType("datetime");
            entity.Property(e => e.Om).HasColumnName("OM");
            entity.Property(e => e.Timestamp).HasColumnType("datetime");
            entity.Property(e => e.Total).HasColumnType("smallmoney");
            entity.Property(e => e.Um).HasColumnName("UM");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<PcapropImportMap>(entity =>
        {
            entity.ToTable("PCAPropImportMap");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<PcasystemInfo>(entity =>
        {
            entity.ToTable("PCASystemInfo");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Dbcatalog)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("DBCatalog");
            entity.Property(e => e.DbdataSource)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("DBDataSource");
            entity.Property(e => e.Dbpassword)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("DBPassword");
            entity.Property(e => e.Dbusername)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("DBUsername");
            entity.Property(e => e.DefaultNss).HasColumnName("DefaultNSS");
            entity.Property(e => e.StreamEndpoint)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.StreamLogin)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.StreamPassword)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.SystemPass)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.SystemUser)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.Version)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Pendingwagerdetail>(entity =>
        {
            entity.HasKey(e => new { e.IdWager, e.IdWagerDetail });

            entity.ToTable("PENDINGWAGERDETAIL");

            entity.Property(e => e.IdWagerDetail).ValueGeneratedOnAdd();
            entity.Property(e => e.ChartDetailRisk).HasColumnType("money");
            entity.Property(e => e.ChartDetailWin).HasColumnType("money");
            entity.Property(e => e.CompleteDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.GameDateTime).HasColumnType("datetime");
            entity.Property(e => e.HomePitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hscore).HasColumnName("HScore");
            entity.Property(e => e.IdEvent).HasComment("Event.IdEvent. 0= is a match");
            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.IfbetAmount).HasColumnType("money");
            entity.Property(e => e.MasterChartDetailRisk).HasColumnType("money");
            entity.Property(e => e.MasterChartDetailWin).HasColumnType("money");
            entity.Property(e => e.SumChartDetailRisk).HasColumnType("money");
            entity.Property(e => e.SumChartDetailWin).HasColumnType("money");
            entity.Property(e => e.VisitorPitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Vscore).HasColumnName("VScore");

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.Pendingwagerdetails)
                .HasForeignKey(d => d.IdGame)
                .HasConstraintName("FK_PENDINGWAGERDETAIL_GAME");

            entity.HasOne(d => d.IdWagerNavigation).WithMany(p => p.Pendingwagerdetails)
                .HasForeignKey(d => d.IdWager)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PENDINGWAGERDETAIL_WAGERHEADER");
        });

        modelBuilder.Entity<Pendingwagerheader>(entity =>
        {
            entity.HasKey(e => e.IdWager);

            entity.ToTable("PENDINGWAGERHEADER");

            entity.Property(e => e.CompleteDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CrrnumDetails).HasColumnName("CRRNumDetails");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Epos).HasColumnName("EPOS");
            entity.Property(e => e.Epospaid).HasColumnName("EPOSPaid");
            entity.Property(e => e.IdBook).HasDefaultValueSql("((1))");
            entity.Property(e => e.IfBetRiskAmount).HasColumnType("money");
            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.MoneyChange).HasColumnType("money");
            entity.Property(e => e.OriginalRiskAmount).HasColumnType("money");
            entity.Property(e => e.OriginalWagerAmount).HasColumnType("money");
            entity.Property(e => e.OriginalWinAmount).HasColumnType("money");
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
            entity.Property(e => e.RiskAmount).HasColumnType("money");
            entity.Property(e => e.SettledDate).HasColumnType("datetime");
            entity.Property(e => e.TaxAmount).HasColumnType("money");
            entity.Property(e => e.WinAmount).HasColumnType("money");

            entity.HasOne(d => d.IdAgentNavigation).WithMany(p => p.Pendingwagerheaders)
                .HasForeignKey(d => d.IdAgent)
                .HasConstraintName("FK_PENDINGWAGERHEADER_AGENT");

            entity.HasOne(d => d.IdCardHeaderNavigation).WithMany(p => p.Pendingwagerheaders)
                .HasForeignKey(d => d.IdCardHeader)
                .HasConstraintName("FK_PENDINGWAGERHEADER_CARDHEADER");

            entity.HasOne(d => d.IdLineTypeNavigation).WithMany(p => p.Pendingwagerheaders)
                .HasForeignKey(d => d.IdLineType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PENDINGWAGERHEADER_LINETYPE");

            entity.HasOne(d => d.IdPlayerNavigation).WithMany(p => p.Pendingwagerheaders)
                .HasForeignKey(d => d.IdPlayer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PENDINGWAGERHEADER_PLAYER");

            entity.HasOne(d => d.IdProfileNavigation).WithMany(p => p.Pendingwagerheaders)
                .HasForeignKey(d => d.IdProfile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PENDINGWAGERHEADER_PLAYERPROFILE");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Pendingwagerheaders)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PENDINGWAGERHEADER_USER");

            entity.HasOne(d => d.IdWagerTypeNavigation).WithMany(p => p.Pendingwagerheaders)
                .HasForeignKey(d => d.IdWagerType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PENDINGWAGERHEADER_WAGERTYPE");
        });

        modelBuilder.Entity<Period>(entity =>
        {
            entity.HasKey(e => new { e.IdSport, e.NumberOfPeriod });

            entity.ToTable("PERIOD");

            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PeriodDescription)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdSportNavigation).WithMany(p => p.Periods)
                .HasForeignKey(d => d.IdSport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERIOD_SPORT");
        });

        modelBuilder.Entity<Pitcher>(entity =>
        {
            entity.HasKey(e => e.IdPitcher);

            entity.ToTable("PITCHER");

            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.PitcherName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Pitcherchangelog>(entity =>
        {
            entity.HasKey(e => e.IdpitcherChangeLog);

            entity.ToTable("PITCHERCHANGELOG");

            entity.Property(e => e.IdpitcherChangeLog).HasColumnName("IDPitcherChangeLog");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.NewHomePitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NewVisitorPitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OldHomePitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OldVisitorPitcher)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.Pitcherchangelogs)
                .HasForeignKey(d => d.IdGame)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PITCHERCHANGELOG_GAME");
        });

        modelBuilder.Entity<Pitcherlang>(entity =>
        {
            entity.HasKey(e => new { e.IdGame, e.Idlanguage });

            entity.ToTable("PITCHERLANG");

            entity.Property(e => e.HomePitcher).HasMaxLength(100);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.VisitorPitcher).HasMaxLength(100);

            entity.HasOne(d => d.IdlanguageNavigation).WithMany(p => p.Pitcherlangs)
                .HasForeignKey(d => d.Idlanguage)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PITCHERLANG_Language");
        });

        modelBuilder.Entity<Player>(entity =>
        {
            entity.HasKey(e => e.IdPlayer);

            entity.ToTable("PLAYER");

            entity.HasIndex(e => e.Player1, "IX_PLAYER_Player").IsUnique();

            entity.Property(e => e.Address1).HasMaxLength(50);
            entity.Property(e => e.Address2).HasMaxLength(50);
            entity.Property(e => e.AllowNegTrans).HasComment("1=Dont check neg. balance for transactions");
            entity.Property(e => e.BonusPointsExpire).HasColumnType("datetime");
            entity.Property(e => e.BonusPointsStart).HasColumnType("datetime");
            entity.Property(e => e.BonusPointsStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CapPerGame).HasColumnType("money");
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Country)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CreditLimit).HasColumnType("money");
            entity.Property(e => e.DateOfBirth)
                .HasDefaultValueSql("('1/1/1970')")
                .HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EnableCards)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.EnableSports)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Eposplayer).HasColumnName("EPOSPlayer");
            entity.Property(e => e.Fax)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.FlagMessage)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FreePlayAmount).HasColumnType("money");
            entity.Property(e => e.FreePlayMessage)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IdLanguage)
                .HasDefaultValueSql("((1))")
                .HasComment("language for the player schedule (online)");
            entity.Property(e => e.IdProfileLimits).HasDefaultValueSql("((1))");
            entity.Property(e => e.IdTimeZone)
                .HasDefaultValueSql("((1))")
                .HasComment("timezone to adjust the schedule of the player   (online)");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.LastName2).HasMaxLength(50);
            entity.Property(e => e.LineStyle)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MaxWager).HasColumnType("money");
            entity.Property(e => e.MinWager).HasColumnType("money");
            entity.Property(e => e.Mlbline)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MLBLine");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Nhlline)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NHLLine");
            entity.Property(e => e.OnlineMaxWager).HasColumnType("money");
            entity.Property(e => e.OnlineMessage).HasMaxLength(100);
            entity.Property(e => e.OnlineMinWager).HasColumnType("money");
            entity.Property(e => e.OnlinePassword).HasMaxLength(255);
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Player1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Player");
            entity.Property(e => e.ResetPassword).HasColumnName("Reset_Password");
            entity.Property(e => e.ScheduleBb).HasColumnName("ScheduleBB");
            entity.Property(e => e.ScheduleBs).HasColumnName("ScheduleBS");
            entity.Property(e => e.ScheduleFb).HasColumnName("ScheduleFB");
            entity.Property(e => e.ScheduleHk).HasColumnName("ScheduleHK");
            entity.Property(e => e.ScheduleStyle)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasComment("Style of the Web Schedule, E=European, A=American");
            entity.Property(e => e.SecAnswer).HasMaxLength(100);
            entity.Property(e => e.SecQuestion).HasMaxLength(100);
            entity.Property(e => e.SettledFigure).HasColumnType("money");
            entity.Property(e => e.SignUpIp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("SignUpIP");
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TempCredit).HasColumnType("money");
            entity.Property(e => e.TempCreditExpire).HasColumnType("datetime");
            entity.Property(e => e.Title)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAffiliateNavigation).WithMany(p => p.Players)
                .HasForeignKey(d => d.IdAffiliate)
                .HasConstraintName("FK_PLAYER_AGENT");

            entity.HasOne(d => d.IdBookNavigation).WithMany(p => p.Players)
                .HasForeignKey(d => d.IdBook)
                .HasConstraintName("FK_PLAYER_BOOK");

            entity.HasOne(d => d.IdCurrencyNavigation).WithMany(p => p.Players)
                .HasForeignKey(d => d.IdCurrency)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYER_CURRENCY");

            entity.HasOne(d => d.IdGroupingNavigation).WithMany(p => p.Players)
                .HasForeignKey(d => d.IdGrouping)
                .HasConstraintName("FK_PLAYER_GROUPING");

            entity.HasOne(d => d.IdLanguageNavigation).WithMany(p => p.Players)
                .HasForeignKey(d => d.IdLanguage)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYER_Language");

            entity.HasOne(d => d.IdLineTypeNavigation).WithMany(p => p.Players)
                .HasForeignKey(d => d.IdLineType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYER_LINETYPE");

            entity.HasOne(d => d.IdOfficeNavigation).WithMany(p => p.Players)
                .HasForeignKey(d => d.IdOffice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYER_OFFICE");

            entity.HasOne(d => d.IdProfileNavigation).WithMany(p => p.Players)
                .HasForeignKey(d => d.IdProfile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYER_PLAYERPROFILE");

            entity.HasOne(d => d.IdProfileLimitsNavigation).WithMany(p => p.Players)
                .HasForeignKey(d => d.IdProfileLimits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYER_PLAYERPROFILELIMITS");

            entity.HasOne(d => d.IdTimeZoneNavigation).WithMany(p => p.Players)
                .HasForeignKey(d => d.IdTimeZone)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYER_TIMEZONE");
        });

        modelBuilder.Entity<PlayerClaim>(entity =>
        {
            entity.HasKey(e => e.IdClaim).HasName("PK_CLAIMS");

            entity.Property(e => e.Comments)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.Placed).HasColumnType("datetime");
            entity.Property(e => e.Results)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TapeTime).HasColumnType("datetime");

            entity.HasOne(d => d.IdPlayerNavigation).WithMany(p => p.PlayerClaims)
                .HasForeignKey(d => d.IdPlayer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CLAIMS_PLAYER");
        });

        modelBuilder.Entity<PlayerRule>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Exacta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("exacta");
            entity.Property(e => e.Idplayer).HasColumnName("idplayer");
            entity.Property(e => e.Trifecta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("trifecta");
            entity.Property(e => e.Win)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("win");
        });

        modelBuilder.Entity<Playeraccounting>(entity =>
        {
            entity.HasKey(e => e.IdPlayerAccounting);

            entity.ToTable("PLAYERACCOUNTING");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.MoneyChange).HasColumnType("money");
            entity.Property(e => e.TaxAmount).HasColumnType("money");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdPlayerNavigation).WithMany(p => p.Playeraccountings)
                .HasForeignKey(d => d.IdPlayer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYERACCOUNTING_PLAYER");
        });

        modelBuilder.Entity<Playeragentlog>(entity =>
        {
            entity.HasKey(e => e.IdPlayerAgentLog);

            entity.ToTable("PLAYERAGENTLOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.NewValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Playerblackbook>(entity =>
        {
            entity.HasKey(e => e.IdPlayer);

            entity.ToTable("PLAYERBLACKBOOK");

            entity.Property(e => e.IdPlayer).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.SettleDate).HasColumnType("datetime");

            entity.HasOne(d => d.IdPlayerNavigation).WithOne(p => p.Playerblackbook)
                .HasForeignKey<Playerblackbook>(d => d.IdPlayer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYERBLACKBOOK_PLAYER");
        });

        modelBuilder.Entity<Playerbonustransaction>(entity =>
        {
            entity.HasKey(e => e.IdPlayerBonusTransactions).HasName("PK_BONUSTRANSACTIONS");

            entity.ToTable("PLAYERBONUSTRANSACTIONS");

            entity.Property(e => e.BonusDate).HasColumnType("datetime");
            entity.Property(e => e.BonusPoints).HasColumnType("money");
            entity.Property(e => e.CurrBalance).HasColumnType("money");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.PrevBalance).HasColumnType("money");

            entity.HasOne(d => d.IdPlayerNavigation).WithMany(p => p.Playerbonustransactions)
                .HasForeignKey(d => d.IdPlayer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BONUSTRANSACTIONS_PLAYER");
        });

        modelBuilder.Entity<Playercallslog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PLAYERCALLSLOG");

            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IP");
            entity.Property(e => e.StartTime).HasColumnType("datetime");
            entity.Property(e => e.System)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Url)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<Playerdeleted>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PLAYERDELETED");

            entity.Property(e => e.AccountOpened).HasColumnType("datetime");
            entity.Property(e => e.CreditLimit).HasColumnType("money");
            entity.Property(e => e.LastCall).HasColumnType("datetime");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.LastName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LastName2)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LastWager).HasColumnType("datetime");
            entity.Property(e => e.LastWeekCasino).HasColumnType("money");
            entity.Property(e => e.LastWeekHorses).HasColumnType("money");
            entity.Property(e => e.LastWeekSports).HasColumnType("money");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Player)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ThisWeekCasino).HasColumnType("money");
            entity.Property(e => e.ThisWeekHorses).HasColumnType("money");
            entity.Property(e => e.ThisWeekSports).HasColumnType("money");
        });

        modelBuilder.Entity<Playerfw>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PLAYERFW");

            entity.Property(e => e.Account)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT");
        });

        modelBuilder.Entity<Playerholdsetting>(entity =>
        {
            entity.HasKey(e => new { e.Idplayer, e.WagerType });

            entity.ToTable("PLAYERHOLDSETTINGS");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdplayerNavigation).WithMany(p => p.Playerholdsettings)
                .HasForeignKey(d => d.Idplayer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYERHOLDSETTINGS_PLAYER");
        });

        modelBuilder.Entity<Playerid>(entity =>
        {
            entity.HasKey(e => e.IdPlayerId);

            entity.ToTable("PLAYERID");

            entity.Property(e => e.PreName)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Playerlog>(entity =>
        {
            entity.HasKey(e => e.IdPlayerLog);

            entity.ToTable("PLAYERLOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.NewValue)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
            entity.Property(e => e.Player)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Playerlogon>(entity =>
        {
            entity.HasKey(e => new { e.IdPlayer, e.PlacedDate });

            entity.ToTable("PLAYERLOGONS");

            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IP");
            entity.Property(e => e.System)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdPlayerNavigation).WithMany(p => p.Playerlogons)
                .HasForeignKey(d => d.IdPlayer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYERLOGONS_PLAYER");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Playerlogons)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYERLOGONS_USER");
        });

        modelBuilder.Entity<Playermessage>(entity =>
        {
            entity.HasKey(e => e.IdPlayerMessage);

            entity.ToTable("PLAYERMESSAGES");

            entity.Property(e => e.ExpirationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastModification)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastModificationUser).HasDefaultValueSql("((1))");
            entity.Property(e => e.Message)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.IdPlayerNavigation).WithMany(p => p.Playermessages)
                .HasForeignKey(d => d.IdPlayer)
                .HasConstraintName("FK_PLAYERMESSAGES_PLAYER");
        });

        modelBuilder.Entity<Playernote>(entity =>
        {
            entity.HasKey(e => e.IdPlayer);

            entity.ToTable("PLAYERNOTES");

            entity.Property(e => e.IdPlayer).ValueGeneratedNever();
            entity.Property(e => e.Notes0)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Notes1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Notes2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Notes3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Notes4)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Notes5)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Notes6)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.IdPlayerNavigation).WithOne(p => p.Playernote)
                .HasForeignKey<Playernote>(d => d.IdPlayer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYERNOTES_PLAYER");
        });

        modelBuilder.Entity<Playerprofile>(entity =>
        {
            entity.HasKey(e => e.IdProfile);

            entity.ToTable("PLAYERPROFILE");

            entity.HasIndex(e => e.ProfileName, "IX_PLAYERPROFILEName").IsUnique();

            entity.Property(e => e.ClmaxWager)
                .HasColumnType("money")
                .HasColumnName("CLMaxWager");
            entity.Property(e => e.DuplicateBetsCheckIfSbrev).HasColumnName("DuplicateBetsCheckIfSBRev");
            entity.Property(e => e.DuplicateBetsCheckParlays).HasComment("");
            entity.Property(e => e.DuplicateBetsCheckParlaysSb).HasColumnName("DuplicateBetsCheckParlaysSB");
            entity.Property(e => e.DuplicateBetsCheckTeasersSb).HasColumnName("DuplicateBetsCheckTeasersSB");
            entity.Property(e => e.FpallowBothSides).HasColumnName("FPAllowBothSides");
            entity.Property(e => e.FpallowDuplicatedBets).HasColumnName("FPAllowDuplicatedBets");
            entity.Property(e => e.FpcheckOfficeFilters).HasColumnName("FPCheckOfficeFilters");
            entity.Property(e => e.FpmaxFav).HasColumnName("FPMaxFav");
            entity.Property(e => e.FpmaxPayout)
                .HasColumnType("money")
                .HasColumnName("FPMaxPayout");
            entity.Property(e => e.FpmaxTeams).HasColumnName("FPMaxTeams");
            entity.Property(e => e.FpoddsLimit)
                .HasDefaultValueSql("((-110))")
                .HasColumnName("FPOddsLimit");
            entity.Property(e => e.IlAllowChildHigher).HasColumnName("IL_AllowChildHigher");
            entity.Property(e => e.IlAskAmount).HasColumnName("IL_AskAmount");
            entity.Property(e => e.IlMaxLevelParlays).HasColumnName("IL_MaxLevelParlays");
            entity.Property(e => e.IlMaxLevelTeasers).HasColumnName("IL_MaxLevelTeasers");
            entity.Property(e => e.IlMaxNumberSb).HasColumnName("IL_MaxNumberSB");
            entity.Property(e => e.IlMaxParlays).HasColumnName("IL_MaxParlays");
            entity.Property(e => e.IlMaxTeasers).HasColumnName("IL_MaxTeasers");
            entity.Property(e => e.Iloddslimit)
                .HasDefaultValueSql("((100000))")
                .HasColumnName("ILOddslimit");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PcPitcherChangeType).HasColumnName("PC_PitcherChangeType");
            entity.Property(e => e.PcSkipRunLine).HasColumnName("PC_SkipRunLine");
            entity.Property(e => e.PcSkipSide).HasColumnName("PC_SkipSide");
            entity.Property(e => e.PcSkipTotal).HasColumnName("PC_SkipTotal");
            entity.Property(e => e.PlAllowGolf).HasColumnName("PL_AllowGolf");
            entity.Property(e => e.PlAllowMatchUps).HasColumnName("PL_AllowMatchUps");
            entity.Property(e => e.PlAllowOpenPlays).HasColumnName("PL_AllowOpenPlays");
            entity.Property(e => e.PlAllowProps).HasColumnName("PL_AllowProps");
            entity.Property(e => e.PlAllowRunLineTotal).HasColumnName("PL_AllowRunLineTotal");
            entity.Property(e => e.PlAllowSpreadTotalHk).HasColumnName("PL_AllowSpreadTotalHK");
            entity.Property(e => e.PlAllowSpreadTotalSoc).HasColumnName("PL_AllowSpreadTotalSOC");
            entity.Property(e => e.PlAlwaysAction).HasColumnName("PL_AlwaysAction");
            entity.Property(e => e.PlJuice2TeamParlay).HasColumnName("PL_Juice2TeamParlay");
            entity.Property(e => e.PlLowerUseDefault).HasColumnName("PL_LowerUseDefault");
            entity.Property(e => e.PlMaxBuyPoints).HasColumnName("PL_MaxBuyPoints");
            entity.Property(e => e.PlMaxDogsMoney).HasColumnName("PL_MaxDogsMoney");
            entity.Property(e => e.PlMaxDogsSide).HasColumnName("PL_MaxDogsSide");
            entity.Property(e => e.PlMaxDogsTotal).HasColumnName("PL_MaxDogsTotal");
            entity.Property(e => e.PlMaxGames).HasColumnName("PL_MaxGames");
            entity.Property(e => e.PlMaxOdds).HasColumnName("PL_MaxOdds");
            entity.Property(e => e.PlMaxPayout)
                .HasColumnType("money")
                .HasColumnName("PL_MaxPayout");
            entity.Property(e => e.PlMaxSumOdds).HasColumnName("PL_MaxSumOdds");
            entity.Property(e => e.PlMaxTeamBuyPoints).HasColumnName("PL_MaxTeamBuyPoints");
            entity.Property(e => e.PlNoListedPitchers).HasColumnName("PL_NoListedPitchers");
            entity.Property(e => e.PlOddsDefault).HasColumnName("PL_OddsDefault");
            entity.Property(e => e.PlParlayFormula).HasColumnName("PL_ParlayFormula");
            entity.Property(e => e.PlTieLoses).HasColumnName("PL_TieLoses");
            entity.Property(e => e.PlTrueOddsOption).HasColumnName("PL_TrueOddsOption");
            entity.Property(e => e.PlUseMaxSumOdds).HasColumnName("PL_UseMaxSumOdds");
            entity.Property(e => e.ProfileName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RevAllowOpen).HasColumnName("Rev_AllowOpen");
            entity.Property(e => e.SgCancelRunLine).HasColumnName("SG_CancelRunLine");
            entity.Property(e => e.SgCancelSide).HasColumnName("SG_CancelSide");
            entity.Property(e => e.SgCancelTotal).HasColumnName("SG_CancelTotal");
            entity.Property(e => e.SlAlwaysActionMlbtotals).HasColumnName("SL_AlwaysActionMLBTotals");
            entity.Property(e => e.SlIfBets).HasColumnName("SL_IfBets");
            entity.Property(e => e.SocHookups).HasColumnName("Soc_Hookups");
            entity.Property(e => e.TlOpenLose).HasColumnName("TL_OpenLose");
            entity.Property(e => e.TlTeaserCancel).HasColumnName("TL_TeaserCancel");
        });

        modelBuilder.Entity<Playerprofilecustomteaser>(entity =>
        {
            entity.HasKey(e => new { e.IdProfile, e.IdWagerType });

            entity.ToTable("PLAYERPROFILECUSTOMTEASER");

            entity.Property(e => e.Cbbside).HasColumnName("CBBSide");
            entity.Property(e => e.Cbbtotal).HasColumnName("CBBTotal");
            entity.Property(e => e.Cfbside).HasColumnName("CFBSide");
            entity.Property(e => e.Cfbtotal).HasColumnName("CFBTotal");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.MaxRisk).HasColumnType("money");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nbaside).HasColumnName("NBASide");
            entity.Property(e => e.Nbatotal).HasColumnName("NBATotal");
            entity.Property(e => e.Nflside).HasColumnName("NFLSide");
            entity.Property(e => e.Nfltotal).HasColumnName("NFLTotal");
            entity.Property(e => e.Tie)
                .HasMaxLength(130)
                .IsUnicode(false);

            entity.HasOne(d => d.IdProfileNavigation).WithMany(p => p.Playerprofilecustomteasers)
                .HasForeignKey(d => d.IdProfile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYERPROFILECUSTOMTEASER_PLAYERPROFILE");

            entity.HasOne(d => d.IdWagerTypeNavigation).WithMany(p => p.Playerprofilecustomteasers)
                .HasForeignKey(d => d.IdWagerType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYERPROFILECUSTOMTEASER_WAGERTYPE");
        });

        modelBuilder.Entity<Playerprofilecustomteaserlog>(entity =>
        {
            entity.HasKey(e => e.IdPlayerProfileCustomTeaserLog);

            entity.ToTable("PLAYERPROFILECUSTOMTEASERLOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.NewValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Playerprofilegametype>(entity =>
        {
            entity.HasKey(e => new { e.IdProfile, e.IdGameType });

            entity.ToTable("PLAYERPROFILEGAMETYPE");

            entity.Property(e => e.AllowOff3cfb).HasColumnName("AllowOFF3CFB");
            entity.Property(e => e.AllowOff3nfl).HasColumnName("AllowOFF3NFL");
            entity.Property(e => e.AllowOff7cfb).HasColumnName("AllowOFF7CFB");
            entity.Property(e => e.AllowOff7nfl).HasColumnName("AllowOFF7NFL");
            entity.Property(e => e.AllowOn3cfb).HasColumnName("AllowON3CFB");
            entity.Property(e => e.AllowOn3nfl).HasColumnName("AllowON3NFL");
            entity.Property(e => e.AllowOn7cfb).HasColumnName("AllowON7CFB");
            entity.Property(e => e.AllowOn7nfl).HasColumnName("AllowON7NFL");
            entity.Property(e => e.IlCheckSameTeam).HasColumnName("IL_CheckSameTeam");
            entity.Property(e => e.IlMaxSameTeam).HasColumnName("IL_MaxSameTeam");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.PlCheckMlnSpread).HasColumnName("PL_CheckMLnSpread");
            entity.Property(e => e.PlCheckSameTeam).HasColumnName("PL_CheckSameTeam");
            entity.Property(e => e.PlCheckTonTu).HasColumnName("PL_CheckTOnTU");
            entity.Property(e => e.PlMaxSameTeam).HasColumnName("PL_MaxSameTeam");
            entity.Property(e => e.PlUseWideLine).HasColumnName("PL_UseWideLine");
            entity.Property(e => e.RlCheckMlnSpread).HasColumnName("RL_CheckMLnSpread");
            entity.Property(e => e.RlCheckTonTu).HasColumnName("RL_CheckTOnTU");
            entity.Property(e => e.SlCheckMlnSpread).HasColumnName("SL_CheckMLnSpread");
            entity.Property(e => e.TlCheckSameTeam).HasColumnName("TL_CheckSameTeam");
            entity.Property(e => e.TlCheckTonTu).HasColumnName("TL_CheckTOnTU");
            entity.Property(e => e.TlMaxSameTeam).HasColumnName("TL_MaxSameTeam");
            entity.Property(e => e.UseWideLine)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.HasOne(d => d.IdGameTypeNavigation).WithMany(p => p.Playerprofilegametypes)
                .HasForeignKey(d => d.IdGameType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYERPROFILEGAMETYPE_GAMETYPE");

            entity.HasOne(d => d.IdProfileNavigation).WithMany(p => p.Playerprofilegametypes)
                .HasForeignKey(d => d.IdProfile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYERPROFILEGAMETYPE_PLAYERPROFILE");
        });

        modelBuilder.Entity<Playerprofilegametypelog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PLAYERPROFILEGAMETYPELOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdPlayerProfileGameTypeLog).ValueGeneratedOnAdd();
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.NewValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Playerprofilegametypesport>(entity =>
        {
            entity.HasKey(e => new { e.IdProfile, e.IdGameType, e.IdSport, e.WagerType });

            entity.ToTable("PLAYERPROFILEGAMETYPESPORT");

            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WagerType).HasDefaultValueSql("((1))");
            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdGameTypeNavigation).WithMany(p => p.Playerprofilegametypesports)
                .HasForeignKey(d => d.IdGameType)
                .HasConstraintName("FK_PLAYERPROFILEGAMETYPESPORT_GAMETYPE");

            entity.HasOne(d => d.IdProfileNavigation).WithMany(p => p.Playerprofilegametypesports)
                .HasForeignKey(d => d.IdProfile)
                .HasConstraintName("FK_PLAYERPROFILEGAMETYPESPORT_PLAYERPROFILE");

            entity.HasOne(d => d.IdSportNavigation).WithMany(p => p.Playerprofilegametypesports)
                .HasForeignKey(d => d.IdSport)
                .HasConstraintName("FK_PLAYERPROFILEGAMETYPESPORT_SPORT");
        });

        modelBuilder.Entity<Playerprofilegametypesportlog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PLAYERPROFILEGAMETYPESPORTLOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.NewValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
            entity.Property(e => e.WagerType).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<Playerprofilelimit>(entity =>
        {
            entity.HasKey(e => e.IdProfileLimits);

            entity.ToTable("PLAYERPROFILELIMITS");

            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ProfileName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Playerprofilelimitsdetail>(entity =>
        {
            entity.HasKey(e => new { e.IdProfileLimits, e.Online, e.IdGameType, e.IdSport });

            entity.ToTable("PLAYERPROFILELIMITSDETAILS");

            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IfBets).HasColumnType("money");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.MoneyLine).HasColumnType("money");
            entity.Property(e => e.Parlays).HasColumnType("money");
            entity.Property(e => e.Related).HasColumnType("money");
            entity.Property(e => e.Reverses).HasColumnType("money");
            entity.Property(e => e.Side).HasColumnType("money");
            entity.Property(e => e.Teasers).HasColumnType("money");
            entity.Property(e => e.Total).HasColumnType("money");

            entity.HasOne(d => d.IdGameTypeNavigation).WithMany(p => p.Playerprofilelimitsdetails)
                .HasForeignKey(d => d.IdGameType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYERPROFILELIMITSDETAILS_GAMETYPE");

            entity.HasOne(d => d.IdProfileLimitsNavigation).WithMany(p => p.Playerprofilelimitsdetails)
                .HasForeignKey(d => d.IdProfileLimits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYERPROFILELIMITSDETAILS_PLAYERPROFILELIMITS");

            entity.HasOne(d => d.IdSportNavigation).WithMany(p => p.Playerprofilelimitsdetails)
                .HasForeignKey(d => d.IdSport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYERPROFILELIMITSDETAILS_SPORT");
        });

        modelBuilder.Entity<Playerprofilelimitsdetailslog>(entity =>
        {
            entity.HasKey(e => e.IdPlayerProfileLimitsLog);

            entity.ToTable("PLAYERPROFILELIMITSDETAILSLOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.NewValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Playerprofilelimitslog>(entity =>
        {
            entity.HasKey(e => e.IdProfileLimitsLog);

            entity.ToTable("PLAYERPROFILELIMITSLOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.NewValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Playerprofilelog>(entity =>
        {
            entity.HasKey(e => e.IdPlayerProfileLog);

            entity.ToTable("PLAYERPROFILELOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.NewValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Playerprofileparlaybasicsport>(entity =>
        {
            entity.HasKey(e => new { e.IdProfile, e.IdSport });

            entity.ToTable("PLAYERPROFILEPARLAYBASICSPORTS");

            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdProfileNavigation).WithMany(p => p.Playerprofileparlaybasicsports)
                .HasForeignKey(d => d.IdProfile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYERPROFILEPARLAYBASICSPORTS_PLAYERPROFILE");

            entity.HasOne(d => d.IdSportNavigation).WithMany(p => p.Playerprofileparlaybasicsports)
                .HasForeignKey(d => d.IdSport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYERPROFILEPARLAYBASICSPORTS_SPORT");
        });

        modelBuilder.Entity<Playerprofileparlaybasicsportslog>(entity =>
        {
            entity.HasKey(e => e.IdLog);

            entity.ToTable("PLAYERPROFILEPARLAYBASICSPORTSLOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Idsport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idsport");
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.Newvalue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Placeddate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Playerprofileparlaylimit>(entity =>
        {
            entity.HasKey(e => new { e.IdProfile, e.NumTeams });

            entity.ToTable("PLAYERPROFILEPARLAYLIMIT");

            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.MaxPayout).HasColumnType("numeric(19, 4)");
            entity.Property(e => e.MaxRisk).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Odds).HasColumnType("numeric(10, 3)");

            entity.HasOne(d => d.IdProfileNavigation).WithMany(p => p.Playerprofileparlaylimits)
                .HasForeignKey(d => d.IdProfile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYERPROFILEPARLAYLIMIT_PLAYERPROFILE");

            entity.HasOne(d => d.IdWagerTypeNavigation).WithMany(p => p.Playerprofileparlaylimits)
                .HasForeignKey(d => d.IdWagerType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYERPROFILEPARLAYLIMIT_WAGERTYPE");
        });

        modelBuilder.Entity<Playerprofileparlaylimitdetail>(entity =>
        {
            entity.HasKey(e => new { e.IdProfile, e.IdSport, e.NumTeams });

            entity.ToTable("PLAYERPROFILEPARLAYLIMITDETAIL");

            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdSportNavigation).WithMany(p => p.Playerprofileparlaylimitdetails)
                .HasForeignKey(d => d.IdSport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYERPROFILEPARLAYLIMITDETAIL_SPORT");
        });

        modelBuilder.Entity<Playerprofileparlaylimitdetaillog>(entity =>
        {
            entity.HasKey(e => e.IdLog);

            entity.ToTable("PLAYERPROFILEPARLAYLIMITDETAILLOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.NewValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Playerprofileparlaylimitlog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PLAYERPROFILEPARLAYLIMITLOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdPlayerProfileParlayLimitLog).ValueGeneratedOnAdd();
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.NewValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Playerprofilestraightlimit>(entity =>
        {
            entity.HasKey(e => new { e.IdProfile, e.IdSport }).HasName("PK_PLAYERPROFILESTRAIGTHLIMIT");

            entity.ToTable("PLAYERPROFILESTRAIGHTLIMIT");

            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.SurchargeTwice3pts).HasColumnName("SurchargeTwice_3pts");
            entity.Property(e => e.SurchargeTwice7pts).HasColumnName("SurchargeTwice_7pts");

            entity.HasOne(d => d.IdProfileNavigation).WithMany(p => p.Playerprofilestraightlimits)
                .HasForeignKey(d => d.IdProfile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYERPROFILESTRAIGTHLIMIT_PLAYERPROFILE");

            entity.HasOne(d => d.IdSportNavigation).WithMany(p => p.Playerprofilestraightlimits)
                .HasForeignKey(d => d.IdSport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYERPROFILESTRAIGTHLIMIT_SPORT");
        });

        modelBuilder.Entity<Playerprofilestraightlimitlog>(entity =>
        {
            entity.HasKey(e => e.IdPlayerProfileStraightLimitsLog);

            entity.ToTable("PLAYERPROFILESTRAIGHTLIMITLOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.NewValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Playerrate>(entity =>
        {
            entity.HasKey(e => e.IdPlayerRate);

            entity.ToTable("PLAYERRATE");

            entity.HasIndex(e => e.Description, "IX_PLAYERRATE_DESCRIPTION").IsUnique();

            entity.Property(e => e.Description)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
        });

        modelBuilder.Entity<Playerstatistic>(entity =>
        {
            entity.HasKey(e => e.IdPlayer);

            entity.ToTable("PLAYERSTATISTIC");

            entity.Property(e => e.IdPlayer).ValueGeneratedNever();
            entity.Property(e => e.AccountOpened).HasColumnType("datetime");
            entity.Property(e => e.AmountAtRisk).HasColumnType("money");
            entity.Property(e => e.AvailBalance).HasColumnType("money");
            entity.Property(e => e.BonusPoints).HasColumnType("money");
            entity.Property(e => e.CurrentBalance).HasColumnType("money");
            entity.Property(e => e.LastCall).HasColumnType("datetime");
            entity.Property(e => e.LastGrade).HasColumnType("datetime");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.LastWager).HasColumnType("datetime");
            entity.Property(e => e.LastWeekCasino).HasColumnType("money");
            entity.Property(e => e.LastWeekHorses).HasColumnType("money");
            entity.Property(e => e.LastWeekSports).HasColumnType("money");
            entity.Property(e => e.LifeTimeBonus)
                .HasComment("All bonus added in PlayerTransactions")
                .HasColumnType("money");
            entity.Property(e => e.LifeTimeFees)
                .HasComment("All fees added in PlayerTransactions")
                .HasColumnType("money");
            entity.Property(e => e.LifeTimeFreePlays)
                .HasComment("All freeplays assigned to the account since it was oppened")
                .HasColumnType("money");
            entity.Property(e => e.LifeTimeLose).HasColumnType("money");
            entity.Property(e => e.LifeTimeNetCasino).HasColumnType("money");
            entity.Property(e => e.LifeTimeNetHorses).HasColumnType("money");
            entity.Property(e => e.LifeTimeWin).HasColumnType("money");
            entity.Property(e => e.ThisWeekCasino).HasColumnType("money");
            entity.Property(e => e.ThisWeekHorses).HasColumnType("money");
            entity.Property(e => e.ThisWeekSports).HasColumnType("money");
            entity.Property(e => e.Ytdlose)
                .HasColumnType("money")
                .HasColumnName("YTDLose");
            entity.Property(e => e.Ytdwin)
                .HasColumnType("money")
                .HasColumnName("YTDWin");

            entity.HasOne(d => d.IdPlayerNavigation).WithOne(p => p.Playerstatistic)
                .HasForeignKey<Playerstatistic>(d => d.IdPlayer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYERSTATISTIC_PLAYER");
        });

        modelBuilder.Entity<Playertransaction>(entity =>
        {
            entity.HasKey(e => e.IdTransaction);

            entity.ToTable("PLAYERTRANSACTION");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Bonus).HasColumnType("money");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Fee).HasColumnType("money");
            entity.Property(e => e.IdPaymentMethod).HasDefaultValueSql("((1))");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransactionType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdAdjustmentTypeNavigation).WithMany(p => p.Playertransactions)
                .HasForeignKey(d => d.IdAdjustmentType)
                .HasConstraintName("FK_PLAYERTRANSACTION_ADJUSTMENTTYPE");

            entity.HasOne(d => d.IdPaymentMethodNavigation).WithMany(p => p.Playertransactions)
                .HasForeignKey(d => d.IdPaymentMethod)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYERTRANSACTION_PAYMENTMETHOD");

            entity.HasOne(d => d.IdPlayerNavigation).WithMany(p => p.Playertransactions)
                .HasForeignKey(d => d.IdPlayer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAYERTRANSACTION_PLAYER");
        });

        modelBuilder.Entity<Playerweeklybalance>(entity =>
        {
            entity.HasKey(e => new { e.IdPlayer, e.Week }).HasName("PK_WEEKLYBALANCE");

            entity.ToTable("PLAYERWEEKLYBALANCE");

            entity.Property(e => e.Week).HasColumnType("datetime");
            entity.Property(e => e.Balance).HasColumnType("money");
            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdPlayerNavigation).WithMany(p => p.Playerweeklybalances)
                .HasForeignKey(d => d.IdPlayer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WEEKLYBALANCE_PLAYER");
        });

        modelBuilder.Entity<PoolPayout>(entity =>
        {
            entity.HasKey(e => new { e.RaceId, e.PoolType, e.Entries, e.NumCorrect });

            entity.ToTable("PoolPayout");

            entity.Property(e => e.RaceId).HasColumnName("RaceID");
            entity.Property(e => e.Entries)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Payoff).HasColumnType("money");

            entity.HasOne(d => d.Race).WithMany(p => p.PoolPayouts)
                .HasForeignKey(d => d.RaceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PoolPayout_Race");
        });

        modelBuilder.Entity<ProfileTrack>(entity =>
        {
            entity.HasKey(e => e.ProfileId);

            entity.ToTable("ProfileTrack");

            entity.Property(e => e.ProfileId)
                .ValueGeneratedNever()
                .HasColumnName("ProfileID");
            entity.Property(e => e.ProfileName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProfileTrackEnable>(entity =>
        {
            entity.HasKey(e => new { e.ProfileId, e.Uitype, e.TrackId });

            entity.ToTable("ProfileTrackEnable");

            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.Uitype).HasColumnName("UIType");
            entity.Property(e => e.TrackId).HasColumnName("TrackID");

            entity.HasOne(d => d.Profile).WithMany(p => p.ProfileTrackEnables)
                .HasForeignKey(d => d.ProfileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProfileTrackEnable_ProfileTrack");

            entity.HasOne(d => d.Track).WithMany(p => p.ProfileTrackEnables)
                .HasForeignKey(d => d.TrackId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProfileTrackEnable_Track");
        });

        modelBuilder.Entity<PropDstSpVersion>(entity =>
        {
            entity.HasKey(e => e.ProcName);

            entity.ToTable("Prop_DST_SP_Versions");

            entity.Property(e => e.ProcName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ProcVersion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Updated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Race>(entity =>
        {
            entity.ToTable("Race");

            entity.Property(e => e.RaceId).HasColumnName("RaceID");
            entity.Property(e => e.ActualCloseMethod).HasDefaultValueSql("((0))");
            entity.Property(e => e.Class)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Distance)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Exacta)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Mtp).HasColumnName("MTP");
            entity.Property(e => e.OffTime).HasColumnType("datetime");
            entity.Property(e => e.Pk31).HasColumnName("PK3_1");
            entity.Property(e => e.Pk33).HasColumnName("PK3_3");
            entity.Property(e => e.Pk41).HasColumnName("PK4_1");
            entity.Property(e => e.Pk44).HasColumnName("PK4_4");
            entity.Property(e => e.Pk61).HasColumnName("PK6_1");
            entity.Property(e => e.Pk66).HasColumnName("PK6_6");
            entity.Property(e => e.Place)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.PostCutoff).HasDefaultValueSql("((-1))");
            entity.Property(e => e.PostTime).HasColumnType("datetime");
            entity.Property(e => e.Purse).HasColumnType("money");
            entity.Property(e => e.Quinella)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.RaceDate).HasColumnType("datetime");
            entity.Property(e => e.RaceDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RaceDescription)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.RaceShortDesc)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RaceStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Show)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Surface)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SystemOffDateTime).HasColumnType("datetime");
            entity.Property(e => e.SystemRaceDateTime).HasColumnType("datetime");
            entity.Property(e => e.TrackCond)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TrackId).HasColumnName("TrackID");
            entity.Property(e => e.Trifecta)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Win)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Track).WithMany(p => p.Races)
                .HasForeignKey(d => d.TrackId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Race_Track");
        });

        modelBuilder.Entity<RaceChart>(entity =>
        {
            entity.HasKey(e => new { e.RaceId, e.BetType, e.Selections });

            entity.ToTable("RaceChart");

            entity.Property(e => e.RaceId).HasColumnName("RaceID");
            entity.Property(e => e.Selections)
                .HasMaxLength(17)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("money");
        });

        modelBuilder.Entity<RaceChartQueue>(entity =>
        {
            entity.HasKey(e => new { e.TicketId, e.Unchart });

            entity.ToTable("RaceChartQueue");

            entity.Property(e => e.TicketId).HasColumnName("TicketID");
        });

        modelBuilder.Entity<RaceControl>(entity =>
        {
            entity.HasKey(e => e.Pk);

            entity.ToTable("RaceControl");

            entity.Property(e => e.Pk).HasColumnName("PK");
            entity.Property(e => e.AmtoteAccount)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AmtoteGateway)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AmtotePin)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AmtotePIN");
            entity.Property(e => e.BetTickerServer)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MetaVer)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.EposTransferPaymentMethodNavigation).WithMany(p => p.RaceControls)
                .HasForeignKey(d => d.EposTransferPaymentMethod)
                .HasConstraintName("FK_RaceControl_PAYMENTMETHOD");
        });

        modelBuilder.Entity<RaceTicketBatchDetail>(entity =>
        {
            entity.HasKey(e => new { e.BatchId, e.TicketId });

            entity.ToTable("RaceTicketBatchDetail");

            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.TicketId).HasColumnName("TicketID");
            entity.Property(e => e.AccountId).HasColumnName("AccountID");
            entity.Property(e => e.RefundAmount).HasColumnType("money");
            entity.Property(e => e.SettleDate).HasColumnType("datetime");
            entity.Property(e => e.TotalStake).HasColumnType("money");
            entity.Property(e => e.WagerId).HasColumnName("WagerID");
            entity.Property(e => e.WinAmount).HasColumnType("money");

            entity.HasOne(d => d.Batch).WithMany(p => p.RaceTicketBatchDetails)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RaceTicketBatchDetail_RaceTicketBatchHeader");
        });

        modelBuilder.Entity<RaceTicketBatchHeader>(entity =>
        {
            entity.HasKey(e => e.BatchId);

            entity.ToTable("RaceTicketBatchHeader");

            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.BatchDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<RaceTicketDetail>(entity =>
        {
            entity.HasKey(e => e.TicketDetailId);

            entity.ToTable("RaceTicketDetail");

            entity.Property(e => e.TicketDetailId).HasColumnName("TicketDetailID");
            entity.Property(e => e.RaceId).HasColumnName("RaceID");
            entity.Property(e => e.TicketId).HasColumnName("TicketID");

            entity.HasOne(d => d.Race).WithMany(p => p.RaceTicketDetails)
                .HasForeignKey(d => d.RaceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RaceTicketDetail_Race");

            entity.HasOne(d => d.Ticket).WithMany(p => p.RaceTicketDetails)
                .HasForeignKey(d => d.TicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RaceTicketDetail_RaceTicketMain");
        });

        modelBuilder.Entity<RaceTicketMain>(entity =>
        {
            entity.HasKey(e => e.TicketId);

            entity.ToTable("RaceTicketMain");

            entity.Property(e => e.TicketId).HasColumnName("TicketID");
            entity.Property(e => e.AccountId).HasColumnName("AccountID");
            entity.Property(e => e.ActiveTillId).HasColumnName("ActiveTillID");
            entity.Property(e => e.CurrCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.ExchangeRate)
                .HasDefaultValueSql("((1))")
                .HasColumnType("money");
            entity.Property(e => e.HostWagerId).HasColumnName("HostWagerID");
            entity.Property(e => e.MachineName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MinOddsStake).HasColumnType("money");
            entity.Property(e => e.MinOddsStakeP).HasColumnType("money");
            entity.Property(e => e.MinOddsStakeS).HasColumnType("money");
            entity.Property(e => e.PlacedDateTime).HasColumnType("datetime");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.RactiveTillId).HasColumnName("RActiveTillID");
            entity.Property(e => e.RebateAmount).HasColumnType("money");
            entity.Property(e => e.RebatePaidDate).HasColumnType("datetime");
            entity.Property(e => e.Redeemed).HasColumnType("smalldatetime");
            entity.Property(e => e.RefundAmount).HasColumnType("money");
            entity.Property(e => e.Selections)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SettleDate).HasColumnType("smalldatetime");
            entity.Property(e => e.TheoWinAmount).HasColumnType("money");
            entity.Property(e => e.TicketDesc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalStake).HasColumnType("money");
            entity.Property(e => e.ToteTicketNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TrackId).HasColumnName("TrackID");
            entity.Property(e => e.Uitype).HasColumnName("UIType");
            entity.Property(e => e.UnitStake).HasColumnType("money");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WinPaid).HasColumnType("money");

            entity.HasOne(d => d.Account).WithMany(p => p.RaceTicketMains)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RaceTicketMain_Account");

            entity.HasOne(d => d.Profile).WithMany(p => p.RaceTicketMains)
                .HasForeignKey(d => d.ProfileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RaceTicketMain_ProfileTrack");
        });

        modelBuilder.Entity<RaceTicketType>(entity =>
        {
            entity.HasKey(e => e.TicketType);

            entity.ToTable("RaceTicketType");

            entity.Property(e => e.BaseShortDesc)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.LongDesc)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ShortDesc)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RebateDetail>(entity =>
        {
            entity.HasKey(e => new { e.RebateId, e.BetType, e.Uitype });

            entity.ToTable("RebateDetail");

            entity.Property(e => e.RebateId).HasColumnName("RebateID");
            entity.Property(e => e.Uitype).HasColumnName("UIType");
            entity.Property(e => e.Rebate).HasColumnType("money");
            entity.Property(e => e.Volume).HasColumnType("money");
            entity.Property(e => e.VolumeRebate).HasColumnType("money");
            entity.Property(e => e.WinLoss).HasColumnType("money");

            entity.HasOne(d => d.RebateNavigation).WithMany(p => p.RebateDetails)
                .HasForeignKey(d => d.RebateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RebateDetail_RebateHeader");
        });

        modelBuilder.Entity<RebateHeader>(entity =>
        {
            entity.HasKey(e => e.RebateId).HasName("PK__RebateHe__493C1B4C9BA5424A");

            entity.ToTable("RebateHeader");

            entity.Property(e => e.RebateId).HasColumnName("RebateID");
            entity.Property(e => e.AccountId).HasColumnName("AccountID");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.CutoffDate).HasColumnType("datetime");
            entity.Property(e => e.ExchangeRate).HasColumnType("money");
            entity.Property(e => e.RebateAmount).HasColumnType("money");
            entity.Property(e => e.RebatePaidDate).HasColumnType("datetime");

            entity.HasOne(d => d.Account).WithMany(p => p.RebateHeaders)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RebateHeader_Account");
        });

        modelBuilder.Entity<RefactorLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("__RefactorLog");
        });

        modelBuilder.Entity<RefillTill>(entity =>
        {
            entity.HasKey(e => e.RefillId);

            entity.ToTable("RefillTill");

            entity.Property(e => e.RefillId).HasColumnName("RefillID");
            entity.Property(e => e.CurrAmount).HasColumnType("money");
            entity.Property(e => e.CurrCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ExchangeRate).HasColumnType("money");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
            entity.Property(e => e.OpDate).HasColumnType("datetime");
            entity.Property(e => e.RefillDateTime).HasColumnType("datetime");
            entity.Property(e => e.TerminalId).HasColumnName("TerminalID");
        });

        modelBuilder.Entity<Right>(entity =>
        {
            entity.HasKey(e => e.IdRight).HasName("PK_RIGHT");

            entity.ToTable("RIGHTS");

            entity.Property(e => e.IdRight).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.System)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SmtoagentGameValueAdjustment>(entity =>
        {
            entity.HasKey(e => e.IdAdjustment);

            entity.ToTable("SMTOAgentGameValueAdjustments");

            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.IdAgentNavigation).WithMany(p => p.SmtoagentGameValueAdjustments)
                .HasForeignKey(d => d.IdAgent)
                .HasConstraintName("FK_SMTOAgentGameValueAdjustments_AGENT");

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.SmtoagentGameValueAdjustments)
                .HasForeignKey(d => d.IdGame)
                .HasConstraintName("FK_SMTOAgentGameValueAdjustments_GAME");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.SmtoagentGameValueAdjustments)
                .HasForeignKey(d => d.IdStatus)
                .HasConstraintName("FK_SMTOAgentGameValueAdjustments_SMTOStatus");
        });

        modelBuilder.Entity<Smtobook>(entity =>
        {
            entity.HasKey(e => e.IdBook);

            entity.ToTable("SMTOBook");

            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SmtoidBook).HasColumnName("SMTOIdBook");
        });

        modelBuilder.Entity<SmtocustomPeriod>(entity =>
        {
            entity.HasKey(e => e.IdPeriod);

            entity.ToTable("SMTOCustomPeriods");

            entity.Property(e => e.IdPeriod).ValueGeneratedOnAdd();
            entity.Property(e => e.Abbreviation)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Name).IsUnicode(false);
            entity.Property(e => e.Team)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdSportNavigation).WithMany(p => p.SmtocustomPeriods)
                .HasForeignKey(d => d.IdSport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMTOCustomPeriods_SPORT");
        });

        modelBuilder.Entity<SmtoeuropeanSport>(entity =>
        {
            entity.HasKey(e => e.IdEuropeanSport);

            entity.ToTable("SMTOEuropeanSports");

            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdSportNavigation).WithMany(p => p.SmtoeuropeanSports)
                .HasForeignKey(d => d.IdSport)
                .HasConstraintName("FK_SMTOEuropeanSports_SPORT");
        });

        modelBuilder.Entity<SmtoexcludedGame>(entity =>
        {
            entity.HasKey(e => e.IdExcludedGame).HasName("PK_SMTOExcludedGames_1");

            entity.ToTable("SMTOExcludedGames");

            entity.Property(e => e.ExcludeMoneylines)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.ExcludeSpreadOdds)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.ExcludeSpreads)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.ExcludeTotalOdds)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.ExcludeTotals)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.LineTypeIds).IsUnicode(false);

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.SmtoexcludedGames)
                .HasForeignKey(d => d.IdGame)
                .HasConstraintName("FK_SMTOExcludedGames_GAME");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.SmtoexcludedGames)
                .HasForeignKey(d => d.IdStatus)
                .HasConstraintName("FK_SMTOExcludedGames_SMTOStatus");
        });

        modelBuilder.Entity<SmtogameValueAdjustment>(entity =>
        {
            entity.HasKey(e => e.IdAdjustment);

            entity.ToTable("SMTOGameValueAdjustments");

            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.IsAutoDeleted)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.SmtogameValueAdjustments)
                .HasForeignKey(d => d.IdGame)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SMTOGameValueAdjustments_GAME");

            entity.HasOne(d => d.IdLeagueNavigation).WithMany(p => p.SmtogameValueAdjustments)
                .HasForeignKey(d => d.IdLeague)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SMTOGameValueAdjustments_LEAGUE");

            entity.HasOne(d => d.IdLineTypeNavigation).WithMany(p => p.SmtogameValueAdjustments)
                .HasForeignKey(d => d.IdLineType)
                .HasConstraintName("FK_SMTOGameValueAdjustments_LINETYPE");

            entity.HasOne(d => d.IdSportNavigation).WithMany(p => p.SmtogameValueAdjustments)
                .HasForeignKey(d => d.IdSport)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SMTOGameValueAdjustments_SPORT");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.SmtogameValueAdjustments)
                .HasForeignKey(d => d.IdStatus)
                .HasConstraintName("FK_SMTOGameValueAdjustments_SMTOStatus");
        });

        modelBuilder.Entity<SmtogameValueChangeReason>(entity =>
        {
            entity.HasKey(e => e.IdReason);

            entity.ToTable("SMTOGameValueChangeReasons");

            entity.Property(e => e.IdReason).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(256);
        });

        modelBuilder.Entity<Smtoleague>(entity =>
        {
            entity.ToTable("SMTOLeagues");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.GameTypeDescription)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.GameTypeInGameDescription)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.IdSmtosport).HasColumnName("IdSMTOSport");
            entity.Property(e => e.LeagueDescription)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LeagueInGameDescription)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Periods).IsUnicode(false);
            entity.Property(e => e.SmtosportName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SMTOSportName");

            entity.HasOne(d => d.IdGameTypeNavigation).WithMany(p => p.SmtoleagueIdGameTypeNavigations)
                .HasForeignKey(d => d.IdGameType)
                .HasConstraintName("FK_SMTOLeagues_GAMETYPE");

            entity.HasOne(d => d.IdGameTypeInGameNavigation).WithMany(p => p.SmtoleagueIdGameTypeInGameNavigations)
                .HasForeignKey(d => d.IdGameTypeInGame)
                .HasConstraintName("FK_SMTOLeagues_GAMETYPE1");

            entity.HasOne(d => d.IdLeagueNavigation).WithMany(p => p.SmtoleagueIdLeagueNavigations)
                .HasForeignKey(d => d.IdLeague)
                .HasConstraintName("FK_SMTOLeagues_LEAGUE");

            entity.HasOne(d => d.IdLeagueInGameNavigation).WithMany(p => p.SmtoleagueIdLeagueInGameNavigations)
                .HasForeignKey(d => d.IdLeagueInGame)
                .HasConstraintName("FK_SMTOLeagues_LEAGUE1");

            entity.HasOne(d => d.IdSmtosportNavigation).WithMany(p => p.Smtoleagues)
                .HasForeignKey(d => d.IdSmtosport)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SMTOLeagues_SMTOSports");
        });

        modelBuilder.Entity<SmtoleagueAdjustment>(entity =>
        {
            entity.HasKey(e => e.IdAdjustment);

            entity.ToTable("SMTOLeagueAdjustments");

            entity.Property(e => e.DogAdjustment).HasDefaultValueSql("((0))");
            entity.Property(e => e.FavoriteAdjustment).HasDefaultValueSql("((0))");
            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdStatus).HasDefaultValueSql("((1))");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RangeFrom).HasDefaultValueSql("((0))");
            entity.Property(e => e.RangeTo).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.IdLeagueNavigation).WithMany(p => p.SmtoleagueAdjustments)
                .HasForeignKey(d => d.IdLeague)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SMTOLeagueAdjustments_LEAGUE");

            entity.HasOne(d => d.IdLineTypeNavigation).WithMany(p => p.SmtoleagueAdjustments)
                .HasForeignKey(d => d.IdLineType)
                .HasConstraintName("FK_SMTOLeagueAdjustments_LINETYPE");

            entity.HasOne(d => d.IdSportNavigation).WithMany(p => p.SmtoleagueAdjustments)
                .HasForeignKey(d => d.IdSport)
                .HasConstraintName("FK_SMTOLeagueAdjustments_SPORT");
        });

        modelBuilder.Entity<Smtolimit>(entity =>
        {
            entity.HasKey(e => e.IdLimit);

            entity.ToTable("SMTOLimits");

            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");

            entity.HasOne(d => d.IdLeagueNavigation).WithMany(p => p.Smtolimits)
                .HasForeignKey(d => d.IdLeague)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SMTOLimits_LEAGUE");

            entity.HasOne(d => d.IdLineTypeNavigation).WithMany(p => p.Smtolimits)
                .HasForeignKey(d => d.IdLineType)
                .HasConstraintName("FK_SMTOLimits_LINETYPE");

            entity.HasOne(d => d.IdSportNavigation).WithMany(p => p.Smtolimits)
                .HasForeignKey(d => d.IdSport)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SMTOLimits_SPORT");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Smtolimits)
                .HasForeignKey(d => d.IdStatus)
                .HasConstraintName("FK_SMTOLimits_SMTOStatus");
        });

        modelBuilder.Entity<SmtolineTypeBookLink>(entity =>
        {
            entity.HasKey(e => e.IdLink);

            entity.ToTable("SMTOLineTypeBookLinks");

            entity.Property(e => e.ApplyOddsBySport)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SyncMoneylines)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.SyncSpreadOdds)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.SyncSpreads)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.SyncTotalOdds)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.SyncTotals)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.HasOne(d => d.IdBookNavigation).WithMany(p => p.SmtolineTypeBookLinks)
                .HasForeignKey(d => d.IdBook)
                .HasConstraintName("FK_SMTOLineTypesBooks_SMTOBook");

            entity.HasOne(d => d.IdLeagueNavigation).WithMany(p => p.SmtolineTypeBookLinks)
                .HasForeignKey(d => d.IdLeague)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SMTOLineTypesBooks_LEAGUE");

            entity.HasOne(d => d.IdLineTypeNavigation).WithMany(p => p.SmtolineTypeBookLinks)
                .HasForeignKey(d => d.IdLineType)
                .HasConstraintName("FK_SMTOLineTypesBooks_LINETYPE");

            entity.HasOne(d => d.IdSportNavigation).WithMany(p => p.SmtolineTypeBookLinks)
                .HasForeignKey(d => d.IdSport)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SMTOLineTypesBooks_SPORT");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.SmtolineTypeBookLinks)
                .HasForeignKey(d => d.IdStatus)
                .HasConstraintName("FK_SMTOLineTypeBookLinks_SMTOStatus");
        });

        modelBuilder.Entity<SmtolinksLog>(entity =>
        {
            entity.HasKey(e => e.IdLink);

            entity.ToTable("SMTOLinksLog");

            entity.Property(e => e.ApplyOddsBySport)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SyncMoneylines)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.SyncSpreadOdds)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.SyncSpreads)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.SyncTotalOdds)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.SyncTotals)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.HasOne(d => d.IdBookNavigation).WithMany(p => p.SmtolinksLogs)
                .HasForeignKey(d => d.IdBook)
                .HasConstraintName("FK_SMTOLinksLog_SMTOBook");

            entity.HasOne(d => d.IdLeagueNavigation).WithMany(p => p.SmtolinksLogs)
                .HasForeignKey(d => d.IdLeague)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SMTOLinksLog_LEAGUE");

            entity.HasOne(d => d.IdLineTypeNavigation).WithMany(p => p.SmtolinksLogs)
                .HasForeignKey(d => d.IdLineType)
                .HasConstraintName("FK_SMTOLinksLog_LINETYPE");

            entity.HasOne(d => d.IdSportNavigation).WithMany(p => p.SmtolinksLogs)
                .HasForeignKey(d => d.IdSport)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SMTOLinksLog_SPORT");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.SmtolinksLogs)
                .HasForeignKey(d => d.IdStatus)
                .HasConstraintName("FK_SMTOLinksLog_SMTOStatus");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.SmtolinksLogs)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMTOLinksLog_SMTOLinksLog");
        });

        modelBuilder.Entity<Smtolog>(entity =>
        {
            entity.HasKey(e => e.IdLog);

            entity.ToTable("SMTOLog");

            entity.Property(e => e.TimeStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.IdAdjustmentNavigation).WithMany(p => p.Smtologs)
                .HasForeignKey(d => d.IdAdjustment)
                .HasConstraintName("FK_SMTOLog_SMTOGameValueAdjustments");

            entity.HasOne(d => d.IdBookNavigation).WithMany(p => p.Smtologs)
                .HasForeignKey(d => d.IdBook)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SMTOLog_SMTOBook");

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.Smtologs)
                .HasForeignKey(d => d.IdGame)
                .HasConstraintName("FK_SMTOLog_GAME");

            entity.HasOne(d => d.IdLineTypeNavigation).WithMany(p => p.Smtologs)
                .HasForeignKey(d => d.IdLineType)
                .HasConstraintName("FK_SMTOLog_LINETYPE");

            entity.HasOne(d => d.IdLinkNavigation).WithMany(p => p.Smtologs)
                .HasForeignKey(d => d.IdLink)
                .HasConstraintName("FK_SMTOLog_SMTOLineTypeBookLinks");
        });

        modelBuilder.Entity<SmtologArchive>(entity =>
        {
            entity.HasKey(e => e.IdLog);

            entity.ToTable("SMTOLogArchive");

            entity.Property(e => e.IdLog).ValueGeneratedNever();
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");

            entity.HasOne(d => d.IdBookNavigation).WithMany(p => p.SmtologArchives)
                .HasForeignKey(d => d.IdBook)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SMTOLogArchive_SMTOBook");

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.SmtologArchives)
                .HasForeignKey(d => d.IdGame)
                .HasConstraintName("FK_SMTOLogArchive_GAME");

            entity.HasOne(d => d.IdLineTypeNavigation).WithMany(p => p.SmtologArchives)
                .HasForeignKey(d => d.IdLineType)
                .HasConstraintName("FK_SMTOLogArchive_LINETYPE");
        });

        modelBuilder.Entity<SmtoperiodCreationDefault>(entity =>
        {
            entity.HasKey(e => new { e.IdLeague, e.NumberOfPeriod });

            entity.ToTable("SMTOPeriodCreationDefaults");
        });

        modelBuilder.Entity<SmtoscoreLog>(entity =>
        {
            entity.HasKey(e => e.IdLog);

            entity.ToTable("SMTOScoreLog");

            entity.Property(e => e.TimeStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.SmtoscoreLogs)
                .HasForeignKey(d => d.IdGame)
                .HasConstraintName("FK_SMTOScoreLog_GAME");
        });

        modelBuilder.Entity<SmtoscoringExcludedLeague>(entity =>
        {
            entity.HasKey(e => e.IdLeague);

            entity.ToTable("SMTOScoringExcludedLeagues");

            entity.Property(e => e.IdLeague).ValueGeneratedNever();

            entity.HasOne(d => d.IdLeagueNavigation).WithOne(p => p.SmtoscoringExcludedLeague)
                .HasForeignKey<SmtoscoringExcludedLeague>(d => d.IdLeague)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMTOScoringExcludedLeagues_LEAGUE");
        });

        modelBuilder.Entity<SmtoserviceReset>(entity =>
        {
            entity.HasKey(e => e.IdReset);

            entity.ToTable("SMTOServiceResets");

            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<Smtosetting>(entity =>
        {
            entity.HasKey(e => e.IdSetting);

            entity.ToTable("SMTOSettings");

            entity.Property(e => e.SettingName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SettingValue)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Smtosport>(entity =>
        {
            entity.ToTable("SMTOSports");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdSportNavigation).WithMany(p => p.Smtosports)
                .HasForeignKey(d => d.IdSport)
                .HasConstraintName("FK_SMTOSports_SPORT");
        });

        modelBuilder.Entity<Smtostatus>(entity =>
        {
            entity.HasKey(e => e.IdStatus).HasName("PK_SMTOLineTypeBookLinkStatus");

            entity.ToTable("SMTOStatus");

            entity.Property(e => e.IdStatus).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(50);
        });

        modelBuilder.Entity<Source>(entity =>
        {
            entity.HasKey(e => e.IdSource);

            entity.ToTable("SOURCE");

            entity.HasIndex(e => e.SourceName, "IX_SOURCENAME").IsUnique();

            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.SourceName)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sourcebybook>(entity =>
        {
            entity.HasKey(e => new { e.IdSource, e.IdBook });

            entity.ToTable("SOURCEBYBOOK");
        });

        modelBuilder.Entity<Sport>(entity =>
        {
            entity.HasKey(e => e.IdSport);

            entity.ToTable("SPORT");

            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.SportName)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SwfeedState>(entity =>
        {
            entity.HasKey(e => e.FileName);

            entity.ToTable("SWFeedState");

            entity.Property(e => e.FileName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProcessedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Systembannedip>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SYSTEMBANNEDIPS");

            entity.Property(e => e.Ip)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("IP");
        });

        modelBuilder.Entity<Systembetradarcategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId);

            entity.ToTable("SYSTEMBETRADARCATEGORY");

            entity.Property(e => e.CategoryId)
                .ValueGeneratedNever()
                .HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.HasTournaments)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.SportId).HasColumnName("SportID");

            entity.HasOne(d => d.OutrightIdGametypeNavigation).WithMany(p => p.Systembetradarcategories)
                .HasForeignKey(d => d.OutrightIdGametype)
                .HasConstraintName("FK_SYSTEMBETRADARCATEGORY_GAMETYPE");

            entity.HasOne(d => d.OutrightIdLeagueNavigation).WithMany(p => p.Systembetradarcategories)
                .HasForeignKey(d => d.OutrightIdLeague)
                .HasConstraintName("FK_SYSTEMBETRADARCATEGORY_LEAGUE");

            entity.HasOne(d => d.Sport).WithMany(p => p.Systembetradarcategories)
                .HasForeignKey(d => d.SportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SYSTEMBETRADARCATEGORY_SYSTEMBETRADARSPORT");
        });

        modelBuilder.Entity<Systembetradarconfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SYSTEMBETRADARCONFIG");

            entity.Property(e => e.FilesPath)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.IdGameType)
                .HasDefaultValueSql("((1))")
                .HasColumnName("idGameType");
            entity.Property(e => e.IdLineType)
                .HasDefaultValueSql("((1))")
                .HasColumnName("idLineType");
            entity.Property(e => e.ImportCsasProps).HasColumnName("ImportCSasProps");
            entity.Property(e => e.LastModification)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastModificationUser).HasDefaultValueSql("((1))");
            entity.Property(e => e.RefreshRate).HasDefaultValueSql("((10))");
        });

        modelBuilder.Entity<Systembetradarsport>(entity =>
        {
            entity.HasKey(e => e.SportId);

            entity.ToTable("SYSTEMBETRADARSPORT");

            entity.Property(e => e.SportId).HasColumnName("SportID");
            entity.Property(e => e.Enabled)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.SportName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Systembetradartournament>(entity =>
        {
            entity.HasKey(e => e.TournamentId);

            entity.ToTable("SYSTEMBETRADARTOURNAMENT");

            entity.Property(e => e.TournamentId)
                .ValueGeneratedNever()
                .HasColumnName("TournamentID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.IdLeagueCs).HasColumnName("IdLeagueCS");
            entity.Property(e => e.ImportCsasProps).HasColumnName("ImportCSasProps");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.TournamentName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UniqueTournamentId).HasColumnName("UniqueTournamentID");
            entity.Property(e => e.UniqueTournamentName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Category).WithMany(p => p.Systembetradartournaments)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SYSTEMBETRADARTOURNAMENT_SYSTEMBETRADARCATEGORY");

            entity.HasOne(d => d.IdGametypeNavigation).WithMany(p => p.Systembetradartournaments)
                .HasForeignKey(d => d.IdGametype)
                .HasConstraintName("FK_SYSTEMBETRADARTOURNAMENT_GAMETYPE");

            entity.HasOne(d => d.IdLeagueNavigation).WithMany(p => p.SystembetradartournamentIdLeagueNavigations)
                .HasForeignKey(d => d.IdLeague)
                .HasConstraintName("FK_SYSTEMBETRADARTOURNAMENT_LEAGUE");

            entity.HasOne(d => d.IdLeagueCsNavigation).WithMany(p => p.SystembetradartournamentIdLeagueCsNavigations)
                .HasForeignKey(d => d.IdLeagueCs)
                .HasConstraintName("FK_SYSTEMBETRADARTOURNAMENT_LEAGUE1");
        });

        modelBuilder.Entity<Systembonusoption>(entity =>
        {
            entity.HasKey(e => new { e.IdOffice, e.IdSport, e.Line });

            entity.ToTable("SYSTEMBONUSOPTIONS");

            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Systembonussetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SYSTEMBONUSSETTING");

            entity.Property(e => e.EnableNabets).HasColumnName("EnableNABets");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FuncParlays)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FuncStraightBets)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FuncTeasers)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastModification)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Systembonussettingdetail>(entity =>
        {
            entity.HasKey(e => e.WagerType);

            entity.ToTable("SYSTEMBONUSSETTINGDETAIL");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.PointsPerUnit).HasColumnType("money");
        });

        modelBuilder.Entity<Systemcachechange>(entity =>
        {
            entity.HasKey(e => e.IdSystemCacheChange);

            entity.ToTable("SYSTEMCACHECHANGE");

            entity.Property(e => e.Action).HasDefaultValueSql("((1))");
            entity.Property(e => e.Pk).HasColumnName("PK");
            entity.Property(e => e.SubPk)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");

            entity.HasOne(d => d.IdSystemCacheTableNavigation).WithMany(p => p.Systemcachechanges)
                .HasForeignKey(d => d.IdSystemCacheTable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SYSTEMCACHECHANGE_SYSTEMCACHETABLE");
        });

        modelBuilder.Entity<Systemcachetable>(entity =>
        {
            entity.HasKey(e => e.IdSystemCacheTable);

            entity.ToTable("SYSTEMCACHETABLE");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<Systemcall>(entity =>
        {
            entity.HasKey(e => e.IdCall).HasName("PK_SystemCalls");

            entity.ToTable("SYSTEMCALLS");

            entity.Property(e => e.PhoneLine).HasDefaultValueSql("((-1))");
        });

        modelBuilder.Entity<Systemchangedline>(entity =>
        {
            entity.HasKey(e => e.IdSystemChangedLines);

            entity.ToTable("SYSTEMCHANGEDLINES");

            entity.Property(e => e.ChangeValue)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");

            entity.HasOne(d => d.IdLineTypeNavigation).WithMany(p => p.Systemchangedlines)
                .HasForeignKey(d => d.IdLineType)
                .HasConstraintName("FK_SYSTEMCHANGEDLINES_LINETYPE");

            entity.HasOne(d => d.IdSportNavigation).WithMany(p => p.Systemchangedlines)
                .HasForeignKey(d => d.IdSport)
                .HasConstraintName("FK_SYSTEMCHANGEDLINES_SPORT");
        });

        modelBuilder.Entity<Systemchangedlines2>(entity =>
        {
            entity.HasKey(e => e.IdSystemChangedLines);

            entity.ToTable("SYSTEMCHANGEDLINES2");

            entity.Property(e => e.ChangeValue)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Systemchangedlineslog>(entity =>
        {
            entity.HasKey(e => e.IdSystemChangedLines);

            entity.ToTable("SYSTEMCHANGEDLINESLOG");

            entity.Property(e => e.ChangeValue)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Systemchangedlineslog2>(entity =>
        {
            entity.HasKey(e => e.IdSystemChangedLines);

            entity.ToTable("SYSTEMCHANGEDLINESLOG2");

            entity.Property(e => e.ChangeValue)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Systemcolor>(entity =>
        {
            entity.HasKey(e => e.IdSystemColors);

            entity.ToTable("SYSTEMCOLORS");

            entity.Property(e => e.Description)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.GameStat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastModification).HasColumnType("datetime");
        });

        modelBuilder.Entity<Systemdbsbook>(entity =>
        {
            entity.HasKey(e => e.BookId);

            entity.ToTable("SYSTEMDBSBOOK");

            entity.Property(e => e.BookId).ValueGeneratedNever();
            entity.Property(e => e.Abbreviation)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Systemdbsconfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SYSTEMDBSCONFIG");

            entity.Property(e => e.EventChangeUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EventChangeURL");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.LineChangesUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("LineChangesURL");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PitchingChangeUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PitchingChangeURL");
            entity.Property(e => e.ScheduleUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ScheduleURL");
            entity.Property(e => e.ScoresUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ScoresURL");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdLineTypeNavigation).WithMany()
                .HasForeignKey(d => d.IdLineType)
                .HasConstraintName("FK_SYSTEMDBSCONFIG_LINETYPE");
        });

        modelBuilder.Entity<Systemdbsevent>(entity =>
        {
            entity.ToTable("SYSTEMDBSEVENT");

            entity.Property(e => e.SystemDbseventId).HasColumnName("SystemDBSEventID");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Systemdbsgamestatchange>(entity =>
        {
            entity.HasKey(e => e.IdGameStatChange);

            entity.ToTable("SYSTEMDBSGAMESTATCHANGE");

            entity.Property(e => e.DbseventId).HasColumnName("DBSEventId");
            entity.Property(e => e.EventDate).HasColumnType("datetime");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.NewValue)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.Systemdbsgamestatchanges)
                .HasForeignKey(d => d.IdGame)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SYSTEMDBSGAMESTATCHANGE_GAME");
        });

        modelBuilder.Entity<Systemdbsgamestatchangelog>(entity =>
        {
            entity.HasKey(e => e.IdGameStatChange);

            entity.ToTable("SYSTEMDBSGAMESTATCHANGELOG");

            entity.Property(e => e.IdGameStatChange).ValueGeneratedNever();
            entity.Property(e => e.DbseventId).HasColumnName("DBSEventId");
            entity.Property(e => e.EventDate).HasColumnType("datetime");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.NewValue)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Systemdbsleague>(entity =>
        {
            entity.HasKey(e => e.LeagueId);

            entity.ToTable("SYSTEMDBSLEAGUE");

            entity.Property(e => e.LeagueId).ValueGeneratedNever();
            entity.Property(e => e.Abbreviation)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Systemdbsperiod>(entity =>
        {
            entity.HasKey(e => e.IdSystemDbsperiod);

            entity.ToTable("SYSTEMDBSPERIOD");

            entity.Property(e => e.IdSystemDbsperiod).HasColumnName("IdSystemDBSPeriod");
            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Systemdbspitchingchange>(entity =>
        {
            entity.HasKey(e => e.IdPitchingChange);

            entity.ToTable("SYSTEMDBSPITCHINGCHANGE");

            entity.Property(e => e.DbseventId).HasColumnName("DBSEventId");
            entity.Property(e => e.EventDate).HasColumnType("datetime");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.NewPitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Side)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.Systemdbspitchingchanges)
                .HasForeignKey(d => d.IdGame)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SYSTEMDBSPITCHINGCHANGE_GAME");
        });

        modelBuilder.Entity<Systemdbspitchingchangelog>(entity =>
        {
            entity.HasKey(e => e.IdPitchingChange);

            entity.ToTable("SYSTEMDBSPITCHINGCHANGELOG");

            entity.Property(e => e.IdPitchingChange).ValueGeneratedNever();
            entity.Property(e => e.DbseventId).HasColumnName("DBSEventId");
            entity.Property(e => e.EventDate).HasColumnType("datetime");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.NewPitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Side)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Systemdbsscore>(entity =>
        {
            entity.HasKey(e => e.IdScore);

            entity.ToTable("SYSTEMDBSSCORE");

            entity.Property(e => e.DbseventId).HasColumnName("DBSEventId");
            entity.Property(e => e.EventDate).HasColumnType("datetime");
            entity.Property(e => e.LastModification)
                .HasDefaultValueSql("((0))")
                .HasColumnType("datetime");

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.Systemdbsscores)
                .HasForeignKey(d => d.IdGame)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SYSTEMDBSSCORE_GAME");
        });

        modelBuilder.Entity<Systemdbsscorelog>(entity =>
        {
            entity.HasKey(e => e.IdScore);

            entity.ToTable("SYSTEMDBSSCORELOG");

            entity.Property(e => e.IdScore).HasColumnType("money");
            entity.Property(e => e.DbseventId).HasColumnName("DBSEventId");
            entity.Property(e => e.EventDate).HasColumnType("datetime");
            entity.Property(e => e.LastModification)
                .HasDefaultValueSql("((0))")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Systemdbssport>(entity =>
        {
            entity.HasKey(e => e.LeagueId);

            entity.ToTable("SYSTEMDBSSPORT");

            entity.Property(e => e.LeagueId).ValueGeneratedNever();
            entity.Property(e => e.BookIdTnt).HasColumnName("BookIdTNT");
            entity.Property(e => e.IdTntleague).HasColumnName("IdTNTLeague");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.ProcessProps).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.Book).WithMany(p => p.SystemdbssportBooks)
                .HasForeignKey(d => d.BookId)
                .HasConstraintName("FK_SYSTEMDBSSPORT_SYSTEMDBSBOOK");

            entity.HasOne(d => d.BookIdPropsNavigation).WithMany(p => p.SystemdbssportBookIdPropsNavigations)
                .HasForeignKey(d => d.BookIdProps)
                .HasConstraintName("FK_SYSTEMDBSSPORT_SYSTEMDBSBOOK2");

            entity.HasOne(d => d.BookIdTntNavigation).WithMany(p => p.SystemdbssportBookIdTntNavigations)
                .HasForeignKey(d => d.BookIdTnt)
                .HasConstraintName("FK_SYSTEMDBSSPORT_SYSTEMDBSBOOK1");

            entity.HasOne(d => d.IdLeagueNavigation).WithMany(p => p.Systemdbssports)
                .HasForeignKey(d => d.IdLeague)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SYSTEMDBSSPORT_LEAGUE");

            entity.HasOne(d => d.League).WithOne(p => p.Systemdbssport)
                .HasForeignKey<Systemdbssport>(d => d.LeagueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SYSTEMDBSSPORT_SYSTEMDBSLEAGUE");
        });

        modelBuilder.Entity<Systemdictionary>(entity =>
        {
            entity.HasKey(e => new { e.IdLanguage, e.IdMessage, e.Page });

            entity.ToTable("SYSTEMDICTIONARY");

            entity.Property(e => e.IdMessage)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Page)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Message)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.IdLanguageNavigation).WithMany(p => p.Systemdictionaries)
                .HasForeignKey(d => d.IdLanguage)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SYSTEMDICTIONARY_SYSTEMLANGUAGE");
        });

        modelBuilder.Entity<Systemdistributioninfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SYSTEMDISTRIBUTIONINFO");

            entity.Property(e => e.Cwcancel).HasColumnName("CWCancel");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TableEndDate).HasColumnType("datetime");
            entity.Property(e => e.TableStartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Systemdistributionlog>(entity =>
        {
            entity.HasKey(e => e.IdLog).HasName("PK_DISTRIBUTIONLOG");

            entity.ToTable("SYSTEMDISTRIBUTIONLOG");

            entity.Property(e => e.Data1).HasColumnType("money");
            entity.Property(e => e.Data2).HasColumnType("money");
            entity.Property(e => e.Data3).HasColumnType("money");
            entity.Property(e => e.Data4).HasColumnType("money");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DistributionDate).HasColumnType("datetime");
            entity.Property(e => e.TransacDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Systemerrorlog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SYSTEMERRORLOG");

            entity.Property(e => e.Comments)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.ErrorDate).HasColumnType("datetime");
            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(900)
                .IsUnicode(false);
            entity.Property(e => e.IdsystemErrorLog).ValueGeneratedOnAdd();
            entity.Property(e => e.System)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Systemlanguage>(entity =>
        {
            entity.HasKey(e => e.IdLanguage);

            entity.ToTable("SYSTEMLANGUAGE");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Home)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Meta)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Systemoddsconversion>(entity =>
        {
            entity.HasKey(e => e.AmericanFormat);

            entity.ToTable("SYSTEMODDSCONVERSION");

            entity.Property(e => e.AmericanFormat).ValueGeneratedNever();
            entity.Property(e => e.FractionalFormat)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Systempreferencesclient>(entity =>
        {
            entity.HasKey(e => e.IdSystemPreferencesClient);

            entity.ToTable("SYSTEMPREFERENCESCLIENT");

            entity.Property(e => e.HideOtbgames).HasColumnName("HideOTBGames");
            entity.Property(e => e.IfBetsNui).HasColumnName("IfBetsNUI");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.PrecallTimer).HasDefaultValueSql("((30))");
            entity.Property(e => e.Threshold).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<Systempreferencesclientlog>(entity =>
        {
            entity.HasKey(e => e.IdSystemPreferencesClientLog);

            entity.ToTable("SYSTEMPREFERENCESCLIENTLOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.NewValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Systempreferencesdefault>(entity =>
        {
            entity.HasKey(e => e.IdBook);

            entity.ToTable("SYSTEMPREFERENCESDEFAULT");

            entity.Property(e => e.IdBook).ValueGeneratedNever();
            entity.Property(e => e.DefaultBonusPointsExpire)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DefaultBonusPointsStart)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DefaultBonusPointsStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('B')")
                .IsFixedLength();
            entity.Property(e => e.DefaultEnable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('D')")
                .IsFixedLength();
            entity.Property(e => e.DefaultEnableCards)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.DefaultFlagMessage)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DefaultFlagType).HasDefaultValueSql("((1))");
            entity.Property(e => e.DefaultLineStyle)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DefaultMaxWager).HasColumnType("money");
            entity.Property(e => e.DefaultMaxWagerOnline).HasColumnType("money");
            entity.Property(e => e.DefaultMinWager).HasColumnType("money");
            entity.Property(e => e.DefaultMinWagerOnline).HasColumnType("money");
            entity.Property(e => e.DefaultMlbline)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DefaultMLBLine");
            entity.Property(e => e.DefaultNhlline)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DefaultNHLLine");
            entity.Property(e => e.DefaultOnlineMessage)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DefaultProfileLimit).HasDefaultValueSql("((1))");
            entity.Property(e => e.DefaultSettleAmount).HasColumnType("money");
            entity.Property(e => e.IdLanguage)
                .HasDefaultValueSql("((1))")
                .HasComment("language for the player schedule (online)");
            entity.Property(e => e.IdTimeZone)
                .HasDefaultValueSql("((1))")
                .HasComment("timezone to adjust the schedule of the player   (online)");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.ScheduleStyle)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasComment("Style of the Web Schedule, E=European, A=American");

            entity.HasOne(d => d.IdBookNavigation).WithOne(p => p.Systempreferencesdefault)
                .HasForeignKey<Systempreferencesdefault>(d => d.IdBook)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SYSTEMPREFERENCESDEFAULT_BOOK");
        });

        modelBuilder.Entity<Systempreferencesdefaultlog>(entity =>
        {
            entity.HasKey(e => e.IdSystemPreferencesDefaultManagerLog);

            entity.ToTable("SYSTEMPREFERENCESDEFAULTLOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdBook).HasDefaultValueSql("((1))");
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.NewValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Systempreferencesmanager>(entity =>
        {
            entity.HasKey(e => e.IdSystemPreferencesManager);

            entity.ToTable("SYSTEMPREFERENCESMANAGER");

            entity.Property(e => e.ActionColumnDisplay)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ApcountTie)
                .HasComment("Option for Action Points to count the 1 to -1 case, if on, then there are 2 AP, if off just 1")
                .HasColumnName("APCountTie");
            entity.Property(e => e.DecimalsChart).HasComment("Display Decimals in Chart info if the option UseDecimals is ON");
            entity.Property(e => e.DefaultLineHistory).HasColumnType("money");
            entity.Property(e => e.EnforcePassRules)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.IncludeApinChart)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("IncludeAPInChart");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.LicenseServerIp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'127.0.0.1')")
                .HasColumnName("LicenseServerIP");
            entity.Property(e => e.LicenseServerPort).HasDefaultValueSql("((1516))");
            entity.Property(e => e.SendAmericanLineToDbs).HasColumnName("SendAmericanLineToDBS");
            entity.Property(e => e.SetGamesFinal)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.SoundLocalPath)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('c:\\temp')");
            entity.Property(e => e.SoundServerPath)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.SyncGoalLineAsSpread)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.SyncRunlineAsSpread)
                .IsRequired()
                .HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<Systempreferencesmanagerlog>(entity =>
        {
            entity.HasKey(e => e.IdSystemPreferencesManagerLog).HasName("PK_SYSTEMPREFERENCESLOG");

            entity.ToTable("SYSTEMPREFERENCESMANAGERLOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.NewValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Systemprocess>(entity =>
        {
            entity.HasKey(e => e.IdSystemProcess);

            entity.ToTable("SYSTEMPROCESS");

            entity.Property(e => e.EndingTime).HasColumnType("datetime");
            entity.Property(e => e.HomePitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IP");
            entity.Property(e => e.LoseAmount).HasColumnType("money");
            entity.Property(e => e.OldHomePitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OldVisitorPitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RequestingTime).HasColumnType("datetime");
            entity.Property(e => e.StartingTime).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Vhchange).HasColumnName("VHChange");
            entity.Property(e => e.VisitorPitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WinAmount).HasColumnType("money");
        });

        modelBuilder.Entity<Systemprocessdetail>(entity =>
        {
            entity.HasKey(e => e.IdSystemProcessDetail);

            entity.ToTable("SYSTEMPROCESSDETAIL");

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.IdSystemProcessNavigation).WithMany(p => p.Systemprocessdetails)
                .HasForeignKey(d => d.IdSystemProcess)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SYSTEMPROCESSDETAIL_SYSTEMPROCESS");
        });

        modelBuilder.Entity<Systemprocessflag>(entity =>
        {
            entity.HasKey(e => e.ProcessName);

            entity.ToTable("SYSTEMPROCESSFLAG");

            entity.Property(e => e.ProcessName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IP");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Systemprocesslog>(entity =>
        {
            entity.HasKey(e => e.IdSystemProcess);

            entity.ToTable("SYSTEMPROCESSLOG");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessDate).HasColumnType("datetime");
            entity.Property(e => e.TotalTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<Systemprocesslogdetail>(entity =>
        {
            entity.HasKey(e => new { e.IdSystemProcessDetail, e.IdSystemProcess });

            entity.ToTable("SYSTEMPROCESSLOGDETAIL");

            entity.Property(e => e.IdSystemProcessDetail).ValueGeneratedOnAdd();
            entity.Property(e => e.Step)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalTime).HasColumnType("datetime");

            entity.HasOne(d => d.IdSystemProcessNavigation).WithMany(p => p.Systemprocesslogdetails)
                .HasForeignKey(d => d.IdSystemProcess)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SYSTEMPROCESSLOGDETAIL_SYSTEMPROCESSLOG");
        });

        modelBuilder.Entity<Systemrecordinglog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SYSTEMRECORDINGLOG");

            entity.Property(e => e.Application)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ErrorDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Systemservice>(entity =>
        {
            entity.HasKey(e => e.IdService);

            entity.ToTable("SYSTEMSERVICES");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LastModification)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastModificationUser).HasDefaultValueSql("((1))");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Systemservicesreg>(entity =>
        {
            entity.HasKey(e => e.IdServiceReg);

            entity.ToTable("SYSTEMSERVICESREG");

            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IPAddress");
            entity.Property(e => e.LastModification)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastModificationUser).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.IdServiceNavigation).WithMany(p => p.Systemservicesregs)
                .HasForeignKey(d => d.IdService)
                .HasConstraintName("FK_SYSTEMSERVICESREG_SYSTEMSERVICES");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Systemservicesregs)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK_SYSTEMSERVICESREG_USERS");
        });

        modelBuilder.Entity<Systemsession>(entity =>
        {
            entity.HasKey(e => e.IdSession);

            entity.ToTable("SYSTEMSESSION");

            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.Expiration).HasColumnType("datetime");
            entity.Property(e => e.Ip)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IP");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.Session)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StartTime).HasColumnType("datetime");
            entity.Property(e => e.System)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Systemsessionaccount>(entity =>
        {
            entity.HasKey(e => new { e.IdAccount, e.AccountType });

            entity.ToTable("SYSTEMSESSIONACCOUNT");

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.LastModificacion).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.StartTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<Systemsessiondetail>(entity =>
        {
            entity.HasKey(e => e.IdSessionDetail);

            entity.ToTable("SYSTEMSESSIONDETAIL");

            entity.Property(e => e.Action)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ActionTime).HasColumnType("datetime");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.Session)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Systemsessionlog>(entity =>
        {
            entity.HasKey(e => e.IdSystemSessionLog);

            entity.ToTable("SYSTEMSESSIONLOG");

            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.Expiration).HasColumnType("datetime");
            entity.Property(e => e.Ip)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IP");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.Session)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StartTime).HasColumnType("datetime");
            entity.Property(e => e.System)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Systemsobook>(entity =>
        {
            entity.HasKey(e => e.BookId);

            entity.ToTable("SYSTEMSOBOOK");

            entity.Property(e => e.BookId).ValueGeneratedNever();
            entity.Property(e => e.Abbreviation)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Systemsoconfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SYSTEMSOCONFIG");

            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ServerIp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ServerIP");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Systemsoleague>(entity =>
        {
            entity.HasKey(e => e.LeagueId);

            entity.ToTable("SYSTEMSOLEAGUE");

            entity.Property(e => e.LeagueId).ValueGeneratedNever();
            entity.Property(e => e.Abbreviation)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Systemsosport>(entity =>
        {
            entity.HasKey(e => e.LeagueId);

            entity.ToTable("SYSTEMSOSPORT");

            entity.Property(e => e.LeagueId).ValueGeneratedNever();
            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.Book).WithMany(p => p.Systemsosports)
                .HasForeignKey(d => d.BookId)
                .HasConstraintName("FK_SYSTEMSOSPORT_SYSTEMSOBOOK");

            entity.HasOne(d => d.IdLeagueNavigation).WithMany(p => p.SystemsosportIdLeagueNavigations)
                .HasForeignKey(d => d.IdLeague)
                .HasConstraintName("FK_SYSTEMSOSPORT_LEAGUE");

            entity.HasOne(d => d.IdPropLeagueNavigation).WithMany(p => p.SystemsosportIdPropLeagueNavigations)
                .HasForeignKey(d => d.IdPropLeague)
                .HasConstraintName("FK_SYSTEMSOSPORT_LEAGUE1");

            entity.HasOne(d => d.League).WithOne(p => p.Systemsosport)
                .HasForeignKey<Systemsosport>(d => d.LeagueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SYSTEMSOSPORT_SYSTEMSOLEAGUE");
        });

        modelBuilder.Entity<Systemversioninfo>(entity =>
        {
            entity.HasKey(e => e.IdSystemVersioninfo);

            entity.ToTable("SYSTEMVERSIONINFO");

            entity.Property(e => e.CustoId).HasColumnName("CustoID");
            entity.Property(e => e.DaysBeforeExpirationWarning).HasDefaultValueSql("((5))");
            entity.Property(e => e.DbVersion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastArchivingDate).HasColumnType("datetime");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.LastModificationUser)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UsePassEncryptAgents).HasColumnName("UsePassEncrypt_Agents");
            entity.Property(e => e.UsePassEncryptPlayers).HasColumnName("UsePassEncrypt_Players");
            entity.Property(e => e.UsePassEncryptUsers).HasColumnName("UsePassEncrypt_Users");
        });

        modelBuilder.Entity<Targeturl>(entity =>
        {
            entity.HasKey(e => e.IdTargetUrl);

            entity.ToTable("TARGETURL");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TargetUrl1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TargetUrl");
        });

        modelBuilder.Entity<Tax>(entity =>
        {
            entity.HasKey(e => e.TaxId).HasName("PK_Tax");

            entity.ToTable("TAX");

            entity.Property(e => e.TaxId).HasColumnName("TaxID");
            entity.Property(e => e.AppliesTo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TaxAmount).HasColumnType("money");
            entity.Property(e => e.TaxDesc)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TaxRate).HasColumnType("numeric(5, 3)");
        });

        modelBuilder.Entity<Taxtransact>(entity =>
        {
            entity.HasKey(e => e.TaxTransactId).HasName("PK_TaxTransact");

            entity.ToTable("TAXTRANSACT");

            entity.Property(e => e.TaxTransactId).HasColumnName("TaxTransactID");
            entity.Property(e => e.ActiveTillId).HasColumnName("ActiveTillID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.OpDate).HasColumnType("datetime");
            entity.Property(e => e.TaxId).HasColumnName("TaxID");
            entity.Property(e => e.TransactAmount).HasColumnType("money");
            entity.Property(e => e.TransactDateTime).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity.HasKey(e => e.IdTeam);

            entity.ToTable("TEAM");

            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.LongName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TeamName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdSportNavigation).WithMany(p => p.Teams)
                .HasForeignKey(d => d.IdSport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TEAM_SPORT");
        });

        modelBuilder.Entity<Teamlang>(entity =>
        {
            entity.HasKey(e => new { e.IdTeam, e.IdLanguage });

            entity.ToTable("TEAMLANG");

            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.LongName).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(60);
            entity.Property(e => e.ShortName).HasMaxLength(20);

            entity.HasOne(d => d.IdLanguageNavigation).WithMany(p => p.Teamlangs)
                .HasForeignKey(d => d.IdLanguage)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TEAMLANG_Language");

            entity.HasOne(d => d.IdTeamNavigation).WithMany(p => p.Teamlangs)
                .HasForeignKey(d => d.IdTeam)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TEAMLANG_TEAM");
        });

        modelBuilder.Entity<TeaserBtnDetail>(entity =>
        {
            entity.HasKey(e => new { e.IdProfile, e.IdTeaserBtn, e.NumTeams });

            entity.ToTable("TeaserBtnDetail");

            entity.Property(e => e.TeaserName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Id).WithMany(p => p.TeaserBtnDetails)
                .HasForeignKey(d => new { d.IdProfile, d.IdTeaserBtn })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeaserBtnDetail_TeaserBtnMain");

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.TeaserBtnDetails)
                .HasForeignKey(d => new { d.IdProfile, d.IdWagerType })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeaserBtnDetail_PLAYERPROFILECUSTOMTEASER");
        });

        modelBuilder.Entity<TeaserBtnMain>(entity =>
        {
            entity.HasKey(e => new { e.IdProfile, e.IdTeaserBtn });

            entity.ToTable("TeaserBtnMain");

            entity.Property(e => e.IdTeaserBtn).ValueGeneratedOnAdd();
            entity.Property(e => e.BtnCaption)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.IdProfileNavigation).WithMany(p => p.TeaserBtnMains)
                .HasForeignKey(d => d.IdProfile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeaserBtnMain_PLAYERPROFILE");
        });

        modelBuilder.Entity<Terminal>(entity =>
        {
            entity.ToTable("Terminal");

            entity.HasIndex(e => e.Description, "IX_Terminal_Desc").IsUnique();

            entity.Property(e => e.TerminalId).HasColumnName("TerminalID");
            entity.Property(e => e.CashedTicketTemplateId).HasColumnName("CashedTicketTemplateID");
            entity.Property(e => e.Cdinterface).HasColumnName("CDInterface");
            entity.Property(e => e.Cdport).HasColumnName("CDPort");
            entity.Property(e => e.Description)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.TicketTemplateId).HasColumnName("TicketTemplateID");
            entity.Property(e => e.VoucherTemplateId).HasColumnName("VoucherTemplateID");

            entity.HasOne(d => d.CashedTicketTemplate).WithMany(p => p.Terminals)
                .HasForeignKey(d => d.CashedTicketTemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Terminal_CashedTicketTemplate");

            entity.HasOne(d => d.Location).WithMany(p => p.Terminals)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Terminal_Location");

            entity.HasOne(d => d.TicketTemplate).WithMany(p => p.Terminals)
                .HasForeignKey(d => d.TicketTemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Terminal_TicketTemplate");
        });

        modelBuilder.Entity<TerminalManager>(entity =>
        {
            entity.HasKey(e => e.ManagerId);

            entity.ToTable("TerminalManager");

            entity.HasIndex(e => e.UserName, "IX_TerminalManager_UserName").IsUnique();

            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
            entity.Property(e => e.Password)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasMany(d => d.Locations).WithMany(p => p.Managers)
                .UsingEntity<Dictionary<string, object>>(
                    "ManagerLocation",
                    r => r.HasOne<Location>().WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ManagerLocation_Location"),
                    l => l.HasOne<TerminalManager>().WithMany()
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ManagerLocation_TerminalManager"),
                    j =>
                    {
                        j.HasKey("ManagerId", "LocationId");
                        j.ToTable("ManagerLocation");
                        j.IndexerProperty<int>("ManagerId").HasColumnName("ManagerID");
                        j.IndexerProperty<int>("LocationId").HasColumnName("LocationID");
                    });
        });

        modelBuilder.Entity<TerminalSessionActive>(entity =>
        {
            entity.HasKey(e => e.TermSessId);

            entity.ToTable("TerminalSessionActive");

            entity.Property(e => e.TermSessId).HasColumnName("TermSessID");
            entity.Property(e => e.ActiveTillId).HasColumnName("ActiveTillID");
            entity.Property(e => e.LastActivity).HasColumnType("smalldatetime");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Mlbline)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MLBLine");
            entity.Property(e => e.Nhlline)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NHLLine");
            entity.Property(e => e.OpenedDateTime).HasColumnType("smalldatetime");
            entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

            entity.HasOne(d => d.IdPlayerNavigation).WithMany(p => p.TerminalSessionActives)
                .HasForeignKey(d => d.IdPlayer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TerminalSessionActive_PLAYER");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.TerminalSessionActives)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TerminalSessionActive_Users");

            entity.HasOne(d => d.Location).WithMany(p => p.TerminalSessionActives)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TerminalSessionActive_Location");

            entity.HasOne(d => d.Terminal).WithMany(p => p.TerminalSessionActives)
                .HasForeignKey(d => d.TerminalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TerminalSessionActive_Terminal");
        });

        modelBuilder.Entity<TerminalSessionClosed>(entity =>
        {
            entity.HasKey(e => e.TermSessId);

            entity.ToTable("TerminalSessionClosed");

            entity.Property(e => e.TermSessId)
                .ValueGeneratedNever()
                .HasColumnName("TermSessID");
            entity.Property(e => e.ActiveTillId).HasColumnName("ActiveTillID");
            entity.Property(e => e.ClosedDateTime).HasColumnType("smalldatetime");
            entity.Property(e => e.OpenedDateTime).HasColumnType("smalldatetime");
            entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.TerminalSessionCloseds)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TerminalSessionClosed_Users");

            entity.HasOne(d => d.Terminal).WithMany(p => p.TerminalSessionCloseds)
                .HasForeignKey(d => d.TerminalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TerminalSessionClosed_Terminal");
        });

        modelBuilder.Entity<Tickerconfiguration>(entity =>
        {
            entity.HasKey(e => e.IdUser);

            entity.ToTable("TICKERCONFIGURATION");

            entity.Property(e => e.IdUser).ValueGeneratedNever();
            entity.Property(e => e.Agent)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Player).HasMaxLength(255);
            entity.Property(e => e.Profile)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ShowCbb).HasColumnName("ShowCBB");
            entity.Property(e => e.ShowCfb).HasColumnName("ShowCFB");
            entity.Property(e => e.ShowEsoc)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("ShowESOC");
            entity.Property(e => e.ShowMlb).HasColumnName("ShowMLB");
            entity.Property(e => e.ShowMu).HasColumnName("ShowMU");
            entity.Property(e => e.ShowNba).HasColumnName("ShowNBA");
            entity.Property(e => e.ShowNfl).HasColumnName("ShowNFL");
            entity.Property(e => e.ShowNhl).HasColumnName("ShowNHL");
            entity.Property(e => e.ShowProp).HasColumnName("ShowPROP");
            entity.Property(e => e.ShowRac).HasColumnName("ShowRAC");
            entity.Property(e => e.ShowSoc).HasColumnName("ShowSOC");
            entity.Property(e => e.ShowTnt).HasColumnName("ShowTNT");

            entity.HasOne(d => d.IdUserNavigation).WithOne(p => p.Tickerconfiguration)
                .HasForeignKey<Tickerconfiguration>(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TICKERCONFIGURATION_USERS");
        });

        modelBuilder.Entity<Tickerconfigurationdetail>(entity =>
        {
            entity.HasKey(e => new { e.IdUser, e.MaxValue, e.MinValue });

            entity.ToTable("TICKERCONFIGURATIONDETAIL");

            entity.Property(e => e.MaxValue).HasColumnType("money");
            entity.Property(e => e.MinValue).HasColumnType("money");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Tickerconfigurationdetails)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TICKERCONFIGURATIONDETAIL_TICKERCONFIGURATION");
        });

        modelBuilder.Entity<TicketDetail>(entity =>
        {
            entity.HasKey(e => new { e.TicketNumber, e.IdWager });

            entity.ToTable("TicketDetail");

            entity.HasOne(d => d.TicketNumberNavigation).WithMany(p => p.TicketDetails)
                .HasForeignKey(d => d.TicketNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TicketDetail_TicketMain");
        });

        modelBuilder.Entity<TicketHold>(entity =>
        {
            entity.HasKey(e => e.TicketNumber);

            entity.ToTable("TicketHold");

            entity.Property(e => e.TicketNumber).ValueGeneratedNever();
            entity.Property(e => e.HoldDateTime).HasColumnType("datetime");
            entity.Property(e => e.HoldReason)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

            entity.HasOne(d => d.Manager).WithMany(p => p.TicketHolds)
                .HasForeignKey(d => d.ManagerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TicketHold_TerminalManager");

            entity.HasOne(d => d.TicketNumberNavigation).WithOne(p => p.TicketHold)
                .HasForeignKey<TicketHold>(d => d.TicketNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TicketHold_TicketMain");
        });

        modelBuilder.Entity<TicketHoldRelease>(entity =>
        {
            entity.HasKey(e => new { e.TicketNumber, e.ReleaseId });

            entity.ToTable("TicketHoldRelease");

            entity.Property(e => e.ReleaseId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ReleaseID");
            entity.Property(e => e.HoldDateTime).HasColumnType("datetime");
            entity.Property(e => e.HoldReason)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
            entity.Property(e => e.ReleaseDateTime).HasColumnType("datetime");
            entity.Property(e => e.ReleaseManagerId).HasColumnName("ReleaseManagerID");
            entity.Property(e => e.ReleaseReason)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Manager).WithMany(p => p.TicketHoldReleaseManagers)
                .HasForeignKey(d => d.ManagerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TicketHoldRelease_TerminalManager");

            entity.HasOne(d => d.ReleaseManager).WithMany(p => p.TicketHoldReleaseReleaseManagers)
                .HasForeignKey(d => d.ReleaseManagerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TicketHoldRelease_TerminalManager1");
        });

        modelBuilder.Entity<TicketMain>(entity =>
        {
            entity.HasKey(e => e.TicketNumber);

            entity.ToTable("TicketMain");

            entity.HasIndex(e => e.Etsn, "IX_TicketMain_ESTN").IsUnique();

            entity.Property(e => e.CashedDate).HasColumnType("datetime");
            entity.Property(e => e.CashedOpDate).HasColumnType("datetime");
            entity.Property(e => e.CashedTerminalId).HasColumnName("CashedTerminalID");
            entity.Property(e => e.CashedValue).HasColumnType("money");
            entity.Property(e => e.CurrCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EposPlayerId).HasColumnName("EposPlayerID");
            entity.Property(e => e.Etsn)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ETSN");
            entity.Property(e => e.ExchangeRate).HasColumnType("money");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MoneyChange).HasColumnType("money");
            entity.Property(e => e.SettledOpDate).HasColumnType("datetime");
            entity.Property(e => e.SettledRefund).HasColumnType("money");
            entity.Property(e => e.SettledValue).HasColumnType("money");
            entity.Property(e => e.SoldDate).HasColumnType("datetime");
            entity.Property(e => e.SoldOpDate).HasColumnType("datetime");
            entity.Property(e => e.SoldTerminalId).HasColumnName("SoldTerminalID");
            entity.Property(e => e.SoldValue).HasColumnType("money");
            entity.Property(e => e.TicketType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('S')")
                .IsFixedLength();

            entity.HasOne(d => d.CashedIdUserNavigation).WithMany(p => p.TicketMainCashedIdUserNavigations)
                .HasForeignKey(d => d.CashedIdUser)
                .HasConstraintName("FK_TicketMain_USERS");

            entity.HasOne(d => d.CashedTerminal).WithMany(p => p.TicketMainCashedTerminals)
                .HasForeignKey(d => d.CashedTerminalId)
                .HasConstraintName("FK_TicketMain_Terminal");

            entity.HasOne(d => d.CurrCodeNavigation).WithMany(p => p.TicketMains)
                .HasForeignKey(d => d.CurrCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TicketMain_EposCurrency");

            entity.HasOne(d => d.EposPlayer).WithMany(p => p.TicketMains)
                .HasForeignKey(d => d.EposPlayerId)
                .HasConstraintName("FK_TicketMain_EposPlayer");

            entity.HasOne(d => d.Location).WithMany(p => p.TicketMains)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TicketMain_Location");

            entity.HasOne(d => d.SoldIdUserNavigation).WithMany(p => p.TicketMainSoldIdUserNavigations)
                .HasForeignKey(d => d.SoldIdUser)
                .HasConstraintName("FK_TicketMain_USERS1");

            entity.HasOne(d => d.SoldTerminal).WithMany(p => p.TicketMainSoldTerminals)
                .HasForeignKey(d => d.SoldTerminalId)
                .HasConstraintName("FK_TicketMain_Terminal1");
        });

        modelBuilder.Entity<Tickettemplate>(entity =>
        {
            entity.HasKey(e => e.TicketTemplateId).HasName("PK_TicketTemplate");

            entity.ToTable("TICKETTEMPLATE");

            entity.Property(e => e.TicketTemplateId).HasColumnName("TicketTemplateID");
            entity.Property(e => e.Description)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TicketTemplate1)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("TicketTemplate");
        });

        modelBuilder.Entity<Till>(entity =>
        {
            entity.HasKey(e => e.TillId).HasName("PK_Till");

            entity.ToTable("TILL");

            entity.HasIndex(e => e.Description, "IX_Till_Description").IsUnique();

            entity.Property(e => e.TillId).HasColumnName("TillID");
            entity.Property(e => e.ActiveTillId).HasColumnName("ActiveTillID");
            entity.Property(e => e.Description)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");

            entity.HasOne(d => d.Location).WithMany(p => p.Tills)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TILL_Location");
        });

        modelBuilder.Entity<TillTransact>(entity =>
        {
            entity.ToTable("TillTransact");

            entity.Property(e => e.TillTransactId).HasColumnName("TillTransactID");
            entity.Property(e => e.ActiveTillId).HasColumnName("ActiveTillID");
            entity.Property(e => e.CurrCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CurrencyDiff).HasColumnType("money");
            entity.Property(e => e.ExchangeRate).HasColumnType("money");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.OpDate).HasColumnType("datetime");
            entity.Property(e => e.RefillId).HasColumnName("RefillID");
            entity.Property(e => e.TransactAmount).HasColumnType("money");
            entity.Property(e => e.TransactDateTime).HasColumnType("smalldatetime");
            entity.Property(e => e.TransferId).HasColumnName("TransferID");
            entity.Property(e => e.VoucherId).HasColumnName("VoucherID");

            entity.HasOne(d => d.CurrCodeNavigation).WithMany(p => p.TillTransacts)
                .HasForeignKey(d => d.CurrCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TillTransact_EposCurrency");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.TillTransacts)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK_TillTransact_USERS");

            entity.HasOne(d => d.Location).WithMany(p => p.TillTransacts)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TillTransact_Location");

            entity.HasOne(d => d.Refill).WithMany(p => p.TillTransacts)
                .HasForeignKey(d => d.RefillId)
                .HasConstraintName("FK_TillTransact_RefillTill");

            entity.HasOne(d => d.TicketNumberNavigation).WithMany(p => p.TillTransacts)
                .HasForeignKey(d => d.TicketNumber)
                .HasConstraintName("FK_TillTransact_TicketMain");

            entity.HasOne(d => d.Transfer).WithMany(p => p.TillTransacts)
                .HasForeignKey(d => d.TransferId)
                .HasConstraintName("FK_TillTransact_EposSportsbookTransfer");

            entity.HasOne(d => d.Voucher).WithMany(p => p.TillTransacts)
                .HasForeignKey(d => d.VoucherId)
                .HasConstraintName("FK_TillTransact_Voucher");
        });

        modelBuilder.Entity<Timezone>(entity =>
        {
            entity.HasKey(e => e.IdTimeZone);

            entity.ToTable("TIMEZONE");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gmt)
                .HasDefaultValueSql("((-100.0))")
                .HasColumnName("GMT");
        });

        modelBuilder.Entity<Track>(entity =>
        {
            entity.ToTable("Track");

            entity.HasIndex(e => e.TrackCode, "IX_Track_TrackCode").IsUnique();

            entity.Property(e => e.TrackId).HasColumnName("TrackID");
            entity.Property(e => e.AmtoteTrackCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.DefaultPostCutoff).HasDefaultValueSql("((-1))");
            entity.Property(e => e.Enabled)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.ShortName)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.TrackCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.TrackName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TrackTimeZone)
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TrackAmtote>(entity =>
        {
            entity.HasKey(e => new { e.TrackId, e.BetType });

            entity.ToTable("TrackAmtote");

            entity.Property(e => e.TrackId).HasColumnName("TrackID");
            entity.Property(e => e.Threshold).HasColumnType("smallmoney");

            entity.HasOne(d => d.Track).WithMany(p => p.TrackAmtotes)
                .HasForeignKey(d => d.TrackId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TrackAmtote_Track");
        });

        modelBuilder.Entity<TwCasinoLiveTransControl>(entity =>
        {
            entity.HasKey(e => e.Idtran);

            entity.ToTable("TW_CasinoLiveTransControl");

            entity.Property(e => e.Idtran).HasColumnName("IDTran");
            entity.Property(e => e.CasinoLiveTransId)
                .HasMaxLength(50)
                .HasColumnName("CasinoLiveTransID");
            entity.Property(e => e.Dgstransaction).HasColumnName("DGSTransaction");
            entity.Property(e => e.Player)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Reg).HasColumnType("datetime");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TwGameScoresChecker>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TW_GameScoresChecker");

            entity.Property(e => e.Check).HasColumnName("check");
            entity.Property(e => e.Doublecheck).HasColumnName("doublecheck");
            entity.Property(e => e.Idgame).HasColumnName("idgame");
            entity.Property(e => e.Regdate)
                .HasColumnType("datetime")
                .HasColumnName("regdate");
        });

        modelBuilder.Entity<TwGradeLog>(entity =>
        {
            entity.HasKey(e => e.IdLog);

            entity.ToTable("TW_Grade_LOG");

            entity.Property(e => e.IdLog).HasColumnName("IdLOG");
            entity.Property(e => e.Idwager).HasColumnName("IDWager");
            entity.Property(e => e.Log).HasColumnName("LOG");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TwLoginRequest>(entity =>
        {
            entity.ToTable("TW_LoginRequest");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Idplayer).HasColumnName("idplayer");
            entity.Property(e => e.Otp)
                .IsUnicode(false)
                .HasColumnName("OTP");
            entity.Property(e => e.Player)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("player");
            entity.Property(e => e.Reg)
                .HasColumnType("datetime")
                .HasColumnName("reg");
        });

        modelBuilder.Entity<TwMarketingOfficeStat>(entity =>
        {
            entity.ToTable("TW_MARKETING_OFFICE_STATS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Agentcount).HasColumnName("AGENTCOUNT");
            entity.Property(e => e.Agentsignup).HasColumnName("AGENTSIGNUP");
            entity.Property(e => e.Playercount).HasColumnName("PLAYERCOUNT");
            entity.Property(e => e.Playersignup).HasColumnName("PLAYERSIGNUP");
            entity.Property(e => e.Riskaction)
                .HasColumnType("money")
                .HasColumnName("RISKACTION");
            entity.Property(e => e.Wagercount).HasColumnName("WAGERCOUNT");
            entity.Property(e => e.Weekstartdate)
                .HasColumnType("datetime")
                .HasColumnName("WEEKSTARTDATE");
        });

        modelBuilder.Entity<TwOgsSessioncontrol>(entity =>
        {
            entity.HasKey(e => e.Idsession);

            entity.ToTable("TW_OGS_Sessioncontrol");

            entity.Property(e => e.Idsession).HasColumnName("idsession");
            entity.Property(e => e.Datetime).HasColumnType("datetime");
            entity.Property(e => e.Player)
                .HasMaxLength(50)
                .HasColumnName("player");
            entity.Property(e => e.Session).HasMaxLength(100);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
        });

        modelBuilder.Entity<TwRichieTempBalance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TW_RICHIE_TEMP_BALANCE");

            entity.Property(e => e.Bow)
                .HasColumnType("money")
                .HasColumnName("bow");
            entity.Property(e => e.Currentbalance)
                .HasColumnType("money")
                .HasColumnName("currentbalance");
            entity.Property(e => e.Historybalance)
                .HasColumnType("money")
                .HasColumnName("historybalance");
            entity.Property(e => e.Idplayer).HasColumnName("IDPLAYER");
            entity.Property(e => e.Player)
                .HasMaxLength(10)
                .HasColumnName("player");
        });

        modelBuilder.Entity<TwSiteIdcontrolClive>(entity =>
        {
            entity.HasKey(e => e.Idsite);

            entity.ToTable("TW_SiteIDControlCLive");

            entity.Property(e => e.Idsite).HasColumnName("IDsite");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.SiteIdchar)
                .HasMaxLength(50)
                .HasColumnName("SiteIDChar");
        });

        modelBuilder.Entity<TwSptUserLogAction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TW_SPT_UserLog_Action");

            entity.Property(e => e.Idlog)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDLOG");
            entity.Property(e => e.Iduser).HasColumnName("IDUSER");
            entity.Property(e => e.Note).HasColumnName("NOTE");
            entity.Property(e => e.Regdate)
                .HasComment("Save action for user when using the SuperTool , Richie vargas ")
                .HasColumnType("datetime")
                .HasColumnName("REGDATE");
        });

        modelBuilder.Entity<Ungradedwagerdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UNGRADEDWAGERDETAIL");

            entity.Property(e => e.ChartDetailRisk).HasColumnType("money");
            entity.Property(e => e.ChartDetailWin).HasColumnType("money");
            entity.Property(e => e.CompleteDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.GameDateTime).HasColumnType("datetime");
            entity.Property(e => e.HomePitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hscore).HasColumnName("HScore");
            entity.Property(e => e.IdEvent).HasComment("Event.IdEvent. 0= is a match");
            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.IfbetAmount).HasColumnType("money");
            entity.Property(e => e.MasterChartDetailRisk).HasColumnType("money");
            entity.Property(e => e.MasterChartDetailWin).HasColumnType("money");
            entity.Property(e => e.SumChartDetailRisk).HasColumnType("money");
            entity.Property(e => e.SumChartDetailWin).HasColumnType("money");
            entity.Property(e => e.VisitorPitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Vscore).HasColumnName("VScore");
        });

        modelBuilder.Entity<Ungradedwagerheader>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UNGRADEDWAGERHEADER");

            entity.Property(e => e.CompleteDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CrrnumDetails).HasColumnName("CRRNumDetails");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Epos).HasColumnName("EPOS");
            entity.Property(e => e.Epospaid).HasColumnName("EPOSPaid");
            entity.Property(e => e.IdBook).HasDefaultValueSql("((1))");
            entity.Property(e => e.IdcardHeader).HasColumnName("IDCardHeader");
            entity.Property(e => e.IfBetRiskAmount).HasColumnType("money");
            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.MoneyChange).HasColumnType("money");
            entity.Property(e => e.OriginalRiskAmount).HasColumnType("money");
            entity.Property(e => e.OriginalWagerAmount).HasColumnType("money");
            entity.Property(e => e.OriginalWinAmount).HasColumnType("money");
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
            entity.Property(e => e.RiskAmount).HasColumnType("money");
            entity.Property(e => e.SettledDate).HasColumnType("datetime");
            entity.Property(e => e.TaxAmount).HasColumnType("money");
            entity.Property(e => e.WagerType).HasDefaultValueSql("((1))");
            entity.Property(e => e.WinAmount).HasColumnType("money");
        });

        modelBuilder.Entity<UpdTbchange>(entity =>
        {
            entity.HasKey(e => e.IdChange);

            entity.ToTable("upd_tbchanges");

            entity.Property(e => e.AwayNss)
                .HasMaxLength(10)
                .HasColumnName("AwayNSS");
            entity.Property(e => e.AwayOdds).HasMaxLength(10);
            entity.Property(e => e.AwayScore).HasMaxLength(10);
            entity.Property(e => e.AwaySpread).HasMaxLength(10);
            entity.Property(e => e.AwaySpreadOdds).HasMaxLength(10);
            entity.Property(e => e.AwayStatus).HasMaxLength(10);
            entity.Property(e => e.AwayTotal).HasMaxLength(10);
            entity.Property(e => e.AwayTotalOdds).HasMaxLength(10);
            entity.Property(e => e.Draw).HasMaxLength(10);
            entity.Property(e => e.HomeNss)
                .HasMaxLength(10)
                .HasColumnName("HomeNSS");
            entity.Property(e => e.HomeOdds).HasMaxLength(10);
            entity.Property(e => e.HomeScore).HasMaxLength(10);
            entity.Property(e => e.HomeSpread).HasMaxLength(10);
            entity.Property(e => e.HomeSpreadOdds).HasMaxLength(10);
            entity.Property(e => e.HomeStatus).HasMaxLength(10);
            entity.Property(e => e.HomeTotal).HasMaxLength(10);
            entity.Property(e => e.HomeTotalOdds).HasMaxLength(10);
            entity.Property(e => e.IdBook).HasMaxLength(20);
            entity.Property(e => e.IdLeague).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.IdUser).HasName("PK_USER");

            entity.ToTable("USERS");

            entity.HasIndex(e => e.LoginName, "IX_USERS").IsUnique();

            entity.Property(e => e.IdDepartment).HasDefaultValueSql("((1))");
            entity.Property(e => e.LastLogin).HasColumnType("datetime");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.LoginName)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.ResetPassword).HasColumnName("Reset_Password");
            entity.Property(e => e.Type).HasComment("0=Regular user, 1=Internet acess, >=2 others");

            entity.HasOne(d => d.IdDepartmentNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdDepartment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USERS_DEPARTMENT");

            entity.HasOne(d => d.IdLanguageNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdLanguage)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USERS_Language");

            entity.HasOne(d => d.IdUserProfileNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdUserProfile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_USERPROFILE");

            entity.HasMany(d => d.IdBooks).WithMany(p => p.IdUsers)
                .UsingEntity<Dictionary<string, object>>(
                    "Usersbook",
                    r => r.HasOne<Book>().WithMany()
                        .HasForeignKey("IdBook")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_USERSBOOK_BOOK"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_USERSBOOK_USERS"),
                    j =>
                    {
                        j.HasKey("IdUser", "IdBook");
                        j.ToTable("USERSBOOK");
                    });

            entity.HasMany(d => d.IdLanguages).WithMany(p => p.IdUsers)
                .UsingEntity<Dictionary<string, object>>(
                    "Userslanguage",
                    r => r.HasOne<Language>().WithMany()
                        .HasForeignKey("IdLanguage")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_USERSLANGUAGE_Language"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_USERSLANGUAGE_USERS"),
                    j =>
                    {
                        j.HasKey("IdUser", "IdLanguage");
                        j.ToTable("USERSLANGUAGE");
                    });

            entity.HasMany(d => d.IdLineTypes).WithMany(p => p.IdUsers)
                .UsingEntity<Dictionary<string, object>>(
                    "Tickeruserlinetype",
                    r => r.HasOne<Linetype>().WithMany()
                        .HasForeignKey("IdLineType")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_TICKERUSERLINETYPE_LINETYPE"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_TICKERUSERLINETYPE_USERS"),
                    j =>
                    {
                        j.HasKey("IdUser", "IdLineType");
                        j.ToTable("TICKERUSERLINETYPE");
                    });

            entity.HasMany(d => d.IdLineTypesNavigation).WithMany(p => p.IdUsers1)
                .UsingEntity<Dictionary<string, object>>(
                    "Userlinetype",
                    r => r.HasOne<Linetype>().WithMany()
                        .HasForeignKey("IdLineType")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_USERLINETYPE_LINETYPE"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_USERLINETYPE_USERS"),
                    j =>
                    {
                        j.HasKey("IdUser", "IdLineType");
                        j.ToTable("USERLINETYPE");
                    });

            entity.HasMany(d => d.IdlineTypes).WithMany(p => p.IdUsersNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "Userchartconfiguration",
                    r => r.HasOne<Linetype>().WithMany()
                        .HasForeignKey("IdlineType")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_USERCHARTCONFIGURATION_LINETYPE"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_USERCHARTCONFIGURATION_USERS"),
                    j =>
                    {
                        j.HasKey("IdUser", "IdlineType");
                        j.ToTable("USERCHARTCONFIGURATION");
                        j.IndexerProperty<short>("IdlineType").HasColumnName("IDLineType");
                    });
        });

        modelBuilder.Entity<Userlogon>(entity =>
        {
            entity.HasKey(e => e.LogonSessionId);

            entity.ToTable("USERLOGONS");

            entity.Property(e => e.LogonSessionId).HasColumnName("LogonSessionID");
            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.LoginTime).HasColumnType("datetime");
            entity.Property(e => e.System)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Userlogons)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USERLOGONS_USER");
        });

        modelBuilder.Entity<Userlogonslog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("USERLOGONSLOG");

            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.LoginTime).HasColumnType("datetime");
            entity.Property(e => e.LogonSessionId).HasColumnName("LogonSessionID");
            entity.Property(e => e.LogoutTime).HasColumnType("datetime");
            entity.Property(e => e.System)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usermessage>(entity =>
        {
            entity.HasKey(e => e.IdUserMessage);

            entity.ToTable("USERMESSAGE");

            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.Message)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Usermessages)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USERMESSAGE_USER");
        });

        modelBuilder.Entity<Userprofile>(entity =>
        {
            entity.HasKey(e => e.IdUserProfile);

            entity.ToTable("USERPROFILE");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.ProfileName)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasMany(d => d.IdUserProfileSources).WithMany(p => p.IdUserProfileTargets)
                .UsingEntity<Dictionary<string, object>>(
                    "Userprofilemsg",
                    r => r.HasOne<Userprofile>().WithMany()
                        .HasForeignKey("IdUserProfileSource")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_USERPROFILESMSG_USERPROFILE"),
                    l => l.HasOne<Userprofile>().WithMany()
                        .HasForeignKey("IdUserProfileTarget")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_USERPROFILESMSG_USERPROFILE1"),
                    j =>
                    {
                        j.HasKey("IdUserProfileSource", "IdUserProfileTarget").HasName("PK_USERPROFILESMSG");
                        j.ToTable("USERPROFILEMSG");
                    });

            entity.HasMany(d => d.IdUserProfileTargets).WithMany(p => p.IdUserProfileSources)
                .UsingEntity<Dictionary<string, object>>(
                    "Userprofilemsg",
                    r => r.HasOne<Userprofile>().WithMany()
                        .HasForeignKey("IdUserProfileTarget")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_USERPROFILESMSG_USERPROFILE1"),
                    l => l.HasOne<Userprofile>().WithMany()
                        .HasForeignKey("IdUserProfileSource")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_USERPROFILESMSG_USERPROFILE"),
                    j =>
                    {
                        j.HasKey("IdUserProfileSource", "IdUserProfileTarget").HasName("PK_USERPROFILESMSG");
                        j.ToTable("USERPROFILEMSG");
                    });
        });

        modelBuilder.Entity<Userprofileright>(entity =>
        {
            entity.HasKey(e => new { e.IdUserProfile, e.IdRight, e.IdForm }).HasName("PK_USERPROFILERIGHT");

            entity.ToTable("USERPROFILERIGHTS");

            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdFormNavigation).WithMany(p => p.Userprofilerights)
                .HasForeignKey(d => d.IdForm)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USERPROFILERIGHT_FORM");

            entity.HasOne(d => d.IdRightNavigation).WithMany(p => p.Userprofilerights)
                .HasForeignKey(d => d.IdRight)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USERPROFILERIGHT_RIGHT");

            entity.HasOne(d => d.IdUserProfileNavigation).WithMany(p => p.Userprofilerights)
                .HasForeignKey(d => d.IdUserProfile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USERPROFILERIGHT_USERPROFILE");
        });

        modelBuilder.Entity<Userprofilerightslog>(entity =>
        {
            entity.HasKey(e => e.IdLog);

            entity.ToTable("USERPROFILERIGHTSLOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.NewValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Userright>(entity =>
        {
            entity.HasKey(e => new { e.IdUser, e.IdForm, e.IdRight }).HasName("PK_USERRIGHT");

            entity.ToTable("USERRIGHTS");

            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdFormNavigation).WithMany(p => p.Userrights)
                .HasForeignKey(d => d.IdForm)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USERRIGHT_FORM");

            entity.HasOne(d => d.IdRightNavigation).WithMany(p => p.Userrights)
                .HasForeignKey(d => d.IdRight)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USERRIGHT_RIGHT");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Userrights)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USERRIGHT_USER");
        });

        modelBuilder.Entity<Userrightslog>(entity =>
        {
            entity.HasKey(e => e.IdLog);

            entity.ToTable("USERRIGHTSLOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.NewValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Usersactionlog>(entity =>
        {
            entity.HasKey(e => e.IdUserActionLog);

            entity.ToTable("USERSACTIONLOG");

            entity.Property(e => e.AccessDate).HasColumnType("datetime");
            entity.Property(e => e.AccountType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
        });

        modelBuilder.Entity<Usersdeleted>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("USERSDELETED");

            entity.Property(e => e.LastLogin).HasColumnType("datetime");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.LoginName)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Type).HasComment("");

            entity.HasOne(d => d.IdLanguageNavigation).WithMany()
                .HasForeignKey(d => d.IdLanguage)
                .HasConstraintName("FK_USERSDELETED_Language");
        });

        modelBuilder.Entity<Userslog>(entity =>
        {
            entity.HasKey(e => e.IdUserLog).HasName("PK_USERLOG");

            entity.ToTable("USERSLOG");

            entity.Property(e => e.FieldName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.NewValue)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OldValue)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Vipaccount>(entity =>
        {
            entity.HasKey(e => e.DgsaccountId);

            entity.ToTable("VIPAccount");

            entity.Property(e => e.DgsaccountId).HasColumnName("DGSAccountID");
            entity.Property(e => e.AccountId).HasColumnName("AccountID");
            entity.Property(e => e.AccountName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LicenseId).HasColumnName("LicenseID");
        });

        modelBuilder.Entity<VipuserSession>(entity =>
        {
            entity.HasKey(e => e.DgsuserId);

            entity.ToTable("VIPUserSession");

            entity.Property(e => e.DgsuserId).HasColumnName("DGSUserID");
            entity.Property(e => e.AccountId).HasColumnName("AccountID");
            entity.Property(e => e.LicenseId).HasColumnName("LicenseID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserSessionId).HasColumnName("UserSessionID");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.ToTable("Voucher");

            entity.HasIndex(e => e.VoucherId, "IX_Voucher_VoucherNum").IsUnique();

            entity.Property(e => e.VoucherId).HasColumnName("VoucherID");
            entity.Property(e => e.CurrBalance).HasColumnType("money");
            entity.Property(e => e.CurrCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CurrOriginalBalance).HasColumnType("money");
            entity.Property(e => e.CurrRedeemedBalance).HasColumnType("money");
            entity.Property(e => e.IssuedDateTime).HasColumnType("datetime");
            entity.Property(e => e.IssuedOpDate).HasColumnType("datetime");
            entity.Property(e => e.IssuedTerminalId).HasColumnName("IssuedTerminalID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.RedeemedDateTime).HasColumnType("datetime");
            entity.Property(e => e.RedeemedOpDate).HasColumnType("datetime");
            entity.Property(e => e.VoucherNum)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.CurrCodeNavigation).WithMany(p => p.Vouchers)
                .HasForeignKey(d => d.CurrCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Voucher_EposCurrency");

            entity.HasOne(d => d.IssuedTerminal).WithMany(p => p.Vouchers)
                .HasForeignKey(d => d.IssuedTerminalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Voucher_Terminal");

            entity.HasOne(d => d.Location).WithMany(p => p.Vouchers)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Voucher_Location");
        });

        modelBuilder.Entity<VoucherTemplate>(entity =>
        {
            entity.ToTable("VoucherTemplate");

            entity.Property(e => e.VoucherTemplateId).HasColumnName("VoucherTemplateID");
            entity.Property(e => e.Description)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.VoucherTemplate1)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("VoucherTemplate");
        });

        modelBuilder.Entity<VoucherTran>(entity =>
        {
            entity.HasKey(e => e.VtransId);

            entity.Property(e => e.VtransId).HasColumnName("VTransID");
            entity.Property(e => e.ActiveTillId).HasColumnName("ActiveTillID");
            entity.Property(e => e.CurrAmount).HasColumnType("money");
            entity.Property(e => e.CurrCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.NewVoucherId).HasColumnName("NewVoucherID");
            entity.Property(e => e.OpDate).HasColumnType("datetime");
            entity.Property(e => e.TransactDateTime).HasColumnType("datetime");
            entity.Property(e => e.VoucherId).HasColumnName("VoucherID");

            entity.HasOne(d => d.CurrCodeNavigation).WithMany(p => p.VoucherTrans)
                .HasForeignKey(d => d.CurrCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherTrans_EposCurrency");

            entity.HasOne(d => d.Location).WithMany(p => p.VoucherTrans)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherTrans_Location");

            entity.HasOne(d => d.NewVoucher).WithMany(p => p.VoucherTranNewVouchers)
                .HasForeignKey(d => d.NewVoucherId)
                .HasConstraintName("FK_VoucherTrans_Voucher1");

            entity.HasOne(d => d.TicketNumberNavigation).WithMany(p => p.VoucherTrans)
                .HasForeignKey(d => d.TicketNumber)
                .HasConstraintName("FK_VoucherTrans_TicketMain");

            entity.HasOne(d => d.Voucher).WithMany(p => p.VoucherTranVouchers)
                .HasForeignKey(d => d.VoucherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherTrans_Voucher");
        });

        modelBuilder.Entity<Wagerdetail>(entity =>
        {
            entity.HasKey(e => new { e.IdWager, e.IdWagerDetail });

            entity.ToTable("WAGERDETAIL");

            entity.Property(e => e.IdWagerDetail).ValueGeneratedOnAdd();
            entity.Property(e => e.ChartDetailRisk).HasColumnType("money");
            entity.Property(e => e.ChartDetailWin).HasColumnType("money");
            entity.Property(e => e.CompleteDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.GameDateTime).HasColumnType("datetime");
            entity.Property(e => e.HomePitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hscore).HasColumnName("HScore");
            entity.Property(e => e.IdEvent).HasComment("Event.IdEvent. 0= is a match");
            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.IfbetAmount).HasColumnType("money");
            entity.Property(e => e.MasterChartDetailRisk).HasColumnType("money");
            entity.Property(e => e.MasterChartDetailWin).HasColumnType("money");
            entity.Property(e => e.SumChartDetailRisk).HasColumnType("money");
            entity.Property(e => e.SumChartDetailWin).HasColumnType("money");
            entity.Property(e => e.VisitorPitcher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Vscore).HasColumnName("VScore");

            entity.HasOne(d => d.IdEventNavigation).WithMany(p => p.Wagerdetails)
                .HasForeignKey(d => d.IdEvent)
                .HasConstraintName("FK_WAGERDETAIL_EVENT");

            entity.HasOne(d => d.IdGameNavigation).WithMany(p => p.Wagerdetails)
                .HasForeignKey(d => d.IdGame)
                .HasConstraintName("FK_WAGERDETAIL_GAME");

            entity.HasOne(d => d.IdWagerNavigation).WithMany(p => p.Wagerdetails)
                .HasForeignKey(d => d.IdWager)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WAGERDETAIL_WAGERHEADER");
        });

        modelBuilder.Entity<Wagerheader>(entity =>
        {
            entity.HasKey(e => e.IdWager);

            entity.ToTable("WAGERHEADER");

            entity.Property(e => e.CompleteDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CrrnumDetails).HasColumnName("CRRNumDetails");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Epos).HasColumnName("EPOS");
            entity.Property(e => e.Epospaid).HasColumnName("EPOSPaid");
            entity.Property(e => e.IdBook).HasDefaultValueSql("((1))");
            entity.Property(e => e.IfBetRiskAmount).HasColumnType("money");
            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('0.0.0.0')")
                .HasColumnName("IP");
            entity.Property(e => e.LastModification).HasColumnType("datetime");
            entity.Property(e => e.MoneyChange).HasColumnType("money");
            entity.Property(e => e.OriginalRiskAmount).HasColumnType("money");
            entity.Property(e => e.OriginalWagerAmount).HasColumnType("money");
            entity.Property(e => e.OriginalWinAmount).HasColumnType("money");
            entity.Property(e => e.PlacedDate).HasColumnType("datetime");
            entity.Property(e => e.RiskAmount).HasColumnType("money");
            entity.Property(e => e.SettledDate).HasColumnType("datetime");
            entity.Property(e => e.TaxAmount).HasColumnType("money");
            entity.Property(e => e.WinAmount).HasColumnType("money");

            entity.HasOne(d => d.IdAgentNavigation).WithMany(p => p.Wagerheaders)
                .HasForeignKey(d => d.IdAgent)
                .HasConstraintName("FK_WAGERHEADER_AGENT");

            entity.HasOne(d => d.IdCardHeaderNavigation).WithMany(p => p.Wagerheaders)
                .HasForeignKey(d => d.IdCardHeader)
                .HasConstraintName("FK_WAGERHEADER_CARDHEADER");

            entity.HasOne(d => d.IdLineTypeNavigation).WithMany(p => p.Wagerheaders)
                .HasForeignKey(d => d.IdLineType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WAGERHEADER_LINETYPE");

            entity.HasOne(d => d.IdPlayerNavigation).WithMany(p => p.Wagerheaders)
                .HasForeignKey(d => d.IdPlayer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WAGERHEADER_PLAYER");

            entity.HasOne(d => d.IdProfileNavigation).WithMany(p => p.Wagerheaders)
                .HasForeignKey(d => d.IdProfile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WAGERHEADER_PLAYERPROFILE");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Wagerheaders)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WAGERHEADER_USER");

            entity.HasOne(d => d.IdWagerTypeNavigation).WithMany(p => p.Wagerheaders)
                .HasForeignKey(d => d.IdWagerType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WAGERHEADER_WAGERTYPE");
        });

        modelBuilder.Entity<Wagertracker>(entity =>
        {
            entity.HasKey(e => e.IdwagerTracker);

            entity.ToTable("WAGERTRACKER");

            entity.Property(e => e.LastModification)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Wagertype>(entity =>
        {
            entity.HasKey(e => e.IdWagerType).HasName("PK_WagerType");

            entity.ToTable("WAGERTYPE");

            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.WagerType1).HasColumnName("WagerType");

            entity.HasOne(d => d.IdProfileNavigation).WithMany(p => p.Wagertypes)
                .HasForeignKey(d => d.IdProfile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WAGERTYPE_PLAYERPROFILE");
        });

        modelBuilder.Entity<Wagertypegrouplang>(entity =>
        {
            entity.HasKey(e => new { e.Wagertype, e.IdLanguage });

            entity.ToTable("WAGERTYPEGROUPLANG");

            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdLanguageNavigation).WithMany(p => p.Wagertypegrouplangs)
                .HasForeignKey(d => d.IdLanguage)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WAGERTYPEGROUPLANG_Language");
        });

        modelBuilder.Entity<Wagertypelang>(entity =>
        {
            entity.HasKey(e => new { e.IdWagerType, e.IdLanguage });

            entity.ToTable("WAGERTYPELANG");

            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdLanguageNavigation).WithMany(p => p.Wagertypelangs)
                .HasForeignKey(d => d.IdLanguage)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WAGERTYPELANG_Language");

            entity.HasOne(d => d.IdWagerTypeNavigation).WithMany(p => p.Wagertypelangs)
                .HasForeignKey(d => d.IdWagerType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WAGERTYPELANG_WAGERTYPE");
        });

        modelBuilder.Entity<Wagertypesport>(entity =>
        {
            entity.HasKey(e => new { e.IdWagerType, e.IdSport });

            entity.ToTable("WAGERTYPESPORT");

            entity.Property(e => e.IdSport)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdSportNavigation).WithMany(p => p.Wagertypesports)
                .HasForeignKey(d => d.IdSport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WAGERTYPESPORT_SPORT");

            entity.HasOne(d => d.IdWagerTypeNavigation).WithMany(p => p.Wagertypesports)
                .HasForeignKey(d => d.IdWagerType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WAGERTYPESPORT_WAGERTYPE");
        });

        modelBuilder.Entity<Webcolumn>(entity =>
        {
            entity.HasKey(e => e.IdWebColumn);

            entity.ToTable("WEBCOLUMN");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
        });

        modelBuilder.Entity<Webcolumndetail>(entity =>
        {
            entity.HasKey(e => new { e.IdWebColumn, e.IdWebRow });

            entity.ToTable("WEBCOLUMNDETAIL");

            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdWebColumnNavigation).WithMany(p => p.Webcolumndetails)
                .HasForeignKey(d => d.IdWebColumn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WEBCOLUMNDETAIL_WEBCOLUMN");

            entity.HasOne(d => d.IdWebRowNavigation).WithMany(p => p.Webcolumndetails)
                .HasForeignKey(d => d.IdWebRow)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WEBCOLUMNDETAIL_WEBROW");
        });

        modelBuilder.Entity<Webrow>(entity =>
        {
            entity.HasKey(e => e.IdWebRow);

            entity.ToTable("WEBROW");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastModification).HasColumnType("datetime");
        });

        modelBuilder.Entity<Webrowdetail>(entity =>
        {
            entity.HasKey(e => new { e.IdWebRow, e.IdLeague });

            entity.ToTable("WEBROWDETAIL");

            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdLeagueNavigation).WithMany(p => p.Webrowdetails)
                .HasForeignKey(d => d.IdLeague)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WEBROWDETAIL_LEAGUE");

            entity.HasOne(d => d.IdWebRowNavigation).WithMany(p => p.Webrowdetails)
                .HasForeignKey(d => d.IdWebRow)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WEBROWDETAIL_WEBROW");
        });

        modelBuilder.Entity<Webrowlang>(entity =>
        {
            entity.HasKey(e => new { e.IdWebRow, e.IdLanguage });

            entity.ToTable("WEBROWLANG");

            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.LastModification).HasColumnType("datetime");

            entity.HasOne(d => d.IdLanguageNavigation).WithMany(p => p.Webrowlangs)
                .HasForeignKey(d => d.IdLanguage)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WEBROWLANG_Language");

            entity.HasOne(d => d.IdWebRowNavigation).WithMany(p => p.Webrowlangs)
                .HasForeignKey(d => d.IdWebRow)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WEBROWLANG_WEBROW");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
