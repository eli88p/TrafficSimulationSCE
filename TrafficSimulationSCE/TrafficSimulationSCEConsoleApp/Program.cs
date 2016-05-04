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
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                var res1 = TrafficSim.ChangingTimeSim(rnd);
                var res2 = TrafficSim.FixedTimeSim(rnd);
                Console.WriteLine("----------------------------------------------------------");
                res1.PrintResult("Changing");
                res2.PrintResult("Fixed");
                Console.WriteLine("----------------------------------------------------------");
            }
            Console.ReadKey();
        }




       
    }
}
