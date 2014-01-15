using BackOffice.FabricanteAService;
using System;

namespace BackOffice
{
    public class AdapterFabricanteA : IAdapterFabricantes
    {

        private FabricanteAServiceClient AFabricanteA { get; set; }

        public AdapterFabricanteA(FabricanteAServiceClient a)
        {
            AFabricanteA = a;

        }

        public FabricantePriceResponse GetPrice(OrderInfo order)
        {
            var request = new ObjectQuoteRequest
            {
                encomendaID = order.Encomendaid,
                fabricante = "fabrica a",
                userID = order.UserId,
                WSCallback = "qwerty"
            };
            var x = 0;
            var arrayOfMusic = new Music[order.OrderedTracks.Count];
            foreach (var t in order.OrderedTracks)
            {
                var m = new Music {nome = t.TrackName, price = t.Price};
                arrayOfMusic[x] = m;
                x++;
            }
            request.ListaMusicas = arrayOfMusic;

            AFabricanteA.getQuote(request);
            return new FabricantePriceResponse();
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
                arrayOfMusic[x] = m;
                x++;
            }
            request.ListaMusicas = arrayOfMusic;
            AFabricanteA.MakeCD(request);

            return new ObjectMakeCdResponse();
        }
    }
}
