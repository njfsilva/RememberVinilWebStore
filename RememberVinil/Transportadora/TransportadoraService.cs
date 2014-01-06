using System;
using System.Threading;

namespace Transportadora
{
    public class TransportadoraService : ITransportadoraService
    {

        public string TransportJob(TransportJobRequest request)
        {
            var response = new TransportJobResponse();
            int id = 0;
            try
            {
                id=TransportadoraDB.AddNewTransportJob(request);
                response.Sucess = true;
            }
            catch (Exception)
            {
                response.Sucess = false;
            }


            return id.ToString();
        }


        public TransportJobPriceRequest TransportJobPrice(TransportJobPriceRequest request)
        {
            PriceCalculator workerObject = new PriceCalculator();
            Thread thread = new Thread(() => workerObject.PriceCalc(request));
            thread.Start();
            return new TransportJobPriceRequest();
        }
    }
}
