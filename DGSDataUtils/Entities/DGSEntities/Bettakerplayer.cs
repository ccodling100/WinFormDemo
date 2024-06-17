namespace DGSDataUtils.Entities.DGSEntities;

public partial class Bettakerplayer
{
    public int IdPlayer { get; set; }

    public DateTime Placeddate { get; set; }

    public virtual Player IdPlayerNavigation { get; set; } = null!;
}
