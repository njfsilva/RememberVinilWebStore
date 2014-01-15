using System.Collections.Generic;

namespace Website
{
    public class Notification
    {
        public string CdReadyNotification { get; set; }
        public string DownloadReadyNotification { get; set; }
        public string OrderStatusNotification { get; set; }


        public List<string> GetAllNotifications()
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
