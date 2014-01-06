using System.Collections.Generic;

namespace FabricanteC
{
    public class ObjectQuoteRequest
    {
        public int id { get; set; }
        public List<Music> ListaMusicas { get; set; }
        public string WSCallback { get; set; }
    }
}
