namespace DGSDataUtils.Entities.DGSEntities;

public partial class Gamesyncgame
{
    public int IdGame { get; set; }

    public bool ToDelete { get; set; }

    public DateTime OldDate { get; set; }

    public byte ChangeType { get; set; }
}
