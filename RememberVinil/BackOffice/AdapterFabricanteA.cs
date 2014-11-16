using System.Linq;
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

        public FabricantePriceResponse getPrice(OrderInfo order)
        {
            var request = new ObjectQuoteRequest
            {
                encomendaID = order.encomendaid,
                fabricante = "fabrica a",
                userID = order.userID,
                WSCallback = "qwerty"
            };

            var x = 0;
            var arrayOfMusic = new Music[order.orderedTracks.Count];

            foreach (var m in order.orderedTracks.Select(t => new Music {nome = t.TrackName, price = t.Price}))
            {
                arrayOfMusic[x] = m;
                x++;
            }
            request.ListaMusicas = arrayOfMusic;

            AFabricanteA.getQuote(request);
            return new FabricantePriceResponse();
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
                arrayOfMusic[x] = m;
                x++;
            }
            request.ListaMusicas = arrayOfMusic;
            AFabricanteA.MakeCD(request);

            return new ObjectMakeCDResponse();
        }
    }
}
