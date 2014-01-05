using System.Collections.Generic;

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
