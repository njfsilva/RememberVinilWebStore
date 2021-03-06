﻿using System.ServiceModel;

namespace FabricanteA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBackOfficeCallBackService" in both code and config file together.
    [ServiceContract]
    public interface IFabricanteAService
    {
        [OperationContract]
        FabricantePriceResponse getQuote(ObjectQuoteRequest request);

        [OperationContract]
        ObjectMakeCDResponse MakeCD(ObjectCDRequest request);
    }
}
