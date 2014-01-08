using System.Collections.Generic;
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
            var request = new ObjectQuoteRequest();
            request.encomendaID = order.encomendaid;
            request.fabricante = "fabrica b";
            request.userID = order.userID;
            request.WSCallback = "qwerty";
            var x = 0;
            var arrayOfMusic = new Music[order.orderedTracks.Count];
            foreach (var t in order.orderedTracks)
            {
                var m = new Music();
                m.TrackName = t.TrackName;
                m.Price = t.Price;
                m.ArtisName = t.ArtisName;
                m.PriceFormatted = t.PriceFormatted;
                arrayOfMusic[x] = m;
                x++;
            }
            request.ListaMusicas = arrayOfMusic;

            AFabricanteB.getQuote(request);
            return new FabricantePriceResponse();
        }


        public ObjectMakeCDResponse setOrder(OrderInfo order)
        {
            var request = new ObjectCDRequest();
            request.WSCallback = "xxxxxxx";
            request.WSCallback = "xxxxxxx";
            request.DeliveryAdress = order.morada;
            request.Distance = order.distance;
            //request.Distance = requestA.Distance;
            request.encomendaID = order.encomendaid;
            request.fabrica = "fabrica b";
            request.userid = Convert.ToInt32(order.userID);
            var arrayOfMusic = new Music[order.orderedTracks.Count];
            var x = 0;
            foreach (var t in order.orderedTracks)
            {
                var m = new Music();
                m.TrackName = t.TrackName;
                m.Price = t.Price;
                m.ArtisName = t.ArtisName;
                m.PriceFormatted = t.PriceFormatted;
                arrayOfMusic[x] = m;
                x++;
            }
            request.ListaMusicas = arrayOfMusic;
            AFabricanteB.MakeCD(request);
            
            return new ObjectMakeCDResponse();
        }
    }
}
