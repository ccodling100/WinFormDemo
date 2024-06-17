namespace DGSDataUtils.Entities.DGSEntities;

public partial class AceAgentimportedplayerslog
{
    public int IdImportedPlayersLog { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public decimal Balance { get; set; }

    public decimal CreditLimit { get; set; }

    public int IdAgent { get; set; }

    public int IdLineType { get; set; }

    public int IdProfile { get; set; }

    public int IdLimitProfile { get; set; }

    public decimal LocalMinWager { get; set; }

    public decimal LocalMaxWager { get; set; }

    public decimal OnlineMinWager { get; set; }

    public decimal OnlineMaxWager { get; set; }

    public bool EnableSport { get; set; }

    public bool EnableCasino { get; set; }

    public bool EnableHorses { get; set; }

    public string Status { get; set; } = null!;

    public int IdPlacedUser { get; set; }

    public DateTime PlacedDate { get; set; }
}
