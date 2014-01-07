using System;
using System.Runtime.Serialization;

namespace BackOffice
{
    [Serializable]
    [DataContract]
    public class Track
    {
        [DataMember]
        public string ArtisName { get; set; }
        [DataMember]
        public string TrackName { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public string PriceFormatted { get; set; }

        public Track(string Nome, double preço)
        {
            TrackName = Nome;
            Price = preço;
        }
        public Track()
        {
        }
    }
}
