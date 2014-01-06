namespace FabricanteC
{
    public class FabricanteCService : IFabricanteCService
    {
        public double getQuote(ObjectQuoteRequest request)
        {
            double total = 0;
            foreach (Music m in request.ListaMusicas)
            {
                total += m.price;
                //total += 0.99;
            }
            return total;
        }

        public string MakeCD(ObjectCDRequest request)
        {
            return FabricaCDB.AddNewCDRequest(request).ToString();
        }
    }
}
