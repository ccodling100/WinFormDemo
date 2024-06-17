namespace DGSDataUtils.Entities.DGSEntities;

public partial class SmtocustomPeriod
{
    public byte IdPeriod { get; set; }

    public string IdSport { get; set; } = null!;

    public string Name { get; set; } = null!;

    public byte NumberOfTeams { get; set; }

    public string Team { get; set; } = null!;

    public byte? Prefix { get; set; }

    public byte? Postfix { get; set; }

    public string Abbreviation { get; set; } = null!;

    public bool? IsActive { get; set; }

    public virtual Sport IdSportNavigation { get; set; } = null!;
}
