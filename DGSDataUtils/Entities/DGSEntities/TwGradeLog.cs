namespace DGSDataUtils.Entities.DGSEntities;

public partial class TwGradeLog
{
    public long IdLog { get; set; }

    public long Idwager { get; set; }

    public string Log { get; set; } = null!;

    public DateTime RegDate { get; set; }
}
