﻿using System.ServiceModel;

namespace FabricanteB
{

    [ServiceContract]
    public interface IFabricanteBService
    {
        [OperationContract]
        FabricantePriceResponse getQuote(ObjectQuoteRequest request);

        [OperationContract]
        ObjectMakeCDResponse MakeCD(ObjectCDRequest request);
    }
}

