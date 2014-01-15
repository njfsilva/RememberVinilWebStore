using System;
using System.Runtime.Serialization;

namespace FabricanteA
{
        [Serializable]
    [DataContract]
    public class ObjectMakeCdResponse
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public string RefRequestCd { get; set; }
        [DataMember]
        public string DeliveryAdress { get; set; }
        [DataMember]
        public string Fabrica { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string Distance { get; set; }
        [DataMember]
        public string EncomendaId { get; set; }
    }
}
