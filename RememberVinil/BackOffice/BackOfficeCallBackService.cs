using System.Collections.Generic;
using BackOffice.TransportadoraServiceReference;


namespace BackOffice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BackOfficeCallBackService" in both code and config file together.
    public class BackOfficeCallBackService : IBackOfficeCallBackService
    {
        private static List<OrderInfo> orderList = new List<OrderInfo>();
        
        public string GetStatus(TransportJobResponse response)
        {
            return response.Status;
        }
<<<<<<< HEAD
=======
        
        public string GetTransporterPrice(TransportJobPriceResponse response)
        {
            OrderInfo order=null;
            
            foreach (OrderInfo item in orderList)
            {
                if (item.encomendaid == response.encomendaID)
                {
                    order = item;
                    break;
                }
            }
            if (order == null)
            {
                order = new OrderInfo();
                order.encomendaid = response.encomendaID;
                order.userID = response.userID;
                order.addpriceTransp(response.fabricante, response.Price);
            }
            else
            {
                order.addpriceTransp(response.fabricante, response.Price);
                if (order.all3Received())
                {
                    string bestdeal = order.getbestdeal();
                    orderList.Remove(order);
                    //send to website
                }
            }
            return "ack";
        }

        public string GetFabricantePrice(FabricantePriceResponse response)
        {
            OrderInfo order = null;

            foreach (OrderInfo item in orderList)
            {
                if (item.encomendaid == response.encomendaID)
                {
                    order = item;
                    break;
                }
            }
            if (order == null)
            {
                order = new OrderInfo();
                order.encomendaid = response.encomendaID;
                order.userID = response.userID;
                order.addpriceFabric(response.fabricante, response.Price);
            }
            else
            {
                order.addpriceFabric(response.fabricante, response.Price);
                if (order.all3Received())
                {
                    string bestdeal = order.getbestdeal();
                    orderList.Remove(order);
                    //send to website
                }
            }
            return "ack";
        }
>>>>>>> 7bc9f85ce012c8ce9d45709c3105f223564621b2
    }
}
