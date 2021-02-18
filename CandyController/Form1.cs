using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandyController
{
    public partial class Form1 : Form
    { // trudny kod w zadaniu:
      // int t = m.chkTemp();
      // if (t > 160)
      // {  
      //    T obj = new T();
      //    obj.clsTrpV (2);
      //    ics.Fill();
      //    ics.Vent();
      //    m.airsyschk();
      // }
        public Form1()
        {
            InitializeComponent();
        }
        public class CandyController
        {
            public void DoMaintenanceTests()
            {
                if (IsNougatTooHot() == true)
                {
                    DoCICSVentProcedure();
                }
            }
            public Boolean IsNougatTooHot()
            {
                int temp = Maker.CheckNougatTenoerature();
                if (temp > 160)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            public void DoCICSVentProcedure()
            {
                Turbine turbineController = new Turbine();
                turbineController.CloseTripValve(2);
                IsolationCoolingSystem.Fill();
                IsolationCoolingSystem.Vent();
                Maker.CheckAirSystem();
            }
        
        
    }
}
