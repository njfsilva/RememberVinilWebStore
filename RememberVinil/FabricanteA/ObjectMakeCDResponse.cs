﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FabricanteA
{
    public class ObjectMakeCDResponse
    {
        public int id { get; set; }
        public int userID { get; set; }
        public string refRequestCD { get; set; }

        public string DeliveryAdress { get; set; }
        public string fabrica { get; set; }
        public string Status { get; set; }
        public string Distance { get; set; }
        public string encomendaID { get; set; }
    }
}