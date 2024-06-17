namespace DGSDataUtils.Entities.DGSEntities;

public partial class Book
{
    public short IdBook { get; set; }

    public string Description { get; set; } = null!;

    public int? IdWebColumn { get; set; }

    public DateTime? LastModification { get; set; }

    public short? LastModificationUser { get; set; }

    public virtual ICollection<Agent> Agents { get; set; } = new List<Agent>();

    public virtual Bookclientpreference? Bookclientpreference { get; set; }

    public virtual ICollection<Bookprefix> Bookprefixes { get; set; } = new List<Bookprefix>();

    public virtual Webcolumn? IdWebColumnNavigation { get; set; }

    public virtual ICollection<Player> Players { get; set; } = new List<Player>();

    public virtual Systempreferencesdefault? Systempreferencesdefault { get; set; }

    public virtual ICollection<Playerprofilelimit> IdProfileLimits { get; set; } = new List<Playerprofilelimit>();

    public virtual ICollection<Playerprofile> IdProfiles { get; set; } = new List<Playerprofile>();

    public virtual ICollection<User> IdUsers { get; set; } = new List<User>();
}
