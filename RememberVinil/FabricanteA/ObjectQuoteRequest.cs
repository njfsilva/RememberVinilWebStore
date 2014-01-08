using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FabricanteA
{
    [Serializable]
    [DataContract]
    public class ObjectQuoteRequest
    {
        //public int id { get; set; }
        [DataMember]
        public List<Music> ListaMusicas { get; set; }
        [DataMember]
        public string WSCallback { get; set; }
        [DataMember]
        public string userID { get; set; }
        [DataMember]
        public string encomendaID { get; set; }
        [DataMember]
        public string fabricante { get; set; }
    }
}
