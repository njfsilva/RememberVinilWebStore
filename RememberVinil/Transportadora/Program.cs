using System;
using System.ServiceModel;
using System.Threading;
using Transportadora.VinilBackoffice;

namespace Transportadora
{
    static class Program
    {
        static void Main()
        {
            var host = new ServiceHost(typeof(TransportadoraService));
            host.Open();
            Console.ReadLine();
        }
    }
}
