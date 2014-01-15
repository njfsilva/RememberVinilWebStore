using System.Linq;
using System.Threading;
using FabricanteA.BOCallBack;

namespace FabricanteA
{
    public class FabricanteAService : IFabricanteAService
    {
        public FabricantePriceResponse GetQuote(ObjectQuoteRequest request)
        {

            var thread = new Thread(() =>
            {
                var total = request.ListaMusicas.Sum(m => 0.99);

                var client = new BackOfficeCallBackServiceClient();

                var response = new BOCallBack.FabricantePriceResponse
                {
                    encomendaID = request.EncomendaId,
                    fabricante = request.Fabricante,
                    refRequestPrice = request.WsCallback,
                    Price = total
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
                var newId= FabricaADB.AddNewCDRequest(request);
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
                response.fabrica = "fabrica a";
                response.Distance = request.Distance;
                response.DeliveryAdress = request.DeliveryAdress;
                client.GetStatus(response);
            });
            thread.Start();

            return new ObjectMakeCdResponse();
        }
    }
}
