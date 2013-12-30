using System;
using System.ServiceModel.Web;
using System.Timers;
using CDFactory;

namespace BackOffice
{
    class Program
    {
        const string InboxQueuePath = ".\\Private$\\CDFactoryInbox";
        const string OutboxQueuePath = ".\\Private$\\CDFactoryOutBox";

        static void Main()
        {
            //Create timer to check messageQueue Outbox
            var myTimer = new System.Timers.Timer();
            myTimer.Elapsed += new ElapsedEventHandler(LookForDownloadReady);
            myTimer.Interval = 5000;
            myTimer.Enabled = true;

            //Start WebSiteService
            var iservice = new WebSiteService();
            var server = new WebServiceHost(iservice, new Uri("http://localhost:9001/WebSiteService"));

            server.Open();

            //teste web services
            //var outputs = LastFmHelper.GetArtistTopTracks("Eminem");

            //foreach (var output in outputs)
            //{
            //    Console.WriteLine(output);
            //}

            //Console.WriteLine(GeocodingHelper.GetDistanceBetweenPlaces("rua jose cardoso pires 22 rio tinto PT", "travessa da boavista 22 rio tinto PT"));

            Console.ReadLine();

            server.Close();
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
