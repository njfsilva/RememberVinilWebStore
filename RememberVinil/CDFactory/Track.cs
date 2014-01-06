using System;

namespace BackOffice
{
    [Serializable]
    public class Track
    {
        public string ArtisName { get; set; }
        public string TrackName { get; set; }
        public double Price { get; set; }
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
