using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klasa_guy
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;



        public Form1()
        {
            InitializeComponent();

            bob = new Guy();
            bob.Name = "Bob";
            bob.Cash = 100;

            joe = new Guy();
            joe.Name = "Joe";
            joe.Cash = 50;

            UpdateForm();

        }
        public class Guy
        {
            public string Name;
            public int Cash;

            public int GiveCash(int amount)
            {
                if (amount <= Cash && amount > 0)
                {
                    Cash -= amount;
                    return amount;
                }
                else
                {
                    MessageBox.Show("Nie mam wystarczającej ilości pieniędzy, aby Ci dać " + amount, Name + " powiedział...");
                    return 0;
                }
            }
            public int ReceiveCash(int amount)
            {
                if (amount > 0)
                {
                    Cash += amount;
                    return amount;
                }
                else
                {
                    MessageBox.Show(amount + " to nie jest ilość pieniędzy, jaką mogę wziąć", Name + " powiedział...");
                    return 0;
                }
            }
        }
            
            
        public void UpdateForm()
        {
                joesCashLabel.Text = joe.Name + " ma" + joe.Cash + " zł";
                bobsCashLabel.Text = bob.Name + " ma" + bob.Cash + " zł";
                bankCashLabel.Text = "Bank ma " + bank + " zł";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bank nie posiada takiej ilości pieniędzy");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }
    }

    



}


    




