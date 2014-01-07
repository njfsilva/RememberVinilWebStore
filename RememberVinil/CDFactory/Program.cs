using System;
using System.Messaging;
using System.Timers;
using System.Collections.Generic;
using System.IO;
using Ionic.Zip;
using Ionic.Zlib;
using Timer = System.Timers.Timer;


namespace CDFactory
{
    class Program
    {
        const string InboxQueuePath = ".\\Private$\\CDFactoryInbox";
        const string OutboxQueuePath = ".\\Private$\\CDFactoryOutBox";

        static void Main(string[] args)
        {
            //Creates Queues
            MessageQueueHelper.CreateQueue(InboxQueuePath);
            MessageQueueHelper.CreateQueue(OutboxQueuePath);

            //test code
                //AddToMsmq();
            

            //// Create a timer to look for work
            var myTimer = new Timer();
            myTimer.Elapsed += new ElapsedEventHandler(LookForWork);
            myTimer.Interval = 1;
            myTimer.Enabled = true;

            Console.ReadLine();
        }

        public static void AddToMsmq()
        {
            //teste
            var test = new List<Track>
            {
                new Track
                {
                    ArtisName = "Myley Cyrus",
                    TrackName = "Recking Ball",
                },
                new Track
                {
                    ArtisName = "Eminem",
                    TrackName = "Berzerk",
                }
                //new Track
                //{
                //    ArtisName = "Tretas",
                //    TrackName = "Recking Ball",
                //},
                //new Track
                //{
                //    ArtisName = "Super Tretas",
                //    TrackName = "Recking Ball",
                //}
            };

            var songsByorder = new SongsByOrder
            {
                OrderId = "1",
                TrackList = test
            };

            MessageQueueHelper.SendMessage(InboxQueuePath, songsByorder, "Test Message");
        }

        public static void LookForWork(object sender, EventArgs e)
        {
            var errorMessage = string.Empty;

            var message = MessageQueueHelper.ReceiveMessage(InboxQueuePath, 1000, out errorMessage);

            if (message != null)
            {
                DoWork(message);
            }
        }

        public static void DoWork(Message messageToProcess)
        {

            var songsByOrder = (SongsByOrder)messageToProcess.Body;

            //SongsByOrder songsbyorder = new SongsByOrder
            //{
            //    OrderId = songsByOrder.OrderId
            //};

            var dirinfo = Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\" + songsByOrder.OrderId);

            foreach (var song in songsByOrder.TrackList)
            {
                var mp3File = dirinfo.FullName + "\\" + song.TrackName + ".mp3";
                var lyricsFile = dirinfo.FullName + "\\" + song.TrackName + ".txt";

                File.Create(mp3File).Dispose();
                File.Create(lyricsFile).Dispose();

                var lyrics = new List<string>();

                lyrics.Add(LyricsHelper.GetLyrics(song.TrackName, song.ArtisName));

                File.WriteAllLines(lyricsFile, lyrics);

                Console.WriteLine("Processed: " + song.TrackName + " for Order number: " + songsByOrder.OrderId);
            }

            using (var zip = new ZipFile())
            {
                zip.AddDirectory(dirinfo.FullName);
                zip.CompressionLevel = CompressionLevel.BestCompression;
                zip.Comment = "This zip was created at " + DateTime.Now.ToString("G");
                zip.Save(string.Format("Order{0}.zip", songsByOrder.OrderId)); 
            }

            var cdReady = new DownloadReady
            {
                OrderId = songsByOrder.OrderId,
                LinkToDownload = Directory.GetCurrentDirectory() + "\\" + string.Format("Order{0}.zip", songsByOrder.OrderId)
            };

            MessageQueueHelper.SendMessage(OutboxQueuePath, cdReady, "Download for Order"+songsByOrder.OrderId);
        }
    }
}
