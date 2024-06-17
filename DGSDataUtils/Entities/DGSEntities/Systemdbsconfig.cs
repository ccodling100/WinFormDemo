namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemdbsconfig
{
    public bool? ImportSchedule { get; set; }

    public string? ScheduleUrl { get; set; }

    public byte? ScheduleRefresh { get; set; }

    public bool? ImportScores { get; set; }

    public string? ScoresUrl { get; set; }

    public byte? ScoresRefresh { get; set; }

    public bool? ImportLineChanges { get; set; }

    public string? LineChangesUrl { get; set; }

    public byte? LineChangesRefresh { get; set; }

    public DateTime? LastModification { get; set; }

    public short? LastModificationUser { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? PitchingChangeUrl { get; set; }

    public byte? PitchingChangeRefresh { get; set; }

    public bool? ImportPitchingChange { get; set; }

    public string? EventChangeUrl { get; set; }

    public byte? EventChangeRefresh { get; set; }

    public bool? ImportEventChange { get; set; }

    public short? IdLineType { get; set; }

    public virtual Linetype? IdLineTypeNavigation { get; set; }
}
