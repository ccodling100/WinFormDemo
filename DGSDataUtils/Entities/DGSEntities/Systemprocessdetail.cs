namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systemprocessdetail
{
    public int IdSystemProcessDetail { get; set; }

    public int IdSystemProcess { get; set; }

    public byte ErrorType { get; set; }

    public int Id { get; set; }

    public string ErrorMessage { get; set; } = null!;

    public virtual Systemprocess IdSystemProcessNavigation { get; set; } = null!;
}
