namespace DGSDataUtils.Entities.DGSEntities;

public partial class Team
{
    public int IdTeam { get; set; }

    public string IdSport { get; set; } = null!;

    public string TeamName { get; set; } = null!;

    public string LongName { get; set; } = null!;

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual ICollection<Game> GameIdTeamHomeNavigations { get; set; } = new List<Game>();

    public virtual ICollection<Game> GameIdTeamVisitorNavigations { get; set; } = new List<Game>();

    public virtual ICollection<Gametnt> Gametnts { get; set; } = new List<Gametnt>();

    public virtual Sport IdSportNavigation { get; set; } = null!;

    public virtual ICollection<Teamlang> Teamlangs { get; set; } = new List<Teamlang>();
}
