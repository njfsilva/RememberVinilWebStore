using System.Threading;
using Transportadora.VinilBackoffice;

namespace Transportadora
{
    public class TransportadoraService : ITransportadoraService
    {

        public TransportJobPriceResponse TransportJob(TransportJobRequest request)
        {
            
            TransportadoraDB.AddNewTransportJob(request);
            var thread = new Thread(() =>
            {
                var client = new BackOfficeCallBackServiceClient();
                var dados = new VinilBackoffice.TransportJobResponse
                {
                    DeliveryAdress = request.DeliveryAdress,
                    Distance = request.Distance,
                    encomendaID = request.encomendaID,
                    fabrica = request.fabrica,
                    userID = request.userID,
                    Status = "ja fui ao fabricante"
                };
                client.UpdateOrderTransportStatus(dados);
                Thread.Sleep(2000);
                dados.Status = "estou a caminho do cliente";
                client.UpdateOrderTransportStatus(dados);
                Thread.Sleep(2000);
                dados.Status = "Entregue!";
                client.UpdateOrderTransportStatus(dados);
            });
            thread.Start();
            return new TransportJobPriceResponse();
        }


        public TransportJobPriceRequest TransportJobPrice(TransportJobPriceRequest request)
        {
            var workerObject = new PriceCalculator();
            var thread = new Thread(() => PriceCalculator.PriceCalc(request));
            thread.Start();
            return new TransportJobPriceRequest();
        }
    }
}
