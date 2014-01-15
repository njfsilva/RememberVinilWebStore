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

        public FabricantePriceResponse GetPrice(OrderInfo order)
        {
            var request = new ObjectQuoteRequest
            {
                encomendaID = order.Encomendaid,
                fabricante = "fabrica b",
                userID = order.UserId,
                WSCallback = "qwerty"
            };
            var x = 0;
            var arrayOfMusic = new Music[order.OrderedTracks.Count];
            foreach (var t in order.OrderedTracks)
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


        public ObjectMakeCdResponse SetOrder(OrderInfo order)
        {
            var request = new ObjectCDRequest {WSCallback = "xxxxxxx"};
            request.WSCallback = "xxxxxxx";
            request.DeliveryAdress = order.Morada;
            request.Distance = order.Distance;
            //request.Distance = requestA.Distance;
            request.encomendaID = order.Encomendaid;
            request.fabrica = "fabrica b";
            request.userid = Convert.ToInt32(order.UserId);
            var arrayOfMusic = new Music[order.OrderedTracks.Count];
            var x = 0;
            foreach (var t in order.OrderedTracks)
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
            AFabricanteB.MakeCD(request);
            
            return new ObjectMakeCdResponse();
        }
    }
}
