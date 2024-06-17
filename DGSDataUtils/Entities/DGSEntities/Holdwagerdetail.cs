namespace DGSDataUtils.Entities.DGSEntities;

public partial class Holdwagerdetail
{
    public int IdHoldWagerDetail { get; set; }

    public int IdHoldWagerHeader { get; set; }

    public string Description { get; set; } = null!;

    public int IdWager { get; set; }

    public virtual Holdwagerheader IdHoldWagerHeaderNavigation { get; set; } = null!;
}
