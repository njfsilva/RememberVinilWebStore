using System.ServiceModel;
using System.Text;

namespace BackOffice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WebSiteService" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class WebSiteService : IWebSiteService
    {
        public string SessionLogin(string loginName)
        {
            return loginName;
        }

        public string GetArtistTopTracks(string artist)
        {
            var outputs = LastFmHelper.GetArtistTopTracks(artist);
            var sb = new StringBuilder();

            foreach (var output in outputs)
            {
                sb.Append(output);
            }

            return sb.ToString();
        }

        public AlbumsDto GetAlbumsByArtist(string artist)
        {

            var outputs = new AlbumsDto();
            
            outputs.AlbumsList = LastFmHelper.GetArtistTopAlbums(artist);

            return outputs;
        }

        public int RequestOrder()
        {
            return 43;
        }
    }
}
