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

        
            
         
        //Bei Auswahl eines TreeViewItems ändern sich die Inhalte der Labels
        private void itm_Modul_Selected(object sender, RoutedEventArgs e)
        {
            //Die Labels ändern sich in Abhängigkeit des ausgewählten TreeViewItems
            lab_oben.Content = "Modul:";
            lab_unten.Content = "Zähnezahl:";

            //Textboxen und Labels werden sichtbar geschaltet
            tb_oben.Visibility = Visibility.Visible;
            tb_unten.Visibility = Visibility.Visible;
            tb_fußkreisdurchmesser.Visibility=Visibility.Visible;
            tb_kopfkreisdurchmesser.Visibility = Visibility.Visible;
            tb_kopfspiel.Visibility = Visibility.Visible;
            tb_teilung.Visibility = Visibility.Visible;
            tb_zahnfußhöhe.Visibility = Visibility.Visible;
            tb_zahnhöhe.Visibility = Visibility.Visible;
            tb_zahnkopfhöhe.Visibility = Visibility.Visible;
            tb_grundkreisdurchmesser.Visibility = Visibility.Visible;
            lab_fußkreisdurchmesser.Visibility = Visibility.Visible;
            lab_kopfkreisdurchmesser.Visibility = Visibility.Visible;
            lab_kopfspiel.Visibility = Visibility.Visible;
            lab_teilung.Visibility = Visibility.Visible;
            lab_zahnfußhöhe.Visibility = Visibility.Visible;
            lab_zahnhöhe.Visibility = Visibility.Visible;
            lab_zahnkopfhöhe.Visibility = Visibility.Visible;
            lab_grundkreisdurchmesser.Visibility = Visibility.Visible;
            lab_Zahnrad.Visibility = Visibility.Hidden;



            //Bei Auswahl eines neuen Items werden die Inhalte der Textboxen gelöscht
            tb_fußkreisdurchmesser.Clear();
            tb_kopfkreisdurchmesser.Clear();
            tb_kopfspiel.Clear();
            tb_oben.Clear();
            tb_teilung.Clear();
            tb_unten.Clear();
            tb_zahnfußhöhe.Clear();
            tb_zahnhöhe.Clear();
            tb_zahnkopfhöhe.Clear();
            tb_grundkreisdurchmesser.Clear();

            //Berechnungsbutton wird freigeschaltet
            btn_berechnen.IsEnabled = true;
        }

        private void itm_Zahn_Selected(object sender, RoutedEventArgs e)
        {
            lab_oben.Content = "Zähnezahl:";
            lab_unten.Content = "Teilkreisdurchmesser:";

            //Textboxen und Labels werden sichtbar geschaltet
            tb_oben.Visibility = Visibility.Visible;
            tb_unten.Visibility = Visibility.Visible;
            tb_fußkreisdurchmesser.Visibility = Visibility.Visible;
            tb_kopfkreisdurchmesser.Visibility = Visibility.Visible;
            tb_kopfspiel.Visibility = Visibility.Visible;
            tb_teilung.Visibility = Visibility.Visible;
            tb_zahnfußhöhe.Visibility = Visibility.Visible;
            tb_zahnhöhe.Visibility = Visibility.Visible;
            tb_zahnkopfhöhe.Visibility = Visibility.Visible;
            tb_grundkreisdurchmesser.Visibility = Visibility.Visible;
            lab_fußkreisdurchmesser.Visibility = Visibility.Visible;
            lab_kopfkreisdurchmesser.Visibility = Visibility.Visible;
            lab_kopfspiel.Visibility = Visibility.Visible;
            lab_teilung.Visibility = Visibility.Visible;
            lab_zahnfußhöhe.Visibility = Visibility.Visible;
            lab_zahnhöhe.Visibility = Visibility.Visible;
            lab_zahnkopfhöhe.Visibility = Visibility.Visible;
            lab_grundkreisdurchmesser.Visibility = Visibility.Visible;
            lab_Zahnrad.Visibility = Visibility.Hidden;

            //Bei Auswahl eines neuen Items werden die Inhalte der Textboxen gelöscht
            tb_fußkreisdurchmesser.Clear();
            tb_kopfkreisdurchmesser.Clear();
            tb_kopfspiel.Clear();
            tb_oben.Clear();
            tb_teilung.Clear();
            tb_unten.Clear();
            tb_zahnfußhöhe.Clear();
            tb_zahnhöhe.Clear();
            tb_zahnkopfhöhe.Clear();
            tb_grundkreisdurchmesser.Clear();


            //Berechnungsbutton wird freigeschaltet
            btn_berechnen.IsEnabled = true;
        }

        private void itm_Teilkreis_Selected(object sender, RoutedEventArgs e)
        {
            lab_oben.Content = "Modul:";
            lab_unten.Content = "Teilkreisdurchmesser:";

            //Textboxen und Labels werden sichtbar geschaltet
            tb_oben.Visibility = Visibility.Visible;
            tb_unten.Visibility = Visibility.Visible;
            tb_fußkreisdurchmesser.Visibility = Visibility.Visible;
            tb_kopfkreisdurchmesser.Visibility = Visibility.Visible;
            tb_kopfspiel.Visibility = Visibility.Visible;
            tb_teilung.Visibility = Visibility.Visible;
            tb_zahnfußhöhe.Visibility = Visibility.Visible;
            tb_zahnhöhe.Visibility = Visibility.Visible;
            tb_zahnkopfhöhe.Visibility = Visibility.Visible;
            tb_grundkreisdurchmesser.Visibility = Visibility.Visible;
            lab_fußkreisdurchmesser.Visibility = Visibility.Visible;
            lab_kopfkreisdurchmesser.Visibility = Visibility.Visible;
            lab_kopfspiel.Visibility = Visibility.Visible;
            lab_teilung.Visibility = Visibility.Visible;
            lab_zahnfußhöhe.Visibility = Visibility.Visible;
            lab_zahnhöhe.Visibility = Visibility.Visible;
            lab_zahnkopfhöhe.Visibility = Visibility.Visible;
            lab_grundkreisdurchmesser.Visibility = Visibility.Visible;
            lab_Zahnrad.Visibility = Visibility.Hidden;


            //Bei Auswahl eines neuen Items werden die Inhalte der Textboxen gelöscht
            tb_fußkreisdurchmesser.Clear();
            tb_kopfkreisdurchmesser.Clear();
            tb_kopfspiel.Clear();
            tb_oben.Clear();
            tb_teilung.Clear();
            tb_unten.Clear();
            tb_zahnfußhöhe.Clear();
            tb_zahnhöhe.Clear();
            tb_zahnkopfhöhe.Clear();
            tb_grundkreisdurchmesser.Clear();

            //Berechnungsbutton wird freigeschaltet
            btn_berechnen.IsEnabled = true;
        }

        //Event für den BeendenButton
        private void btn_beenden_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        //Event für den Berechungsbutton
        private void btn_berechnen_Click(object sender, RoutedEventArgs e)
        {



            //if-Schleife:Variablenzuweisung ist abhängig von der Auswahl eines TreeViewItems

            if (trv_1.SelectedItem.Equals(itm_Modul))
            {

                //Zuweisung der Variablen über die Textboxen, je nachdem welches Item ausgewählt ist 
                double m = Convert.ToDouble(tb_oben.Text);
                double z = Convert.ToDouble(tb_unten.Text);
                double d;

                //Berechnungen mittels Modul und Zähnezahl
                double p = Math.PI / m;
                d = m * z;
                double c = 0.167 * m;
                double df = d - 2 * (m + c);
                double da = d + 2 * m;
                double h = 2 * m + c;
                double hf = m + c;
                double ha = m;
                double a = 20;
                double db = m * z + Math.Cos(a);


                //Rückgabbe der berechneten Werte an die Textboxen
                tb_fußkreisdurchmesser.Text = Convert.ToString(df);
                tb_kopfkreisdurchmesser.Text = Convert.ToString(da);
                tb_zahnhöhe.Text = Convert.ToString(h);
                tb_zahnfußhöhe.Text = Convert.ToString(hf);
                tb_zahnkopfhöhe.Text = Convert.ToString(ha);
                tb_teilung.Text = Convert.ToString(p);
                tb_kopfspiel.Text = Convert.ToString(c);
                tb_grundkreisdurchmesser.Text = Convert.ToString(db); 



            }


            else if (trv_1.SelectedItem.Equals(itm_Zahn))
            {

                //Zuweisung der Variablen über die Textboxen, je nachdem welches Item ausgewählt ist
                double m;
                double z = Convert.ToDouble(tb_oben.Text);
                double d = Convert.ToDouble(tb_unten.Text);

                //Berechnungen mittels Zähnezahl und Teilkreisdurchmesser
                m = d / z;
                double p = Math.PI / m;
                double c = 0.167 * m;
                double df = d - 2 * (m + c);
                double da = d + 2 * m;
                double h = 2 * m + c;
                double hf = m + c;
                double ha = m;
                double a = 20;
                double db = m * z * Math.Cos(a);

                //Rückgabe der berechneten Werte an die Textboxen
                tb_fußkreisdurchmesser.Text = Convert.ToString(df);
                tb_kopfkreisdurchmesser.Text = Convert.ToString(da);
                tb_zahnhöhe.Text = Convert.ToString(h);
                tb_zahnfußhöhe.Text = Convert.ToString(hf);
                tb_zahnkopfhöhe.Text = Convert.ToString(ha);
                tb_teilung.Text = Convert.ToString(p);
                tb_kopfspiel.Text = Convert.ToString(c);
                tb_grundkreisdurchmesser.Text = Convert.ToString(db);

            }

            else if (trv_1.SelectedItem.Equals(itm_Teilkreis))
            {

                //Zuweisung der Variablen über die Textboxen, je nachdem welches Item ausgewählt ist
                double m = Convert.ToDouble(tb_oben.Text);
                double z;
                double d = Convert.ToDouble(tb_unten.Text);

                //Berechnungen mittels Modul und Teilkreisdurchmesser
                z = d / m;
                double p = Math.PI / m;
                double c = 0.167 * m;
                double df = d - 2 * (m + c);
                double da = d + 2 * m;
                double h = 2 * m + c;
                double hf = m + c;
                double ha = m;
                double a = 20;
                double db = m * z * Math.Cos(a);

                //Rückgabe der berechneten Werte an die Textboxen 
                tb_fußkreisdurchmesser.Text = Convert.ToString(df);
                tb_kopfkreisdurchmesser.Text = Convert.ToString(da);
                tb_zahnhöhe.Text = Convert.ToString(h);
                tb_zahnfußhöhe.Text = Convert.ToString(hf);
                tb_zahnkopfhöhe.Text = Convert.ToString(ha);
                tb_teilung.Text = Convert.ToString(p);
                tb_kopfspiel.Text = Convert.ToString(c);
                tb_grundkreisdurchmesser.Text = Convert.ToString(db);


            }

        }

        
    }
}
