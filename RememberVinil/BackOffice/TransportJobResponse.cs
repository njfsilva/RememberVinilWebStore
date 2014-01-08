using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
namespace BackOffice
{
    [Serializable]
    [DataContract]
    public class TransportJobResponse
    {
        [DataMember]
        public bool Sucess { get; set; }
        [DataMember]
        public string DeliveryAdress { get; set; }
        [DataMember]
        public string Distance { get; set; }
        [DataMember]
        public string encomendaID { get; set; }
        [DataMember]
        public string fabrica { get; set; }
        [DataMember]
        public string userID { get; set; }
        [DataMember]
        public string Status { get; set; }
    }
}
