namespace DGSProfileManager.ViewModels;

public class ProfileItem
{
    private int _idProfile;
    private string _profileName;
    private int _idPlayer;

    public int IdProfile
    {
        get => _idProfile;
        set => _idProfile = value;
    }

    public string ProfileName
    {
        get => _profileName;
        set => _profileName = value;
    }

    public int IdPlayer
    {
        get => _idPlayer;
        set => _idPlayer = value;
    }

    public ProfileItem()
    {
        _profileName = string.Empty;
        _idPlayer = -1;
        _idProfile = -1;
    }

    public ProfileItem(int profileId, string profileName)
    {
        _idProfile = profileId;
        _profileName = profileName;
    }

    public ProfileItem(int profileId, string profileName, int playerId)
    {
        _idPlayer = playerId;
        _profileName = profileName;
        _idProfile = profileId;
    }
}