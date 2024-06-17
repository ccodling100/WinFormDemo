namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systembonussetting
{
    public int MaxWager { get; set; }

    public DateTime? LastUpdate { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? FuncStraightBets { get; set; }

    public string? FuncParlays { get; set; }

    public string? FuncTeasers { get; set; }

    public bool? EnableWinBets { get; set; }

    public bool? EnableLostBets { get; set; }

    public bool? EnablePushBets { get; set; }

    public bool? EnableNabets { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }
}
