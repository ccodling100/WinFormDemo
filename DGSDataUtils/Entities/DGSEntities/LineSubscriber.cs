namespace DGSDataUtils.Entities.DGSEntities;

public partial class LineSubscriber
{
    public short IdSubscriber { get; set; }

    public string SubscriberName { get; set; } = null!;

    public short IdSubscriberType { get; set; }

    public short IdLineType { get; set; }

    public string ConfigurationData { get; set; } = null!;

    public bool Enabled { get; set; }

    public virtual Linetype IdLineTypeNavigation { get; set; } = null!;

    public virtual LineSubscriberType IdSubscriberTypeNavigation { get; set; } = null!;
}
