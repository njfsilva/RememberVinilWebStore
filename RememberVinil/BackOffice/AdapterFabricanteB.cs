using System.Linq;
using BackOffice.FabricanteBService;
using System;

namespace BackOffice
{
    public class AdapterFabricanteB : IAdapterFabricantes
    {
        private FabricanteBServiceClient AFabricanteB { get; set; }

        public AdapterFabricanteB(FabricanteBServiceClient a)
        {
            AFabricanteB = a;
        }

        public FabricantePriceResponse getPrice(OrderInfo order)
        {
            var request = new ObjectQuoteRequest
            {
                encomendaID = order.encomendaid,
                fabricante = "fabrica b",
                userID = order.userID,
                WSCallback = "qwerty"
            };
            var x = 0;
            var arrayOfMusic = new Music[order.orderedTracks.Count];
            foreach (var t in order.orderedTracks)
            {
                var m = new Music
                {
                    TrackName = t.TrackName,
                    Price = t.Price,
                    ArtisName = t.ArtisName,
                    PriceFormatted = t.PriceFormatted
                };
                arrayOfMusic[x] = m;
                x++;
            }
            request.ListaMusicas = arrayOfMusic;

            AFabricanteB.getQuote(request);
            return new FabricantePriceResponse();
        }


        public ObjectMakeCDResponse setOrder(OrderInfo order)
        {
            var request = new ObjectCDRequest {WSCallback = "xxxxxxx"};
            request.WSCallback = "xxxxxxx";
            request.DeliveryAdress = order.morada;
            request.Distance = order.distance;
            //request.Distance = requestA.Distance;
            request.encomendaID = order.encomendaid;
            request.fabrica = "fabrica b";
            request.userid = Convert.ToInt32(order.userID);
            var arrayOfMusic = new Music[order.orderedTracks.Count];
            var x = 0;

            foreach (var m in order.orderedTracks.Select(t => new Music
            {
                TrackName = t.TrackName,
                Price = t.Price,
                ArtisName = t.ArtisName,
                PriceFormatted = t.PriceFormatted
            }))
            {
                arrayOfMusic[x] = m;
                x++;
            }

            request.ListaMusicas = arrayOfMusic;
            AFabricanteB.MakeCD(request);
            
            return new ObjectMakeCDResponse();
        }
    }
}
