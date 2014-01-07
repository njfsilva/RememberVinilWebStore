using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BackOffice
{
    [Serializable]
    [DataContract]
    public class SongsByOrder
    {
        [DataMember]
        public string OrderId { get; set; }
        [DataMember]
        public List<Track> TrackList { get; set; }
    }
}
