namespace DGSDataUtils.Entities.DGSEntities;

public partial class TeaserBtnMain
{
    public short IdProfile { get; set; }

    public short IdTeaserBtn { get; set; }

    public string BtnCaption { get; set; } = null!;

    public byte BtnIndex { get; set; }

    public virtual Playerprofile IdProfileNavigation { get; set; } = null!;

    public virtual ICollection<TeaserBtnDetail> TeaserBtnDetails { get; set; } = new List<TeaserBtnDetail>();
}
