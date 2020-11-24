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

        
         

        private void itm_Modul_Selected(object sender, RoutedEventArgs e)
        {
            lab_oben.Content = "Modul:";
            lab_unten.Content = "Zähnezahl:";

        }

        private void itm_Zahn_Selected(object sender, RoutedEventArgs e)
        {
            lab_oben.Content = "Zähnezahl:";
            lab_unten.Content = "Teilkreisdurchmesser:";

        }

        private void itm_Teilkreis_Selected(object sender, RoutedEventArgs e)
        {
            lab_oben.Content = "Modul:";
            lab_unten.Content = "Teilkreisdurchmesser:";

        }


        private void btn_beenden_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }


        private void btn_berechnen_Click(object sender, RoutedEventArgs e)
        {





            if (trv_1.SelectedItem.Equals(itm_Modul))
            {
                double m = Convert.ToDouble(tb_oben.Text);
                double z = Convert.ToDouble(tb_unten.Text);
                double d;

                double p = Math.PI / m;
                d = m * z;
                double c = 0.167 * m;
                double df = d - 2 * (m + c);
                double da = d + 2 * m;
                double h = 2 * m + c;
                double hf = m + c;
                double ha = m;
                tb_fußkreisdurchmesser.Text = Convert.ToString(df);
                tb_kopfkreisdurchmesser.Text = Convert.ToString(da);
                tb_zahnhöhe.Text = Convert.ToString(h);
                tb_zahnfußhöhe.Text = Convert.ToString(hf);
                tb_zahnkopfhöhe.Text = Convert.ToString(ha);
                tb_teilung.Text = Convert.ToString(p);
                tb_kopfspiel.Text = Convert.ToString(c);
            }


            else if (trv_1.SelectedItem.Equals(itm_Zahn))
            {

                double m;
                double z = Convert.ToDouble(tb_oben.Text);
                double d = Convert.ToDouble(tb_unten.Text);

                m = d / z;
                double p = Math.PI / m;
                double c = 0.167 * m;
                double df = d - 2 * (m + c);
                double da = d + 2 * m;
                double h = 2 * m + c;
                double hf = m + c;
                double ha = m;

                tb_fußkreisdurchmesser.Text = Convert.ToString(df);
                tb_kopfkreisdurchmesser.Text = Convert.ToString(da);
                tb_zahnfußhöhe.Text = Convert.ToString(h);
                tb_zahnfußhöhe.Text = Convert.ToString(hf);
                tb_zahnkopfhöhe.Text = Convert.ToString(ha);
                tb_teilung.Text = Convert.ToString(p);
                tb_kopfspiel.Text = Convert.ToString(c);
            }

            else if (trv_1.SelectedItem.Equals(itm_Teilkreis))
            {

                double m = Convert.ToDouble(tb_oben.Text);
                double z;
                double d = Convert.ToDouble(tb_unten.Text);

                z = d / m;
                double p = Math.PI / m;
                double c = 0.167 * m;
                double df = d - 2 * (m + c);
                double da = d + 2 * m;
                double h = 2 * m + c;
                double hf = m + c;
                double ha = m;

                tb_fußkreisdurchmesser.Text = Convert.ToString(df);
                tb_kopfkreisdurchmesser.Text = Convert.ToString(da);
                tb_zahnfußhöhe.Text = Convert.ToString(h);
                tb_zahnfußhöhe.Text = Convert.ToString(hf);
                tb_zahnkopfhöhe.Text = Convert.ToString(ha);
                tb_teilung.Text = Convert.ToString(p);
                tb_kopfspiel.Text = Convert.ToString(c);
            }

        }

        
    }
}
