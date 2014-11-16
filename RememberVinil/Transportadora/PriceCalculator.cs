using System;
using Transportadora.VinilBackoffice;

namespace Transportadora
{
    public class PriceCalculator
    {
        public static void PriceCalc(TransportJobPriceRequest request)
        {
            double d;
            try
            {
                d = Convert.ToDouble(request.Distance);
            }
            catch (Exception)
            {
                d = 0;
            }
            var result = (d * 0.26 / 1000);
            var client = new BackOfficeCallBackServiceClient();

            var response = new VinilBackoffice.TransportJobPriceResponse
            {
                encomendaID = request.encomendaID,
                fabricante = request.fabrica,
                refRequestPrice = request.WSCallback,
                Price = result,
                userID = request.userID
            };
            client.GetTransporterPrice(response);
        }
    }
}
