using System;
using System.Runtime.Serialization;

namespace FabricanteC
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
        public string Status { get; set; }
        [DataMember]
        public string RefRequestCd { get; set; }
    }
}
