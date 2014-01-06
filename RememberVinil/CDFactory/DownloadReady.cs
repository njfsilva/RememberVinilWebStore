using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CDFactory
{
    [Serializable]
    public class DownloadReady
    {
        public string OrderId { get; set; }
        public string LinkToDownload { get; set; }
    }
}
