using System.Threading;
using FabricanteA.BOCallBack;

namespace FabricanteA
{
    public class FabricanteAService : IFabricanteAService
    {
        public FabricantePriceResponse getQuote(ObjectQuoteRequest request)
        {

            var thread = new Thread(() =>
            {
                double total = 0;
                foreach (var m in request.ListaMusicas)
                {
                    //total += m.price;
                    total += 0.99;
                }

                var client = new BackOfficeCallBackServiceClient();

                var response = new BOCallBack.TransportJobPriceResponse();
                response.encomendaID = request.encomendaID;
                response.fabricante = request.fabricante;
                response.refRequestPrice = request.WSCallback;
                response.Price = total;
                client.GetTransporterPrice(response);
            });
            thread.Start();
            return new FabricantePriceResponse();
        }




        public ObjectMakeCDResponse MakeCD(ObjectCDRequest request)
        {
            var thread = new Thread(() =>
            {
                int newID= FabricaADB.AddNewCDRequest(request);
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
                response.fabrica = "fabrica a";
                response.Distance = request.Distance;
                response.DeliveryAdress = request.DeliveryAdress;
                client.GetStatus(response);
            });
            thread.Start();

            return new ObjectMakeCDResponse();
        }
    }
}
