using System.Threading;
using FabricanteB.BOCallBack;
namespace FabricanteB
{
    public class FabricanteBService : IFabricanteBService
    {

        public FabricantePriceResponse getQuote(ObjectQuoteRequest request)
        {

            var thread = new Thread(() =>
            {
                double total = 0;
                foreach (var m in request.ListaMusicas)
                {
                    //total += m.price;
                    total += 1;
                }

                var client = new BackOfficeCallBackServiceClient();

                var response = new BOCallBack.FabricantePriceResponse();
                response.encomendaID = request.encomendaID;
                response.fabricante = request.fabricante;
                response.refRequestPrice = request.WSCallback;
                response.Price = total;
                response.userID = request.userID;
                client.GetFabricantePrice(response);
            });
            thread.Start();
            return new FabricantePriceResponse();
        }

        public ObjectMakeCDResponse MakeCD(ObjectCDRequest request)
        {
            var thread = new Thread(() =>
            {
                int newID = FabricaBDB.AddNewCDRequest(request);
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
                response.fabrica = "fabrica b";
                response.Distance = request.Distance;
                response.DeliveryAdress = request.DeliveryAdress;
                client.GetStatus(response);
            });
            thread.Start();
            return new ObjectMakeCDResponse();
        }
    }
}
