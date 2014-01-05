﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FabricanteC
{
    internal static class FabricaCDB
    {
        static List<ObjectCDRequest> DbFabrica = new List<ObjectCDRequest>();

        public static int AddNewCDRequest(ObjectCDRequest request)
        {
            request.id = DbFabrica.Count + 1;
            DbFabrica.Add(request);

            return request.id;
        }
    }
}