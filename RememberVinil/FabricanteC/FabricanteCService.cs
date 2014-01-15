using System.Linq;
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
                var total = request.ListaMusicas.Sum(m => m.price);

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
                var newId = FabricaCDB.AddNewCDRequest(request);
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
                response.fabrica = "fabrica c";
                response.Distance = request.Distance;
                response.DeliveryAdress = request.DeliveryAdress;
                client.GetStatus(response);
            });
            thread.Start();
            return new ObjectMakeCdResponse();
        }
    }
}
