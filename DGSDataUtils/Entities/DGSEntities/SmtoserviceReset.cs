namespace DGSDataUtils.Entities.DGSEntities;

public partial class SmtoserviceReset
{
    public int IdReset { get; set; }

    public TimeSpan ResetTime { get; set; }

    public bool BootstrapOdds { get; set; }

    public bool? IsActive { get; set; }
}
