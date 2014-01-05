using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace FabricanteC
{
    [ServiceContract]
    public interface IFabricanteCService
    {
        [OperationContract]
        double getQuote(ObjectQuoteRequest request);

        [OperationContract]
        string MakeCD(ObjectCDRequest request);
    }
}
