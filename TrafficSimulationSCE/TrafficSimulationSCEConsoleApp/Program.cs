using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficSimulationSCEConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

           var res1 = TrafficSim.ChangingTimeSim();
           var res2 = TrafficSim.FixedTimeSim();
            res1.PrintResult("Changing");
            res2.PrintResult("Fixed");
            Console.ReadKey();
        }




       
    }
}
