namespace DGSDataUtils.Configure
{
    public class ProgressEventArgs : EventArgs
    {
        public string TableName { get; set; }
        public int Progress { get; set; }
    }
}