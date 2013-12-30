using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Transportadora
{
    internal static class TransportadoraDB
    {
        static List<TransportJobRequest> DbTranposrtadora = new List<TransportJobRequest>();


        public static bool AddNewTransportJob(TransportJobRequest request)
        {
            DbTranposrtadora.Add(request);

            return true;
        }


        public static List<TransportJobRequest> GetAllTransportJobs()
        {
            return DbTranposrtadora;
        }


    }
}
