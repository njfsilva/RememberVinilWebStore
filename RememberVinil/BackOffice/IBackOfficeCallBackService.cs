using System.ServiceModel;

namespace BackOffice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBackOfficeCallBackService" in both code and config file together.
    [ServiceContract]
    public interface IBackOfficeCallBackService
    {

        [OperationContract]
        string GetStatus(ObjectMakeCDResponse response);

        [OperationContract]
        string UpdateOrderTransportStatus(TransportJobResponse response);

        [OperationContract]
        string GetTransporterPrice(TransportJobPriceResponse response);

        [OperationContract]
        string GetFabricantePrice(FabricantePriceResponse response);
    }
}
