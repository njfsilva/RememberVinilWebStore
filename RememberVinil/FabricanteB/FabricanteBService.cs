using System.Linq;
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
                var total = request.ListaMusicas.Aggregate<Music, double>(0, (current, m) => current + 1);

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

        public ObjectMakeCDResponse MakeCD(ObjectCDRequest request)
        {
            var thread = new Thread(() =>
            {
                var newId = FabricaBDB.AddNewCDRequest(request);
                var client = new BackOfficeCallBackServiceClient();

                var response = new BOCallBack.ObjectMakeCDResponse();

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
            return new ObjectMakeCDResponse();
        }
    }
}
