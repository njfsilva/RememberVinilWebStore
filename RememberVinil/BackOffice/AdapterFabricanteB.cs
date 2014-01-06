using System.Collections.Generic;
using BackOffice.FabricanteBService;

namespace BackOffice
{
    public class AdapterFabricanteB : IAdapterFabricantes
    {
        private FabricanteBService.FabricanteBServiceClient AFabricanteB { get; set; }

        public AdapterFabricanteB(FabricanteBService.FabricanteBServiceClient a)
        {
            AFabricanteB = a;
        }
        
        
        public double getPrice(List<Track> list)
        {
            return AFabricanteB.getQuote(newQuoteRequest(list));

        }

        public ObjectQuoteRequest newQuoteRequest(List<Track> list)
        {
            ObjectQuoteRequest request = new ObjectQuoteRequest();
            request.WSCallback = "xxxxxxx";
            Music[] arrayOfMusic = new Music[list.Count];
            int x = 0;
            foreach (Track t in list)
	        {
		            Music m = new Music();
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
