using System;
using System.Messaging;
using System.ServiceModel.Web;
using System.Timers;
using CDFactory;
using System.Collections.Generic;

namespace BackOffice
{
    class Program
    {
        const string InboxQueuePath = ".\\Private$\\CDFactoryInbox";
        const string OutboxQueuePath = ".\\Private$\\CDFactoryOutBox";

        static void Main()
        {
            //Create Users
            UserDB.AddUser(new User("u1", "p1"));
            UserDB.AddUser(new User("u2", "p2"));
            UserDB.AddUser(new User("u3", "p3"));

            //Start BackOfficeService
            var backOfficeCallBackServiceHost = new WebServiceHost(typeof(BackOfficeCallBackService));
            backOfficeCallBackServiceHost.Open();

            //Start REST WebSiteService 
            var webSiteServer = new WebServiceHost(typeof(WebSiteService));
            webSiteServer.Open();

            //Create timer to check messageQueue Outbox
            var myTimer = new Timer();
            myTimer.Elapsed += new ElapsedEventHandler(LookForDownloadReady);
            myTimer.Interval = 5;
            myTimer.Enabled = true;

            var Lista = new List<Track>();

            Lista.Add(new Track("ole", 12.5));
            Lista.Add(new Track("oli", 10.5));
            Lista.Add(new Track("olu", 9.5));

            var result=GeocodingHelper.GetDistanceBetweenPlaces("praça do império,porto", "rotunda da boavista,porto");
            //Console.WriteLine(result);
            var artist = LastFmHelper.SearchArtistByName("linkin park");
            foreach (var item in artist)
            {
                //Console.WriteLine(item);
            }
            
            //IAdapterFabricantes adapterA = new AdapterFabricanteA(new FabricanteAServiceClient());
            //double pricefabricantea = adapterA.getPrice(Lista);

            //IAdapterFabricantes adapterB = new AdapterFabricanteB(new FabricanteBServiceClient());
            //double pricefabricanteb = adapterB.getPrice(Lista);

            //IAdapterFabricantes adapterC = new AdapterFabricanteC(new FabricanteCServiceClient());
            //double pricefabricantec = adapterC.getPrice(Lista);

            //Console.WriteLine("a: " + pricefabricantea);
            //Console.WriteLine("b: " + pricefabricanteb);
            //Console.WriteLine("c: " + pricefabricantec);

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
            var errorMessage = string.Empty;

            var message = MessageQueueHelper.ReceiveMessage(OutboxQueuePath, 20, out errorMessage);

            if (message != null)
            {
                NotifyUserDownloadReady(message);
            }
        }

        public static void NotifyUserDownloadReady(Message msgToProcess)
        {
            var cdReady = (DownloadReady) msgToProcess.Body;
            Console.WriteLine("Download ready for order {0}: {1}", cdReady.OrderId, cdReady.LinkToDownload);
        }
    }
}
