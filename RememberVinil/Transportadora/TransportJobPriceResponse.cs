using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace Transportadora
{
    [Serializable]
    [DataContract]
    public class TransportJobPriceResponse
    {
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public string refRequestPrice { get; set; }
        [DataMember]
        public string userID { get; set; }
        [DataMember]
        public string encomendaID { get; set; }
    }
}
