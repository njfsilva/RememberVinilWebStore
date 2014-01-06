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
                total += 1;
            }
            return total;
        }

        public string MakeCD(ObjectCDRequest request)
        {
            return FabricaBDB.AddNewCDRequest(request).ToString();
        }
    }
}
