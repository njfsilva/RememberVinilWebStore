using System.Collections.Generic;
using BackOffice.TransportadoraServiceReference;
using System.Threading;


namespace BackOffice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BackOfficeCallBackService" in both code and config file together.
    public class BackOfficeCallBackService : IBackOfficeCallBackService
    {
        private static List<OrderInfo> orderList = new List<OrderInfo>();

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
            return "ack";
        }
        
        public string GetTransporterPrice(TransportJobPriceResponse response)
        {
            OrderInfo order=null;
            
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
                order = new OrderInfo {encomendaid = response.encomendaID, userID = response.userID};
                order.addpriceTransp(response.fabricante, response.Price);
            }
            else
            {
                order.addpriceTransp(response.fabricante, response.Price);
                if (order.all3Received())
                {
                    var bestdeal = order.getbestdeal();
                    orderList.Remove(order);
                    //send to website
                    //send to website
                    //send to website
                    //send to website
                    //send to website
                    //send to website
                }
            }
            return "ack";
        }

        public string GetFabricantePrice(FabricantePriceResponse response)
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
                order = new OrderInfo {encomendaid = response.encomendaID, userID = response.userID};
                order.addpriceFabric(response.fabricante, response.Price);
            }
            else
            {
                order.addpriceFabric(response.fabricante, response.Price);
                if (order.all3Received())
                {
                    var bestdeal = order.getbestdeal();
                    orderList.Remove(order);
                    //send to website
                    //send to website
                    //send to website
                    //send to website
                    //send to website
                    //send to website
                }
            }
            return "ack";
        }

    }
}
