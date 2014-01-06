using System.ServiceModel;

namespace Transportadora
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITransportadoraService" in both code and config file together.
    [ServiceContract]
    public interface ITransportadoraService
    {
        [OperationContract]
        string TransportJob(TransportJobRequest request);

        [OperationContract]
        TransportJobPriceRequest TransportJobPrice(TransportJobPriceRequest request);
    }
}
