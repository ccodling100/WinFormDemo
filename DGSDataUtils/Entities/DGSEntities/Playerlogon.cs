namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playerlogon
{
    public int IdPlayer { get; set; }

    public DateTime PlacedDate { get; set; }

    public short IdUser { get; set; }

    public string? System { get; set; }

    public string? Ip { get; set; }

    public int? IdCall { get; set; }

    public virtual Player IdPlayerNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
