using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Transportadora
{
    public class TransportJobPriceResponse
    {
        public string Status { get; set; }
        public double Price { get; set; }
        public string refRequestPrice { get; set; }
        public string userID { get; set; }
        public string encomendaID { get; set; }
    }
}
