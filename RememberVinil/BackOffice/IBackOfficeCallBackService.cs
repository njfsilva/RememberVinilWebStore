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

        [OperationContract]
        string NotifyCDReady(object response);//object cdready
    }
}
