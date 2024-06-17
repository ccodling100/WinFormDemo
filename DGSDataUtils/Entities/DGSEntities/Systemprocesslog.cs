namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemprocesslog
{
    public int IdSystemProcess { get; set; }

    public short? IdUser { get; set; }

    public DateTime ProcessDate { get; set; }

    public DateTime? TotalTime { get; set; }

    public int? Wagers { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Systemprocesslogdetail> Systemprocesslogdetails { get; set; } = new List<Systemprocesslogdetail>();
}
