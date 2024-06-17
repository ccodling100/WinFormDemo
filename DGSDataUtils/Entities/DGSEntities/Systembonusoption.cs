namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systembonusoption
{
    public byte IdOffice { get; set; }

    public string IdSport { get; set; } = null!;

    public byte Line { get; set; }

    public bool Online { get; set; }

    public bool Onlocal { get; set; }
}
