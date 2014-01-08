using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace Transportadora
{
    [Serializable]
    [DataContract]
    public class TransportJobRequest
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string DeliveryAdress { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string WSCallback { get; set; }
        [DataMember]
        public string Distance { get; set; }
        [DataMember]
        public string userID { get; set; }
        [DataMember]
        public string encomendaID { get; set; }
        [DataMember]
        public string fabrica { get; set; }
    }
}
