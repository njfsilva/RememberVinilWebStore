namespace Website
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WebsiteNotificationService" in both code and config file together.
    public class WebsiteNotificationService : IWebsiteNotificationService
    {
        public void ReceiveNotification(Notification notification)
        {
            foreach (var n in notification.GetAllNotifications())
            {
                WebsiteMain.Notifications.Add(n);
            }
        }
    }
}
