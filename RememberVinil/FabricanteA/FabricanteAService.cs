using System;

namespace FabricanteA
{
    public class FabricanteAService : IFabricanteAService
    {
        public double getQuote(ObjectQuoteRequest request)
        {
            double total = 0;
            foreach(Music m in request.ListaMusicas)
            {
                //total += m.price;
                total += 0.99;
            }
            return total;
        }

        public string MakeCD(ObjectCDRequest request)
        {
            return FabricaADB.AddNewCDRequest(request).ToString();
        }
    }
}
