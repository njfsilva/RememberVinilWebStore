﻿using System;
using System.ServiceModel;

namespace FabricanteB
{
    static class Program
    {
        static void Main()
        {
            var host = new ServiceHost(typeof(FabricanteBService));
            host.Open();
            Console.ReadLine();
        }
    }
}
