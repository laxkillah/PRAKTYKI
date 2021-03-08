using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klasa_bazowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }//
    //public class Vertebrate
    //{
    //    public virtual void Eat(Food morsel)
    //    {
    //        Swallow(morsel);
    //        Digest();
    //    }
    //}
    //public class Chameleon : Vertebrate
    //{
    //    public override void Eat(Food morsel)
    //    {
    //        CatchWithTongue(morsel);
    //        base.Eat(morsel);
    //    }
    //}
    //public class Subclass : BaseClass
    //{
    //    public Subclass(lista parametrów)
    //        : base(lista parametrów konstruktora klasy bazowej)
    //    {

    //    }
    //}

    public class MyBaseClass
    {
        public MyBaseClass(string baseClassNeedsThis)
        {
            MessageBox.Show("To jest klasa bazowa: " + baseClassNeedsThis);
        }
    }
    public class MySubclass : MyBaseClass
    {
        public MySubclass(string baseClassNeedsThis, int anotherValue)
            : base(baseClassNeedsThis)
        {
            MessageBox.Show("To jest klasa pochodna: " + baseClassNeedsThis + " i " + anotherValue);
                
        }
    }
}
