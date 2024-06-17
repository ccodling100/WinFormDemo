using DGSDataUtils.Configure;
using DGSDataUtils.Data;
using Microsoft.Extensions.Configuration;

namespace DGSImportUtilityUI;

public partial class Startup : Form
{
    private IImportUtility _importer;
    private int lastProgressValue = 0;
    private string defaultServerIp = "192.168.0.27";
    

    private string importTable = String.Empty;
    private int batchSize = 1000;
    
    public Startup()
    {
        InitializeComponent();
        string dgsConnectionString = String.Empty;
        string profileMgrConnectionString = String.Empty;

    // Read from config.json file
        var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("config.json", optional: false);
        var config = builder.Build();
        var importSettings = config.GetSection("ImportSettings").Get<ImportSettings>();
        dgsConnectionString = importSettings.SourceDatabase;
        profileMgrConnectionString = importSettings.DestinationDatabase;
        batchSize = importSettings.ImportBatchSize;
        importTable = importSettings.ImportTable;

        txtSourceConnection.Text = dgsConnectionString;
        txtDestConnection.Text = profileMgrConnectionString;
    }

    private void btnImport_Click(object? sender, EventArgs e)
    {
        btnImport.Enabled = false;

        _importer = new ImportUtility(txtSourceConnection.Text, txtDestConnection.Text, batchSize);

        DateTime startTime = DateTime.Now;
        Console.WriteLine("Importing data from DGSData database.");
        _importer.ImportProgressChanged += OnProgressChanged;

        _importer.ImportDataFromDGSDataDB(GetImportTable(importTable));

        btnImport.Enabled = true;
    }

    private void btnCancel_Click(object? sender, EventArgs e)
    {
        Environment.Exit(0);
    }
    
    private void OnProgressChanged(object sender, ProgressEventArgs args)
    {
        if (args.Progress > lastProgressValue)
        {
            progressBar.Value = args.Progress;
            lblTable.Text = $"Importing table {args.TableName}";
            if (lastProgressValue > 99)
                lastProgressValue = 0;
            
            lblTable.Update();
            lblTable.Refresh();
            Application.DoEvents();
        }
    }
    
    private ImportTableEnums GetImportTable(string tableArg)
    {
        switch (tableArg.ToLower())
        {
            case "all":
                return ImportTableEnums.All;
                break;
            case "agents":
                return ImportTableEnums.AgentDefaults;
                break;
            case "tracks":
                return ImportTableEnums.Tracks;
                break;
            case "bettypes":
                return ImportTableEnums.BetTypes;
                break;
            case "tracklimits":
                return ImportTableEnums.TrackLimits;
                break;
            case "profilemap":
                return ImportTableEnums.ProfileMaps;
                break;
            case "raceprofiles":
                return ImportTableEnums.RaceProfiles;
                break;
        }

        return ImportTableEnums.All;
    }
}