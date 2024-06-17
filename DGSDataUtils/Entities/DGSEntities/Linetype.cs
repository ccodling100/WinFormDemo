namespace DGSDataUtils.Entities.DGSEntities;

public partial class Linetype
{
    public short IdLineType { get; set; }

    public string Description { get; set; } = null!;

    public bool FbbbspreadSync { get; set; }

    public bool FbbbspreadOddsSync { get; set; }

    public bool FbbbtotalSync { get; set; }

    public bool FbbbtotalOddsSync { get; set; }

    public bool FbbbmoneyLineSync { get; set; }

    public bool MlbmoneyLineSync { get; set; }

    public byte Mlbincrease { get; set; }

    public bool MlbrunSync { get; set; }

    public bool MlbrunOddsSync { get; set; }

    public bool MlbtotalSync { get; set; }

    public bool MlbtotalOddsSync { get; set; }

    public bool MuspreadSync { get; set; }

    public bool MuspreadOddsSync { get; set; }

    public bool MutotalSync { get; set; }

    public bool MutotalOddsSync { get; set; }

    public bool MumoneyLineSync { get; set; }

    public byte Nbaincrease { get; set; }

    public bool NhlamericanSync { get; set; }

    public bool NhlamericanOddsSync { get; set; }

    public bool NhlcanadianSync { get; set; }

    public bool NhlcanadianOddsSync { get; set; }

    public bool NhlmoneyLineSync { get; set; }

    public bool NhltotalSync { get; set; }

    public bool NhltotalOddsSync { get; set; }

    public bool SocgoalsSync { get; set; }

    public bool SocgoalsOddsSync { get; set; }

    public bool SocmoneyLineSync { get; set; }

    public bool SoctotalSync { get; set; }

    public bool SoctotalOddsSync { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public byte Nhlincrease { get; set; }

    public virtual ICollection<Agentlinetype> Agentlinetypes { get; set; } = new List<Agentlinetype>();

    public virtual ICollection<Agent> Agents { get; set; } = new List<Agent>();

    public virtual ICollection<Gameaction> Gameactions { get; set; } = new List<Gameaction>();

    public virtual ICollection<Gametntpropaction> Gametntpropactions { get; set; } = new List<Gametntpropaction>();

    public virtual ICollection<Gamevalue> Gamevalues { get; set; } = new List<Gamevalue>();

    public virtual ICollection<Gamevalueslog> Gamevalueslogs { get; set; } = new List<Gamevalueslog>();

    public virtual ICollection<Juicerebate> Juicerebates { get; set; } = new List<Juicerebate>();

    public virtual ICollection<LineSubscriber> LineSubscribers { get; set; } = new List<LineSubscriber>();

    public virtual Linetypeflag? Linetypeflag { get; set; }

    public virtual ICollection<Linetypelink> LinetypelinkIdLineTypeInNavigations { get; set; } = new List<Linetypelink>();

    public virtual ICollection<Linetypelink> LinetypelinkIdLineTypeOutNavigations { get; set; } = new List<Linetypelink>();

    public virtual ICollection<Oddsbysport> Oddsbysports { get; set; } = new List<Oddsbysport>();

    public virtual ICollection<Pendingwagerheader> Pendingwagerheaders { get; set; } = new List<Pendingwagerheader>();

    public virtual ICollection<Player> Players { get; set; } = new List<Player>();

    public virtual ICollection<SmtogameValueAdjustment> SmtogameValueAdjustments { get; set; } = new List<SmtogameValueAdjustment>();

    public virtual ICollection<SmtoleagueAdjustment> SmtoleagueAdjustments { get; set; } = new List<SmtoleagueAdjustment>();

    public virtual ICollection<Smtolimit> Smtolimits { get; set; } = new List<Smtolimit>();

    public virtual ICollection<SmtolineTypeBookLink> SmtolineTypeBookLinks { get; set; } = new List<SmtolineTypeBookLink>();

    public virtual ICollection<SmtolinksLog> SmtolinksLogs { get; set; } = new List<SmtolinksLog>();

    public virtual ICollection<SmtologArchive> SmtologArchives { get; set; } = new List<SmtologArchive>();

    public virtual ICollection<Smtolog> Smtologs { get; set; } = new List<Smtolog>();

    public virtual ICollection<Systemchangedline> Systemchangedlines { get; set; } = new List<Systemchangedline>();

    public virtual ICollection<Wagerheader> Wagerheaders { get; set; } = new List<Wagerheader>();

    public virtual ICollection<User> IdUsers { get; set; } = new List<User>();

    public virtual ICollection<User> IdUsers1 { get; set; } = new List<User>();

    public virtual ICollection<User> IdUsersNavigation { get; set; } = new List<User>();
}
