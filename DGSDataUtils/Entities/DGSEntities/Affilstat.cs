namespace DGSDataUtils.Entities.DGSEntities;

public partial class Affilstat
{
    public int IdAgent { get; set; }

    public int Visitors { get; set; }

    public int UniqueVisitors { get; set; }

    public int BannerImp { get; set; }

    public int BannerClick { get; set; }

    public int TextImp { get; set; }

    public int TextClick { get; set; }

    public int SignUps { get; set; }

    public virtual Agent IdAgentNavigation { get; set; } = null!;
}
