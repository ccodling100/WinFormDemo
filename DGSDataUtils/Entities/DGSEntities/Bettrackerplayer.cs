namespace DGSDataUtils.Entities.DGSEntities;

public partial class Bettrackerplayer
{
    public int IdPlayer { get; set; }

    public string PromoCode { get; set; } = null!;

    public DateTime Placeddate { get; set; }

    public virtual Player IdPlayerNavigation { get; set; } = null!;
}
