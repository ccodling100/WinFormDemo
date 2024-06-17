namespace DGSDataUtils.Entities.DGSEntities;

public partial class SmtoscoringExcludedLeague
{
    public short IdLeague { get; set; }

    public virtual League IdLeagueNavigation { get; set; } = null!;
}
