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
    public partial class Welcome : Files
    {
        TextBox textBox = new TextBox();
        string fileName = "";
        public Welcome()
        {
            InitializeComponent();
        }

        private void newListPasswordButton_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text == "")
            {
                MessageBox.Show("Wprowadź hasło!", "Błędne hasło");
                return; 
            }
            newFileWithPassword();
        }

        private void newListButton_Click(object sender, EventArgs e)
        {
            newFile();
            //Form1 f1 = new Form1();
            //this.Hide();
            //f1.ShowDialog();
            //this.Close();
        }

        private void openListButton_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Wszystkie pliki| *";
            dialog.Multiselect = false;
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                fileName = dialog.FileName;
                StreamReader f = new StreamReader(fileName);
                textBox.Text = f.ReadToEnd();
                f.ReadToEnd();
            }
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
            

        }
    }
}
