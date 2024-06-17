namespace DGSDataUtils;

public class SimpleLogger
{
    private string logFile { get; }

    public SimpleLogger()
    {
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        logFile = Path.Combine(docPath, "import.log");

        if (!File.Exists(logFile))
        {
            File.WriteAllText(logFile, "Import Utility Log File\n-----------------------");
        }
    }

    public void Log(string message, string errorMessage)
    {
        var errorList = new List<string> { $"{message}|{errorMessage}\n" };
        File.AppendAllLines(logFile,errorList.ToArray());
    }
}