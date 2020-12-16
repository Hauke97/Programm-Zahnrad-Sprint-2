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
        public void Berechne_Schnittpunkte1 (double m, double z, double d, double b)
        {
            // Parameter Kopfkreis

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
            x5 = tkr * Math.Sin(3*Math.PI/(2*z));
            y5 = tkr * Math.Cos(3 * Math.PI / (2 * z));

           

            

        }


       
    }
}
