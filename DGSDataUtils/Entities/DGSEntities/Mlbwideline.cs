namespace DGSDataUtils.Entities.DGSEntities;

public partial class Mlbwideline
{
    public short IdMlbwideLine { get; set; }

    public short MaxOdds { get; set; }

    public short MinOdds { get; set; }

    public short FavOdds { get; set; }

    public short DogOdds { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }
}
