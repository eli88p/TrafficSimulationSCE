using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficSimulationSCE
{
    class Road
    {
        public int countRoadCap { get; set; }
        public int greenLightTime { get; set; }
        public int redLightTime { get; set; }
        public double p { get; set; }
        public double q { get; set; }

        public Road()
        {
            countRoadCap = 0;
            greenLightTime = 0;
            redLightTime = 0;
        }



    }
}
