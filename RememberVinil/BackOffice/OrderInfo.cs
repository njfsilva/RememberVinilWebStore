using System;
using System.Collections.Generic;
using System.Linq;

namespace BackOffice
{
    public class OrderInfo
    {
        public string userID { get; set; }
        public string encomendaid { get; set; }
        public string morada { get; set; }
        public string distance { get; set; }
        public List<Track> orderedTracks { get; set; }
        public List<Order> pricesFabric= new List<Order>();
        public List<Order> pricesTransp =new List<Order>();

        public OrderInfo(string u, string id)
        {
            userID = u;
            encomendaid = id;
            pricesTransp = new List<Order>();
            pricesFabric = new List<Order>();
        }

        public OrderInfo()
        {
            pricesFabric = new List<Order>();
            pricesTransp = new List<Order>();
        }

        public int countpricesTransp()
        {
            return pricesTransp.Count;
        }

        public int countpricesFabric()
        {
            return pricesFabric.Count;
        }

        public Boolean all3Received()
        {
            if (pricesTransp.Count == 3 && pricesFabric != null && pricesFabric.Count == 3)
                return true;
            return false;
        }

        public void addpriceTransp(string f, double p)
        {
            var o = new Order {fabrica = f, price = p};
            pricesTransp.Add(o);
        }

        public void addpriceFabric(string f, double p)
        {
            if (pricesFabric==null)
                pricesFabric = new List<Order>();
            var o = new Order {fabrica = f, price = p};
            pricesFabric.Add(o);
        }

        public string getbestdeal()
        {
            double lowest = Int32.MaxValue;
            var result= string.Empty;
            foreach (var itemTransp in pricesTransp)
            {
                var fabrica = itemTransp.fabrica;
                var pricetrans = itemTransp.price;

                foreach (var total in from itemFabric in pricesFabric where itemFabric.fabrica == fabrica select pricetrans + itemFabric.price)
                {
                    if (total < lowest)
                    {
                        lowest = total;
                        result = fabrica;
                    }
                    break;
                }
               
            }
            return result;
        }
    }

    public class Order
    {
        public string fabrica { get; set; }
        public double price { get; set; } 
    }
}
