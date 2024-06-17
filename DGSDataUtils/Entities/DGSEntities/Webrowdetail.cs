namespace DGSDataUtils.Entities.DGSEntities;

public partial class Webrowdetail
{
    public int IdWebRow { get; set; }

    public short IdLeague { get; set; }

    public int RowOrder { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual League IdLeagueNavigation { get; set; } = null!;

    public virtual Webrow IdWebRowNavigation { get; set; } = null!;
}
