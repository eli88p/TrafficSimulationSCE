using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace TrafficSimulationSCEConsoleApp
{
    class Program
    {
        public const double CONVERGENT = 0.0001;

        static void Main(string[] args)
        {

            Random rnd = new Random();
            var resTotalChangingTime = new Result(0,0,0,0,0);
            var resTotalFixTime = new Result(0, 0, 0, 0, 0);

            double diff = 0;
            double avgDiff = 0;
            double preLoopDiff = 0;
            int i = 0;
            do
            {
                var res1 = TrafficSim.ChangingTimeSim(rnd);
                
                resTotalChangingTime.P += res1.P;
                resTotalChangingTime.Q += res1.Q;
                resTotalChangingTime.TotalCarsPass += res1.TotalCarsPass;
                resTotalChangingTime.TotalSuccess += res1.TotalSuccess;
                resTotalChangingTime.TotalFailure += res1.TotalFailure;

                preLoopDiff = avgDiff;

                diff += (1440 * res1.P * res1.Q);
                avgDiff = diff / (i + 1);

                //Console.WriteLine("Sum of Diff: " + avgDiff);
                //Console.WriteLine("i: " + i);
                //Console.WriteLine("********");
                
                i++;

            } while (Math.Abs(avgDiff - preLoopDiff) > CONVERGENT);

            double diffChange = 0;
            double avgDiffChange = 0;
            double preLoopDiffChange = 0;
            int j = 0;
            do
            {
                var res2 = TrafficSim.FixedTimeSim(rnd);

                preLoopDiffChange = avgDiffChange;

                diffChange += (1440 * res2.P * res2.Q);
                avgDiffChange = diffChange / (j + 1);

                //Console.WriteLine("Sum of Diff: " + avgDiff);
                //Console.WriteLine("i: " + i);
                //Console.WriteLine("********");

                resTotalFixTime.P += res2.P;
                resTotalFixTime.Q += res2.Q;
                resTotalFixTime.TotalCarsPass += res2.TotalCarsPass;
                resTotalFixTime.TotalSuccess += res2.TotalSuccess;
                resTotalFixTime.TotalFailure += res2.TotalFailure;

                j++;

            } while (Math.Abs(avgDiffChange - preLoopDiffChange) > CONVERGENT);


            Console.WriteLine("----- Changing Lights Time -----");
            Console.WriteLine("Number of total cars pass:" + resTotalChangingTime.TotalCarsPass);
            Console.WriteLine("Number of Success:" + resTotalChangingTime.TotalSuccess);
            Console.WriteLine("Number of Failure:" + resTotalChangingTime.TotalFailure);
            Console.WriteLine("Total P:" + resTotalChangingTime.P / i);

            Console.WriteLine(" ");

            Console.WriteLine("----- Fixed Lights Time -----");
            Console.WriteLine("Number of total cars pass:" + resTotalFixTime.TotalCarsPass);
            Console.WriteLine("Number of Success:" + resTotalFixTime.TotalSuccess);
            Console.WriteLine("Number of Failure:" + resTotalFixTime.TotalFailure);
            Console.WriteLine("Total P:" + resTotalFixTime.P / j);

            Console.WriteLine("\n----- Fixed Lights Time -----\nconvergent after: " + i +" days\n");
            Console.WriteLine("----- Changing Lights Time -----\nconvergent after: " + j + " days");
            Console.WriteLine("\nIn accuracy of: " + CONVERGENT);

            Console.ReadKey();
        }




       
    }
}
