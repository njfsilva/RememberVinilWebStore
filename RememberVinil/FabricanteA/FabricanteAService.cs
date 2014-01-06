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
                response.userID = request.userID;
                client.GetTransporterPrice(response);
            });
            thread.Start();
            return new FabricantePriceResponse();
        }

        public string MakeCD(ObjectCDRequest request)
        {
            return FabricaADB.AddNewCDRequest(request).ToString();
        }

    }
}
