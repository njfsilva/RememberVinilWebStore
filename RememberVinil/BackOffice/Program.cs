using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Timers;
using BackOffice.TransportadoraServiceReference;
using CDFactory;

namespace BackOffice
{
    class Program
    {
        //const string InboxQueuePath = ".\\Private$\\CDFactoryInbox";
        const string OutboxQueuePath = ".\\Private$\\CDFactoryOutBox";

        static void Main()
        {
            //Start BackOfficeService
            var backOfficeCallBackServiceHost = new WebServiceHost(typeof(BackOfficeCallBackService));
            backOfficeCallBackServiceHost.Open();

            //Start REST WebSiteService 
            var webSiteServer = new WebServiceHost(typeof(WebSiteService));
            webSiteServer.Open();

            //Create timer to check messageQueue Outbox
            var myTimer = new System.Timers.Timer();
            myTimer.Elapsed += new ElapsedEventHandler(LookForDownloadReady);
            myTimer.Interval = 5000;
            myTimer.Enabled = true;


            ////Transp Service test
            //var transp = new TransportadoraServiceClient();
            //var req = new TransportJobRequest();
            //req.DeliveryAdress = "address";
            //req.Status = "ordered";

            //TransportJobResponse resp = transp.TransportJob(req);

            //Console.WriteLine(resp.Sucess.ToString());

            Console.ReadLine();

            //Meter aqui os closes dos servicos nos fim
        }

        public static void LookForDownloadReady(object source, ElapsedEventArgs e)
        {
            string errorMessage = string.Empty;

            var message = MessageQueueHelper.ReceiveMessage(OutboxQueuePath, 20, out errorMessage);

            if (message != null)
            {
                NotifyUserDownloadReady();
            }
        }

        public static void NotifyUserDownloadReady()
        {

        }
    }
}
