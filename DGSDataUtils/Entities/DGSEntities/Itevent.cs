namespace DGSDataUtils.Entities.DGSEntities;

public partial class Itevent
{
    public string MeetingCode { get; set; } = null!;

    public byte EventNumber { get; set; }

    public byte RaceNumber { get; set; }

    public string? RunnerStatusFlags { get; set; }
}
