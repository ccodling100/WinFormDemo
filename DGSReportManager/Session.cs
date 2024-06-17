using System.IO;
using Microsoft.Extensions.Configuration;

namespace DGSReportManager;

public static class Session
{
    private static string _dgsConnectionstring;
    private static string _proMgrConnectionString;
    
    public static string DgsConnectionstring
    {
        get => _dgsConnectionstring;
        set => _dgsConnectionstring = value;
    }

    public static string ProMgrConnectionString
    {
        get => _proMgrConnectionString;
        set => _proMgrConnectionString = value;
    }
    
    public static void InitAppSettings()
    {
        // Read from config.json file
        var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("config.json", optional: false);
        var config = builder.Build();
        var appSettings = config.GetSection("AppDBSettings").Get<Settings>();
        
        _dgsConnectionstring = appSettings.DGSDatabase;
        _proMgrConnectionString = appSettings.ProMgrDatabase;
    }
    
    public static void InitSession()
    {
        // SelectedPlayers = new Collection<PlayerItem>();
        // HighlightedProfiles = new Collection<ProfileItem>();
        // DefaultProfile = new ProfileItem();
        //
        // SelectedAgent = new PlayerItem();
        // SelectedPlayers.Clear();
        // HighlightedProfiles.Clear();
        // GeneralSelectedTracks = new();
        // ModifiedSelectedTracks = new();
        // SelectedProfile = new ProfileItem();
        // HorseGlobalMaxOn = false;
        // HorseGlobalMaxWeekOn = false;
        // HorseGlobalMaxDayOn = false;
        // IsModified = false;
    }
}