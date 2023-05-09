using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ConsoleLogger
    {
        public static void VehicleStartUpDialoge()
        {
            Console.WriteLine("Put Key in ignition!");
            Thread.Sleep(1000);
            Console.WriteLine("Turn Key");
            Thread.Sleep(1000);
        }
    }
}
