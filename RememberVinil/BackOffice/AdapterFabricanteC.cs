using System;
using System.Collections.Generic;
using BackOffice.FabricanteCService;

namespace BackOffice
{
    public class AdapterFabricanteC : IAdapterFabricantes
    {
        private FabricanteCService.FabricanteCServiceClient AFabricanteC { get; set; }

        public AdapterFabricanteC(FabricanteCService.FabricanteCServiceClient a)
        {
            AFabricanteC = a;
        }
        
        
        public double getPrice(List<Track> list)
        {
            return AFabricanteC.getQuote(newQuoteRequest(list));

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
            Random random = new Random();
            double minutes = random.NextDouble() * (5 - 3) + 3;

            return Math.Round(minutes, 2);
        }
    }
}
