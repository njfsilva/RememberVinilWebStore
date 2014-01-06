using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackOffice
{
    public class OrderInfo
    {
        public string userID { get; set; }
        public string encomendaid { get; set; }
        public List<order> pricesTransp { get; set; }
        public List<order> pricesFabric { get; set; }

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
            order o = new order();
            o.fabrica = f;
            o.price = p;
            pricesTransp.Add(o);
        }

        public void addpriceFabric(string f, double p)
        {
            order o = new order();
            o.fabrica = f;
            o.price = p;
            pricesFabric.Add(o);
        }

        public string getbestdeal()
        {
            double lowest = Int32.MaxValue;
            string result= string.Empty;
            foreach (order itemTransp in pricesTransp)
            {
                string fabrica = itemTransp.fabrica;
                double pricetrans = itemTransp.price;
                foreach (order itemFabric in pricesFabric)
                {
                    if (itemFabric.fabrica == fabrica)
                    {
                        double total = pricetrans + itemFabric.price;
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
