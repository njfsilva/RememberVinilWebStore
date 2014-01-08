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

        public FabricantePriceResponse getPrice(OrderInfo order)
        {
            var request = new ObjectQuoteRequest();
            request.encomendaID = order.encomendaid;
            request.fabricante = "fabrica c";
            request.userID = order.userID;
            request.WSCallback = "qwerty";
            var x = 0;
            var arrayOfMusic = new Music[order.orderedTracks.Count];
            foreach (var t in order.orderedTracks)
            {
                var m = new Music();
                m.nome = t.TrackName;
                m.price = 0.99;
                m.duracao = getMusicDuration(m.nome);
                arrayOfMusic[x] = m;
                x++;
            }
            request.ListaMusicas = arrayOfMusic;

            AFabricanteC.GetQuote(request);
            return new FabricantePriceResponse();
        }

        public double getMusicDuration(string musicName)
        {
            var random = new Random();
            var minutes = random.NextDouble() * (5 - 3) + 3;

            return Math.Round(minutes, 2);
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
