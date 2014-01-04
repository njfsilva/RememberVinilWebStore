using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackOffice
{
    class Client
    {
        public string ClientID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string TransportadoraID { get; set; }

        public Client(string ClientID)
        {
            this.ClientID = ClientID;
        }
    }
}
