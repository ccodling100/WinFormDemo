namespace DGSDataUtils.Entities.DGSEntities;

public partial class TwSptUserLogAction
{
    public long Idlog { get; set; }

    public int Iduser { get; set; }

    public string Note { get; set; } = null!;

    /// <summary>
    /// Save action for user when using the SuperTool , Richie vargas 
    /// </summary>
    public DateTime Regdate { get; set; }
}
