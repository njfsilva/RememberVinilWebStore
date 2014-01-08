using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FabricanteA
{
        [Serializable]
    [DataContract]
    public class ObjectMakeCDResponse
    {
            [DataMember]
            public int id { get; set; }
        [DataMember]
        public int userID { get; set; }
        [DataMember]
        public string refRequestCD { get; set; }
        [DataMember]
        public string DeliveryAdress { get; set; }
        [DataMember]
        public string fabrica { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string Distance { get; set; }
        [DataMember]
        public string encomendaID { get; set; }
    }
}
