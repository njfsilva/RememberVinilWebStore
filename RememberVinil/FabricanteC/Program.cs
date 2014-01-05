using System;
using System.ServiceModel;

namespace FabricanteC
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(FabricanteCService));
            host.Open();
            Console.ReadLine();
        }
    }
}
