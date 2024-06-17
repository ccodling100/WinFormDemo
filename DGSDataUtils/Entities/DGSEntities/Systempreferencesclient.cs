namespace DGSDataUtils.Entities.DGSEntities;

public partial class Systempreferencesclient
{
    public short IdSystemPreferencesClient { get; set; }

    public bool DisableCreditFeatures { get; set; }

    public byte GameCuttOffTime { get; set; }

    public bool HideOtbgames { get; set; }

    public byte NoActionLimit { get; set; }

    public bool PhoneRequired { get; set; }

    public bool PlayerPasswordUsage { get; set; }

    public bool ShowDefaultLine { get; set; }

    public bool SoundRecording { get; set; }

    public bool UsePhoneDefault { get; set; }

    public byte WagerTimeLimit { get; set; }

    public bool SimultaneousLogin { get; set; }

    public bool UseRecManager { get; set; }

    public short Threshold { get; set; }

    public short PrecallTimer { get; set; }

    public bool IfBetsNui { get; set; }

    public DateTime LastModification { get; set; }

    public short LastModificationUser { get; set; }
}
