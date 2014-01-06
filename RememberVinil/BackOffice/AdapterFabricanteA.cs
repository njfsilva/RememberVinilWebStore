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
        
        
        public double getPrice(List<Track> list)
        {
            return AFabricanteA.getQuote(newQuoteRequest(list));

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


        public string setOrder(List<Track> list)
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
            return AFabricanteA.MakeCD(request);
        }
    }
}
