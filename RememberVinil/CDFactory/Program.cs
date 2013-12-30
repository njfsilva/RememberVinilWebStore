using System;
using System.Messaging;
using System.Timers;

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
            Console.WriteLine(messageToProcess.Body);
        }
    }
}
