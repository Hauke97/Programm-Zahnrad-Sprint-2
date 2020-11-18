using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sprint2_experiment
{
    class Program
    {
        Program()
        {
            Window fenster = new Window();
            fenster.Title = "MeinFenster";

            UserControl1 myGUI = new UserControl1();
            fenster.Content = myGUI;
            fenster.ShowDialog();


        }

        [STAThread]
        static void Main(string[] args)
        {
            new Program();
        }
    }
}

