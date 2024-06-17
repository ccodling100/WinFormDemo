namespace DGSDataUtils.Entities.DGSEntities;

public partial class User
{
    public short IdUser { get; set; }

    public short IdUserProfile { get; set; }

    public int IdDepartment { get; set; }

    public string LoginName { get; set; } = null!;

    public string? Name { get; set; }

    public string Password { get; set; } = null!;

    public DateTime? LastLogin { get; set; }

    public bool Status { get; set; }

    /// <summary>
    /// 0=Regular user, 1=Internet acess, &gt;=2 others
    /// </summary>
    public byte Type { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public bool ResetPassword { get; set; }

    public byte IdLanguage { get; set; }

    public virtual ICollection<EposSportsbookTransfer> EposSportsbookTransfers { get; set; } = new List<EposSportsbookTransfer>();

    public virtual ICollection<EposVoid> EposVoids { get; set; } = new List<EposVoid>();

    public virtual Department IdDepartmentNavigation { get; set; } = null!;

    public virtual Language IdLanguageNavigation { get; set; } = null!;

    public virtual Userprofile IdUserProfileNavigation { get; set; } = null!;

    public virtual ICollection<Pendingwagerheader> Pendingwagerheaders { get; set; } = new List<Pendingwagerheader>();

    public virtual ICollection<Playerlogon> Playerlogons { get; set; } = new List<Playerlogon>();

    public virtual ICollection<SmtolinksLog> SmtolinksLogs { get; set; } = new List<SmtolinksLog>();

    public virtual ICollection<Systemservicesreg> Systemservicesregs { get; set; } = new List<Systemservicesreg>();

    public virtual ICollection<TerminalSessionActive> TerminalSessionActives { get; set; } = new List<TerminalSessionActive>();

    public virtual ICollection<TerminalSessionClosed> TerminalSessionCloseds { get; set; } = new List<TerminalSessionClosed>();

    public virtual Tickerconfiguration? Tickerconfiguration { get; set; }

    public virtual ICollection<TicketMain> TicketMainCashedIdUserNavigations { get; set; } = new List<TicketMain>();

    public virtual ICollection<TicketMain> TicketMainSoldIdUserNavigations { get; set; } = new List<TicketMain>();

    public virtual ICollection<TillTransact> TillTransacts { get; set; } = new List<TillTransact>();

    public virtual ICollection<Userlogon> Userlogons { get; set; } = new List<Userlogon>();

    public virtual ICollection<Usermessage> Usermessages { get; set; } = new List<Usermessage>();

    public virtual ICollection<Userright> Userrights { get; set; } = new List<Userright>();

    public virtual ICollection<Wagerheader> Wagerheaders { get; set; } = new List<Wagerheader>();

    public virtual ICollection<Book> IdBooks { get; set; } = new List<Book>();

    public virtual ICollection<Language> IdLanguages { get; set; } = new List<Language>();

    public virtual ICollection<Linetype> IdLineTypes { get; set; } = new List<Linetype>();

    public virtual ICollection<Linetype> IdLineTypesNavigation { get; set; } = new List<Linetype>();

    public virtual ICollection<Linetype> IdlineTypes { get; set; } = new List<Linetype>();
}
