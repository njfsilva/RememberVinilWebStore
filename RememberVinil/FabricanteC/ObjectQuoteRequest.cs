using System.Collections.Generic;

namespace FabricanteC
{
    public class ObjectQuoteRequest
    {
        //public int id { get; set; }
        public List<Music> ListaMusicas { get; set; }
        public string WSCallback { get; set; }
        public string userID { get; set; }
        public string encomendaID { get; set; }
        public string fabricante { get; set; }
    }
}
