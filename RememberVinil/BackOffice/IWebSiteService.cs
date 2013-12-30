using System.ServiceModel;
using System.ServiceModel.Web;

namespace BackOffice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWebSiteService" in both code and config file together.
    [ServiceContract]
    public interface IWebSiteService
    {
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json, UriTemplate = "/session/login.json")]
        string SessionLogin(string loginName);

        [WebGet(UriTemplate = "/TopTracks/{artist}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        string GetArtistTopTracks(string artist);

        [WebGet(UriTemplate = "/Albums/{artist}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        string GetAlbumsByArtist(string artist);

        [WebGet(UriTemplate = "/RequestOrder/", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        int RequestOrder();
    }
}
