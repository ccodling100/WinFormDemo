namespace DGSDataUtils.Entities.DGSEntities;

public partial class Smtosport
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string IdSport { get; set; } = null!;

    public virtual Sport IdSportNavigation { get; set; } = null!;

    public virtual ICollection<Smtoleague> Smtoleagues { get; set; } = new List<Smtoleague>();
}
