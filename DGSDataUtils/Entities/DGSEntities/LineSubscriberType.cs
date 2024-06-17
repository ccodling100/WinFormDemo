namespace DGSDataUtils.Entities.DGSEntities;

public partial class LineSubscriberType
{
    public short IdSubscriberType { get; set; }

    public string SubscriberType { get; set; } = null!;

    public virtual ICollection<LineSubscriber> LineSubscribers { get; set; } = new List<LineSubscriber>();
}
