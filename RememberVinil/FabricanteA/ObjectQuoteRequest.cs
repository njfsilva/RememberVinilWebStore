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
        public string WsCallback { get; set; }
        [DataMember]
        public string UserId { get; set; }
        [DataMember]
        public string EncomendaId { get; set; }
        [DataMember]
        public string Fabricante { get; set; }
    }
}
