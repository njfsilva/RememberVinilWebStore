using System.Collections.Generic;
using BackOffice.FabricanteAService;

namespace BackOffice
{
    public class AdapterFabricanteA : IAdapterFabricantes
    {

        private FabricanteAServiceClient AFabricanteA { get; set; }

        public AdapterFabricanteA(FabricanteAServiceClient a)
        {
            AFabricanteA = a;

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
                    m.nome=t.TrackName;
                    m.price=t.Price;
                    arrayOfMusic[x]=m;
                    x++;
	        }
            request.ListaMusicas = arrayOfMusic;
            return request;
        }

        public FabricantePriceResponse getPrice(List<Track> list)
        {
            AFabricanteA.getQuote(newQuoteRequest(list));
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
                m.nome = t.TrackName;
                m.price = t.Price;
                arrayOfMusic[x] = m;
                x++;
            }
            request.ListaMusicas = arrayOfMusic;
            AFabricanteA.MakeCD(request);

            return new ObjectMakeCDResponse();
        }
    }
}
