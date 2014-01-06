using System;
using System.Collections.Generic;

namespace BackOffice
{
    [Serializable]
    public class SongsByOrder
    {
        public string OrderId { get; set; }
        public List<Track> TrackList { get; set; }
    }
}
