namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playermessage
{
    public int IdPlayerMessage { get; set; }

    public int IdPlayer { get; set; }

    public string Message { get; set; } = null!;

    public bool MessageType { get; set; }

    public bool UseExpirationDate { get; set; }

    public bool UseDisplayCounter { get; set; }

    public bool UseCloseOption { get; set; }

    public DateTime ExpirationDate { get; set; }

    public byte DisplayCounter { get; set; }

    public bool Closed { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Player IdPlayerNavigation { get; set; } = null!;
}
