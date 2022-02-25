using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace WCFHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(WCFService));
            host.Open();

            Console.WriteLine("Service started...");
            Console.ReadKey();
        }
    }
}
