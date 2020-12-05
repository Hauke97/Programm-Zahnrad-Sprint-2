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
        Zahnradparameter zahnradparameter = new Zahnradparameter();

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

            //Textboxen für die Eingabe und Labels werden sichtbar geschaltet
            Zeige_Ergebnislabels();
            lab_Zahnrad.Visibility = Visibility.Hidden;

            //Bei Auswahl eines neuen Items werden die Inhalte der Textboxen gelöscht
            Loesche_Textboxen();

            //Berechnungsbutton wird freigeschaltet
            btn_berechnen.IsEnabled = true;
        }

        private void itm_Zahn_Selected(object sender, RoutedEventArgs e)
        {
            lab_oben.Content = "Zähnezahl:";
            lab_unten.Content = "Teilkreisdurchmesser:";

            //Textboxen für die Eingabe und Labels werden sichtbar geschaltet
            Zeige_Ergebnislabels();

            lab_Zahnrad.Visibility = Visibility.Hidden;

            //Bei Auswahl eines neuen Items werden die Inhalte der Textboxen gelöscht
            Loesche_Textboxen();

            //Berechnungsbutton wird freigeschaltet
            btn_berechnen.IsEnabled = true;
        }

        private void itm_Teilkreis_Selected(object sender, RoutedEventArgs e)
        {
            lab_oben.Content = "Modul:";
            lab_unten.Content = "Teilkreisdurchmesser:";

            //Textboxen für die Eingabe und Labels werden sichtbar geschaltet
            Zeige_Ergebnislabels();
            lab_Zahnrad.Visibility = Visibility.Hidden;


            //Bei Auswahl eines neuen Items werden die Inhalte der Textboxen gelöscht
            Loesche_Textboxen();
            
            //Berechnungsbutton wird freigeschaltet
            btn_berechnen.IsEnabled = true;
        }

        private void Zeige_Ergebnislabels()
        {
            tb_oben.Visibility = Visibility.Visible;
            tb_unten.Visibility = Visibility.Visible;
            lab_fußkreisdurchmesser.Visibility = Visibility.Visible;
            lab_kopfkreisdurchmesser.Visibility = Visibility.Visible;
            lab_kopfspiel.Visibility = Visibility.Visible;
            lab_teilung.Visibility = Visibility.Visible;
            lab_zahnfußhöhe.Visibility = Visibility.Visible;
            lab_zahnhöhe.Visibility = Visibility.Visible;
            lab_zahnkopfhöhe.Visibility = Visibility.Visible;
            lab_grundkreisdurchmesser.Visibility = Visibility.Visible;
        }

        private void Loesche_Textboxen()
        {
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
                string eingabem = tb_oben.Text;
                string eingabez = tb_unten.Text;
                double m;
                double z;
                double d;

                bool checkm = Double.TryParse(eingabem, out m);
                bool checkz = Double.TryParse(eingabez, out z);

                if (checkm == false)
                {
                    MessageBox.Show("Es dürfen nur numerische Werte für den Modul eingegeben werden." ,"Fehlermeldung",MessageBoxButton.OK, MessageBoxImage.Warning);
                    tb_oben.Focus();
                    tb_oben.SelectAll();
                }

                else if (checkz == false)
                {
                    MessageBox.Show("Es dürfen nur numerische Werte für die Zähnezahl eingegeben werden.", "Fehlermeldung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    tb_unten.Focus();
                    tb_unten.SelectAll();
                }

                else if (m < 0)
                {
                    MessageBox.Show("Der Modul darf nicht negativ sein.", "Fehlermeldung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    tb_oben.Focus();
                    tb_oben.SelectAll();
                }

                else if (m == 0) 
                {
                    MessageBox.Show("Der Modul darf nicht 0 sein.", "Fehlermeldung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    tb_oben.Focus();
                    tb_oben.SelectAll();
                }

                else if (z < 0)
                {
                    MessageBox.Show("Die Zähnezahl darf nicht negativ sein.", "Fehlermeldung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    tb_unten.Focus();
                    tb_unten.SelectAll();
                }

                else if (z==0)
                {
                    MessageBox.Show("Die Zähnezahl darf nicht 0 sein.", "Fehlermeldung", MessageBoxButton.OK, MessageBoxImage.Warning);
                    tb_unten.Focus();
                    tb_unten.SelectAll();
                }

                else
                {
                    //Berechnungen mittels Modul und Zähnezahl
                    d = m * z;
                    zahnradparameter.Berechne_Parameter(m, z, d);                                       
                }
            }

            else if (trv_1.SelectedItem.Equals(itm_Zahn))
            {

                //Zuweisung der Variablen über die Textboxen, je nachdem welches Item ausgewählt ist

                string eingabez = tb_oben.Text;
                string eingabed = tb_unten.Text;
                double m;
                double z;
                double d;

                bool checkz = Double.TryParse(eingabez, out z);
                bool checkd = Double.TryParse(eingabed, out d);

                if (checkz == false)
                {
                    Zeige_Fehler("Es dürfen nur numerische Werte für die Zähnezahl eingegeben werden.");
                }

                else if (checkd == false)
                {
                    Zeige_Fehler("Es dürfen nur numerische Werte für den Teilkreisdurchmesser eingegeben werden.");
                }

                else if (z < 0)
                {
                    Zeige_Fehler("Die Zähnezahl darf nicht kleiner als 0 sein.");
                }

                else if (z == 0)
                {
                    Zeige_Fehler("Die Zähnezahl darf nicht 0 sein.");
                }

                else if (d < 0)
                {
                    Zeige_Fehler("Der Teilkreisdurchmesser darf nicht negativ sein.");
                }

                else if (d == 0)
                {
                    Zeige_Fehler("Der Teilkreisdurchmesser darf nicht 0 sein.");
                }

                else
                {

                    //Berechnungen mittels Zähnezahl und Teilkreisdurchmesser
                    m = d / z;
                    zahnradparameter.Berechne_Parameter(m, z, d);
                                      
                }
            }

            else if (trv_1.SelectedItem.Equals(itm_Teilkreis))
            {

                //Zuweisung der Variablen über die Textboxen, je nachdem welches Item ausgewählt ist

                string eingabem = tb_oben.Text;
                string eingabed = tb_unten.Text;
                double m;
                double z;
                double d;

                bool checkm = Double.TryParse(eingabem, out m);
                bool checkd = Double.TryParse(eingabed, out d);

                if (checkm == false)
                {
                    Zeige_Fehler("Es dürfen nur numerische Werte für den Modul eingegeben werden."); 
                }

                else if (checkd == false)
                {
                    Zeige_Fehler("Es dürfen nur numerische Werte für den Teilkreisdurchmesser eingegeben werden.");
                }

                else if (m < 0)
                {
                    Zeige_Fehler("Der Modul kann nicht negativ sein.");
                }

                else if (m == 0)
                {
                    Zeige_Fehler("Der Modul darf nicht 0 sein.");
                }

                else if (d < 0)
                {
                    Zeige_Fehler("Der Teilkreisdurchmesser darf nicht negativ sein.");
                }

                else if (d == 0)
                {
                    Zeige_Fehler("Der Teilkreisdurchmesser darf nicht 0 sein.");
                }

                else
                {
                    //Berechnungen mittels Modul und Teilkreisdurchmesser
                    z = d / m;
                    zahnradparameter.Berechne_Parameter(m, z, d);                                                      
                }
                               
            }
            //Textboxen für die Ausgabe werden sichtbar geschaltet
            tb_fußkreisdurchmesser.Visibility = Visibility.Visible;
            tb_kopfkreisdurchmesser.Visibility = Visibility.Visible;
            tb_kopfspiel.Visibility = Visibility.Visible;
            tb_teilung.Visibility = Visibility.Visible;
            tb_zahnfußhöhe.Visibility = Visibility.Visible;
            tb_zahnhöhe.Visibility = Visibility.Visible;
            tb_zahnkopfhöhe.Visibility = Visibility.Visible;
            tb_grundkreisdurchmesser.Visibility = Visibility.Visible;

            //Rückgabbe der berechneten Werte an die Textboxen
            tb_fußkreisdurchmesser.Text = Convert.ToString(zahnradparameter.df);
            tb_kopfkreisdurchmesser.Text = Convert.ToString(zahnradparameter.da);
            tb_zahnhöhe.Text = Convert.ToString(zahnradparameter.h);
            tb_zahnfußhöhe.Text = Convert.ToString(zahnradparameter.hf);
            tb_zahnkopfhöhe.Text = Convert.ToString(zahnradparameter.ha);
            tb_teilung.Text = Convert.ToString(zahnradparameter.p);
            tb_kopfspiel.Text = Convert.ToString(zahnradparameter.c);
            tb_grundkreisdurchmesser.Text = Convert.ToString(zahnradparameter.db);
        }
        private void Zeige_Fehler(string Fehlermeldung)
        {
            MessageBox.Show(Fehlermeldung , "Fehlermeldung", MessageBoxButton.OK, MessageBoxImage.Warning);
            tb_oben.Focus();
            tb_oben.SelectAll();
        }

    }
}
