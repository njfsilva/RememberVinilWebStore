using System;
using System.Collections.Generic;

namespace BackOffice
{
    public class OrderInfo
    {
        public string UserId { get; set; }
        public string Encomendaid { get; set; }
        public string Morada { get; set; }
        public string Distance { get; set; }
        public List<Track> OrderedTracks { get; set; }
        public List<Order> PricesFabric = new List<Order>();
        public List<Order> PricesTransp = new List<Order>();

        public OrderInfo(string u, string id)
        {
            UserId = u;
            Encomendaid = id;
            PricesTransp = new List<Order>();
            PricesFabric = new List<Order>();
        }

        public OrderInfo()
        {
            PricesFabric = new List<Order>();
            PricesTransp = new List<Order>();
        }

        public int CountpricesTransp()
        {
            return PricesTransp.Count;
        }

        public int CountpricesFabric()
        {
            return PricesFabric.Count;
        }

        public Boolean All3Received()
        {
            if (PricesTransp.Count == 3 && PricesFabric != null && PricesFabric.Count == 3)
                return true;
            return false;
        }

        public void AddpriceTransp(string f, double p)
        {
            var o = new Order {Fabrica = f, Price = p};
            PricesTransp.Add(o);
        }

        public void AddpriceFabric(string f, double p)
        {
            if (PricesFabric==null)
                PricesFabric = new List<Order>();
            var o = new Order {Fabrica = f, Price = p};
            PricesFabric.Add(o);
        }

        public string Getbestdeal()
        {
            var lowest = Double.MaxValue;
            var result= string.Empty;
            foreach (var itemTransp in PricesTransp)
            {
                var fabrica = itemTransp.Fabrica;
                var pricetrans = itemTransp.Price;
                foreach (var itemFabric in PricesFabric)
                {
                    if (itemFabric.Fabrica == fabrica)
                    {
                        var total = pricetrans + itemFabric.Price;
                        if (total < lowest)
                        {
                            lowest = total;
                            result = fabrica;
                        }
                        break;
                    }
                }
               
            }
            return result;
        }
    }

    public class Order
    {
        public string Fabrica { get; set; }
        public double Price { get; set; } 
    }
}
