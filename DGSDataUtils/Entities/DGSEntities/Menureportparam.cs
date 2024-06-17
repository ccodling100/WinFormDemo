namespace DGSDataUtils.Entities.DGSEntities;

public partial class Menureportparam
{
    public int IdParam { get; set; }

    public short Idreport { get; set; }

    public byte CustoId { get; set; }

    public string Name { get; set; } = null!;

    public byte Type { get; set; }

    public string Parent { get; set; } = null!;

    public byte Tab { get; set; }

    public virtual Menureportfile Menureportfile { get; set; } = null!;

    public virtual ICollection<Menureportparamslang> Menureportparamslangs { get; set; } = new List<Menureportparamslang>();
}
