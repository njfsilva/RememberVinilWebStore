using System.ServiceModel;

namespace FabricanteC
{
    [ServiceContract]
    public interface IFabricanteCService
    {
        [OperationContract]
        double getQuote(ObjectQuoteRequest request);

        [OperationContract]
        string MakeCD(ObjectCDRequest request);
    }
}
