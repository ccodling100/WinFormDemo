namespace DGSDataUtils.Entities.DGSEntities;

public partial class TeaserBtnDetail
{
    public short IdProfile { get; set; }

    public short IdTeaserBtn { get; set; }

    public byte NumTeams { get; set; }

    public int IdWagerType { get; set; }

    public string TeaserName { get; set; } = null!;

    public virtual TeaserBtnMain Id { get; set; } = null!;

    public virtual Playerprofilecustomteaser IdNavigation { get; set; } = null!;
}
