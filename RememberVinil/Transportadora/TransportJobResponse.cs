using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Transportadora
{
    public class TransportJobResponse
    {
        public bool Sucess { get; set; }
        public string Status { get; set; }

        public TransportJobResponse()
        {
        }

        public TransportJobResponse(string status)
        {
            this.Status = status;
        }
    }
}
