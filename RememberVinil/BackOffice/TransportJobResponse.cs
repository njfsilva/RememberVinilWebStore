using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackOffice
{
    public class TransportJobResponse
    {
        public bool Sucess { get; set; }
        public string DeliveryAdress { get; set; }
        public string Distance { get; set; }
        public string encomendaID { get; set; }
        public string fabrica { get; set; }
        public string userID { get; set; }
        public string Status { get; set; }
    }
}
