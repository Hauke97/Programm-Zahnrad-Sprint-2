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
        public double x6;
        public double y6;
        public double dis;
        public double L;
        public double h;
        public double X1;
        public double Y1;
        public double R1;
        public double X2;
        public double Y2;
        public double R2;
        
        

        public Schnittpunkte ()
        {
        }
        public void Berechne_Schnittpunkte1 (double m, double z, double d)
        {
            // Parameter Kopfkreis
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
            
        }


        public void Berechne_Schnittpunkt2 (double m, double z, double d)
        {
            //Parameter großer Kreis
            X1 = 0.94 * d * Math.Sin(Math.PI * 20 / 180);
            Y1 = 0.94 * d * Math.Cos(Math.PI * 20 / 180);
            R1 = Math.Sqrt(Math.Pow(d * Math.Sin(90 / z) - 0.94 * d * Math.Sin(Math.PI * 20 / 180), 2) + Math.Pow(d * Math.Cos(90 / z) - 0.94 * d * Math.Cos(Math.PI * 20 / 180), 2));

            // Parameter Verrundungskreis
            R2 = 0.35 * m;
            X2 = ((d / 2 - 1.25 * m) + 0.35 * m) * Math.Sin(Math.PI * 10 / 180);
            Y2 = ((d / 2 - 1.25 * m) + 0.35 * m) * Math.Cos(Math.PI * 10 / 180);




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
                x3 = (L * (X2 - X1)) / dis + (h * (Y2 - Y1)) / dis + X1;
                y3 = (L * (Y2 - Y1)) / dis + (h * (X2 - X1)) / dis + Y1;

                x4 = (L * (X2 - X1)) / dis - (h * (Y2 - Y1)) / dis + X1;
                y4 = (L * (Y2 - Y1)) / dis - (h * (X2 - X1)) / dis + Y1;
            }          
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
                x5 = (L * (X2 - X1)) / dis + (h * (Y2 - Y1)) / dis + X1;
                y5 = (L * (Y2 - Y1)) / dis + (h * (X2 - X1)) / dis + Y1;

                x6 = (L * (X2 - X1)) / dis - (h * (Y2 - Y1)) / dis + X1;
                y6 = (L * (Y2 - Y1)) / dis - (h * (X2 - X1)) / dis + Y1;
            }          
        }
    }
}
