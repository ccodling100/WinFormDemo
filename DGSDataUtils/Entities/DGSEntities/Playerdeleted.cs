namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playerdeleted
{
    public int Idplayer { get; set; }

    public int? IdAgent { get; set; }

    public short IdCurrency { get; set; }

    public string Player { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Name { get; set; }

    public string? LastName { get; set; }

    public string? LastName2 { get; set; }

    public decimal CreditLimit { get; set; }

    public decimal ThisWeekSports { get; set; }

    public decimal LastWeekSports { get; set; }

    public decimal ThisWeekCasino { get; set; }

    public decimal LastWeekCasino { get; set; }

    public decimal ThisWeekHorses { get; set; }

    public decimal LastWeekHorses { get; set; }

    public DateTime? LastCall { get; set; }

    public DateTime AccountOpened { get; set; }

    public DateTime? LastWager { get; set; }

    public DateTime? LastModification { get; set; }

    public short? LastModificationUser { get; set; }
}
