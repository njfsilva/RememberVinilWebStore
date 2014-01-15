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

        public Track(string nome, double preço)
        {
            TrackName = nome;
            Price = preço;
        }
        public Track()
        {
        }
    }
}
