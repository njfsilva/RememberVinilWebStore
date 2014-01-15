using System.ServiceModel;
using System.ServiceModel.Web;

namespace BackOffice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWebSiteService" in both code and config file together.
    [ServiceContract]
    public interface IWebSiteService
    {
        [WebGet(UriTemplate = "/Login/{user}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        User SessionLogin(string user);

        [WebGet(UriTemplate = "/TopTracks/{artist}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        TracksDto GetArtistTopTracks(string artist);

        [WebGet(UriTemplate = "/Albums/{artist}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        AlbumsDto GetAlbumsByArtist(string artist);

        [WebGet(UriTemplate = "/Artists/{artist}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        ArtistsDto SearchForArtists(string artist);

        //[WebGet(UriTemplate = "/RequestOrder/", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        //[OperationContract]
        //int RequestOrder();

        //[OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/RequestOrder/", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        OrderStatus RequestOrder(OrderInfo order);


        [WebGet(UriTemplate = "/RequestUpdate/{loginName}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        string GetOrderStatus(string loginName);
    }
}
