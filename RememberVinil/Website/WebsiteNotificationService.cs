using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Website
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WebsiteNotificationService" in both code and config file together.
    public class WebsiteNotificationService : IWebsiteNotificationService
    {
        public void ReceiveNotification(Notification notification)
        {
            foreach (var n in notification.GetAllNotifications())
            {
                WebsiteMain.notifications.Add(n);
            }
        }
    }
}
