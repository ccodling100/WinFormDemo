namespace DGSDataUtils.Data.Models
{
    public class TracksViewModel
    {
        public int IdTrack { get; set; }
        public string TrackName { get; set; }
        public bool IsTrackSelected { get; set; }
        public bool IsEnabled { get; set; }
        public int IdProfile { get; set; }
        public bool IsModified { get; set; }

        public TracksViewModel()
        {
            IsTrackSelected = false;
            IsModified = false;
        }
    }
}
