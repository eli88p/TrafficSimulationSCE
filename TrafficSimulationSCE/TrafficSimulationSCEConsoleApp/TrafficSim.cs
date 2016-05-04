using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficSimulationSCEConsoleApp
{
    public static class TrafficSim
    {
        public static Result ChangingTimeSim()
        {

            Road road = new Road();
            Binomial binomial = new Binomial();
            Random rnd = new Random();

            /* first peak time 7 - 9 AM
             * 40 secounds of green light
             * 20 secounds of red light
             * 200 cars already waiting in traffic
             * two times more then the normal traffic 
             * our goal is less then 50 cars in line after each cycle */

            road.GreenLightTime = 40;
            road.RedLightTime = 20;
            road.NumberOfCarsWaiting = 200;

            for (int i = 0; i < 120; i++)
            {
                int newComingCars = rnd.Next(0, road.RedLightTime);
                road.NumberOfCarsWaiting += newComingCars;

                int outGoingCars = rnd.Next(0, road.GreenLightTime);
                road.NumberOfCarsWaiting -= outGoingCars;

                if (road.NumberOfCarsWaiting < 0)
                {
                    road.NumberOfCarsWaiting = 0;
                }
                road.TotalCarsMovement += outGoingCars;


                if (road.NumberOfCarsWaiting <= 50)
                {
                    binomial.P++;
                }
                else
                {
                    binomial.Q++;
                }

            }

            /* not a peak time 9 - 1 PM
             * 30 secounds of green light
             * 30 secounds of red light 
             * normal traffic
             * our goal is less then 10 cars in line after each cycle */

            road.GreenLightTime = 30;
            road.RedLightTime = 30;

            for (int i = 0; i < 240; i++)
            {
                int newComingCars = rnd.Next(0, road.RedLightTime);
                road.NumberOfCarsWaiting += newComingCars;

                int outGoingCars = rnd.Next(0, road.GreenLightTime);
                road.NumberOfCarsWaiting -= outGoingCars;

                if (road.NumberOfCarsWaiting < 0)
                {
                    road.NumberOfCarsWaiting = 0;
                }
                road.TotalCarsMovement += outGoingCars;

                if (road.NumberOfCarsWaiting <= 10)
                {
                    binomial.P++;
                }
                else
                {
                    binomial.Q++;
                }
            }

            /* secound peak time 1 - 5 PM
             * 40 secounds of green light
             * 20 secounds of red light 
             * more then 300 cars already waiting in traffic
             * three times more then the normal traffic 
             * our goal is less then 50 cars in line after each cycle */

            road.GreenLightTime = 40;
            road.RedLightTime = 20;
            road.NumberOfCarsWaiting += 300;

            for (int i = 0; i < 240; i++)
            {
                int newComingCars = rnd.Next(0, road.RedLightTime);
                road.NumberOfCarsWaiting += newComingCars;

                int outGoingCars = rnd.Next(0, road.GreenLightTime);
                road.NumberOfCarsWaiting -= outGoingCars;

                if (road.NumberOfCarsWaiting < 0)
                {
                    road.NumberOfCarsWaiting = 0;
                }
                road.TotalCarsMovement += outGoingCars;

                if (road.NumberOfCarsWaiting <= 50)
                {
                    binomial.P++;
                }
                else
                {
                    binomial.Q++;
                }

            }

            /* not a peak time 5 - 11 PM
             * 50 secounds of green light
             * 10 secounds of red light 
             * half of the normal traffic - night time
             * our goal is less then 10 cars in line after each cycle */

            road.GreenLightTime = 50;
            road.RedLightTime = 10;

            for (int i = 0; i < 360; i++)
            {
                int newComingCars = rnd.Next(0, road.RedLightTime) / 2;
                road.NumberOfCarsWaiting += newComingCars;

                int outGoingCars = rnd.Next(0, road.GreenLightTime);
                road.NumberOfCarsWaiting -= outGoingCars;

                if (road.NumberOfCarsWaiting < 0)
                {
                    road.NumberOfCarsWaiting = 0;
                }
                road.TotalCarsMovement += outGoingCars;

                if (road.NumberOfCarsWaiting <= 10)
                {
                    binomial.P++;
                }
                else
                {
                    binomial.Q++;
                }

            }


            /* not a peak time 11 - 7 AM
             * 50 secounds of green light
             * 10 secounds of red light 
             * * half of the normal traffic - night time
             * our goal is less then 5 cars in line after each cycle */

            road.GreenLightTime = 50;
            road.RedLightTime = 10;

            for (int i = 0; i < 480; i++)
            {
                int newComingCars = rnd.Next(0, road.RedLightTime) / 2;
                road.NumberOfCarsWaiting += newComingCars;

                int outGoingCars = rnd.Next(0, road.GreenLightTime);
                road.NumberOfCarsWaiting -= outGoingCars;

                if (road.NumberOfCarsWaiting < 0)
                {
                    road.NumberOfCarsWaiting = 0;
                }
                road.TotalCarsMovement += outGoingCars;

                if (road.NumberOfCarsWaiting <= 5)
                {
                    binomial.P++;
                }
                else
                {
                    binomial.Q++;
                }

            }
            return new Result(binomial.P / (binomial.P + binomial.Q), binomial.Q / (binomial.P + binomial.Q), road.TotalCarsMovement);
        }


        public static Result FixedTimeSim()
        {

            Road road = new Road();
            Binomial binomial = new Binomial();
            Random rnd = new Random();

            /* first peak time 7 - 9 AM
             * 30 secounds of green light
             * 30 secounds of red light
             * 200 cars already waiting in traffic
             * two times more then the normal traffic 
             * our goal is less then 50 cars in line after each cycle */

            road.GreenLightTime = 30;
            road.RedLightTime = 30;
            road.NumberOfCarsWaiting = 200;

            for (int i = 0; i < 120; i++)
            {
                int newComingCars = rnd.Next(0, road.RedLightTime);
                road.NumberOfCarsWaiting += newComingCars;

                int outGoingCars = rnd.Next(0, road.GreenLightTime);
                road.NumberOfCarsWaiting -= outGoingCars;

                if (road.NumberOfCarsWaiting < 0)
                {
                    road.NumberOfCarsWaiting = 0;
                }
                road.TotalCarsMovement += outGoingCars;


                if (road.NumberOfCarsWaiting <= 50)
                {
                    binomial.P++;
                }
                else
                {
                    binomial.Q++;
                }

            }

            /* not a peak time 9 - 1 PM
             * 30 secounds of green light
             * 30 secounds of red light 
             * normal traffic
             * our goal is less then 10 cars in line after each cycle */

            road.GreenLightTime = 30;
            road.RedLightTime = 30;

            for (int i = 0; i < 240; i++)
            {
                int newComingCars = rnd.Next(0, road.RedLightTime);
                road.NumberOfCarsWaiting += newComingCars;

                int outGoingCars = rnd.Next(0, road.GreenLightTime);
                road.NumberOfCarsWaiting -= outGoingCars;

                if (road.NumberOfCarsWaiting < 0)
                {
                    road.NumberOfCarsWaiting = 0;
                }
                road.TotalCarsMovement += outGoingCars;

                if (road.NumberOfCarsWaiting <= 10)
                {
                    binomial.P++;
                }
                else
                {
                    binomial.Q++;
                }
            }

            /* secound peak time 1 - 5 PM
             * 30 secounds of green light
             * 30 secounds of red light 
             * more then 300 cars already waiting in traffic
             * three times more then the normal traffic 
             * our goal is less then 50 cars in line after each cycle */

            road.GreenLightTime = 30;
            road.RedLightTime = 30;
            road.NumberOfCarsWaiting += 300;

            for (int i = 0; i < 240; i++)
            {
                int newComingCars = rnd.Next(0, road.RedLightTime);
                road.NumberOfCarsWaiting += newComingCars;

                int outGoingCars = rnd.Next(0, road.GreenLightTime);
                road.NumberOfCarsWaiting -= outGoingCars;

                if (road.NumberOfCarsWaiting < 0)
                {
                    road.NumberOfCarsWaiting = 0;
                }
                road.TotalCarsMovement += outGoingCars;

                if (road.NumberOfCarsWaiting <= 50)
                {
                    binomial.P++;
                }
                else
                {
                    binomial.Q++;
                }

            }

            /* not a peak time 5 - 11 PM
             * 30 secounds of green light
             * 30 secounds of red light 
             * half of the normal traffic - night time
             * our goal is less then 10 cars in line after each cycle */

            road.GreenLightTime = 30;
            road.RedLightTime = 30;

            for (int i = 0; i < 360; i++)
            {
                int newComingCars = rnd.Next(0, road.RedLightTime) / 2;
                road.NumberOfCarsWaiting += newComingCars;

                int outGoingCars = rnd.Next(0, road.GreenLightTime);
                road.NumberOfCarsWaiting -= outGoingCars;

                if (road.NumberOfCarsWaiting < 0)
                {
                    road.NumberOfCarsWaiting = 0;
                }
                road.TotalCarsMovement += outGoingCars;

                if (road.NumberOfCarsWaiting <= 10)
                {
                    binomial.P++;
                }
                else
                {
                    binomial.Q++;
                }

            }


            /* not a peak time 11 - 7 AM
             * 30 secounds of green light
             * 30 secounds of red light 
             * half of the normal traffic - night time
             * our goal is less then 5 cars in line after each cycle */

            road.GreenLightTime = 30;
            road.RedLightTime = 30;

            for (int i = 0; i < 480; i++)
            {
                int newComingCars = rnd.Next(0, road.RedLightTime) / 2;
                road.NumberOfCarsWaiting += newComingCars;

                int outGoingCars = rnd.Next(0, road.GreenLightTime);
                road.NumberOfCarsWaiting -= outGoingCars;

                if (road.NumberOfCarsWaiting < 0)
                {
                    road.NumberOfCarsWaiting = 0;
                }
                road.TotalCarsMovement += outGoingCars;

                if (road.NumberOfCarsWaiting <= 5)
                {
                    binomial.P++;
                }
                else
                {
                    binomial.Q++;
                }

            }
            return new Result(binomial.P / (binomial.P + binomial.Q), binomial.Q / (binomial.P + binomial.Q), road.TotalCarsMovement);
        }
    }
}
