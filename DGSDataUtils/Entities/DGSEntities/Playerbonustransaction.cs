namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playerbonustransaction
{
    public int IdPlayerBonusTransactions { get; set; }

    public int? IdWager { get; set; }

    public int IdPlayer { get; set; }

    public string Description { get; set; } = null!;

    public byte Type { get; set; }

    public decimal BonusPoints { get; set; }

    public DateTime BonusDate { get; set; }

    public int IdWagerType { get; set; }

    public decimal PrevBalance { get; set; }

    public decimal CurrBalance { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Player IdPlayerNavigation { get; set; } = null!;
}
