using System;

namespace Sprint2_experiment
{
    internal class Zahnradparameter
    {
        public double p;
        public double c;
        public double df;
        public double da;
        public double h;
        public double hf;
        public double ha;
        public double a;
        public double db;
        

        public Zahnradparameter()

        {
        }

        public void Berechne_Parameter(double m, double z, double d)
        {
             p = Math.PI / m;
             c = 0.167 * m;
             df = d - 2 * (m + c);
             da = d + 2 * m;
             h = 2 * m + c;
             hf = m + c;
             ha = m;
             a = 20;
             db = m * z + Math.Cos(a);

        }
    }
}