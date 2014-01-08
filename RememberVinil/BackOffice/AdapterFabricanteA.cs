using System.Collections.Generic;
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
            var request = new ObjectQuoteRequest();
            request.encomendaID=order.encomendaid;
            request.fabricante = "fabrica a";
            request.userID = order.userID;
            request.WSCallback = "qwerty";
            var x = 0;
            var arrayOfMusic = new Music[order.orderedTracks.Count];
            foreach (var t in order.orderedTracks)
            {
                var m = new Music();
                m.nome = t.TrackName;
                m.price = t.Price;
                arrayOfMusic[x] = m;
                x++;
            }
            request.ListaMusicas = arrayOfMusic;

            AFabricanteA.getQuote(request);
            return new FabricantePriceResponse();
        }


        public ObjectMakeCDResponse setOrder(OrderInfo order)
        {
            var request = new ObjectCDRequest();
            request.WSCallback = "xxxxxxx";
            request.DeliveryAdress = order.morada;
            request.Distance = order.distance;
            request.encomendaID = order.encomendaid;
            request.fabrica = "fabrica a";
            request.userid = Convert.ToInt32(order.userID);
            var arrayOfMusic = new Music[order.orderedTracks.Count];
            var x = 0;
            foreach (var t in order.orderedTracks)
            {
                var m = new Music();
                m.nome = t.TrackName;
                m.price = t.Price;
                arrayOfMusic[x] = m;
                x++;
            }
            request.ListaMusicas = arrayOfMusic;
            AFabricanteA.MakeCD(request);

            return new ObjectMakeCDResponse();
        }
    }
}
