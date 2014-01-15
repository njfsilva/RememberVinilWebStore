using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FabricanteA
{
    [Serializable]
    [DataContract]
    public class ObjectCDRequest
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int userid { get; set; }
        [DataMember]
        public List<Music> ListaMusicas { get; set; }
        [DataMember]
        public string WSCallback { get; set; }
        [DataMember]
        public string DeliveryAdress { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string Distance { get; set; }
        [DataMember]
        public string encomendaID { get; set; }
        [DataMember]
        public string fabrica { get; set; }
    }
}
