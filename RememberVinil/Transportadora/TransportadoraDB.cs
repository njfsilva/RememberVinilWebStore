using System;
using System.Collections.Generic;

namespace Transportadora
{
    internal static class TransportadoraDb
    {
        static List<TransportJobRequest> DbTranposrtadora = new List<TransportJobRequest>();


        public static int AddNewTransportJob(TransportJobRequest request)
        {
            request.Id = DbTranposrtadora.Count + 1;
            DbTranposrtadora.Add(request);

            return request.Id;
        }


        public static List<TransportJobRequest> GetAllTransportJobs()
        {
            return DbTranposrtadora;
        }

        public static TransportJobRequest GetRequest(int pos)
        {
            try
            {
                return DbTranposrtadora[pos];
            }catch (Exception)
            {
                return null;
            }
        }

        public static Boolean UpdateStatus(int pos, string status)
        {
            try
            {
                DbTranposrtadora[pos].Status = status;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
