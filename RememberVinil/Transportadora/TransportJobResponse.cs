using System;
using System.Runtime.Serialization;
namespace Transportadora
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
        public string EncomendaId { get; set; }
        [DataMember]
        public string Fabrica { get; set; }
        [DataMember]
        public string UserId { get; set; }

    }
}
