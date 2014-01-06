using System;
using System.Messaging;
using System.Threading;
using System.Timers;
using System.Collections.Generic;
using System.IO;

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

            //// Create a timer to look for work
            var myTimer = new System.Timers.Timer();
            myTimer.Elapsed += new ElapsedEventHandler(LookForWork);
            myTimer.Interval = 1;
            myTimer.Enabled = true;

            //var msmqPooling = new Thread(() =>
            //{
            //    while (true)
            //    {
            //        AddToMsmq();
            //    }
            //}
            //    );

            //msmqPooling.Start();

            Console.ReadLine();
        }

        public static void AddToMsmq()
        {
            //teste
            var test = new List<string>
            {
                "Myley Cyrus - Recking Ball",
                "Eminem - Berzerk"
            };


            MessageQueueHelper.SendMessage(InboxQueuePath, test, "Test Message");
        }

        public static void LookForWork(object sender, EventArgs e)
        {
            string errorMessage = string.Empty;

            var message = MessageQueueHelper.ReceiveMessage(InboxQueuePath, 20, out errorMessage);

            if (message != null)
            {
                DoWork(message);
            }
        }

        public static void DoWork(Message messageToProcess)
        {

            var test = messageToProcess.Body;

            var dirinfo = Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\IdDaEncomenda");

            foreach (var song in (List<string>)test)
            {
                //File.Create(dirinfo.FullName + "\\" + song + ".mp3");
                Console.WriteLine("Processed: " + song);
            }

            //zipar conteudo e enviar para a message queue outbox
        }
    }
}
