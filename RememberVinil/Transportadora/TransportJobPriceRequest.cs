using System;
using System.Runtime.Serialization;
namespace Transportadora
{
    [Serializable]
    [DataContract]
    public class TransportJobPriceRequest
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string DeliveryAdress { get; set; }
        [DataMember]
        public string Fabrica { get; set; }
        [DataMember]
        public string WsCallback { get; set; }
        [DataMember]
        public string Distance { get; set; }
        [DataMember]
        public string UserId { get; set; }
        [DataMember]
        public string EncomendaId { get; set; }
    }
}
