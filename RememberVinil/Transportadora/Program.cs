using System;
using System.ServiceModel;

namespace Transportadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }

    public class Coordinates
    {
        public string longitude;
        public string latitude;
    }

    public class ObjectTransportRequest
    {
        public Coordinates origem;
        public Coordinates destino;
        public string wsUrl; /* o url da callback */
	    public string refRequestOriginDestination; /* uma referência para associar as duas mensagens */
    }

    public class ObjectTransportJobResponse
    {
        public int ID;
        public string refRequestOriginDestination; /* uma referência para associar as duas mensagens */
    }

    [ServiceContract]
    public interface Transportadora
    {
        [OperationContract]
        ObjectTransportJobResponse TransportJob(ObjectTransportRequest request);

    }

    public class TransportadoraImpl : Transportadora
    {
        public ObjectTransportJobResponse TransportJob(ObjectTransportRequest request)
        {
            ObjectTransportJobResponse r = new ObjectTransportJobResponse();
            Random rnd = new Random();
            r.ID = rnd.Next(1024);
            r.refRequestOriginDestination = "";
            return r;
        }
    }
}
