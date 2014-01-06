using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FabricanteA
{
    public class FabricantePriceResponse
    {
        public string userID { get; set; }
        public string encomendaID { get; set; }
        public string fabricante { get; set; }
        public double Price { get; set; }
        public string refRequestPrice { get; set; }
    }
}
