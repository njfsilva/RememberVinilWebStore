using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FabricanteA
{
    internal static class FabricaADB
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
