using System.ServiceModel;
using BackOffice.TransportadoraServiceReference;

namespace BackOffice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBackOfficeCallBackService" in both code and config file together.
    [ServiceContract]
    public interface IBackOfficeCallBackService
    {

        [OperationContract]
        string GetStatus(TransportJobResponse response);

<<<<<<< HEAD
=======
        //[OperationContract]
        //string NotifyCDReady(object response);//object cdready

        [OperationContract]
        string GetTransporterPrice(TransportJobPriceResponse response);

        [OperationContract]
        string GetFabricantePrice(FabricantePriceResponse response);
>>>>>>> 7bc9f85ce012c8ce9d45709c3105f223564621b2
    }
}
