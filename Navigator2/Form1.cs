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
            string route = "Marszałkowska";
            int distance1 = 5;
            int distance2 = 3;
            int distance3 = 9;

            string destination = textBox1.Text;
            Navigator navigator1 = new Navigator();
            navigator1.SetDestination(destination);
            navigator1.GetRoute(route);
            navigator1.TotalDistance(distance1);

            string street = textBox2.Text;
            Navigator navigator2 = new Navigator();
            navigator2.SetDestination(destination);
            navigator2.ModifyRouteToAvoid(street);
            navigator2.GetRoute(route);
            navigator2.TotalDistance(distance2);

            string street2 = textBox3.Text;
            Navigator navigator3 = new Navigator();
            navigator3.SetDestination(destination);
            navigator3.ModifyRouteToInclude(street2);
            navigator3.GetRoute(route);
            navigator3.TotalDistance(distance3);

            int shortestDistance = Math.Min(distance1, Math.Min(distance2, distance3));



        }
        
        
        
        
        class Navigator
        {
            public void SetCurrentLocation(string locationName) { }
            public void SetDestination(string destinationName) { }
          
            public void ModifyRouteToAvoid(string streetName) { }
            public void ModifyRouteToInclude(string street2Name) { }
            public void GetRoute(string route) { }
            public void GetTimeToDestination(int timeToDestination) { }
            public void TotalDistance(int distance) { }
            

            

        }//
        
        
            

            
    }
}
