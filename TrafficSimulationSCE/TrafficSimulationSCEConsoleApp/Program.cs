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
            var resTotalChangingTime = new Result(0,0,0,0,0);
            var resTotalFixTime = new Result(0, 0, 0, 0, 0);

            for (int i = 0; i < 365; i++)
            {
                var res1 = TrafficSim.ChangingTimeSim(rnd);
                var res2 = TrafficSim.FixedTimeSim(rnd);

                resTotalChangingTime.P += res1.P;
                resTotalChangingTime.Q += res1.Q;
                resTotalChangingTime.TotalCarsPass += res1.TotalCarsPass;
                resTotalChangingTime.TotalSuccess += res1.TotalSuccess;
                resTotalChangingTime.TotalFailure += res1.TotalFailure;


                resTotalFixTime.P += res2.P;
                resTotalFixTime.Q += res2.Q;
                resTotalFixTime.TotalCarsPass += res2.TotalCarsPass;
                resTotalFixTime.TotalSuccess += res2.TotalSuccess;
                resTotalFixTime.TotalFailure += res2.TotalFailure;
            }

            Console.WriteLine("----- Changing Lights Time -----");
            Console.WriteLine("Number of total cars pass:" + resTotalChangingTime.TotalCarsPass);
            Console.WriteLine("Number of Success:" + resTotalChangingTime.TotalSuccess);
            Console.WriteLine("Number of Failure:" + resTotalChangingTime.TotalFailure);
            Console.WriteLine("Total P:" + resTotalChangingTime.P / 365);

            Console.WriteLine(" ");

            Console.WriteLine("----- Fixed Lights Time -----");
            Console.WriteLine("Number of total cars pass:" + resTotalFixTime.TotalCarsPass);
            Console.WriteLine("Number of Success:" + resTotalFixTime.TotalSuccess);
            Console.WriteLine("Number of Failure:" + resTotalFixTime.TotalFailure);
            Console.WriteLine("Total P:" + resTotalFixTime.P / 365);
            Console.ReadKey();
        }




       
    }
}
