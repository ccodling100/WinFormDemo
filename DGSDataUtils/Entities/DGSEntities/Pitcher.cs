namespace DGSDataUtils.Entities.DGSEntities;

public partial class Pitcher
{
    public int IdPitcher { get; set; }

    public string PitcherName { get; set; } = null!;

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }
}
