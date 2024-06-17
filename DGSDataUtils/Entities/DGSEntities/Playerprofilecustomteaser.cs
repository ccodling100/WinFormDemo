namespace DGSDataUtils.Entities.DGSEntities;

public partial class Playerprofilecustomteaser
{
    public short IdProfile { get; set; }

    public int IdWagerType { get; set; }

    public string Name { get; set; } = null!;

    public bool Enabled { get; set; }

    public byte TeaserSize { get; set; }

    public int Odds { get; set; }

    public int BuyHalf { get; set; }

    public int Buy1 { get; set; }

    public string Tie { get; set; } = null!;

    public int? TieId { get; set; }

    public float Nflside { get; set; }

    public float Nfltotal { get; set; }

    public float Nbaside { get; set; }

    public float Nbatotal { get; set; }

    public float Cfbside { get; set; }

    public float Cfbtotal { get; set; }

    public float Cbbside { get; set; }

    public float Cbbtotal { get; set; }

    public short MaxSide { get; set; }

    public short MaxTotal { get; set; }

    public bool DropHalfPoint { get; set; }

    public bool Special { get; set; }

    public bool Cancel { get; set; }

    public bool WaitForDetails { get; set; }

    public byte MaxOpenSpots { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public decimal MaxRisk { get; set; }

    public virtual Playerprofile IdProfileNavigation { get; set; } = null!;

    public virtual Wagertype IdWagerTypeNavigation { get; set; } = null!;

    public virtual ICollection<TeaserBtnDetail> TeaserBtnDetails { get; set; } = new List<TeaserBtnDetail>();
}
