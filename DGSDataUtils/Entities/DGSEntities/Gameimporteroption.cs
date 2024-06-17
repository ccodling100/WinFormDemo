namespace DGSDataUtils.Entities.DGSEntities;

public partial class Gameimporteroption
{
    public int IdSport { get; set; }

    public bool ProcessSchedule { get; set; }

    public bool ProcessLineChanges { get; set; }

    public int LineChangesBook { get; set; }

    public bool ProcessScores { get; set; }

    public bool ApplyScoresImmediately { get; set; }
}
