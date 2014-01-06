using System.Collections.Generic;
using BackOffice.FabricanteBService;

namespace BackOffice
{
    public class AdapterFabricanteB : IAdapterFabricantes
    {
        private FabricanteBServiceClient AFabricanteB { get; set; }

        public AdapterFabricanteB(FabricanteBServiceClient a)
        {
            AFabricanteB = a;
        }
        
        
        public double getPrice(List<Track> list)
        {
            return AFabricanteB.getQuote(newQuoteRequest(list));

        }

        public ObjectQuoteRequest newQuoteRequest(List<Track> list)
        {
            var request = new ObjectQuoteRequest();
            request.WSCallback = "xxxxxxx";
            var arrayOfMusic = new Music[list.Count];
            var x = 0;
            foreach (var t in list)
	        {
		            var m = new Music();
                    m.TrackName=t.TrackName;
                    m.Price=t.Price;
                    m.ArtisName = t.ArtisName;
                    m.PriceFormatted = t.PriceFormatted;
                    arrayOfMusic[x]=m;
                    x++;
	        }
            request.ListaMusicas = arrayOfMusic;
            return request;
        }
    }
}
