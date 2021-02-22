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

namespace WpfApp2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            String name = "Quentin";
            int x = 3;
            x *= 17;
            double d = Math.PI / 2;
            myLabel.Text = "nazwa to " + name
                + "\nx jest równe " + x
                + "\nd jest równe " + d;

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            int x = 10;
            if (x == 10)
            { 
                myLabel.Text = "x musi być równe 150"; 
            }
            else
            {
                myLabel.Text = "x nie jest równe 10";
            }
                
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            int someValue = 3;
            string name = "Janek";
            if ((someValue == 3) && (name.Equals("Janek")))
            {
                myLabel.Text = "someValue jest równe 3 i name jest równe Janek";
            }
           
                
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            while (count < 10)
            {
                count = count + 1;

            }
            for (int i = 0; i < 5; i++)
            {
                count -= 1;
            }

            myLabel.Text = "Odpowiedź brzmi " + count;


        }
    }
}
