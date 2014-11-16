using System;
using System.Collections.Generic;

namespace Website
{
    [Serializable]
    public abstract class Notification
    {
        protected Notification(string cdReadyNotification, string downloadReadyNotification, string orderStatusNotification)
        {
            OrderStatusNotification = orderStatusNotification;
            DownloadReadyNotification = downloadReadyNotification;
            CdReadyNotification = cdReadyNotification;
        }

        private string CdReadyNotification { get; set; }
        private string DownloadReadyNotification { get; set; }
        private string OrderStatusNotification { get; set; }


        public IEnumerable<string> GetAllNotifications()
        {
            var returnList = new List<string>();

            if (!string.IsNullOrEmpty(CdReadyNotification))
            {
                    returnList.Add(CdReadyNotification);
            }

            if (!string.IsNullOrEmpty(DownloadReadyNotification))
            {
                returnList.Add(DownloadReadyNotification);
            }

            if (!string.IsNullOrEmpty(OrderStatusNotification))
            {
                returnList.Add(OrderStatusNotification);
            }
            return returnList;
        }
    }
}
