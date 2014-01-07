using System;
using Transportadora.VinilBackoffice;

namespace Transportadora
{
    public class PriceCalculator
    {
        public void PriceCalc(TransportJobPriceRequest request)
        {
            double d = 0;
            double result;
            try
            {
                d = Convert.ToDouble(request.Distance)/1000;
            }
            catch (Exception)
            {
                d = 0;
            }
            result = (d * 0.26 / 1000);
            var client = new BackOfficeCallBackServiceClient();

            var response = new VinilBackoffice.TransportJobPriceResponse();
            response.encomendaID = request.encomendaID;
            response.fabricante = request.fabrica;
            response.refRequestPrice = request.WSCallback;
            response.Price = result;
            response.userID = request.userID;
            client.GetTransporterPrice(response);
        }
    }
}
