using System.ServiceModel;

namespace FabricanteB
{

    [ServiceContract]
    public interface IFabricanteBService
    {
        [OperationContract]
        double getQuote(ObjectQuoteRequest request);

        [OperationContract]
        string MakeCD(ObjectCDRequest request);
    }
}

