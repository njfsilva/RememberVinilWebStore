using System;
using System.Messaging;
using System.ServiceModel.Web;
using System.Timers;
using CDFactory;
using Newtonsoft.Json;
using RestSharp;
using Timer = System.Timers.Timer;

namespace BackOffice
{
    static class Program
    {
        
        const string OutboxQueuePath = ".\\Private$\\CDFactoryOutBox";

        static void Main()
        {
            //Create Users
            UserDB.AddUser(new User("u1", "p1","1"));
            UserDB.AddUser(new User("u2", "p2","2"));
            UserDB.AddUser(new User("u3", "p3","3"));

            //Start BackOfficeService
            var backOfficeCallBackServiceHost = new WebServiceHost(typeof(BackOfficeCallBackService));
            backOfficeCallBackServiceHost.Open();

            //Start REST WebSiteService 
            var webSiteServer = new WebServiceHost(typeof(WebSiteService));
            webSiteServer.Open();

            //Create timer to check messageQueue Outbox
            var myTimer = new Timer();
            myTimer.Elapsed += LookForDownloadReady;
            myTimer.Interval = 5;
            myTimer.Enabled = true;

            Console.ReadLine();

            //Meter aqui os closes dos servicos nos fim
        }

        private static void LookForDownloadReady(object source, ElapsedEventArgs e)
        {
            string errorMessage;

            var message = MessageQueueHelper.ReceiveMessage(OutboxQueuePath, 20, out errorMessage);

            if (message != null)
            {
                NotifyUserDownloadReady(message);
            }
        }

        private static void NotifyUserDownloadReady(Message msgToProcess)
        {
            var cdReady = (DownloadReady) msgToProcess.Body;
            
            const string websiteNotification = "http://localhost:9010/WebsiteNotificationService";
            var client = new RestClient(websiteNotification);

            var whatToGet = "/Notitication/";

            var request = new RestRequest("/Notitication/", Method.POST);

            var notification = new Notification
            {
                DownloadReadyNotification = "O CD da ordem " +cdReady.OrderId + " esta pronto e localiz-se em: "+ cdReady.LinkToDownload
            };

            var json = JsonConvert.SerializeObject(notification);
            request.AddParameter("text/json", json, ParameterType.RequestBody);

            var response = client.Execute(request);

            Console.WriteLine("Download ready for order {0}: {1}", cdReady.OrderId, cdReady.LinkToDownload);
        }
    }
}
