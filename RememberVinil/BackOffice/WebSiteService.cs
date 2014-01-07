using System.Collections.Generic;
using System.ServiceModel;
using System.Text;
using System.Threading;
using CDFactory;
using BackOffice.FabricanteAService;
using BackOffice.FabricanteBService;
using BackOffice.FabricanteCService;
using BackOffice.TransportadoraServiceReference;

namespace BackOffice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WebSiteService" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class WebSiteService : IWebSiteService
    {
        public const string InboxQueuePath = ".\\Private$\\CDFactoryInbox";
        public const string fabricaA = "praça do império, porto";
        public const string fabricaB = "Jardim da Boavista, Porto";
        public const string fabricaC = "Avenida do Brasil, Porto";


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
                IAdapterFabricantes adapterA = new AdapterFabricanteA(new FabricanteAServiceClient());
                adapterA.getPrice(order.orderedTracks);
                IAdapterFabricantes adapterB = new AdapterFabricanteB(new FabricanteBServiceClient());
                adapterB.getPrice(order.orderedTracks);
                IAdapterFabricantes adapterC = new AdapterFabricanteC(new FabricanteCServiceClient());
                adapterC.getPrice(order.orderedTracks);

                //get quotes from transportadora
                TransportadoraServiceClient transp = new TransportadoraServiceClient();

                TransportJobPriceRequest requestA =new TransportJobPriceRequest();
                requestA.DeliveryAdress = order.morada;
                requestA.Distance = GeocodingHelper.GetDistanceBetweenPlaces(order.morada, fabricaA);
                requestA.fabrica = "fabrica a";
                requestA.userID = order.userID;
                transp.TransportJobPrice(requestA);

                TransportJobPriceRequest requestB = new TransportJobPriceRequest();
                requestB.DeliveryAdress = order.morada;
                requestB.Distance = GeocodingHelper.GetDistanceBetweenPlaces(order.morada, fabricaB);
                requestB.fabrica = "fabrica b";
                requestB.userID = order.userID;
                transp.TransportJobPrice(requestB);

                TransportJobPriceRequest requestC = new TransportJobPriceRequest();
                requestC.DeliveryAdress = order.morada;
                requestC.Distance = GeocodingHelper.GetDistanceBetweenPlaces(order.morada, fabricaC);
                requestC.fabrica = "fabrica c";
                requestC.userID = order.userID;
                transp.TransportJobPrice(requestC);

                //select fabricante and tell transportadora qhere to get cd and where to deliver
                while (order.all3Received()==false)
                {
                    System.Console.WriteLine("Waiting for CallBacks to Select the best Manufacturer");
                }

                TransportJobRequest request = new TransportJobRequest();
                switch (order.getbestdeal())
                {
                    case("fabrica a"):
                        request.DeliveryAdress = order.morada;
                        request.Distance= requestA.Distance;
                        request.encomendaID = order.encomendaid;
                        request.fabrica="fabrica a";
                        request.userID = order.userID;
                        transp.TransportJob(request);
                        break;
                    case ("fabrica b"):
                        request.DeliveryAdress = order.morada;
                        request.Distance= requestA.Distance;
                        request.encomendaID = order.encomendaid;
                        request.fabrica="fabrica b";
                        request.userID = order.userID;
                        transp.TransportJob(request);
                        transp.TransportJob(request);
                        break;
                    case ("fabrica c"):
                        request.DeliveryAdress = order.morada;
                        request.Distance= requestA.Distance;
                        request.encomendaID = order.encomendaid;
                        request.fabrica="fabrica c";
                        request.userID = order.userID;
                        transp.TransportJob(request);
                        break;
                    default:
                        break;
                }

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
            //user.ListaEncomendas.Add(new BackOffice.Order() { orderID="1",status="check"});
            if (user!=null)
            {
                return user.getLatestOrderStatus();
            }
            
            return string.Empty;
        }
    }
}
