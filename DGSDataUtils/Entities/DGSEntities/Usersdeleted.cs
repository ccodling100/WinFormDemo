namespace DGSDataUtils.Entities.DGSEntities;

public partial class Usersdeleted
{
    public short IdUser { get; set; }

    public short IdUserProfile { get; set; }

    public int IdDepartment { get; set; }

    public string LoginName { get; set; } = null!;

    public string? Name { get; set; }

    public string Password { get; set; } = null!;

    public DateTime? LastLogin { get; set; }

    public bool Status { get; set; }

    public byte Type { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }

    public byte? IdLanguage { get; set; }

    public virtual Language? IdLanguageNavigation { get; set; }
}
