namespace DGSDataUtils.Entities.DGSEntities;

public partial class Webcolumndetail
{
    public int IdWebColumn { get; set; }

    public int IdWebRow { get; set; }

    public int ColumnOrder { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public virtual Webcolumn IdWebColumnNavigation { get; set; } = null!;

    public virtual Webrow IdWebRowNavigation { get; set; } = null!;
}
