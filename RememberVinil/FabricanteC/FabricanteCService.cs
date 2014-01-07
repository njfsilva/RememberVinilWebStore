using System.Threading;
using FabricanteC.BOCallBack;

namespace FabricanteC
{
    public class FabricanteCService : IFabricanteCService
    {
        public FabricantePriceResponse GetQuote(ObjectQuoteRequest request)
        {

            var thread = new Thread(() =>
            {
                double total = 0;
                foreach (var m in request.ListaMusicas)
                {
                    total += m.price;
                    //total += 0.99;
                }

                var client = new BackOfficeCallBackServiceClient();

                var response = new BOCallBack.TransportJobPriceResponse
                {
                    encomendaID = request.encomendaID,
                    fabricante = request.fabricante,
                    refRequestPrice = request.WSCallback,
                    Price = total,
                    userID = request.userID
                };
                client.GetTransporterPrice(response);
            });
            thread.Start();
            return new FabricantePriceResponse();
        }

        public ObjectMakeCDResponse MakeCd(ObjectCDRequest request)
        {
            var thread = new Thread(() =>
            {
                int newID = FabricaCDB.AddNewCDRequest(request);
                var client = new BackOfficeCallBackServiceClient();

                var response = new BOCallBack.ObjectMakeCDResponse();

                //response.id = newID;
                //response.refRequestCD = request.WSCallback;
                //response.userID = request.userid;
                //response.Status = "recebida a encomenda";
                //client.GetStatus(response);
                Thread.Sleep(2000);

                response.id = newID;
                response.refRequestCD = request.WSCallback;
                response.userID = request.userid;
                response.Status = "Pronto a levantar";
                response.fabrica = "fabrica c";
                response.Distance = request.Distance;
                response.DeliveryAdress = request.DeliveryAdress;
                client.GetStatus(response);
            });
            thread.Start();
            return new ObjectMakeCDResponse();
        }
    }
}
