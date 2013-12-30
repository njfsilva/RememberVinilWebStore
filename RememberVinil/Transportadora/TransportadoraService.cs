using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Transportadora
{
    public class TransportadoraService : ITransportadoraService
    {

        public TransportJobResponse TransportJob(TransportJobRequest request)
        {
            var response = new TransportJobResponse();

            try
            {
                TransportadoraDB.AddNewTransportJob(request);
                response.Sucess = true;
            }
            catch (Exception)
            {
                response.Sucess = false;
            }


            return response;
        }
    }
}
