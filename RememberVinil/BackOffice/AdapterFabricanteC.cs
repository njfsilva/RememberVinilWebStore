using System;
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

        public FabricantePriceResponse GetPrice(OrderInfo order)
        {
            var request = new ObjectQuoteRequest
            {
                encomendaID = order.Encomendaid,
                fabricante = "fabrica c",
                userID = order.UserId,
                WSCallback = "qwerty"
            };
            var x = 0;
            var arrayOfMusic = new Music[order.OrderedTracks.Count];
            foreach (var t in order.OrderedTracks)
            {
                var m = new Music {nome = t.TrackName, price = 0.99};
                m.duracao = GetMusicDuration(m.nome);
                arrayOfMusic[x] = m;
                x++;
            }
            request.ListaMusicas = arrayOfMusic;

            AFabricanteC.GetQuote(request);
            return new FabricantePriceResponse();
        }

        public double GetMusicDuration(string musicName)
        {
            var random = new Random();
            var minutes = random.NextDouble() * (5 - 3) + 3;

            return Math.Round(minutes, 2);
        }


        public ObjectMakeCdResponse SetOrder(OrderInfo order)
        {
            var request = new ObjectCDRequest
            {
                WSCallback = "xxxxxxx",
                DeliveryAdress = order.Morada,
                Distance = order.Distance,
                encomendaID = order.Encomendaid,
                fabrica = "fabrica a",
                userid = Convert.ToInt32(order.UserId)
            };
            var arrayOfMusic = new Music[order.OrderedTracks.Count];
            var x = 0;
            foreach (var t in order.OrderedTracks)
            {
                var m = new Music {nome = t.TrackName, price = t.Price};
                m.duracao = GetMusicDuration(m.nome);
                arrayOfMusic[x] = m;
                x++;
            }
            request.ListaMusicas = arrayOfMusic;
            
            AFabricanteC.MakeCd(request);
            return new ObjectMakeCdResponse();
        }
    }
}
