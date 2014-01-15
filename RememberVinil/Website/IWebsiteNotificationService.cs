using System.ServiceModel;
using System.ServiceModel.Web;


namespace Website
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWebsiteNotificationService" in both code and config file together.
    [ServiceContract]
    public interface IWebsiteNotificationService
    {
        //[WebGet(UriTemplate = "/Notitication/", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        //[OperationContract]
        //void ReceiveNotification(Notification notification);

        [WebInvoke(Method = "POST", UriTemplate = "/Notitication/", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void ReceiveNotification(Notification notification);
    }
}
