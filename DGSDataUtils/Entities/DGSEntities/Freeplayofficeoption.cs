namespace DGSDataUtils.Entities.DGSEntities;

public partial class Freeplayofficeoption
{
    public byte IdOffice { get; set; }

    public string IdSport { get; set; } = null!;

    public byte Line { get; set; }

    public byte WagerType { get; set; }

    public bool Online { get; set; }

    public bool Onlocal { get; set; }

    public virtual Office IdOfficeNavigation { get; set; } = null!;
}
