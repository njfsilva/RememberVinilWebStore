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
        public static List<OrderInfo> OrderList = new List<OrderInfo>();
        private static object Sync = new object();

        public string GetStatus(ObjectMakeCdResponse response)//bad name: confirm order
        {
            var userId = response.UserId.ToString(CultureInfo.InvariantCulture);
            var user = UserDB.GetUserByUserID(userId);
            var orderId = user != null ? user.AddOrder() : "0";

            var thread = new Thread(() =>
            {
                var transportadora = new TransportadoraServiceClient();
                var request = new TransportJobRequest
                {
                    DeliveryAdress = response.DeliveryAdress,
                    Distance = response.Distance,
                    encomendaID = orderId,
                    userID = userId,
                    fabrica = response.Fabrica
                };
                transportadora.TransportJob(request);
            });

            thread.Start();
            
            return "ack";
        }

        public string UpdateOrderTransportStatus(TransportJobResponse response)
        {
            var userId = response.UserId;
            var user = UserDB.GetUserByUserID(userId);
            user.UpdateOrderStatus(response.EncomendaId,response.Status);
            System.Console.WriteLine(response.Status);
            return "ack";
        }
        
        public string GetTransporterPrice(TransportJobPriceResponse response)
        {
            lock (Sync)
            {
                OrderInfo order = null;
                System.Console.WriteLine(response.Fabricante + " " + response.Price);
                if (OrderList.Count > 0)
                {
                    foreach (var item in OrderList)
                    {
                        if (item.Encomendaid == response.EncomendaId)
                        {
                            order = item;
                            break;
                        }
                    }
                }
                if (order == null)
                {
                    order = new OrderInfo(response.UserId, response.EncomendaId);
                    order.AddpriceTransp(response.Fabricante, response.Price);
                }
                else
                {
                    order.AddpriceTransp(response.Fabricante, response.Price);
                }
            }
            return "ack";
        }

        public string GetFabricantePrice(FabricantePriceResponse response)
        {
            lock (Sync)
            {
                var order = OrderList.FirstOrDefault(item => item.Encomendaid == response.encomendaID);
                if (order == null)
                {
                    order = new OrderInfo(response.userID, response.encomendaID);
                    order.AddpriceFabric(response.fabricante, response.Price);
                }
                else
                {
                    order.AddpriceFabric(response.fabricante, response.Price);
                }
            }
            return "ack";
        }

    }
}
