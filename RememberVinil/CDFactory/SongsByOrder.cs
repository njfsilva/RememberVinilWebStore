using System;
using System.Collections.Generic;

namespace CDFactory
{
    [Serializable]
    public class SongsByOrder
    {
        public string OrderId { get; set; }
        public List<Track> TrackList { get; set; }
    }
}
