namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playernote
{
    public int IdPlayer { get; set; }

    public string? Notes0 { get; set; }

    public string? Notes1 { get; set; }

    public string? Notes2 { get; set; }

    public string? Notes3 { get; set; }

    public string? Notes4 { get; set; }

    public string? Notes5 { get; set; }

    public string? Notes6 { get; set; }

    public virtual Player IdPlayerNavigation { get; set; } = null!;
}
