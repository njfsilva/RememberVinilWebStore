using System;
using System.ServiceModel;

namespace Transportadora
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(TransportadoraService));
            host.Open();


            Console.ReadLine();
        }
    }
}
