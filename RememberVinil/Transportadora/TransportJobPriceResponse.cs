using System;
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
        public string RefRequestPrice { get; set; }
        [DataMember]
        public string UserId { get; set; }
        [DataMember]
        public string EncomendaId { get; set; }
    }
}
