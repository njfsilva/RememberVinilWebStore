using System;
using System.Messaging;


namespace CDFactory
{
    public static class MessageQueueHelper
    {
        public static void CreateQueue(string queuePath)
        {
            if (!MessageQueue.Exists(queuePath))
            {
                MessageQueue.Create(queuePath);
            }
        }

        public static void SendMessage(string queuePath, object obj2Send, string messageLabel)
        {
            // Connect to a queue on the local computer.
            var myQueue = new MessageQueue(queuePath);

            // Prepare message 
            var myMessage = new Message
            {
                Body = obj2Send,
                Label = messageLabel,
                Formatter = new BinaryMessageFormatter()
            };

            //Send the message into the queue.
            myQueue.Send(myMessage);

        }

        public static Message ReceiveMessage(string queuePath, int time2Wait, out string errorMessage)
        {
            // Define default errorMessage
            errorMessage = null;

            // Connect to the a queue on the local computer and set the formatter to indicate body contains a binary object
            var myQueue = new MessageQueue(queuePath)
            {
                Formatter = new BinaryMessageFormatter()
            };

            // Receive and format the message. 
            Message myMessage = null;
            var timeout = TimeSpan.Zero;
            if (time2Wait > 0)
                timeout = new TimeSpan(0, 0, time2Wait);

            try
            {
                myMessage = myQueue.Receive(timeout);
            }
            catch (MessageQueueException e)
            {
                if (e.MessageQueueErrorCode != MessageQueueErrorCode.IOTimeout)
                {
                    errorMessage = e.Message;
                }
            }

            return myMessage;
        }

        public static void RemoveMessageFromQueue(string queuePath, string messageId, out string errorMessage)
        {
            // Define default errorMessage
            errorMessage = null;

            // Connect to the a queue on the local computer.
            var myQueue = new MessageQueue(queuePath)
            {
                Formatter = new BinaryMessageFormatter()
            };



            try
            {
                myQueue.ReceiveById(messageId);
            }
            catch (MessageQueueException e)
            {
                if (e.MessageQueueErrorCode != MessageQueueErrorCode.IOTimeout)
                {
                    errorMessage = e.Message;
                }
            }

        }
    }
}

