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

namespace basen
{
    /// <summary> //
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();

            int x = 0;
            string poem = "";

            while (x < 4)
            {
                poem += "a";
                if (x < 1)
                {
                    poem += " ";
                }
                poem += "n";

                if (x > 1)
                {
                    poem += " oyster";
                    x = x + 2;
                }
                if (x == 1)
                {
                    poem += "noys ";
                }
                if (x < 1)
                {
                    poem += "oise ";
                }

                x += 1;
            }
            output.Text = poem;

        }
        
        





    }

}
