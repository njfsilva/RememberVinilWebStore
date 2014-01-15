using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
        public const string FabricaA = "praça do império, porto";
        public const string FabricaB = "Jardim da Boavista, Porto";
        public const string FabricaC = "Avenida do Brasil, Porto";


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
            var outputs = new TracksDto
            {
                ArtistName = artist,
                TracksList = LastFmHelper.GetArtistTopTracks(InputHandler(artist))
            };

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

        public OrderStatus RequestOrder(OrderInfo order)
        {
            var thread = new Thread(() =>
            {
                BackOfficeCallBackService.OrderList.Add(order);

                //add to cdfactory
                var inboxMessage = new CDFactory.SongsByOrder
                {
                    OrderId = BackOfficeCallBackService.OrderList.IndexOf(order).ToString(CultureInfo.InvariantCulture),
                    TrackList = new List<CDFactory.Track>()
                };

                foreach (var track in order.OrderedTracks)
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


                //get quotes from fabricantes
                IAdapterFabricantes adapterA = new AdapterFabricanteA(new FabricanteAServiceClient());
                adapterA.GetPrice(order);
                IAdapterFabricantes adapterB = new AdapterFabricanteB(new FabricanteBServiceClient());
                adapterB.GetPrice(order);
                IAdapterFabricantes adapterC = new AdapterFabricanteC(new FabricanteCServiceClient());
                adapterC.GetPrice(order);

                //get quotes from transportadora
                var transp = new TransportadoraServiceClient();

                var requestA = new TransportJobPriceRequest
                {
                    DeliveryAdress = order.Morada,
                    Distance = GeocodingHelper.GetDistanceBetweenPlaces(order.Morada, FabricaA),
                    fabrica = "fabrica a",
                    userID = order.UserId
                };
                transp.TransportJobPrice(requestA);

                var requestB = new TransportJobPriceRequest
                {
                    DeliveryAdress = order.Morada,
                    Distance = GeocodingHelper.GetDistanceBetweenPlaces(order.Morada, FabricaB),
                    fabrica = "fabrica b",
                    userID = order.UserId
                };
                transp.TransportJobPrice(requestB);

                var requestC = new TransportJobPriceRequest
                {
                    DeliveryAdress = order.Morada,
                    Distance = GeocodingHelper.GetDistanceBetweenPlaces(order.Morada, FabricaC),
                    fabrica = "fabrica c",
                    userID = order.UserId
                };
                transp.TransportJobPrice(requestC);

                //select fabricante and tell transportadora qhere to get cd and where to deliver
                while (order.All3Received()==false)
                {
                    System.Console.WriteLine("Waiting for CallBacks to Select the best Manufacturer");
                    Thread.Sleep(1000);
                }

                //TransportJobRequest request = new TransportJobRequest();
                switch (order.Getbestdeal())
                {
                    case("fabrica a"):
                        order.Distance = GeocodingHelper.GetDistanceBetweenPlaces(order.Morada, FabricaA);
                        order.UserId = UserDB.GetLoggedInUsers().First().UserId; // "1";
                        adapterA.SetOrder(order);
                        //request.DeliveryAdress = order.morada;
                        //request.Distance= requestA.Distance;
                        //request.encomendaID = order.encomendaid;
                        //request.fabrica="fabrica a";
                        //request.userID = order.userID;
                        //transp.TransportJob(request);
                        break;
                    case ("fabrica b"):
                        order.Distance = GeocodingHelper.GetDistanceBetweenPlaces(order.Morada, FabricaC);
                        order.UserId = UserDB.GetLoggedInUsers().First().UserId; //"1";
                        adapterB.SetOrder(order);
                        //request.DeliveryAdress = order.morada;
                        //request.Distance= requestA.Distance;
                        //request.encomendaID = order.encomendaid;
                        //request.fabrica="fabrica b";
                        //request.userID = order.userID;
                        //transp.TransportJob(request);
                        break;
                    case ("fabrica c"):
                        order.Distance = GeocodingHelper.GetDistanceBetweenPlaces(order.Morada, FabricaB);
                        order.UserId = UserDB.GetLoggedInUsers().First().UserId; //"1";
                        adapterC.SetOrder(order);
                        
                        //request.DeliveryAdress = order.morada;
                        //request.Distance= requestA.Distance;
                        //request.encomendaID = order.encomendaid;
                        //request.fabrica="fabrica c";
                        //request.userID = order.userID;
                        //transp.TransportJob(request);
                        break;
                }
            });
            
            thread.Start();

            return new OrderStatus
            {
                Status = "Encomenda Recebida"
            };
        }

        private static string InputHandler(string input)
        {
            var bytes = Encoding.Default.GetBytes(input);
            return Encoding.UTF8.GetString(bytes);
        }

        public string GetOrderStatus(string loginName)
        {
            var user = UserDB.GetUserByUsername(loginName);
            //user.ListaEncomendas.Add(new BackOffice.Order() { orderID="1",status="check"});
            if (user!=null)
            {
                return user.GetLatestOrderStatus();
            }
            
            return string.Empty;
        }
    }
}
