namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemdbsbook
{
    public int BookId { get; set; }

    public string Description { get; set; } = null!;

    public string Abbreviation { get; set; } = null!;

    public virtual ICollection<Systemdbssport> SystemdbssportBookIdPropsNavigations { get; set; } = new List<Systemdbssport>();

    public virtual ICollection<Systemdbssport> SystemdbssportBookIdTntNavigations { get; set; } = new List<Systemdbssport>();

    public virtual ICollection<Systemdbssport> SystemdbssportBooks { get; set; } = new List<Systemdbssport>();
}
