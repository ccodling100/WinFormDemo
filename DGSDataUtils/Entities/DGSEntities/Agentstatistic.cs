namespace DGSDataUtils.Entities.DGSEntities;

public partial class Agentstatistic
{
    public int IdAgent { get; set; }

    public decimal CurrentBalance { get; set; }

    public decimal? ThisWeek { get; set; }

    public decimal? LastWeek { get; set; }

    public decimal Ytdwin { get; set; }

    public decimal Ytdlose { get; set; }

    public decimal Ytdcomm { get; set; }

    public decimal LifetimeWin { get; set; }

    public decimal LifeTimeLose { get; set; }

    public decimal LifeTimeComm { get; set; }

    public decimal MakeUp { get; set; }

    public decimal LastWeekMakeUp { get; set; }

    public DateTime AccountOpened { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Agent IdAgentNavigation { get; set; } = null!;
}
