using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sprint2_experiment
{
    class Schnittpunkte
    {
        double x1;
        double y1;
        double x2;
        double y2;
        double x3;
        double y3;
        double x4;
        double y4;
        double x5;
        double y5;
        double x6;
        double y6;
        double dis;
        double L;
        double h;
        double X1;
        double Y1;
        double R1;
        double X2;
        double Y2;
        double R2;
        
        

        public Schnittpunkte ()
        {
        }
        public void Berechne_Schnittpunkt1 (double m, double z, double d)
        {
            // Parameter Kopfkreis
            R1 = d/ 2 + m;
            X1 = 0;
            Y2 = 0;

            // Parameter großer Kreis
            X2 = 0.94 * d * Math.Cos(Math.PI * 20 / 180);
            Y2 = 0.94 * d * Math.Sin(Math.PI * 70 / 180);
            R1 = Math.Sqrt(Math.Pow(d * Math.Sin(90 / z) - 0.94 * d * Math.Sin(Math.PI * 20 /180), 2) + Math.Pow(d * Math.Cos(90 / z) - 0.94 * d * Math.Cos(Math.PI * 20 / 180), 2));

            dis = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1-Y2, 2));
            L = Math.Pow(R1, 2) + Math.Pow(R2, 2) + Math.Pow(dis, 2) / (2 * d);
            h = Math.Sqrt(Math.Pow(R1, 2) - Math.Pow(L, 2));


            // kartesische Koordinaten des Schnittpunkts
            x1 = L * (X2 - X1) / d + h * (Y2 - Y1) / d + X1;
            y1 = L * (Y2 - Y1) / d + h * (X2 - X1) / d + Y1;

            x2 = L * (X2 - X1) / d - h * (Y2 - Y1) / d + X1;
            y2 = L * (Y2 - Y1) / d - h * (X2 - X1) / d + Y1;
        }


        public void Berechne_Schnittpunkt2 (double m, double z, double d)
        {
            //Parameter großer Kreis
            X1 = 0.94 * d * Math.Cos(Math.PI * 20 / 180);
            Y1 = 0.94 * d * Math.Sin(Math.PI * 70 / 180);
            R1 = Math.Sqrt(Math.Pow(d * Math.Sin(90 / z) - 0.94 * d * Math.Sin(Math.PI * 20 / 180), 2) + Math.Pow(d * Math.Cos(90 / z) - 0.94 * d * Math.Cos(Math.PI * 20 / 180), 2));

            // Parameter Verrundungskreis
            R2 = 0.35 * m;
            X2 = ((d / 2 - 1.25 * m) + 0.35 * m) * Math.Sin(Math.PI * 10 / 180);
            Y2 = ((d / 2 - 1.25 * m) + 0.35 * m) * Math.Cos(Math.PI * 10 / 180);




            dis = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
            L = Math.Pow(R1, 2) + Math.Pow(R2, 2) + Math.Pow(dis, 2) / (2 * d);
            h = Math.Sqrt(Math.Pow(R1, 2) - Math.Pow(L, 2));


            // kartesische Koordinaten des Schnittpunkts
            x3 = L * (X2 - X1) / d + h * (Y2 - Y1) / d + X1;
            y3 = L * (Y2 - Y1) / d + h * (X2 - X1) / d + Y1;

            x4 = L * (X2 - X1) / d - h * (Y2 - Y1) / d + X1;
            y4 = L * (Y2 - Y1) / d - h * (X2 - X1) / d + Y1;





        }

        public void Berechne_Schnittpunkt3 (double m, double z, double d)
        {
            //Parameter Fußkreis
            R1 = d / 2 - 1.25 * m;
            X1 = 0;
            Y1 = 0;

            //Parameter Verrundungskreis
            R2 = 0.35 * m;
            X2 = ((d / 2 - 1.25 * m) + 0.35 * m) * Math.Sin(Math.PI * 10 / 180);
            Y2 = ((d / 2 - 1.25 * m) + 0.35 * m) * Math.Cos(Math.PI * 10 / 180);


            dis = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
            L = Math.Pow(R1, 2) + Math.Pow(R2, 2) + Math.Pow(dis, 2) / (2 * d);
            h = Math.Sqrt(Math.Pow(R1, 2) - Math.Pow(L, 2));


            // kartesische Koordinaten des Schnittpunkts
            x5 = L * (X2 - X1) / d + h * (Y2 - Y1) / d + X1;
            y5 = L * (Y2 - Y1) / d + h * (X2 - X1) / d + Y1;

            x6 = L * (X2 - X1) / d - h * (Y2 - Y1) / d + X1;
            y6 = L * (Y2 - Y1) / d - h * (X2 - X1) / d + Y1;

        }



    }
}
