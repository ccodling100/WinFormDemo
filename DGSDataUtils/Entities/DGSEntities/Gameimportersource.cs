namespace DGSDataUtils.Entities.DGSEntities;

public partial class Gameimportersource
{
    public string? ScheduleUrl { get; set; }

    public byte ScheduleRefresh { get; set; }

    public string? ScoresUrl { get; set; }

    public byte ScoresRefresh { get; set; }

    public string? LineChangesUrl { get; set; }

    public byte LineChangesRefresh { get; set; }

    public bool ImportSchedule { get; set; }

    public bool ImportScores { get; set; }

    public bool ImportLineChanges { get; set; }
}
