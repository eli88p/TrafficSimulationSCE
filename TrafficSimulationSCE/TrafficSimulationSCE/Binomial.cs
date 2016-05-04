using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficSimulationSCE
{
    class Binomial
    {
        public double p { get; set; }
        public double q { get; set; }

        public Binomial(double p, double q)
        {
            this.p = p;
            this.q = q;
        }
    }
}
