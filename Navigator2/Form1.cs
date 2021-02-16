using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navigator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Navigator
        {
            string SetCurrentLocation();
            string SetDestination();
            string ModifyRouteToAvoid();
            string ModifyRouteToInclude();
            string GetRoute();
            string GetTimeToDestination();
            string TotalDistance();

            string destination = textBox1.Text;
            Navigator navigator1 = new Navigator();
            navigator1.SetDestination(destination);
            string route = navigator1.GetRoute



        }
            

            
    }
}
