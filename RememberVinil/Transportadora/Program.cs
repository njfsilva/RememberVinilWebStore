using System;
using System.ServiceModel;

namespace Transportadora
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseAddress = new Uri("http://localhost:9002/TransportadoraService");
            var host = new ServiceHost(typeof(TransportadoraService), baseAddress);

            host.Open();


            Console.ReadLine();
        }
    }
}
