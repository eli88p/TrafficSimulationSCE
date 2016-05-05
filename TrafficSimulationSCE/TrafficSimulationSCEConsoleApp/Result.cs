using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficSimulationSCEConsoleApp
{
    public class Result
    {
        public double P { get; set; }
        public double Q { get; set; }
        public int TotalCarsPass { get; set; }
        public double TotalSuccess { get; set; }
        public double TotalFailure { get; set; }

        public Result(double p, double q, int totalcar,double ts,double tf)
        {
            P = p;
            Q = q;
            TotalCarsPass = totalcar;
            TotalSuccess = ts;
            TotalFailure = tf;
        }

        public void PrintResult(string type)
        {
            if (type.Equals("Fixed"))
            {
                Console.WriteLine("The Result for Fixed Time is:\n P:" + P + " " + "Q:" + Q + " " + "Total cars pass:" + TotalCarsPass);
            }
            else if (type.Equals("Changing"))
            {
                Console.WriteLine("The Result for Changing Time is:\n P:" + P + " " + "Q:" + Q + " " + "Total cars pass:" + TotalCarsPass);
            }
        }
    }
}
