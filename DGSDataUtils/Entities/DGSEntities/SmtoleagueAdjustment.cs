namespace DGSDataUtils.Entities.DGSEntities;

public partial class SmtoleagueAdjustment
{
    public int IdAdjustment { get; set; }

    public short IdLineType { get; set; }

    public string IdSport { get; set; } = null!;

    public short? IdLeague { get; set; }

    public short? Play { get; set; }

    public short? Type { get; set; }

    public float? RangeFrom { get; set; }

    public float? RangeTo { get; set; }

    public float? FavoriteAdjustment { get; set; }

    public float? DogAdjustment { get; set; }

    public short IdStatus { get; set; }

    public bool? IsActive { get; set; }

    public DateTime LastUpdate { get; set; }

    public virtual League? IdLeagueNavigation { get; set; }

    public virtual Linetype IdLineTypeNavigation { get; set; } = null!;

    public virtual Sport IdSportNavigation { get; set; } = null!;
}
