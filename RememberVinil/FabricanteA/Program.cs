using System;
using System.ServiceModel;

namespace FabricanteA
{
    static class Program
    {
        static void Main()
        {
            var host = new ServiceHost(typeof(FabricanteAService));
            host.Open();
            Console.ReadLine();
        }
    }
}
