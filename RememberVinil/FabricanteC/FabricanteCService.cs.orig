using System.Threading;
using FabricanteC.BOCallBack;

namespace FabricanteC
{
    public class FabricanteCService : IFabricanteCService
    {
        public double getQuote(ObjectQuoteRequest request)
        {
            double total = 0;
            foreach (Music m in request.ListaMusicas)
            {
                total += m.price;
                //total += 0.99;
            }
            return total;
        }

        public FabricantePriceResponse getQuote(ObjectQuoteRequest request)
        {

            Thread thread = new Thread(() =>
            {
                double total = 0;
                foreach (Music m in request.ListaMusicas)
                {
                    total += m.price;
                    //total += 0.99;
                }

                BackOfficeCallBackServiceClient client = new BackOfficeCallBackServiceClient();

                BOCallBack.TransportJobPriceResponse response = new BOCallBack.TransportJobPriceResponse();
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
            return FabricaCDB.AddNewCDRequest(request).ToString();
        }
    }
}
