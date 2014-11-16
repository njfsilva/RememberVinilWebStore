using System;
using System.Linq;
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

        public FabricantePriceResponse getPrice(OrderInfo order)
        {
            var request = new ObjectQuoteRequest
            {
                encomendaID = order.encomendaid,
                fabricante = "fabrica c",
                userID = order.userID,
                WSCallback = "qwerty"
            };
            var x = 0;
            var arrayOfMusic = new Music[order.orderedTracks.Count];

            foreach (var m in order.orderedTracks.Select(t => new Music {nome = t.TrackName, price = 0.99}))
            {
                m.duracao = getMusicDuration(m.nome);
                arrayOfMusic[x] = m;
                x++;
            }
            request.ListaMusicas = arrayOfMusic;

            AFabricanteC.GetQuote(request);
            return new FabricantePriceResponse();
        }

        private double getMusicDuration(string musicName)
        {
            var random = new Random();
            var minutes = random.NextDouble() * (5 - 3) + 3;

            return Math.Round(minutes, 2);
        }


        public ObjectMakeCDResponse setOrder(OrderInfo order)
        {
            var request = new ObjectCDRequest
            {
                WSCallback = "xxxxxxx",
                DeliveryAdress = order.morada,
                Distance = order.distance,
                encomendaID = order.encomendaid,
                fabrica = "fabrica a",
                userid = Convert.ToInt32(order.userID)
            };
            var arrayOfMusic = new Music[order.orderedTracks.Count];
            var x = 0;

            foreach (var m in order.orderedTracks.Select(t => new Music {nome = t.TrackName, price = t.Price}))
            {
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
