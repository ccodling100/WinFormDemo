namespace DGSDataUtils.Entities.DGSEntities;

public partial class Usermessage
{
    public int IdUserMessage { get; set; }

    public short IdUser { get; set; }

    public string Message { get; set; } = null!;

    public short SentBy { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual User IdUserNavigation { get; set; } = null!;
}
