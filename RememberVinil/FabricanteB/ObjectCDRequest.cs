using System.Collections.Generic;

namespace FabricanteB
{
    public class ObjectCDRequest
    {
        public int id { get; set; }
        public int userid { get; set; }
        public List<Music> ListaMusicas { get; set; }
        public string WSCallback { get; set; }

        public string DeliveryAdress { get; set; }
        public string Status { get; set; }
        public string Distance { get; set; }
        public string encomendaID { get; set; }
    }
}
