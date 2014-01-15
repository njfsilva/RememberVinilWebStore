using System;
using System.Runtime.Serialization;
namespace BackOffice
{
    [Serializable]
    [DataContract]
    public class TransportJobPriceResponse
    {
        [DataMember]
        public string UserId { get; set; }
        [DataMember]
        public string EncomendaId { get; set; }
        [DataMember]
        public string Fabricante { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public string RefRequestPrice { get; set; }
    }
}
