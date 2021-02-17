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

            Navigator navigator1 = new Navigator();
            navigator1.SetDestination("Skrzyżowanie Powstańców Warszawy i Legionów");
            string route;
            route = navigator1.GetRoute();
            string destination = textBox1.Text;
            int distance1 = navigator1.TotalDistance();

            Navigator navigator2 = new Navigator();
            navigator2.SetDestination("Skrzyżowanie Powstańców Warszawy i Legionów");
            navigator2.ModifyRouteToAvoid("Ulica Kochanowskiego");
            route = navigator2.GetRoute();
            string street = textBox2.Text;
            int distance2 = navigator2.TotalDistance();


            Navigator navigator3 = new Navigator();
            navigator3.SetDestination("Skrzyżowanie Powstańców Warszawy i Legionów");
            navigator3.ModifyRouteToInclude("Ulica Niebieska");
            route = navigator3.GetRoute();
            string street2 = textBox3.Text;
            int distance3 = navigator3.TotalDistance();

            int shortestDistance = Math.Min(distance1, Math.Min(distance2, distance3));
            
        }
        class Navigator
        {
            public void SetCurrentLocation(string locationName) { }
            public void SetDestination(string destinationName) { }
            public void ModifyRouteToAvoid(string streetName) { }
            public void ModifyRouteToInclude(string street2Name) { }
            public string GetRoute(string route) { }
            public int GetTimeToDestination { }
            public int TotalDistance(int distance) 
            {
               
            }

            

        }
        class Navigator2
        {
            public void SetCurrentLocation(string locationName) { }
            public void SetDestination(string destinationName) { }
            public void ModifyRouteToAvoid(string streetName) { }
            public void ModifyRouteToInclude(string streetName) { }
            public string GetRoute(string route) { }
            public int GetTimeToDestination { }
            public int TotalDistance { }
        }
        class Navigator3
        {
            public void SetCurrentLocation(string locationName) { }
            public void SetDestination(string destinationName) { }
            public void ModifyRouteToAvoid(string streetName) { }
            public void ModifyRouteToInclude(string streetName) { }
            public string GetRoute(string route) { }
            public int GetTimeToDestination { }
            public int TotalDistance { }
        }
            

            
    }
}
