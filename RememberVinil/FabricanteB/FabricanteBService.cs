using System.Threading;
using FabricanteB.BOCallBack;
namespace FabricanteB
{
    public class FabricanteBService : IFabricanteBService
    {

        public FabricantePriceResponse GetQuote(ObjectQuoteRequest request)
        {

            var thread = new Thread(() =>
            {
                double total = 0;
                foreach (var m in request.ListaMusicas)
                {
                    //total += m.Price;
                    total += 1;
                }

                var client = new BackOfficeCallBackServiceClient();

                var response = new BOCallBack.FabricantePriceResponse
                {
                    encomendaID = request.encomendaID,
                    fabricante = request.fabricante,
                    refRequestPrice = request.WSCallback,
                    Price = total,
                    userID = request.userID
                };
                client.GetFabricantePrice(response);
            });
            thread.Start();
            return new FabricantePriceResponse();
        }

        public ObjectMakeCdResponse MakeCd(ObjectCDRequest request)
        {
            var thread = new Thread(() =>
            {
                int newId = FabricaBDB.AddNewCDRequest(request);
                var client = new BackOfficeCallBackServiceClient();

                var response = new ObjectMakeCDResponse();

                //response.id = newID;
                //response.refRequestCD = request.WSCallback;
                //response.userID = request.userid;
                //response.Status = "recebida a encomenda";
                //client.GetStatus(response);
                Thread.Sleep(2000);

                response.id = newId;
                response.refRequestCD = request.WSCallback;
                response.userID = request.userid;
                response.Status = "Pronto a levantar";
                response.fabrica = "fabrica b";
                response.Distance = request.Distance;
                response.DeliveryAdress = request.DeliveryAdress;
                client.GetStatus(response);
            });
            thread.Start();
            return new ObjectMakeCdResponse();
        }
    }
}
