using System;
using System.ServiceModel;

namespace FabricanteB
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(FabricanteBService));
            host.Open();
            Console.ReadLine();
        }
    }
}
