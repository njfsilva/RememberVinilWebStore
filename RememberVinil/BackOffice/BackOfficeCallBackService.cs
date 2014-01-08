using System.Collections.Generic;
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
            string UserID = response.userID.ToString();
            var user =UserDB.GetUserByUserID(UserID);
            var orderID=user.addOrder();
            var thread = new Thread(() =>
            {
                var transportadora = new TransportadoraServiceClient();
                var request = new TransportadoraServiceReference.TransportJobRequest();
                request.DeliveryAdress = response.DeliveryAdress;
                request.Distance = response.Distance;
                request.encomendaID = orderID;
                request.userID = UserID;
                request.fabrica = response.fabrica;
                transportadora.TransportJob(request);
            });
            thread.Start();
            return "ack";
        }

        public string UpdateOrderTransportStatus(TransportJobResponse response)
        {
            string UserID = response.userID.ToString();
            var user = UserDB.GetUserByUserID(UserID);
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
                OrderInfo order = null;
                foreach (var item in orderList)
                {
                    if (item.encomendaid == response.encomendaID)
                    {
                        order = item;
                        break;
                    }
                }
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
