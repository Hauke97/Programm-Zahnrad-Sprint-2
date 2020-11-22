using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sprint2_experiment
{
    /// <summary>
    /// Interaktionslogik für UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
  

        private void btn_berechnen_Click(object sender, RoutedEventArgs e)
        {
            double m = Convert.ToDouble(tb_modul.Text);
            double z = Convert.ToDouble(tb_zähnezahl.Text);
            double d = Convert.ToDouble(tb_teilkreisdurchmesser1.Text);

            z = d / m;
            double p = Math.PI * m;
            d = m * z;
            double c = 0.167 * m;
            double df = 2 * (m + c) - d;
            double da = 2 * m + d;
            double h = 2 * m + c;
            double hf = m + c;
            double ha = m;

            tb_teilung.Text = Convert.ToString(p);
            tb_kopfspiel.Text = Convert.ToString(c);
            tb_fußkreisdurchmesser.Text = Convert.ToString(df);
            tb_kopfkreisdurchmesser.Text = Convert.ToString(da);
            tb_zahnhöhe.Text = Convert.ToString(h);
            tb_zahnfußhöhe.Text = Convert.ToString(hf);
            tb_zahnkopfhöhe.Text = Convert.ToString(ha);
            



           

        }
       
    }
}
