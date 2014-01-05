﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FabricanteB
{
    public class FabricanteBService : IFabricanteBService
    {
        public double getQuote(ObjectQuoteRequest request)
        {
            double total = 0;
            foreach (Music m in request.ListaMusicas)
            {
                //total += m.price;
                total += 0.99;
            }
            return total;
        }

        public string MakeCD(ObjectCDRequest request)
        {
            return FabricaBDB.AddNewCDRequest(request).ToString();
        }
    }
}