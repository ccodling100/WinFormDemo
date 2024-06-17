namespace DGSDataUtils.Entities.DGSEntities;

public partial class PcaaggregateSecurity
{
    public int Id { get; set; }

    public byte AggregateType { get; set; }

    public int AggregateId { get; set; }

    public int LineTypeId { get; set; }

    public bool UseOddsBySport { get; set; }

    public bool AutoTimeChangeEnabled { get; set; }

    public int AutoTimeChangeOffset { get; set; }

    public bool ScheduleEnabled { get; set; }

    public string Starttime { get; set; } = null!;

    public string Endtime { get; set; } = null!;

    public int SkipPsover { get; set; }

    public int SkipMlover { get; set; }

    public int SkipOuover { get; set; }
}
