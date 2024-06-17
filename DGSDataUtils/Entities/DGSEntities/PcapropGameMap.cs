namespace DGSDataUtils.Entities.DGSEntities;

public partial class PcapropGameMap
{
    public int FromId { get; set; }

    public int ToId { get; set; }

    public DateTime CreatedAt { get; set; }

    public short CreadatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    public short UpdatedBy { get; set; }

    public DateTime KickOff { get; set; }

    public short Flags { get; set; }

    public short MasterLeagueId { get; set; }

    public DateTime Timestamp { get; set; }

    public decimal Ap { get; set; }

    public decimal Hp { get; set; }

    public short Apm { get; set; }

    public short Hpm { get; set; }

    public decimal Total { get; set; }

    public short Om { get; set; }

    public short Um { get; set; }

    public short Am { get; set; }

    public short Hm { get; set; }

    public short Dm { get; set; }
}
