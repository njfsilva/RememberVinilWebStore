using System;
using System.Messaging;
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

            // Create a timer to look for work
            var myTimer = new System.Timers.Timer();
            myTimer.Elapsed += new ElapsedEventHandler(LookForWork);
            myTimer.Interval = 5000;
            myTimer.Enabled = true;

            //remover
            DoWork(new Message());


            Console.ReadLine();
        }

        public static void LookForWork(object source, ElapsedEventArgs e)
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
            var test = new List<string>
            {
                "Myley Cyrus - Recking Ball",
                "Eminem - Berzerk"
            };

            var dirinfo = Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\IdDaEncomenda");

            foreach (var song in test)
            {
                File.Create(dirinfo.FullName + "\\" + song + ".mp3");
            }
            
            //zipar conteudo e enviar para a message queue outbox
        }
    }
}
