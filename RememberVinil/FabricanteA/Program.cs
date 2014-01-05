using System;
using System.ServiceModel;

namespace FabricanteA
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(FabricanteAService));
            host.Open();
            Console.ReadLine();
        }
    }
}
