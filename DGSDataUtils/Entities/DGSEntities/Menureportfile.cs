namespace DGSDataUtils.Entities.DGSEntities;

public partial class Menureportfile
{
    public short IdReport { get; set; }

    public byte CustoId { get; set; }

    public string FileName { get; set; } = null!;

    public virtual Menureportitem IdReportNavigation { get; set; } = null!;

    public virtual ICollection<Menureportparam> Menureportparams { get; set; } = new List<Menureportparam>();
}
