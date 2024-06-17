namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playerstatistic
{
    public int IdPlayer { get; set; }

    public decimal CurrentBalance { get; set; }

    public decimal AmountAtRisk { get; set; }

    public decimal AvailBalance { get; set; }

    public decimal? BonusPoints { get; set; }

    public decimal Ytdwin { get; set; }

    public decimal Ytdlose { get; set; }

    public decimal LifeTimeWin { get; set; }

    public decimal LifeTimeLose { get; set; }

    public decimal LifeTimeNetCasino { get; set; }

    public decimal LifeTimeNetHorses { get; set; }

    public decimal ThisWeekSports { get; set; }

    public decimal LastWeekSports { get; set; }

    public decimal ThisWeekCasino { get; set; }

    public decimal LastWeekCasino { get; set; }

    public decimal ThisWeekHorses { get; set; }

    public decimal LastWeekHorses { get; set; }

    public DateTime? LastCall { get; set; }

    public DateTime AccountOpened { get; set; }

    public DateTime? LastWager { get; set; }

    public DateTime? LastGrade { get; set; }

    /// <summary>
    /// All freeplays assigned to the account since it was oppened
    /// </summary>
    public decimal LifeTimeFreePlays { get; set; }

    /// <summary>
    /// All bonus added in PlayerTransactions
    /// </summary>
    public decimal LifeTimeBonus { get; set; }

    /// <summary>
    /// All fees added in PlayerTransactions
    /// </summary>
    public decimal LifeTimeFees { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Player IdPlayerNavigation { get; set; } = null!;
}
