namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemdistributioninfo
{
    public DateTime StartDate { get; set; }

    public DateTime TableStartDate { get; set; }

    public DateTime TableEndDate { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public bool Cwcancel { get; set; }
}
