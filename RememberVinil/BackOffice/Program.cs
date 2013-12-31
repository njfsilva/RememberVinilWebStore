using System;
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
            //Start BackOfficeCallBackService
            //TODO!!!

            //Create timer to check messageQueue Outbox
            var myTimer = new System.Timers.Timer();
            myTimer.Elapsed += new ElapsedEventHandler(LookForDownloadReady);
            myTimer.Interval = 5000;
            myTimer.Enabled = true;
            

            //Start REST WebSiteService 
            var iservice = new WebSiteService();
            var webSiteServer = new WebServiceHost(iservice, new Uri("http://localhost:9001/WebSiteService"));
            webSiteServer.Open();


            //Start Transportadora Service
            var transportadoraService = new TransportadoraServiceClient();
            //var request = new TransportJobRequest {DeliveryAdress = "Cenas", Status = "Encomenda feita"};

            //var transportJobResponse = transportadoraService.TransportJob(request);

            //Console.WriteLine(transportJobResponse.Sucess.ToString());

            
            
            Console.ReadLine();

            webSiteServer.Close();
            transportadoraService.Close();
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
