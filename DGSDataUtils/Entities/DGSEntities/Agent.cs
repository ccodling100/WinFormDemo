namespace DGSDataUtils.Entities.DGSEntities;

public partial class Agent
{
    public int IdAgent { get; set; }

    public short IdCurrency { get; set; }

    public short IdBook { get; set; }

    public string Agent1 { get; set; } = null!;

    public byte IdAgentType { get; set; }

    public short? IdGrouping { get; set; }

    public int? Distributor { get; set; }

    public string Password { get; set; } = null!;

    public bool? Enable { get; set; }

    public string? Name { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public string? Zip { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public bool IsDistributor { get; set; }

    public bool DontXferPlayerActivity { get; set; }

    public bool? IsDistributed { get; set; }

    public byte CommSports { get; set; }

    public byte CommCasino { get; set; }

    public byte CommHorses { get; set; }

    /// <summary>
    /// if 1, the agent can access the agent site
    /// </summary>
    public bool? OnlineAccess { get; set; }

    /// <summary>
    /// Online message for agents in the agent site
    /// </summary>
    public string? OnlineMessage { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public short? IdLineType { get; set; }

    public bool ResetPassword { get; set; }

    public int? IdAgentPerHead { get; set; }

    public byte? IdLanguage { get; set; }

    public bool? MasterAgentEnabled { get; set; }

    public virtual Affilstat? Affilstat { get; set; }

    public virtual ICollection<Affiltrack> Affiltracks { get; set; } = new List<Affiltrack>();

    public virtual ICollection<Agentaccounting> Agentaccountings { get; set; } = new List<Agentaccounting>();

    public virtual ICollection<Agentlinetype> Agentlinetypes { get; set; } = new List<Agentlinetype>();

    public virtual ICollection<Agentlogon> Agentlogons { get; set; } = new List<Agentlogon>();

    public virtual Agentnote? Agentnote { get; set; }

    public virtual Agentstatistic? Agentstatistic { get; set; }

    public virtual ICollection<Agenttransaction> Agenttransactions { get; set; } = new List<Agenttransaction>();

    public virtual ICollection<Agentweeklybalance> Agentweeklybalances { get; set; } = new List<Agentweeklybalance>();

    public virtual Agent? DistributorNavigation { get; set; }

    public virtual ICollection<Gameactionbyagent> Gameactionbyagents { get; set; } = new List<Gameactionbyagent>();

    public virtual ICollection<Gametntpropbyagentlog> Gametntpropbyagentlogs { get; set; } = new List<Gametntpropbyagentlog>();

    public virtual ICollection<Gametntpropbyagent> Gametntpropbyagents { get; set; } = new List<Gametntpropbyagent>();

    public virtual ICollection<Gamevaluesbyagent> Gamevaluesbyagents { get; set; } = new List<Gamevaluesbyagent>();

    public virtual ICollection<Gradedgameactionbyagent> Gradedgameactionbyagents { get; set; } = new List<Gradedgameactionbyagent>();

    public virtual ICollection<Gradedgametntpropbyagentlog> Gradedgametntpropbyagentlogs { get; set; } = new List<Gradedgametntpropbyagentlog>();

    public virtual ICollection<Gradedgametntpropbyagent> Gradedgametntpropbyagents { get; set; } = new List<Gradedgametntpropbyagent>();

    public virtual ICollection<Gradedgamevaluesbyagentlog> Gradedgamevaluesbyagentlogs { get; set; } = new List<Gradedgamevaluesbyagentlog>();

    public virtual ICollection<Gradedgamevaluesbyagent> Gradedgamevaluesbyagents { get; set; } = new List<Gradedgamevaluesbyagent>();

    public virtual Agentperhead? IdAgentPerHeadNavigation { get; set; }

    public virtual Agenttype IdAgentTypeNavigation { get; set; } = null!;

    public virtual Book IdBookNavigation { get; set; } = null!;

    public virtual Currency IdCurrencyNavigation { get; set; } = null!;

    public virtual Grouping? IdGroupingNavigation { get; set; }

    public virtual Language? IdLanguageNavigation { get; set; }

    public virtual Linetype? IdLineTypeNavigation { get; set; }

    public virtual ICollection<Agent> InverseDistributorNavigation { get; set; } = new List<Agent>();

    public virtual ICollection<Pendingwagerheader> Pendingwagerheaders { get; set; } = new List<Pendingwagerheader>();

    public virtual ICollection<Player> Players { get; set; } = new List<Player>();

    public virtual ICollection<SmtoagentGameValueAdjustment> SmtoagentGameValueAdjustments { get; set; } = new List<SmtoagentGameValueAdjustment>();

    public virtual ICollection<Wagerheader> Wagerheaders { get; set; } = new List<Wagerheader>();
}
