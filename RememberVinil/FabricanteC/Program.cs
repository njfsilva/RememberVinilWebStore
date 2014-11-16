using System;
using System.ServiceModel;

namespace FabricanteC
{
    static class Program
    {
        static void Main()
        {
            var host = new ServiceHost(typeof(FabricanteCService));
            host.Open();
            Console.ReadLine();
        }
    }
}
