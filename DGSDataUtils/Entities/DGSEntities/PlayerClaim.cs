namespace DGSDataUtils.Entities.DGSEntities;

public partial class PlayerClaim
{
    public int IdClaim { get; set; }

    public int IdPlayer { get; set; }

    public int IdWager { get; set; }

    public string? Description { get; set; }

    public short IdUser { get; set; }

    public DateTime? Placed { get; set; }

    public short? IdOffice { get; set; }

    public int? IdCall { get; set; }

    public short? PhoneLine { get; set; }

    public short? Unit { get; set; }

    public short? Channel { get; set; }

    public DateTime? TapeTime { get; set; }

    public short? SolvedBy { get; set; }

    public string? Comments { get; set; }

    public string? Results { get; set; }

    public byte? Status { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Player IdPlayerNavigation { get; set; } = null!;
}
