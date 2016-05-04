using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace TrafficSimulationSCE
{
    public partial class MainScreen : Form
    {
        private Road road = new Road();

        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            
        }

        static int GenRand(int one, int two)
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            return rand.Next(one,two);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Box1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.road.redLightTime = 30;
            this.road.greenLightTime = 30;
            this.road.countRoadCap = 0;
            road.p = 0;
            road.q = 0;
            for (int i = 0; i < 119; i++)
                {
                    int rateOfArrivel = GenRand(0, 50);
                    road.countRoadCap += (rateOfArrivel);

                    int rateOfDeparture = GenRand(0, this.road.greenLightTime);
                    road.countRoadCap -= (rateOfDeparture);
                    if (road.countRoadCap < 0)
                        road.countRoadCap = 0;

                    if (road.countRoadCap <= 10)
                        road.p++;
                    else
                        road.q++;
                }
            Box1.Text = "M1: Peak1 " + road.countRoadCap.ToString() + " ";

            for (int i = 0; i < 239; i++)
                {

                    int rateOfArrivel = GenRand(0, 12);
                    road.countRoadCap += (rateOfArrivel);

                    int rateOfDeparture = GenRand(0, this.road.greenLightTime);
                    road.countRoadCap -= (rateOfDeparture);
                    if (road.countRoadCap < 0)
                        road.countRoadCap = 0;

                    if (road.countRoadCap <= 10)
                        road.p++;
                    else
                        road.q++;
                }
                for (int i = 0; i < 239; i++)
                {
                    

                    int rateOfArrivel = GenRand(0, 60);
                    road.countRoadCap += (rateOfArrivel);

                    int rateOfDeparture = GenRand(0, this.road.greenLightTime);
                    road.countRoadCap -= (rateOfDeparture);
                    if (road.countRoadCap < 0)
                        road.countRoadCap = 0;

                    if (road.countRoadCap <= 10)
                        road.p++;
                    else
                        road.q++;
                }
                for (int i = 0; i < 359; i++)
                {
                    

                    int rateOfArrivel = GenRand(0, 10);
                    road.countRoadCap += (rateOfArrivel);

                    int rateOfDeparture = GenRand(0, this.road.greenLightTime);
                    road.countRoadCap -= (rateOfDeparture);
                    if (road.countRoadCap < 0)
                        road.countRoadCap = 0;

                    if (road.countRoadCap <= 10)
                        road.p++;
                    else
                        road.q++;
                }
                for (int i = 0; i < 479; i++)
                {
                    int rateOfArrivel = GenRand(0, 5);
                    road.countRoadCap += (rateOfArrivel);

                    int rateOfDeparture = GenRand(0, this.road.greenLightTime);
                    road.countRoadCap -= (rateOfDeparture);
                    if (road.countRoadCap < 0)
                        road.countRoadCap = 0;

                    if (road.countRoadCap <= 10)
                        road.p++;
                    else
                        road.q++;
                }

                //Box1.Text = (road.p / (road.p + road.q)).ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            this.road.countRoadCap = 0;
            road.p = 0;
            road.q = 0;

            for (int i = 0; i < 119; i++)
            {
                this.road.redLightTime = 35;
                this.road.greenLightTime = 25;

                int rateOfArrivel = GenRand(0, 50);
                road.countRoadCap += (rateOfArrivel);
                
                int rateOfDeparture = GenRand(0, this.road.greenLightTime);
                road.countRoadCap -= (rateOfDeparture);
                if (road.countRoadCap < 0)
                    road.countRoadCap = 0;
                
                if (road.countRoadCap <= 10)
                    road.p++;
                else
                    road.q++;
            }
            Box1.Text = "M2: Peak1 " +road.countRoadCap.ToString()+" ";
            for (int i = 0; i < 239; i++)
            {
                this.road.redLightTime = 20;
                this.road.greenLightTime = 40;

                int rateOfArrivel = GenRand(0, 12);
                road.countRoadCap += (rateOfArrivel);

                int rateOfDeparture = GenRand(0, this.road.greenLightTime);
                road.countRoadCap -= (rateOfDeparture);
                if (road.countRoadCap < 0)
                    road.countRoadCap = 0;

                if (road.countRoadCap <= 10)
                    road.p++;
                else
                    road.q++;
            }
            for (int i = 0; i < 239; i++)
            {
                this.road.redLightTime = 15;
                this.road.greenLightTime = 45;

                int rateOfArrivel = GenRand(0, 60);
                road.countRoadCap += (rateOfArrivel);

                int rateOfDeparture = GenRand(0, this.road.greenLightTime);
                road.countRoadCap -= (rateOfDeparture);
                if (road.countRoadCap < 0)
                    road.countRoadCap = 0;

                if (road.countRoadCap <= 10)
                    road.p++;
                else
                    road.q++;
            }
            for (int i = 0; i < 359; i++)
            {
                this.road.redLightTime = 45;
                this.road.greenLightTime = 15;

                int rateOfArrivel = GenRand(0, 10);
                road.countRoadCap += (rateOfArrivel);

                int rateOfDeparture = GenRand(0, this.road.greenLightTime);
                road.countRoadCap -= (rateOfDeparture);
                if (road.countRoadCap < 0)
                    road.countRoadCap = 0;

                if (road.countRoadCap <= 10)
                    road.p++;
                else
                    road.q++;
            }
            for (int i = 0; i < 479; i++)
            {
                this.road.redLightTime = 10;
                this.road.greenLightTime = 50;

                int rateOfArrivel = GenRand(0, 5);
                road.countRoadCap += (rateOfArrivel);

                int rateOfDeparture = GenRand(0, this.road.greenLightTime);
                road.countRoadCap -= (rateOfDeparture);
                if (road.countRoadCap < 0)
                    road.countRoadCap = 0;

                if (road.countRoadCap <= 10)
                    road.p++;
                else
                    road.q++;
            }
            
                

            //Box1.Text = (road.p / (road.p + road.q)).ToString();

        }
    }
}
