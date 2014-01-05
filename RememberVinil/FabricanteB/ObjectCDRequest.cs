using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FabricanteB
{
    public class ObjectCDRequest
    {
        public int id { get; set; }
        public List<Music> ListaMusicas { get; set; }
        public string WSCallback { get; set; }
    }
}
