using System;

namespace CDFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            const string queuePath = ".\\Private$\\CDFactory";

            MessageQueueHelper.CreateQueue(queuePath);

            MessageQueueHelper.SendMessage(queuePath, "teste", "teste");

            Console.ReadLine();

        }
    }
}
