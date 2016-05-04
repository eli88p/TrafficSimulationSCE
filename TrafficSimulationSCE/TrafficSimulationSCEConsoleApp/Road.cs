using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficSimulationSCEConsoleApp
{
    public class Road
    {
        public int NumberOfCarsWaiting { get; set; }
        public int TotalCarsMovement { get; set; }
        public int GreenLightTime { get; set; }
        public int RedLightTime { get; set; }

        public Road()
        {
            NumberOfCarsWaiting = 0;
            TotalCarsMovement = 0;
            GreenLightTime = 0;
            RedLightTime = 0;
        }
    }
}
