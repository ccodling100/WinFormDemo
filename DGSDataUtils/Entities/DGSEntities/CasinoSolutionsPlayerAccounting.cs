namespace DGSDataUtils.Entities.DGSEntities;

public partial class CasinoSolutionsPlayerAccounting
{
    public short CasinoGameId { get; set; }

    public int IdPlayer { get; set; }

    public int? IdPlayerAccounting { get; set; }

    public DateTime LastModification { get; set; }
}
