using System;
using System.Collections.Generic;
using Website;

namespace BackOffice
{
    public class OrderInfo
    {
        public string userID { get; set; }
        public string encomendaid { get; set; }
        public string morada { get; set; }
        public List<Track> orderedTracks { get; set; }
        public List<order> pricesTransp { get; set; }
        public List<order> pricesFabric { get; set; }

        public OrderInfo()
        {
            pricesTransp = new List<order>();
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
            if (pricesTransp.Count == 3 && pricesFabric.Count == 3)
                return true;
            return false;
        }

        public void addpriceTransp(string f, double p)
        {
            var o = new order();
            o.fabrica = f;
            o.price = p;
            pricesTransp.Add(o);
        }

        public void addpriceFabric(string f, double p)
        {
            var o = new order();
            o.fabrica = f;
            o.price = p;
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
                foreach (var itemFabric in pricesFabric)
                {
                    if (itemFabric.fabrica == fabrica)
                    {
                        var total = pricetrans + itemFabric.price;
                        if (total < lowest)
                        {
                            lowest = total;
                            result = fabrica;
                        }
                    }
                }
               
            }
            return result;
        }
    }

    public class order
    {
        public string fabrica { get; set; }
        public double price { get; set; } 
    }
}
