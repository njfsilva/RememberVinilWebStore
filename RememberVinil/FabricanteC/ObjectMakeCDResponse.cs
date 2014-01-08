using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FabricanteC
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
        public string Status { get; set; }
        [DataMember]
        public string refRequestCD { get; set; }
    }
}
