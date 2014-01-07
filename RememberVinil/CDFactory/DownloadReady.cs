using System;

namespace CDFactory
{
    [Serializable]
    public class DownloadReady
    {
        public string OrderId { get; set; }
        public string LinkToDownload { get; set; }
    }
}
