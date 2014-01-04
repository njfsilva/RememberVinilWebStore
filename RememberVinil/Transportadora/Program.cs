using System;
using System.ServiceModel;
using System.Threading;
using Transportadora.VinilBackoffice;

namespace Transportadora
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(TransportadoraService));
            host.Open();
            Console.ReadLine();

            ////Callback test
            var boCallback = new BackOfficeCallBackServiceClient();
            VinilBackoffice.TransportJobResponse resposta = new VinilBackoffice.TransportJobResponse();
            resposta.Status = "pedido recebido";
            boCallback.getStatus(resposta);
            Thread.Sleep(2000);
            resposta.Status = "pedido a ser tratado";
            boCallback.getStatus(resposta);
            Thread.Sleep(2000);
            resposta.Status = "pedido concluido";
            boCallback.getStatus(resposta);
            //var req = new TransportJobRequest();
            //req.DeliveryAdress = "address";
            //req.Status = "ordered";

            //TransportJobResponse resp = transp.TransportJob(req);

        }
    }
}
