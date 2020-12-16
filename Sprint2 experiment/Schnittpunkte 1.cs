using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



namespace Sprint2_experiment
{
    public class Schnittpunkte
    {
        public double x1;
        public double y1;
        public double x2;
        public double y2;
        public double x3;
        public double y3;
        public double x4;
        public double y4;
        public double x5;
        public double y5;
        public double tkr;
        public double h;
        public double alpha;
        public double alpharad;
        public double R1;
        public double X2;
        public double Y2;
        public double R2;
        public double betarad;
        public double beta;

        public Schnittpunkte ()
        {
        }
        public void Berechne_Schnittpunkte1 (double m, double z, double d)
        {
            // Parameter Kopfkreis
<<<<<<< HEAD
            beta = 90 / z;
            tkr = d / 2;
            betarad = Math.PI*beta/180;
            alpha = (360/z)-beta;
            alpharad = (2*Math.PI /z)-betarad;
            h=2*m+0.167 * m;
            x1 = Math.Sin(betarad)*tkr;
            y1 = Math.Cos(betarad) * tkr;
            x2 = -1 * x1;
            y2 = y1;
            x3 = x1;
            y3 = y1 + h;
            x4 = x2;
            y4 = y2 + h;
            x5 = Math.Sin(Math.PI/z+Math.PI/2*z) * tkr;
            y5 = Math.Cos(Math.PI /z+Math.PI/2*z) * tkr;
=======
            R1 = (d / 2) + m;
            X1 = 0;
            Y1 = 0;

            // Parameter großer Kreis
            X2 = 0.94 * d * Math.Sin(Math.PI * 20 / 180);
            Y2 = 0.94 * d * Math.Cos(Math.PI * 20 / 180);
            R2 = Math.Sqrt(Math.Pow((d/2 * Math.Sin(90 / z)) - (0.94 * d * Math.Sin(Math.PI * 20 /180)), 2) + Math.Pow((d/2 * Math.Cos(90 / z)) - (0.94 * d * Math.Cos(Math.PI * 20 / 180)), 2));

            dis = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
            L = (Math.Pow(R1, 2) - Math.Pow(R2, 2) + Math.Pow(dis, 2)) / (2 * dis);

            if ((Math.Pow(R1, 2) - Math.Pow(L, 2)) < 0.00001)
            {
                h = 0;
                MessageBox.Show("Das Argument der Wurzel darf nicht 0 sein.", "Fehlermeldung", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            else 
            {
                h = Math.Sqrt(Math.Pow(R1, 2) - Math.Pow(L, 2));


                // kartesische Koordinaten des Schnittpunkts
                x1 = (L * (X2 - X1)) / dis + (h * (Y2 - Y1)) / dis + X1;
                y1 = (L * (Y2 - Y1)) / dis + (h * (X2 - X1)) / dis + Y1;

                x2 = (L * (X2 - X1)) / dis - (h * (Y2 - Y1)) / dis + X1;
                y2 = (L * (Y2 - Y1)) / dis - (h * (X2 - X1)) / dis + Y1;
            }
>>>>>>> ed70cb36550e91b4f9a6f17a33e2c0683fc5cf29
            

            

        }


       
    }
}
