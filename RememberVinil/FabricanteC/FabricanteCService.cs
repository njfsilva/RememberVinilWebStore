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

        public string MakeCd(ObjectCDRequest request)
        {
            return FabricaCDB.AddNewCDRequest(request).ToString();
        }
    }
}
