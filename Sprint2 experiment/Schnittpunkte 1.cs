using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sprint2_experiment
{
    class Schnittpunkte
    {
        double x;
        double y;
        double dis;
        double L;
        double h;
        double X1;
        double Y1;
        double R1;
        double X2;
        double Y2;
        double R2;
        double d;
        double m;
        double z;
        

        public Schnittpunkte ()
        {
        }
        public void Berechne_Schnittpunkt1 (double m, double z, double d)
        {
            // Parameter Hilfskreis
            R1 = 0.5 * 0.94 * d;
            X1 = 0;
            Y2 = 0;

            // Parameter großer Kreis
            X2 = 0.94 * d * Math.Cos(Math.PI * 20 / 180);
            Y2 = 0.94 * d * Math.Sin(Math.PI * 70 / 180);
            R1 = Math.Sqrt(Math.Pow(d * Math.Sin(90 / z) - 0.94 * d * Math.Sin(Math.PI * 20 /180), 2) + Math.Pow(d * Math.Cos(90 / z) - 0.94 * d * Math.Cos(Math.PI * 20 / 180), 2));

            


        }









    }
}
