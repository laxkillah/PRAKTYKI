using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik
{
    public partial class Welcome : Form
    {
        Files files;
        
        public Welcome()
        {
            InitializeComponent();
            files = new Files();
            files.newFile();
            this.Text = files.FileName;
            
            
        }

        private void newListPasswordButton_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text == "")
            {
                MessageBox.Show("Wprowadź hasło!", "Błędne hasło");
                return; 
            }
            
        }

        private void newListButton_Click(object sender, EventArgs e)
        {
            
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
            files.newFile();
        }

        private void openListButton_Click(object sender, EventArgs e)
        {
            
                Form1 f1 = new Form1();
                this.Hide();
                f1.ShowDialog();
                this.Close();
            


        }
    }
}
