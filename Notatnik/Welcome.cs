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
        public Form1 form1;
        Files files;
        public RichTextBox textBox;
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
            Form1 f1 = new Form1();
            f1.ShowDialog();
            files.newFile();


        }

        private void newListButton_Click(object sender, EventArgs e)
        {
            
            files.newFile();

        

        //if (files.IsFileSaved)
        //{
        //    form1.textBox = textBox;
        //    files.newFile();
        //    form1.UpdateView();
        //}
        //form1.newToolStripMenuItem_Click(sender, e);


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
                f.Close();
            }
            Form1 f1 = new Form1();
            f1.ShowDialog();

        }
    }
}
