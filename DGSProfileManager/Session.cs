using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using DGSProfileManager.ViewModels;
using Microsoft.Extensions.Configuration;

namespace DGSProfileManager;

public static class Session
{
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

    public static PlayerItem SelectedAgent { get; set; }
    public static Collection <PlayerItem> SelectedPlayers { get; set; }
    public static Collection<ProfileItem> HighlightedProfiles { get; set; }
    public static List<int> GeneralSelectedTracks = new ();
    public static List<int> ModifiedSelectedTracks = new ();
    private static string _dgsConnectionstring;
    private static string _proMgrConnectionString;
    public static ProfileItem DefaultProfile { get; set; }
    public static ProfileItem SelectedProfile { get; set; }
    public static bool HorseGlobalMaxOn { get; set; }
    public static bool HorseGlobalMaxDayOn { get; set; }
    public static bool HorseGlobalMaxWeekOn { get; set; }
    public static bool IsModified { get; set; }    // true when changes can be saved
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
        SelectedPlayers = new Collection<PlayerItem>();
        HighlightedProfiles = new Collection<ProfileItem>();
        DefaultProfile = new ProfileItem();
        
        SelectedAgent = new PlayerItem();
        SelectedPlayers.Clear();
        HighlightedProfiles.Clear();
        GeneralSelectedTracks = new();
        ModifiedSelectedTracks = new();
        SelectedProfile = new ProfileItem();
        HorseGlobalMaxOn = false;
        HorseGlobalMaxWeekOn = false;
        HorseGlobalMaxDayOn = false;
        IsModified = false;
    }
}