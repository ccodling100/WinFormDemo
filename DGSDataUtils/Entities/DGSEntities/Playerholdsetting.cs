namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playerholdsetting
{
    public int Idplayer { get; set; }

    public byte WagerType { get; set; }

    public bool Enabled { get; set; }

    public decimal Amount { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Player IdplayerNavigation { get; set; } = null!;
}
