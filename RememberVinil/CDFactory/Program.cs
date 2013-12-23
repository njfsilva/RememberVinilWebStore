using System;

namespace CDFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //teste MSMQ
            const string queuePath = ".\\Private$\\CDFactory";

            MessageQueueHelper.CreateQueue(queuePath);

            MessageQueueHelper.SendMessage(queuePath, "teste", "teste");

            string errorMessage = string.Empty;

            var message = MessageQueueHelper.ReceiveMessage(queuePath, 20,  out errorMessage);

            if (message != null)
            {
                Console.WriteLine(message.Body);
            }

            Console.ReadLine();
        }
    }
}
