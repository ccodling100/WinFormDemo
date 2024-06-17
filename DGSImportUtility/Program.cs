using DGSDataUtils.Configure;
using DGSDataUtils.Data;
using Microsoft.Extensions.Configuration;

namespace DGSImportUtility
{
    public class Program
    {
        private static IImportUtility _importer;
        private static int bogusRecordCount = 10000;
        private static int lastProgressValue = 0;
        private static string defaultServerIp = "192.168.0.27";

        static void Main(string[] args)
        {
            var dgsConnectionString = String.Empty;
            var profileMgrConnectionString = String.Empty;
            var importTable = String.Empty;
            var batchSize = 1000;

            if (args.Length > 1)
            {
                if (args.Length < 4)
                {
                    Console.WriteLine(
                        "Please provide the required arguments: DGSConnectionString, ProfileMgrConnectionString, ImportTable, ImportBatchSize");
                    Environment.Exit(0);
                }
                dgsConnectionString = args[0];
                profileMgrConnectionString = args[1];
                importTable = args[2];
                batchSize = int.Parse(args[3]);
            }
            else
            {
                Console.WriteLine("Arguments not passed in, using values found in config.json");

                // Read from config.json file
                var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("config.json", optional: false);
                var config = builder.Build();
                var importSettings = config.GetSection("ImportSettings").Get<ImportSettings>();
                dgsConnectionString = importSettings.SourceDatabase;
                profileMgrConnectionString = importSettings.DestinationDatabase;
                batchSize = importSettings.ImportBatchSize;
                importTable = importSettings.ImportTable;
            }

            _importer = new ImportUtility(dgsConnectionString, profileMgrConnectionString, batchSize);

            DateTime startTime = DateTime.Now;
            Console.WriteLine("Importing data from DGSData database.");
            _importer.ImportProgressChanged += OnProgressChanged;


            _importer.ImportDataFromDGSDataDB(GetImportTable(importTable));

            DateTime endTime = DateTime.Now;
            var ts = (endTime - startTime).TotalSeconds;
            Console.WriteLine($"Job(s) completed in {ts}s.");
        }

        static void OnProgressChanged(object sender, ProgressEventArgs args)
        {
            if (args.Progress > lastProgressValue)
            {
                lastProgressValue = args.Progress;
                Console.WriteLine($"Processed: {args.Progress}% of the data from table {args.TableName}");
                if (lastProgressValue > 99)
                    lastProgressValue = 0;
            }
        }

        private static ImportTableEnums GetImportTable(string tableArg)
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
}