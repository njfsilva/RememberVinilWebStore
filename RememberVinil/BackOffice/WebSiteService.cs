using System.Collections.Generic;
using System.ServiceModel;
using System.Text;
using System.Threading;
using CDFactory;

namespace BackOffice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WebSiteService" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class WebSiteService : IWebSiteService
    {
        public const string InboxQueuePath = ".\\Private$\\CDFactoryInbox";

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

        public Order RequestOrder(OrderInfo order)
        {
            var thread = new Thread(() =>
            {
                BackOfficeCallBackService.orderList.Add(order);

                //get quotes from fabricantes
                //get quotes from transportadora
                //select fabricante and tell transportadora qhere to get cd and where to deliver
                
                
                //add to cdfactory
                var inboxMessage = new CDFactory.SongsByOrder
                {
                    OrderId = BackOfficeCallBackService.orderList.IndexOf(order).ToString(),
                    TrackList = new List<CDFactory.Track>()
                };

                foreach (var track in order.orderedTracks)
                {
                    var newTrack = new CDFactory.Track
                    {
                        ArtisName = track.ArtisName,
                        Price = track.Price,
                        PriceFormatted = track.PriceFormatted,
                        TrackName = track.TrackName
                    };

                    inboxMessage.TrackList.Add(newTrack);
                }

                MessageQueueHelper.SendMessage(InboxQueuePath, inboxMessage, "Order to Process");
            });
            
            thread.Start();

            return new Order
            {
                status = "Encomenda Recebida"
            };
        }

        private static string InputHandler(string input)
        {
            var bytes = Encoding.Default.GetBytes(input);
            return Encoding.UTF8.GetString(bytes);
        }

        public string getOrderStatus(string loginName)
        {
            var user = UserDB.GetUserByUsername(loginName);

            if (user!=null)
            {
                return user.getLatestOrderStatus();
            }
            
            return string.Empty;
        }
    }
}
