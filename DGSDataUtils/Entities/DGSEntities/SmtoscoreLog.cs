namespace DGSDataUtils.Entities.DGSEntities;

public partial class SmtoscoreLog
{
    public int IdLog { get; set; }

    public int IdGame { get; set; }

    public int VisitorScore { get; set; }

    public int HomeScore { get; set; }

    public bool IsFinalized { get; set; }

    public DateTime TimeStamp { get; set; }

    public virtual Game IdGameNavigation { get; set; } = null!;
}
