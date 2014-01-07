using System;
using System.Collections.Generic;
using BackOffice.FabricanteCService;

namespace BackOffice
{
    public class AdapterFabricanteC : IAdapterFabricantes
    {
        private FabricanteCServiceClient AFabricanteC { get; set; }

        public AdapterFabricanteC(FabricanteCServiceClient a)
        {
            AFabricanteC = a;
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
                    m.duracao = getMusicDuration(m.nome);
                    arrayOfMusic[x]=m;
                    x++;
	        }
            request.ListaMusicas = arrayOfMusic;
            return request;
        }

        public double getMusicDuration(string musicName)
        {
            var random = new Random();
            var minutes = random.NextDouble() * (5 - 3) + 3;

            return Math.Round(minutes, 2);
        }

        public FabricantePriceResponse getPrice(List<Track> list)
        {
            AFabricanteC.GetQuote(newQuoteRequest(list));
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
                m.duracao = getMusicDuration(m.nome);
                arrayOfMusic[x] = m;
                x++;
            }
            request.ListaMusicas = arrayOfMusic;
            
            AFabricanteC.MakeCd(request);
            return new ObjectMakeCDResponse();
        }
    }
}
