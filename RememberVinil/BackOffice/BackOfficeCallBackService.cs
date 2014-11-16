using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using BackOffice.TransportadoraServiceReference;
using System.Threading;


namespace BackOffice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BackOfficeCallBackService" in both code and config file together.
    public class BackOfficeCallBackService : IBackOfficeCallBackService
    {
        public static List<OrderInfo> orderList = new List<OrderInfo>();
        private static object _sync = new object();

        public string GetStatus(ObjectMakeCDResponse response)//bad name: confirm order
        {
            var userId = response.userID.ToString(CultureInfo.InvariantCulture);
            var user =UserDB.GetUserByUserID(userId);
            var orderId = user.addOrder();
            var thread = new Thread(() =>
            {
                var transportadora = new TransportadoraServiceClient();

                var request = new TransportJobRequest
                {
                    DeliveryAdress = response.DeliveryAdress,
                    Distance = response.Distance,
                    encomendaID = orderId,
                    userID = userId,
                    fabrica = response.fabrica
                };
                transportadora.TransportJob(request);
            });
            thread.Start();
            return "ack";
        }

        public string UpdateOrderTransportStatus(TransportJobResponse response)
        {
            string userId = response.userID;
            var user = UserDB.GetUserByUserID(userId);
            user.updateOrderStatus(response.encomendaID,response.Status);
            System.Console.WriteLine(response.Status);
            return "ack";
        }
        
        public string GetTransporterPrice(TransportJobPriceResponse response)
        {
            lock (_sync)
            {
                OrderInfo order = null;
                System.Console.WriteLine(response.fabricante + " " + response.Price);
                if (orderList.Count > 0)
                {
                    foreach (var item in orderList)
                    {
                        if (item.encomendaid == response.encomendaID)
                        {
                            order = item;
                            break;
                        }
                    }
                }
                if (order == null)
                {
                    order = new OrderInfo(response.userID, response.encomendaID);
                    order.addpriceTransp(response.fabricante, response.Price);
                }
                else
                {
                    order.addpriceTransp(response.fabricante, response.Price);
                }
            }
            return "ack";
        }

        public string GetFabricantePrice(FabricantePriceResponse response)
        {
            lock (_sync)
            {
                var order = orderList.FirstOrDefault(item => item.encomendaid == response.encomendaID);

                if (order == null)
                {
                    order = new OrderInfo(response.userID, response.encomendaID);
                    order.addpriceFabric(response.fabricante, response.Price);
                }
                else
                {
                    order.addpriceFabric(response.fabricante, response.Price);
                }
            }
            return "ack";
        }

    }
}
