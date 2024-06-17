namespace DGSDataUtils.Entities.DGSEntities;

public partial class PcaaggregateSetting
{
    public int Id { get; set; }

    public byte AggregateType { get; set; }

    public int AggregateId { get; set; }

    public int LineTypeId { get; set; }

    public byte Period { get; set; }

    public bool Enabled { get; set; }

    public bool Ps { get; set; }

    public bool Ml { get; set; }

    public bool Total { get; set; }

    public int PsproviderId { get; set; }

    public int MlproviderId { get; set; }

    public int TotalProviderId { get; set; }

    public decimal PslineOffset { get; set; }

    public int PspriceOffset { get; set; }

    public decimal MllineOffset { get; set; }

    public int MlpriceOffset { get; set; }

    public decimal OulineOffset { get; set; }

    public int OupriceOffset { get; set; }

    public DateTime AddedAt { get; set; }

    public int AddedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int UpdatedBy { get; set; }
}
