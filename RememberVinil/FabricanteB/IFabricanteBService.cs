using System.ServiceModel;

namespace FabricanteB
{

    [ServiceContract]
    public interface IFabricanteBService
    {
        [OperationContract]
        FabricantePriceResponse GetQuote(ObjectQuoteRequest request);

        [OperationContract]
        ObjectMakeCdResponse MakeCd(ObjectCDRequest request);
    }
}

