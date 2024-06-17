namespace DGSDataUtils.Entities.DGSEntities;

public partial class Wagertype
{
    public int IdWagerType { get; set; }

    public short IdProfile { get; set; }

    public string Description { get; set; } = null!;

    public byte NumTeams { get; set; }

    public byte WagerType1 { get; set; }

    public short WagerTypeOrder { get; set; }

    public virtual Playerprofile IdProfileNavigation { get; set; } = null!;

    public virtual ICollection<Pendingwagerheader> Pendingwagerheaders { get; set; } = new List<Pendingwagerheader>();

    public virtual ICollection<Playerprofilecustomteaser> Playerprofilecustomteasers { get; set; } = new List<Playerprofilecustomteaser>();

    public virtual ICollection<Playerprofileparlaylimit> Playerprofileparlaylimits { get; set; } = new List<Playerprofileparlaylimit>();

    public virtual ICollection<Wagerheader> Wagerheaders { get; set; } = new List<Wagerheader>();

    public virtual ICollection<Wagertypelang> Wagertypelangs { get; set; } = new List<Wagertypelang>();

    public virtual ICollection<Wagertypesport> Wagertypesports { get; set; } = new List<Wagertypesport>();
}
