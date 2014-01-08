using System;
using System.Runtime.Serialization;
namespace BackOffice
{
    [Serializable]
    [DataContract]
    public class TransportJobPriceResponse
    {
        [DataMember]
        public string userID { get; set; }
        [DataMember]
        public string encomendaID { get; set; }
        [DataMember]
        public string fabricante { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public string refRequestPrice { get; set; }
    }
}
