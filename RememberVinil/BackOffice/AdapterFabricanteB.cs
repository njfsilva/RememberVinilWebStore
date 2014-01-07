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

        public FabricantePriceResponse getPrice(List<Track> list)
        {
            AFabricanteB.getQuote(newQuoteRequest(list));
            return new FabricantePriceResponse();
        }


        public ObjectMakeCDResponse setOrder(List<Track> list)
        {
            var request = new ObjectCDRequest();
            request.WSCallback = "xxxxxxx";
            var arrayOfMusic = new Music[list.Count];
            var x = 0;
            foreach (var t in list)
            {
                var m = new Music();
                m.TrackName = t.TrackName;
                m.Price = t.Price;
                m.ArtisName = t.ArtisName;
                m.PriceFormatted = t.PriceFormatted;
                arrayOfMusic[x] = m;
                x++;
            }
            request.ListaMusicas = arrayOfMusic;
            AFabricanteB.MakeCD(request);
            
            return new ObjectMakeCDResponse();
        }
    }
}
