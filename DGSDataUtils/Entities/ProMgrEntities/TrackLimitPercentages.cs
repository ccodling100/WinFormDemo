using Microsoft.EntityFrameworkCore;

namespace DGSDataUtils.Entities.ProMgrEntities;

[Keyless]
public class TrackLimitPercentages
{
    public int IdBetType { get; set; }
    public decimal Value { get; set; }
    public decimal ValuePercentage { get; set; }
    public int ValueType { get; set; }
}