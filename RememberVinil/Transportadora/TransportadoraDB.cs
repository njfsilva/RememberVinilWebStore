﻿using System;
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
            request.id = DbTranposrtadora.Count + 1;
            DbTranposrtadora.Add(request);

            return true;
        }


        public static List<TransportJobRequest> GetAllTransportJobs()
        {
            return DbTranposrtadora;
        }

        public static TransportJobRequest getRequest(int pos)
        {
            try
            {
                return DbTranposrtadora[pos];
            }catch (Exception ex)
            {
                return null;
            }
        }

        public static Boolean UpdateStatus(int pos, string Status)
        {
            try
            {
                DbTranposrtadora[pos].Status = Status;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
