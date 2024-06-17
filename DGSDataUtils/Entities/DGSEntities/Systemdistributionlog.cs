namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemdistributionlog
{
    public int IdLog { get; set; }

    public DateTime DistributionDate { get; set; }

    public string? Description { get; set; }

    public int? IdAccount { get; set; }

    public int? IdTransaction { get; set; }

    public DateTime? TransacDate { get; set; }

    public decimal? Data1 { get; set; }

    public decimal? Data2 { get; set; }

    public decimal? Data3 { get; set; }

    public decimal? Data4 { get; set; }

    public byte Type { get; set; }
}
