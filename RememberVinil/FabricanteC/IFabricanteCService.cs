using System.ServiceModel;

namespace FabricanteC
{
    [ServiceContract]
    public interface IFabricanteCService
    {
        [OperationContract]
        FabricantePriceResponse GetQuote(ObjectQuoteRequest request);

        [OperationContract]
        ObjectMakeCdResponse MakeCd(ObjectCDRequest request);
    }
}
