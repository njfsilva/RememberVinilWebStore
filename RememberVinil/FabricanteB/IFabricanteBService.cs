using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace FabricanteB
{

    [ServiceContract]
    public interface IFabricanteBService
    {
        [OperationContract]
        double getQuote(ObjectQuoteRequest request);

        [OperationContract]
        string MakeCD(ObjectCDRequest request);
    }
}

