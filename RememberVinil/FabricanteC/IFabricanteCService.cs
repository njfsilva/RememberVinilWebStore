using System.ServiceModel;

namespace FabricanteC
{
    [ServiceContract]
    public interface IFabricanteCService
    {
        [OperationContract]
        FabricantePriceResponse GetQuote(ObjectQuoteRequest request);

        [OperationContract]
        string MakeCd(ObjectCDRequest request);
    }
}
