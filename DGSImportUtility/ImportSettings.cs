namespace DGSImportUtility;

public class ImportSettings
{
    public string SourceDatabase { get; set; }
    public string DestinationDatabase { get; set; }
    public string ImportTable { get; set; }
    public int ImportBatchSize { get; set; }
}