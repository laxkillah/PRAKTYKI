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
        }

        private void newListPasswordButton_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text == "")
            {
                MessageBox.Show("Wprowadź hasło!", "Błędne hasło");
                return;
            }
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            files.newFile();


        }

        private void newListButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            files.newFile();
        } 

        private void openListButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Wszystkie pliki| *";
            openFile.Multiselect = false;
            openFile.ShowDialog();
            if (openFile.FileName != "")
            {
                files.FileName = openFile.FileName;
                StreamReader f = new StreamReader(files.FileName);
                f.ReadToEnd();
                f.Close();
            }
            
            this.Hide();
            Form1 f1 = new Form1();
            files.OpenFile(openFile.FileName);
            f1.openWelcome();
            f1.ShowDialog();

        }
    }
}
