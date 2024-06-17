using DGSDataUtils.Configure;

namespace DGSDataUtils.Data
{
    public interface IImportUtility
    {
        bool ImportDataFromDGSDataDB(ImportTableEnums tableEnumOptions);
        event EventHandler<ProgressEventArgs> ImportProgressChanged;
        int DefaultBatchSize { get; set; }
    }
}