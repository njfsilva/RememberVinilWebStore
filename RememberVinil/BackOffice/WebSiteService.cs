using System.ServiceModel;
using System.Text;

namespace BackOffice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WebSiteService" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class WebSiteService : IWebSiteService
    {
        public User SessionLogin(string loginName)
        {
            var user = UserDB.GetUserByUsername(loginName);

            if (!string.IsNullOrEmpty(user.Username))
            {
                user.HasPermissionToUseApplication = true;
                UserDB.GetLoggedInUsers().Add(user);
                return user;
            }

            return new User
            {
                HasPermissionToUseApplication = false
            };
        }

        public TracksDto GetArtistTopTracks(string artist)
        {
            var outputs = new TracksDto();

            outputs.ArtistName = artist;

            outputs.TracksList = LastFmHelper.GetArtistTopTracks(InputHandler(artist));

            return outputs;
        }

        public AlbumsDto GetAlbumsByArtist(string artist)
        {

            var outputs = new AlbumsDto
            {
                ArtistName = artist,
                AlbumsList = LastFmHelper.GetArtistTopAlbums(InputHandler(artist))
            };

            return outputs;
        }

        public ArtistsDto SearchForArtists(string artist)
        {
            var outputs = new ArtistsDto
            {
                ArtistName = artist,
                ArtistsList = LastFmHelper.SearchArtistByName(InputHandler(artist))
            };

            return outputs;
        }

        public int RequestOrder()
        {
            return 43;
        }

        private static string InputHandler(string input)
        {
            var bytes = Encoding.Default.GetBytes(input);
            return Encoding.UTF8.GetString(bytes);
            
            //return input.Replace(" ", "+").Replace(",", "").Replace(".", "").Replace("&", "+").Replace("+++", "+").Replace("++", "+");
        }
    }
}
