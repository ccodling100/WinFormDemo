namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systembetradarconfig
{
    public short RefreshRate { get; set; }

    public string FilesPath { get; set; } = null!;

    public int IdGameType { get; set; }

    public int IdLineType { get; set; }

    public bool ImportOdds { get; set; }

    public bool ImportScores { get; set; }

    public bool AutomaticGrade { get; set; }

    public short ImportCsasProps { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }
}
