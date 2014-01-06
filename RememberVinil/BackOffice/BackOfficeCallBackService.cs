using BackOffice.TransportadoraServiceReference;


namespace BackOffice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BackOfficeCallBackService" in both code and config file together.
    public class BackOfficeCallBackService : IBackOfficeCallBackService
    {
        public string GetStatus(TransportJobResponse response)
        {
            return response.Status;
        }
    }
}
