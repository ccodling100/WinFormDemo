namespace DGSDataUtils.Entities.DGSEntities;

public partial class Onlinewagertracker
{
    public int IdWagerTracker { get; set; }

    public int IdPlayer { get; set; }

    public virtual Player IdPlayerNavigation { get; set; } = null!;
}
