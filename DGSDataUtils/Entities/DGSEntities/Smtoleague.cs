namespace DGSDataUtils.Entities.DGSEntities;

public partial class Smtoleague
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? IdSmtosport { get; set; }

    public string? SmtosportName { get; set; }

    public short? NumberOfPeriods { get; set; }

    public short? IdLeague { get; set; }

    public string? LeagueDescription { get; set; }

    public int? IdGameType { get; set; }

    public string? GameTypeDescription { get; set; }

    public short? IdLeagueInGame { get; set; }

    public string? LeagueInGameDescription { get; set; }

    public int? IdGameTypeInGame { get; set; }

    public string? GameTypeInGameDescription { get; set; }

    public string? Periods { get; set; }

    public int? ParentId { get; set; }

    public virtual Gametype? IdGameTypeInGameNavigation { get; set; }

    public virtual Gametype? IdGameTypeNavigation { get; set; }

    public virtual League? IdLeagueInGameNavigation { get; set; }

    public virtual League? IdLeagueNavigation { get; set; }

    public virtual Smtosport? IdSmtosportNavigation { get; set; }
}
